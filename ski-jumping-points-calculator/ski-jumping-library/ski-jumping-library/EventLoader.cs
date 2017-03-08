using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Diagnostics;

namespace Ekoodi.Sports
{
    public static class EventLoader
    {
        public static Event LoadXML(string fileName)
        {

            try
            {
                //Load event data file
                XDocument document = XDocument.Load(fileName);

                //Get the first event element
                //Implementation could be extended to handle multiple events in a same file
                XElement eventXElement = document.Descendants("event").First();
                Debug.WriteLine("XElement:Event:\n{0}", eventXElement);

                //Process event information
                XElement eventXInformation = eventXElement.Descendants("information").First();
                Debug.WriteLine("XElement:Event:Information:\n{0}", eventXInformation);
                string eventName = eventXInformation.Element("name").Value;
                string eventVenue = eventXInformation.Element("venue").Value;
                string eventHillSize = eventXInformation.Element("hillsize").Value;
                DateTime eventDate = DateTime.Parse(eventXInformation.Element("date").Value);

                //Process event parameters
                XElement eventXParameters = eventXElement.Descendants("parameters").First();
                Debug.WriteLine("XElement:Event:Parameters:\n{0}", eventXParameters);
                double eventKPoint = double.Parse(eventXParameters.Element("kpoint").Value);
                double eventBasePoints = double.Parse(eventXParameters.Element("basepoints").Value);
                double eventMeterValue = double.Parse(eventXParameters.Element("metervalue").Value);
                double eventPlatformCorrectionFactor = double.Parse(eventXParameters.Element("platformcorrectionfactor").Value);
                EventParameters eventParameters = new EventParameters(eventKPoint, eventBasePoints, eventMeterValue, eventPlatformCorrectionFactor);

                //Process event competitors
                IList<XElement> eventXCompetitors = eventXElement.Descendants("competitors").First().Elements("competitor").ToList();
                IList<EventCompetitor> eventCompetitors = new List<EventCompetitor>();
                foreach (XElement competitorXElement in eventXCompetitors)
                {
                    Debug.WriteLine("\nXElement:Event:Competitors:Competitor\n{0}", competitorXElement);
                    EventCompetitor eventCompetitor = new EventCompetitor(competitorXElement.Element("fiscode").Value,
                                                                competitorXElement.Element("firstname").Value,
                                                                competitorXElement.Element("lastname").Value,
                                                                competitorXElement.Element("nation").Value);
                    eventCompetitors.Add(eventCompetitor);
                }

                Event competitionEvent = new Event(eventName, eventVenue, eventHillSize, eventDate, eventParameters, eventCompetitors);

                return competitionEvent;

            }
            catch (Exception)
            {
                throw new Exception(String.Format("Processing event configuration file {0} failed!", fileName));
            }
        }
    }
}
