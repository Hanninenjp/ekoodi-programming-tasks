using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekoodi.Sports
{
    public class EventCompetitor
    {
        private string _fisCode;
        private string _firstName;
        private string _lastName;
        private string _nation;

        public string FirstName
        {
            get { return _firstName; }
        }

        public string LastName
        {
            get { return _lastName; }
        }

        public string FisCode
        {
            get { return _fisCode; }
        }

        public string Nation
        {
            get { return _nation; }
        }

        public EventCompetitor()
        {
            _fisCode = String.Empty;
            _firstName = String.Empty;
            _lastName = String.Empty;
            _nation = String.Empty;
        }

        public EventCompetitor(string fisCode, string firstName, string lastName, string nation)
        {
            _fisCode = fisCode;
            _firstName = firstName;
            _lastName = lastName;
            _nation = nation;
        }

        public override string ToString()
        {
            return String.Format("\nFiscode: {0}\nName: {1} {2}\nNation: {3}", _fisCode, _firstName, _lastName, _nation);
        }
    }
}
