using System.Linq;
using System.Transactions;
using static System.Math;

namespace FlatTubeHeatLoss.Library;

public class FlatTubeHeatLossLibrary(InputData input)
{
    private const double C0 = 5.668e-8;

    private List<double> _temperatures = new();

    private LinkedList<double> _Qs = new();

    public Report GetReport()
    {
        InitTemperatures();

        do
        {
            CalculateQl();
            CalculateQk();
        }
        while (CheckQs());

        return new()
        {
            Layers = input.TubeLayers,
            Alfa = CalculateA(),
            Q = _Qs.Average(),
            Accuracy = input.Accuracy,
            Temperatures = [.. _temperatures, input.SorroundTemp]
        };
    }

    private bool CheckQs()
    {
        var avgQl = _Qs.Average();

        foreach (var q in _Qs)
            if (Abs(avgQl - q) >= input.Accuracy)
                return false;

        return true;
    }

    private double CalculateA()
    {
        var outterSideTemp = _temperatures[^1];
        return input.TubeOrientationCoeff
            * Pow(outterSideTemp, 1 / 4)
            * (C0
                * input.E
                * Abs(Pow(CelciasToKelvin(outterSideTemp), 4)
                    - Pow(CelciasToKelvin(input.SorroundTemp), 4)
                )
                / (outterSideTemp - input.SorroundTemp)
            );
    }

    private void InitTemperatures()
    {
        var tempStep = (input.InnerSideTemp + input.SorroundTemp) / (input.TubeLayers.Count + 2);

        _temperatures.Add(input.InnerSideTemp);

        for (var i = 0; i < input.TubeLayers.Count; i++)
            _temperatures.Add(tempStep * (input.TubeLayers.Count - i));
    }

    private double CelciasToKelvin(double temp) => temp + 273.3;

    private void CalculateQl()
    {
        _Qs.Clear();
        for (var i = 0; i < input.TubeLayers.Count; i++)
        {
            var ratio = input.TubeLayers[i].Width
                / input.TubeLayers[i].Material.GetThermalCoeff(_temperatures[i], _temperatures[i + 1]);
            _Qs.AddFirst((_temperatures[i] - _temperatures[i + 1]) / ratio);
        }
    }

    private void CalculateQk() => _Qs.AddLast(CalculateA() * (_temperatures[^1] - input.SorroundTemp));

    private void CalibrateTemps(double avgQ, double q, int fstTempIndex, int scndTempIndex)
    {
        if (avgQ == q)
            return;

        var difference = Abs(q - avgQ);
        var ratio = difference / avgQ / 1000;
        if (q > avgQ)
        {
            if (fstTempIndex > 0 && fstTempIndex < _temperatures.Count)
                _temperatures[fstTempIndex] -= _temperatures[fstTempIndex] * ratio;
            if (scndTempIndex >= 0 && scndTempIndex < _temperatures.Count)
                _temperatures[scndTempIndex] += _temperatures[scndTempIndex] * ratio;
        }
        else
        {
            if (fstTempIndex > 0 && fstTempIndex < _temperatures.Count)
                _temperatures[fstTempIndex] += _temperatures[fstTempIndex] * ratio;
            if (scndTempIndex >= 0 && scndTempIndex < _temperatures.Count)
                _temperatures[scndTempIndex] -= _temperatures[scndTempIndex] * ratio;
        }
    }
}
