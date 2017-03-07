using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekoodi.Sports
{
    public class EventParameters
    {
        private double _kPoint;
        private double _basePoints;
        private double _meterValue;
        private double _platformCorrectionFactor;

        public double KPoint
        {
            get { return _kPoint; }
        }

        public double BasePoints
        {
            get { return _basePoints; }
        }

        public double MeterValue
        {
            get { return _meterValue; }
        }

        public double PlatformCorrectionFactor
        {
            get { return _platformCorrectionFactor; }
        }

        public EventParameters(double kPoint, double basePoints, double meterValue, double platformCorrectionFactor)
        {
            _kPoint = kPoint;
            _basePoints = basePoints;
            _meterValue = meterValue;
            _platformCorrectionFactor = platformCorrectionFactor;
        }

        public override string ToString()
        {
            return String.Format("K-point: {0} m\nBase points: {1} points\nMeter value: {2} points/m\nPlatform correction factor: {3} m/m in platform height", _kPoint, _basePoints, _meterValue, _platformCorrectionFactor);
        }
    }
}
