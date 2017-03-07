using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekoodi.Sports
{
    public class Jump
    {
        private EventCompetitor _competitor;
        private JumpData _jumpData;
        private double _jumpScore;

        public EventCompetitor Competitor
        {
            get { return _competitor; }
        }

        public JumpData Data
        {
            get { return _jumpData; }
        }
        
        public double Score
        {
            get { return _jumpScore; }
        }

        //Get properties are added for the nested class to simplify GUI implementation

        public string CompetitorFisCode
        {
            get { return _competitor.FisCode; }
        }

        public string CompetitorLastName
        {
            get { return _competitor.LastName; }
        }

        public string CompetitorFirstName
        {
            get { return _competitor.FirstName; }
        }

        public string CompetitorNation
        {
            get { return _competitor.Nation; }
        }

        public Jump()
        {
            _competitor = new EventCompetitor();
            _jumpData = new JumpData();
            _jumpScore = 0;
        }

        public Jump(EventCompetitor competitor)
        {
            _competitor = competitor;
            _jumpData = new JumpData();
            _jumpScore = 0;
        }

        public void ScoreJump(JumpData data, EventParameters parameters)
        {
            //Set jump data
            _jumpData = data;

            //Calculate and set jump score
            double score = 0;

            //Length
            //points = basepoints + (length-kpoint)*metervalue
            score += parameters.BasePoints + (data.JumpLength - parameters.KPoint) * parameters.MeterValue;

            //Wind correction (+/-)
            //length correction = (wind correction)*(kpoint-36)/20, rounded to nearest 0,5 meters
            //!!!
            //Exact rounding rule should be double checked!
            //!!!
            //points = (length correction)*metervalue
            double lengthCorrectionWind = data.WindCorrection * (parameters.KPoint - 36) / 20;
            lengthCorrectionWind = Math.Round(lengthCorrectionWind * 2, MidpointRounding.AwayFromZero) / 2;
            score += lengthCorrectionWind * parameters.MeterValue;

            //Platform correction (+/-)
            //length correction = (platform correction)*(platform correction factor)
            //points = (length correction)*metervalue
            double lengthCorrectionPlatform = data.PlatformCorrection * parameters.PlatformCorrectionFactor;
            score += lengthCorrectionPlatform * parameters.MeterValue;

            //Style points
            //5 judges, 5 style points between 0-20, min and max values are removed
            //points = sum(remaining 3 styles)
            IList<double> usedStylePoints = data.StylePoints.OrderBy(sp => sp).Skip(1).Take(3).ToList();
            score += usedStylePoints.Sum();
            _jumpScore = score;

            //Note negative points for a jump are possible by the scoring algorithm and are allowed by the implementation!

        }

        public override string ToString()
        {
            return String.Format("{0}{1}\nScore: {2}", _competitor.ToString(), _jumpData.ToString(), _jumpScore);
        }
    }
}
