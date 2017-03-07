using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekoodi.Sports
{
    public class EventResult
    {
        private EventCompetitor _competitor;
        private double _score;

        public EventCompetitor Competitor
        {
            get { return _competitor; }
        }

        public double Score
        {
            get { return _score; }
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

        public EventResult()
        {
            _competitor = new EventCompetitor();
            _score = 0;
        }

        public EventResult(EventCompetitor competitor, double score)
        {
            _competitor = competitor;
            _score = score;
        }

        public void UpdateScore(double score)
        {
            _score = score;
        }
    }
}
