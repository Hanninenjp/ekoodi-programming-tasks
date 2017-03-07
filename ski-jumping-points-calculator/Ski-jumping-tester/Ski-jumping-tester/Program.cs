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
            Console.WindowHeight = Console.LargestWindowHeight >= 40 ? 40 : Console.LargestWindowHeight;
            Console.Title = "Ski jumping points calculator tester";
            Console.WriteLine("Ski jumping points calculator tester!");

            //Load event information, parameters and competitors from a file
            Event competitionEvent = EventLoader.LoadXML("../../../../Testevent.xml");
            Console.WriteLine("\nEvent:{0}", competitionEvent.ToString());
            Console.WriteLine("\nEvent parameters:\n{0}", competitionEvent.Parameters.ToString());
            Console.WriteLine("\nEvent competitors:");
            foreach (EventCompetitor c in competitionEvent.Competitors)
            {
                Console.WriteLine("\nCompetitor:{0}", c.ToString());
            }

            //Test data
            Random rng = new Random();
            EventCompetitor testCompetitor = new EventCompetitor("0000", "Test", "Jumper", "FIN");
            double length = 124;
            double windCorrection = 1.4;
            double platformCorrection = -1.4;
            IList<double> stylePoints = new List<double>() { 18, 18.5, 18.5, 19, 19 };
            JumpData singleJumpData = new JumpData(length, windCorrection, platformCorrection, stylePoints);

            //Make and score a single test jump
            Jump singleJump = new Jump(testCompetitor);
            singleJump.ScoreJump(singleJumpData, competitionEvent.Parameters);
            Console.WriteLine("\nSingle jump test:\n{0}", singleJump.ToString());

            //Event starts
            //Event has 1..n EventRound(s) and has 1 EventResult(s)
            //EventRound has 1..n Jumps that have 1 Competitor, 1 Jump data and 1 Jump score
            //Event.Parameters are used together with Jump data to calculate Jump score

            //This is not necessarily the best approach, depending on the application type
            //Alternative handle rounds in application and set round data to the Event, after the round has been completed
            //Alternatively, update round jump data at the Event after each jump
            //First round
            EventRound firstRound = competitionEvent.GetFirstRound();
            
            //Now done by Event in previous step
            /*
            //Add competitors to the round
            //Competitors are simply ordered according to their order in the Event
            //Could be potentially hidden from application by Event and EventRound methods
            foreach (EventCompetitor c in competitionEvent.Competitors)
            {
                firstRound.AddJump(new Jump(c));
            }
            */

            //Make first round test jumps, set data about jump and calculate and set score
            //Could be potentially partially hidden from application by an Event method
            //Consider during application design
            foreach (Jump jump in firstRound.Jumps)
            {
                JumpData jumpData = new JumpData(rng.Next(100, 130 + 1), windCorrection, platformCorrection, stylePoints);
                jump.ScoreJump(jumpData, competitionEvent.Parameters);
                //Previous implementation, not compatible with library changes
                //competitionEvent.AddResult(jump.Competitor, jump.Score);
                //New implementation, update result, following library changes
                competitionEvent.UpdateResult(jump.Competitor, jump.Score);
                //Console.WriteLine("\nFirst round jump:\nCompetitor:{0}\nJump:{1}\nScore: {2:F2}", jump.Competitor.ToString(), jump.Data.ToString(), jump.Score);
            }

            /*
            //Display first round results
            //Could be potentially partially hidden from application by an Event method
            foreach (EventResult r in competitionEvent.Results)
            {
                Console.WriteLine("\nFirst round results:\nCompetitor:{0}\nScore: {1:F2}", r.Competitor.ToString(), r.Score);
            }
            */

            //Second round
            //Second round is currently not fully supported after library changes, see below
            //EventRound secondRound = competitionEvent.GetNextRound();

            //Now done by Event in previous step
            /*
            //Add competitors to the round, based on their first round score, in reverse order
            foreach (EventResult r in competitionEvent.Results.Reverse().ToList())
            {
                secondRound.AddJump(new Jump(r.Competitor));
            }
            */

            //Previous implementation, not compatible with library changes
            //Current update method just updates the existing score with the new one, instead of incrementing the score
            //If suppport for multiple rounds is later required, increment functionality can be added to the library
            /*
            //Make second round test jumps, set data about jump and calculate and set score
            foreach (Jump j in secondRound.Jumps)
            {
                JumpData jumpData = new JumpData(rng.Next(100, 130 + 1), windCorrection, platformCorrection, stylePoints);
                j.ScoreJump(jumpData, competitionEvent.Parameters);
                competitionEvent.UpdateResult(j.Competitor, j.Score);
                //Console.WriteLine("\nSecond round jump:\nCompetitor:{0}\nJump:{1}\nScore: {2:F2}", j.Competitor.ToString(), j.Data.ToString(), j.Score);
            }
            */

            //Display jumps by round
            foreach (EventRound r in competitionEvent.Rounds)
            {
                Console.WriteLine("\n{0} jumps:", r.RoundName);
                foreach (Jump j in r.Jumps)
                {
                    //Console.WriteLine("\nCompetitor:{0}\nJump:{1}\nScore: {2}", j.Competitor.ToString(), j.Data.ToString(), j.Score);
                    Console.WriteLine("{0}", j.ToString());
                }
            }

            //Display event final results
            Console.WriteLine("\nFinal results:");
            foreach (EventResult r in competitionEvent.Results)
            {
                Console.WriteLine("\n{0}\nScore: {1:F2}", r.Competitor.ToString(), r.Score);
            }

            Console.ReadLine();
        }
    }
}
