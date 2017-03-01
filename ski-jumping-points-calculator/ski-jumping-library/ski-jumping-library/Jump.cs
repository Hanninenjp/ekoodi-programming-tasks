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

        public Jump(EventCompetitor competitor, JumpData data, EventParameters parameters)
        {
            //Store data
            _competitor = competitor;
            _jumpData = data;

            //Calculate and store score
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
        }

        /*
        //Competitor is also needed, if jump details are stored
        //Might return Jump with correct Competitor, JumpData, and JumpScore
        public static double ScoreJump(JumpData data, EventParameters parameters)
        {
            double score = 0;
            
            //Length
            //points = basepoints + (length-kpoint)*metervalue
            score += parameters.BasePoints + (data.JumpLength - parameters.KPoint) * parameters.MeterValue;
            //Console.WriteLine("Score:Length: {0}", score);
            
            //Wind correction (+/-)
            //length correction = (wind correction)*(kpoint-36)/20
            //round length correction to nearest 0,5 meters
            //!!!
            //Exact rounding rule should be double checked!
            //!!!
            //points = (length correction)*metervalue
            double lengthCorrectionWind = data.WindCorrection * (parameters.KPoint - 36) / 20;
            lengthCorrectionWind = Math.Round(lengthCorrectionWind * 2, MidpointRounding.AwayFromZero)/2;
            //Console.WriteLine("Score:Windcorrection: {0}m", lengthCorrectionWind);
            score += lengthCorrectionWind * parameters.MeterValue;
            //Console.WriteLine("Score:Wind: {0}", score);

            //Platform correction (+/-)
            //length correction = (platform correction)*(platform correction factor)
            //points = (length correction)*metervalue
            //Note: platform correction factor is hill size specific and needs to be added to event parameters!
            double lengthCorrectionPlatform = data.PlatformCorrection * 5;
            //Console.WriteLine("Score:Platformcorrection: {0}m", lengthCorrectionPlatform);
            score += lengthCorrectionPlatform * parameters.MeterValue;
            //Console.WriteLine("Score:Platform: {0}", score);

            //Style points
            //5 judges, 5 style points between 0-20, min and max values are removed
            //points = sum(styles)
            IList<double> usedStylePoints = data.StylePoints.OrderBy(sp => sp).Skip(1).Take(3).ToList();
            //Console.WriteLine("Score:Style points: {0}", usedStylePoints.Sum());
            score += usedStylePoints.Sum();
            //Console.WriteLine("Score:Score: {0}", score);

            return score;
        }
        */
    }
}
