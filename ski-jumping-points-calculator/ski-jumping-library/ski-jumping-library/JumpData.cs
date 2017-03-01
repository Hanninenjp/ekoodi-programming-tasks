using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekoodi.Sports
{
    public class JumpData
    {
        private double _jumpLength;
        private double _windCorrection;
        private double _platformCorrection;
        private IList<double> _stylePoints;

        public double JumpLength
        {
            get { return _jumpLength; }
        }

        public double WindCorrection
        {
            get { return _windCorrection; }
        }

        public double PlatformCorrection
        {
            get { return _platformCorrection; }
        }

        public IList<double> StylePoints
        {
            get { return _stylePoints; }
        }

        public JumpData(double jumpLength, double windCorrection, double platformCorrection, IList<double> stylePoints)
        {
            _jumpLength = jumpLength;
            _windCorrection = windCorrection;
            _platformCorrection = platformCorrection;
            _stylePoints = stylePoints;
        }

        public override string ToString()
        {
            string jumpData = String.Empty;
            jumpData = String.Format("\nJump length: {0:F2}m\nWind correction: {1:F2}m/s\nPlatform correction: {2:F2}m\nStyle points: ", _jumpLength, _windCorrection, _platformCorrection);
            foreach(double sp in _stylePoints)
            {
                jumpData += String.Format("{0:F2} ", sp);
            }
            return jumpData;
        }
    }
}
