using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;


namespace FlatTubeHeatLoss.Library;

public class TubeLayer(double width, MaterialParams material)
{
    public double Width { get; } = width;

    public MaterialParams Material { get; } = material;

    public double GetQl(double innerTemp, double outterTemp)
    {
        var thermalCoeff = Material.GetThermalCoeff(innerTemp, outterTemp);
        return thermalCoeff / Width * Abs(innerTemp - outterTemp);
    }
}
