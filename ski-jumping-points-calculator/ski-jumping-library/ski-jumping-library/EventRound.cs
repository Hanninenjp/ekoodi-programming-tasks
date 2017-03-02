using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekoodi.Sports
{
    public class EventRound
    {
        private IList<Jump> _jumps;
        private string _roundName;

        public IList<Jump> Jumps
        {
            get { return _jumps; }
        }

        public string RoundName
        {
            get { return _roundName; }
        }

        public EventRound()
        {
            _jumps = new List<Jump>();
            _roundName = String.Empty;
        }

        public EventRound(string name)
        {
            _jumps = new List<Jump>();
            _roundName = name;
        }

        public void AddJump(Jump jump)
        {
            _jumps.Add(jump);
        }
    }
}
