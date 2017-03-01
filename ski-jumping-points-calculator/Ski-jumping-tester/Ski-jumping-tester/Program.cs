using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Ekoodi.Sports;

namespace Ski_jumping_tester
{
    class Program
    {
        static void Main(string[] args)
        {
            Event competitionEvent = EventLoader.LoadXML("../../../../Eventdata.xml");
            Console.WriteLine("\nEvent:{0}", competitionEvent.ToString());
            Console.WriteLine("\nEvent parameters:{0}", competitionEvent.Parameters.ToString());
            Console.WriteLine("\nCompetitors:");
            foreach (Competitor c in competitionEvent.Competitors)
            {
                Console.WriteLine("\nCompetitor:{0}", c.ToString());
            }
            Console.ReadLine();
        }
    }
}
