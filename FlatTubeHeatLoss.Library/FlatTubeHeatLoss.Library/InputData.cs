using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatTubeHeatLoss.Library
{
    public class InputData(
        TubeOrientations tubeOrientation,
        double innerSideTemp,
        double sorroundTemp,
        List<TubeLayer> layers,
        double e)
    {
        private InputData(InputData inputData, TubeOrientations tubeOrientation) 
            : this(tubeOrientation, 
                  inputData.InnerSideTemp, 
                  inputData.SorroundTemp, 
                  inputData.TubeLayers, 
                  inputData.E) 
        { }

        public double TubeOrientationCoeff { get; } = tubeOrientation switch
        {
            TubeOrientations.Vertical => 2.4,
            TubeOrientations.HorizontalUp => 3.3,
            TubeOrientations.HorizontalDown => 1.6,
            _ => throw new NotImplementedException(), 
        };

        public double InnerSideTemp { get; } = innerSideTemp;

        public double SorroundTemp { get; } = sorroundTemp;

        public List<TubeLayer> TubeLayers { get; } = layers;

        public double E { get; } = e;

        public double Accuracy { get; private set; } = 1e-3;

        public InputData WithAccuracy(double accuracy) => new(this, tubeOrientation) { Accuracy = accuracy };
    }
}
