using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekoodi.Utilities
{
    public static class ReferenceCreator
    {
        private static int referenceIncrement = 1;

        public static string GetReference(string basepart)
        {
            //Create single reference number
            return ReferenceNumber.CreateReference(basepart);
        }

        public static IList<string> GetReference(string basepart, int count)
        {
            //Create list of sequential reference numbers
            IList<string> referenceNumbers = new List<string>();
            for (int i = 0; i < count; i++)
            {
                string sequentialReferenceBody = basepart + referenceIncrement.ToString();
                string referenceNumber = ReferenceNumber.CreateReference(sequentialReferenceBody);
                //Console.WriteLine("ReferenceCreator:GetReference:Reference number: {0}", referenceNumber);
                referenceNumbers.Add(referenceNumber);
                referenceIncrement++;
            }
            return referenceNumbers;
        }
    }
}
