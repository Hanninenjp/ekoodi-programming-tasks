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
            foreach (EventCompetitor c in competitionEvent.Competitors)
            {
                Console.WriteLine("\nCompetitor:{0}", c.ToString());
            }
            Console.ReadLine();

            //Handle competition round
            //Consider jumping order
            //CompetitionRound has 1..n Jumps that have 1 jump data and 1 jump score
            //Event might have 1..n CompetitionRound(s) and possibly 1 CompetitionResult(s)
            //Event.Parameters are used together with jump data to calculate jump score

            //Handle jump scoring
            //Jump.ScoreJump, takes JumpData, Event.Parameters
            //Might alternatively return Jump that is then added to CompetitionRoundResult(s)
            //Also Competitor is then needed

            //Test data, needs to be assigned to JumpData
            //double length = 124;
            //IList<double> stylePoints = new List<double>() { 18, 18.5, 18.5, 19, 19 };
            //double windAverage = 1.4;
            //double platformCorrection = 1.4;

            //Handle results
            //Add to list, add to competition event
        }
    }
}
