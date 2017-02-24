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

        public static BankReference GetReference(string basepart)
        {
            try
            {
                return NationalReference.CreateReference(basepart);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public static BankReference GetReference(BankReference reference)
        {
            try
            {
                return InternationalReference.CreateReference(reference);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public static IList<BankReference> GetReferenceList(string basepart, int count)
        {
            //Create list of sequential national references
            //Could be extended with parameter indicating reference type to enable 
            //getting also international references
            try
            {
                IList<BankReference> referenceList = new List<BankReference>();
                for (int i = 0; i < count; i++)
                {
                    string sequentialReferenceBody = basepart + referenceIncrement.ToString();
                    BankReference reference = NationalReference.CreateReference(sequentialReferenceBody);
                    referenceList.Add(reference);
                    referenceIncrement++;
                }
                return referenceList;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static BankReference SelectReference(string reference)
        {
            //Select reference type, create and return reference
            if (NationalReference.IsValid(reference))
            {
                return new NationalReference(reference);
            }
            else if (InternationalReference.IsValid(reference))
            {
                return new InternationalReference(reference);
            }
            else
            {
                throw new FormatException("Invalid input!");
            }
        }
    }
}
