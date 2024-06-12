using Client.DataBase;
using Client.DbModels;
using FlatTubeHeatLoss.Library;
using FlatTubeHeatLoss.Library.Models;
using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.Kernel;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;

namespace Client
{
    public partial class MainWin : Form
    {

        public MainWin()
        {
            InitializeComponent();

            Init().GetAwaiter().GetResult();
        }

        private async Task Init()
        {
            Material.DataSource = await DbAccessService.GetMaterials();
            Material.DisplayMember = "Name";
            Material.ValueMember = "ID";
            Material.AutoComplete = true;

            Orientation.Items.AddRange(typeof(TubeOrientations).GetEnumNames());

            Materials.DataSource = (await DbAccessService.GetMaterials())
                .Select(x => new { x.Name, x.A, x.B, x.C, Group = x.Group.Name })
                .ToList();
        }

        private async void calculateButton_Click(object sender, EventArgs e)
        {
            var layers = await GetLayers();

            if (layers.Count < 1)
                return;

            if (!double.TryParse(InnerTemp.Text, out var innerTemp) ||
                !double.TryParse(OutterTemp.Text, out var outterTemp) ||
                !double.TryParse(Darkness.Text, out var darkness) ||
                !Enum.TryParse<TubeOrientations>(Orientation.Text, out var orienation))
                return;

            var inputData = new InputData(orienation, innerTemp, outterTemp, layers, darkness);
            var lib = new FlatTubeHeatLossLibrary(inputData);

            var report = lib.GetReport();

            QLabel.Text = $"Итоговая теплопотеря, Вт: {report.Q}";
            TempsLabel.Text = $"Температуры через слои, °C:\n{string.Join(",\n", report.Temperatures.Select(num => Math.Round(num, 3)))}";

            cartesianChart1.YAxes = new Axis[]
            {
                new Axis()
                {
                    Name = "Температура, °C"
                }
            };

            cartesianChart1.XAxes = new Axis[]
            {
                new Axis()
                {
                    Name = "Расстояние от внутренней стенки, м"
                }
            };

            var layerDist = new List<double>() { 0 };

            var prevDist = 0.0;
            foreach (var layer in report.Layers)
            {
                prevDist += layer.Width;
                layerDist.Add(prevDist);
            }

            cartesianChart1.Series = new ISeries[]
            {
                new LineSeries<ObservablePoint>()
                {
                    Values = report.Temperatures.SkipLast(1).Zip(layerDist).Select(x => new ObservablePoint(x.Second, x.First)),
                    Fill = new LinearGradientPaint(SKColor.Parse("#ff2400"), SKColor.Parse("#fde910")),
                }
            };
        }

        private async Task<List<TubeLayer>> GetLayers()
        {
            var layers = new List<TubeLayer>();


            foreach (DataGridViewRow row in layersGrid
                .Rows
                .ToIEnumerable<DataGridViewRowCollection, DataGridViewRow>()
                .SkipLast(1))
            {
                var thickness = GetDouble(row.Cells["Thickness"].Value);
                if (thickness == null)
                    continue;

                var materialID = (int)row.Cells["Material"].Value;

                var material = await DbAccessService.GetMaterial(materialID);

                if (material == null)
                    continue;

                var matParams = new MaterialParams(
                    material.A,
                    material.B,
                    material.C,
                    material.Name);

                var layer = new TubeLayer(thickness.Value, matParams);
                layers.Add(layer);
            }

            return layers;
        }

        private double? GetDouble(object value)
        {
            var strVal = (string)value;

            return double.TryParse(strVal.Replace(".", ","), out var res) && res > 0 ? res : throw null;
        }

        private void TextChangedInterceptor(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = ((TextBox)sender).Text.Replace(".", ",");
            ((TextBox)sender).SelectionStart = ((TextBox)sender).Text.Length;
            ((TextBox)sender).SelectionLength = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            layersGrid.Rows.Clear();
            InnerTemp.Text = "";
            OutterTemp.Text = "";
            Darkness.Text = "";
            QLabel.Text = "";
            TempsLabel.Text = "";
        }
    }
}
