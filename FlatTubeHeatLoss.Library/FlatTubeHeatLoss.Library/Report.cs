using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatTubeHeatLoss.Library;

public class Report
{
    public List<TubeLayer> Layers { get; internal set; }

    public double Q { get; internal set; }

    public double Alfa { get; internal set; }

    public double Accuracy { get; internal set; }

    public List<double> Temperatures { get; internal set; }
}
