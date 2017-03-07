using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekoodi.Sports
{
    public class Event
    {
        //Also EventInformation could potentially be a class
        private string _name;
        private string _venue;
        private string _hill;
        private DateTime _date;
        private EventParameters _parameters;
        private IList<EventCompetitor> _competitors;
        private IList<EventRound> _rounds;
        private IList<EventResult> _results;

        public string Name
        {
            get { return _name; }
        }

        public string Venue
        {
            get { return _venue; }
        }

        public string Hill
        {
            get { return _hill; }
        }

        public DateTime Date
        {
            get { return _date; }
        }

        public EventParameters Parameters
        {
            get { return _parameters; }
        }

        public IList<EventCompetitor> Competitors
        {
            get { return _competitors; }
        }

        public IList<EventRound> Rounds
        {
            get { return _rounds; }
        }

        public IList<EventResult> Results
        {
            get { return _results; }
        }

        public Event(string name, string venue, string hill, DateTime date, EventParameters parameters, IList<EventCompetitor> competitors)
        {
            _name = name;
            _venue = venue;
            _hill = hill;
            _date = date;
            _parameters = parameters;
            _competitors = competitors;
            _rounds = new List<EventRound>();
            
            //Alternative implementation would be to just initialize an empty list
            //Application would then Add results to the list
            //Now application shall Update results in the list
            _results = new List<EventResult>();
            foreach (EventCompetitor c in _competitors)
            {
                _results.Add(new EventResult(c, 0));
            }
        }

        public EventRound GetFirstRound()
        {
            //Just for testing, handling rounds needs further consideration
            EventRound round = new EventRound("First round");
            foreach (EventCompetitor c in _competitors)
            {
                round.AddJump(new Jump(c));
            }
            _rounds.Add(round);
            return _rounds.First();
        }

        public EventRound GetNextRound()
        {
            //Just for testing, handling rounds needs further consideration
            EventRound round = new EventRound("Next round");
            foreach (EventResult c in _results.Reverse())
            {
                round.AddJump(new Jump(c.Competitor));
            }
            _rounds.Add(round);
            return _rounds.Last();
        }

        public void AddResult(EventCompetitor competitor, double score)
        {
            //Create and add an event result object
            _results.Add(new EventResult(competitor, score));
            //Keep the results ordered
            _results = _results.OrderByDescending(r => r.Score).ToList();
            //Sort results are not reflected correctly in datagrid with binding list and binding source, for some reason
            //Sorting needs further investigation, possible workaround is to just recreate the binding list and binding source
            //after each update to the list
        }

        public void UpdateResult(EventCompetitor competitor, double score)
        {
            //Get the the event result object
            EventResult result = _results.First(r => r.Competitor.FisCode == competitor.FisCode);
            result.UpdateScore(score);
            //Keep the results ordered
            _results = _results.OrderByDescending(r => r.Score).ToList();
            //Sort results are not reflected correctly in datagrid with binding list and binding source, for some reason
            //Sorting needs further investigation, possible workaround is to just recreate the binding list and binding source
            //after each update to the list
        }

        public override string ToString()
        {
            return String.Format("\nName: {0}\nVenue: {1}\nHill: {2}\nDate: {3:d.M.yyyy}", _name, _venue, _hill, _date);
        }
    }
}
