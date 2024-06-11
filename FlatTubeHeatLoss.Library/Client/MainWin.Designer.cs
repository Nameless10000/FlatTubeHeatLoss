using Client.DataBase;
using Client.DbModels;
using System.Windows.Forms;

namespace Client
{
    partial class MainWin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            InnerTemp = new TextBox();
            OutterTemp = new TextBox();
            Darkness = new TextBox();
            Orientation = new ComboBox();
            layersGrid = new DataGridView();
            Thickness = new DataGridViewTextBoxColumn();
            Material = new DataGridViewComboBoxColumn();
            CalculateButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dBContextBindingSource = new BindingSource(components);
            QLabel = new Label();
            TempsLabel = new Label();
            button1 = new Button();
            label5 = new Label();
            Materials = new DataGridView();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            ((System.ComponentModel.ISupportInitialize)layersGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dBContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Materials).BeginInit();
            SuspendLayout();
            // 
            // InnerTemp
            // 
            InnerTemp.Location = new Point(17, 310);
            InnerTemp.Margin = new Padding(4, 5, 4, 5);
            InnerTemp.Name = "InnerTemp";
            InnerTemp.Size = new Size(200, 31);
            InnerTemp.TabIndex = 0;
            InnerTemp.TextChanged += TextChangedInterceptor;
            // 
            // OutterTemp
            // 
            OutterTemp.Location = new Point(225, 310);
            OutterTemp.Margin = new Padding(4, 5, 4, 5);
            OutterTemp.Name = "OutterTemp";
            OutterTemp.Size = new Size(224, 31);
            OutterTemp.TabIndex = 0;
            OutterTemp.TextChanged += TextChangedInterceptor;
            // 
            // Darkness
            // 
            Darkness.Location = new Point(17, 405);
            Darkness.Margin = new Padding(4, 5, 4, 5);
            Darkness.Name = "Darkness";
            Darkness.Size = new Size(200, 31);
            Darkness.TabIndex = 0;
            Darkness.Text = "0,83";
            Darkness.TextChanged += TextChangedInterceptor;
            // 
            // Orientation
            // 
            Orientation.DropDownStyle = ComboBoxStyle.DropDownList;
            Orientation.Location = new Point(225, 405);
            Orientation.Margin = new Padding(4, 5, 4, 5);
            Orientation.Name = "Orientation";
            Orientation.Size = new Size(224, 33);
            Orientation.TabIndex = 0;
            // 
            // layersGrid
            // 
            layersGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            layersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            layersGrid.Columns.AddRange(new DataGridViewColumn[] { Thickness, Material });
            layersGrid.Location = new Point(17, 20);
            layersGrid.Margin = new Padding(4, 5, 4, 5);
            layersGrid.Name = "layersGrid";
            layersGrid.RowHeadersWidth = 62;
            layersGrid.Size = new Size(432, 232);
            layersGrid.TabIndex = 0;
            // 
            // Thickness
            // 
            Thickness.HeaderText = "Толщина слоя, м";
            Thickness.MinimumWidth = 8;
            Thickness.Name = "Thickness";
            // 
            // Material
            // 
            Material.HeaderText = "Материал";
            Material.MinimumWidth = 8;
            Material.Name = "Material";
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(17, 475);
            CalculateButton.Margin = new Padding(4, 5, 4, 5);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(200, 38);
            CalculateButton.TabIndex = 1;
            CalculateButton.Text = "Рассчитать";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += calculateButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 280);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 25);
            label1.TabIndex = 2;
            label1.Text = "Температура внутри, C";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(225, 280);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(213, 25);
            label2.TabIndex = 3;
            label2.Text = "Температура снаружи, C";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 375);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(162, 25);
            label3.TabIndex = 5;
            label3.Text = "Положение трубы";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 375);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(153, 25);
            label4.TabIndex = 4;
            label4.Text = "Степень черноты";
            // 
            // dBContextBindingSource
            // 
            dBContextBindingSource.DataSource = typeof(DBContext);
            // 
            // QLabel
            // 
            QLabel.AutoSize = true;
            QLabel.Location = new Point(17, 544);
            QLabel.Margin = new Padding(4, 0, 4, 0);
            QLabel.Name = "QLabel";
            QLabel.Size = new Size(232, 25);
            QLabel.TabIndex = 7;
            QLabel.Text = "Итоговая теплопотеря, Вт: ";
            // 
            // TempsLabel
            // 
            TempsLabel.AutoSize = true;
            TempsLabel.Location = new Point(17, 586);
            TempsLabel.Margin = new Padding(4, 0, 4, 0);
            TempsLabel.Name = "TempsLabel";
            TempsLabel.Size = new Size(241, 25);
            TempsLabel.TabIndex = 8;
            TempsLabel.Text = "Температуры через слои, С:";
            // 
            // button1
            // 
            button1.Location = new Point(225, 475);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(224, 38);
            button1.TabIndex = 9;
            button1.Text = "Очистить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(1369, 20);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(316, 41);
            label5.TabIndex = 10;
            label5.Text = "Список материалов";
            // 
            // Materials
            // 
            Materials.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Materials.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Materials.Location = new Point(1143, 81);
            Materials.Margin = new Padding(4, 5, 4, 5);
            Materials.Name = "Materials";
            Materials.RowHeadersWidth = 62;
            Materials.Size = new Size(768, 738);
            Materials.TabIndex = 11;
            // 
            // cartesianChart1
            // 
            cartesianChart1.Location = new Point(468, 20);
            cartesianChart1.Margin = new Padding(4, 5, 4, 5);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(649, 757);
            cartesianChart1.TabIndex = 12;
            // 
            // MainWin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1924, 982);
            Controls.Add(cartesianChart1);
            Controls.Add(Materials);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(TempsLabel);
            Controls.Add(QLabel);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CalculateButton);
            Controls.Add(InnerTemp);
            Controls.Add(OutterTemp);
            Controls.Add(Orientation);
            Controls.Add(Darkness);
            Controls.Add(layersGrid);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainWin";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)layersGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)dBContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)Materials).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView layersGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thickness;
        private System.Windows.Forms.DataGridViewComboBoxColumn Material;
        private System.Windows.Forms.TextBox InnerTemp;
        private System.Windows.Forms.TextBox OutterTemp;
        private System.Windows.Forms.TextBox Darkness;
        private System.Windows.Forms.ComboBox Orientation;
        private System.Windows.Forms.Button CalculateButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private BindingSource dBContextBindingSource;
        private Label QLabel;
        private Label TempsLabel;
        private Button button1;
        private Label label5;
        private DataGridView Materials;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
    }
}
