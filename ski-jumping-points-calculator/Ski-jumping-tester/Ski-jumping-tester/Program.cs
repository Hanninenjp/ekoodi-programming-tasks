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
            Event competitionEvent = EventLoader.LoadXML("../../../../Testdata.xml");
            Console.WriteLine("\nEvent:{0}", competitionEvent.ToString());
            Console.WriteLine("\nEvent parameters:{0}", competitionEvent.Parameters.ToString());
            Console.WriteLine("\nCompetitors:");
            foreach (EventCompetitor c in competitionEvent.Competitors)
            {
                Console.WriteLine("\nCompetitor:{0}", c.ToString());
            }

            //Handle competition round
            //Consider jumping order
            //CompetitionRound has 1..n Jumps that have 1 competitor, 1 jump data and 1 jump score
            //Event may have 1..n CompetitionRound(s) and has 1 CompetitionResult(s)
            //Event.Parameters are used together with jump data to calculate jump score

            //Handle jump scoring
            //Might alternatively return Jump that is then added to CompetitionRoundResult(s)
            //Also Competitor is then needed

            //Test data
            EventCompetitor competitor = competitionEvent.Competitors.First();
            double length = 124;
            double windCorrection = 1.4;
            double platformCorrection = -1.4;
            IList<double> stylePoints = new List<double>() { 18, 18.5, 18.5, 19, 19 };

            //Score jump
            JumpData jumpData = new JumpData(length, windCorrection, platformCorrection, stylePoints);
            Console.WriteLine("\n{0}", jumpData.ToString());
            //double score = Jump.ScoreJump(jumpData, competitionEvent.Parameters);
            Jump jump = new Jump(competitor, jumpData, competitionEvent.Parameters);
            //Console.WriteLine("\nScore: {0}", score);
            Console.WriteLine("\nScore: {0}", jump.Score);

            //Handle results
            //Add to list, add to competition event

            Console.ReadLine();
        }
    }
}
