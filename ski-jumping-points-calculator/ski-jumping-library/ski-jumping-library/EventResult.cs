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
            _score += score;
        }
    }
}
