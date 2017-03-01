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

        public EventParameters(double kPoint, double basePoints, double meterValue)
        {
            _kPoint = kPoint;
            _basePoints = basePoints;
            _meterValue = meterValue;
        }

        public override string ToString()
        {
            return String.Format("\nK-point: {0}\nBase points: {1}\nMeter value: {2}", _kPoint, _basePoints, _meterValue);
        }
    }
}
