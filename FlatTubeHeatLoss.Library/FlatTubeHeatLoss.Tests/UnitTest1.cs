using FlatTubeHeatLoss.Library;

namespace FlatTubeHeatLoss.Tests
{
    public class Tests
    {
        private FlatTubeHeatLossLibrary _library;
        [SetUp]
        public void Setup()
        {
            var layers = new List<TubeLayer>()
            {
                new(0.23, new(0, 0.00035, 0.47)),
                new(0.115, new(-0.000000018, 0.000192, 0.119)),
                new(0.115, new(0.000000106, 0.000096, 0.055)),
            };

            var inputData = new InputData(TubeOrientations.Vertical, 700, 20, layers, 0.85);
            _library = new FlatTubeHeatLossLibrary(inputData);
        }

        [Test]
        public void Test1()
        {
            var report = _library.GetReport();

            Assert.Pass();
        }
    }
}