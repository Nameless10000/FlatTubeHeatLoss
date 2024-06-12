using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatTubeHeatLoss.Library.Models
{
    public class MaterialParams(double a, double b, double c, string name = "Nos set")
    {
        public double A { get; set; } = a;
        public double B { get; set; } = b;
        public double C { get; set; } = c;

        public string Name { get; set; } = name;

        public double GetThermalCoeff(double innerTemp, double outterTemp)
        {
            var avgTemp = (innerTemp + outterTemp) / 2;
            return A * avgTemp * avgTemp + B * avgTemp + C;
        }
    }
}
