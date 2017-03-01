using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekoodi.Sports
{
    public class Event
    {
        private string _name;
        private string _venue;
        private string _hill;
        private DateTime _date;
        private EventParameters _parameters;
        private IList<EventCompetitor> _competitors;

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

        public Event(string name, string venue, string hill, DateTime date, EventParameters parameters, IList<EventCompetitor> competitors)
        {
            _name = name;
            _venue = venue;
            _hill = hill;
            _date = date;
            _parameters = parameters;
            _competitors = competitors;
        }

        public override string ToString()
        {
            return String.Format("\nName: {0}\nVenue: {1}\nHill: {2}\nDate: {3:d.M.yyyy}", _name, _venue, _hill, _date);
        }
    }
}
