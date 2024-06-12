using System.Linq;
using System.Transactions;
using FlatTubeHeatLoss.Library.Models;
using static System.Math;

namespace FlatTubeHeatLoss.Library;

public class FlatTubeHeatLossLibrary(InputData input)
{
    private const double C0 = 5.668e-8;

    private List<double> _temperatures = new();

    private List<double> _Qs = new();

    private double _A;

    public Report GetReport()
    {
        InitTemperatures();

        do
        {
            CalculateQl();
            CalculateQk();

            var avgQ = _Qs.Average();
            for (var i = 0; i < input.TubeLayers.Count + 1; i++)
                CalibrateTemps(avgQ, _Qs[i], i);
        }
        while (!CheckQs());

        return new()
        {
            Layers = input.TubeLayers,
            Alfa = _A,
            Q = _Qs.Average(),
            Accuracy = input.Accuracy,
            Temperatures = _temperatures
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
        var outterSideTemp = _temperatures[^2];
        var sorroundTemp = _temperatures[^1];
        return input.TubeOrientationCoeff
            * Pow(outterSideTemp, 1 / 4)
            * (C0
                * input.E
                * Abs(Pow(CelciasToKelvin(outterSideTemp), 4)
                    - Pow(CelciasToKelvin(sorroundTemp), 4)
                )
                / (outterSideTemp - sorroundTemp)
            );
    }

    private void InitTemperatures()
    {
        var tempStep = (input.InnerSideTemp + input.SorroundTemp) / (input.TubeLayers.Count + 2);

        _temperatures.Add(input.InnerSideTemp);

        for (var i = 0; i < input.TubeLayers.Count; i++)
            _temperatures.Add(tempStep * (input.TubeLayers.Count - i));

        _temperatures.Add(input.SorroundTemp);
    }

    private double CelciasToKelvin(double temp) => temp + 273.3;

    private void CalculateQl()
    {
        _Qs.Clear();
        for (var i = 0; i < input.TubeLayers.Count; i++)
        {
            var ratio = input.TubeLayers[i].Width
                / input.TubeLayers[i].Material.GetThermalCoeff(_temperatures[i], _temperatures[i + 1]);
            _Qs.Add((_temperatures[i] - _temperatures[i + 1]) / ratio);
        }
    }

    private void CalculateQk() => _Qs.Add((_A = CalculateA()) * (_temperatures[^2] - _temperatures[^1]));

    private void CalibrateTemps(double avgQ, double q, int tempIndex)
    {
        if (avgQ == q)
            return;

        var step = 100000;
        var diff = q - avgQ;
        if (tempIndex > 0 && tempIndex < _temperatures.Count - 1)
            _temperatures[tempIndex] -= _temperatures[tempIndex] * (diff / step);
        if (tempIndex > -1 && tempIndex < _temperatures.Count - 2)
            _temperatures[tempIndex + 1] += _temperatures[tempIndex + 1] * (diff / step);
    }
}
