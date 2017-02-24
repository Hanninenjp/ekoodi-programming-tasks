using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekoodi.Utilities
{
    public class BankBarcode
    {
        private string _barcode;

        public string Barcode
        {
            get
            {
                return _barcode;
            }
        }

        public BankBarcode()
        {
            _barcode = String.Empty;
        }

        public BankBarcode(IBAN iban, BankReference reference, Decimal sum, DateTime date)
        {
            if (reference is NationalReference)
            {
                //Barcode symbol version 4 with IBAN and national reference
                _barcode = buildBarcode4(iban, reference, sum, date);
            }
            else if (reference is InternationalReference)
            {
                //Barcode symbol version 5 with IBAN and international reference
                _barcode = buildBarcode5(iban, reference, sum, date);
            }
            else
            {
                throw new ArgumentException("Bank barcode creation failed: unsupported reference type!");
            }
        }

        public override string ToString()
        {
            return _barcode;
        }

        private static string buildBarcode4(IBAN iban, BankReference reference, Decimal sum, DateTime date)
        {
            //Format description, just temporarily included for development time purposes
            //Pankkiviivakoodin symboliversiota 4 käytetään, kun tilinumero on kansainvälisessä
            //IBAN -muodossa ja viite kansallisessa muodossa.
            //1. Versionumero 1 4
            //2. Saajan tilinumeron (IBAN) numeerinen osa 16 N
            //Viivakoodissa on saajan IBAN -muotoinen tilinumero ilman FI -
            //maatunnusta.Tilinumero - kentän arvo ei ole koskaan nolla.Viivakoodiin
            //3. Eurot 6 N
            //Laskun euromäärä, etunollatäyttö, lukualue 000000... 999999 euroa.Kun
            //laskun summa ylittää 99999999 senttiä, laskuttaja valintansa mukaan joko
            //tulostaa euro-ja senttikenttiin arvon 00000000 tai ei lainkaan tulosta
            //tilisiirtolomakkeelle viivakoodia. Jos maksaja saa itse valita maksettavan
            //summan, euro - ja senttikenttiin tulostetaan arvo 00000000.
            //4. Sentit 2 N
            //Laskun senttimäärä, lukualue 00...99.
            //5. Varalla 3 000
            //Tieto on 000 (nolla).
            //6. Viitenumero(kansallinen) 20 N
            //Laskun viitenumero (kansallinen), etunollatäyttö. Pankkiviivakoodissa  
            //viitenumero on aina pakollinen. Etunollia ei tulosteta selkokielisenä
            //tilisiirtolomakkeelle.
            //7. Eräpäivä 6 VVKKPP
            //Laskun eräpäivä on koodissa muodossa vvkkpp, mutta selkokielisenä  
            //eräpäiväkentässä muodossa pp.kk.vvvv.Laskuttaja voi halutessaan
            //täyttää pankkiviivakoodin eräpäiväkentän nollilla.
            //!!!
            //Note: can be zeroes, perhaps will not be supported, needs attention!
            //
            string barcode = String.Empty;
            barcode += "4"; //Version 4
            barcode += iban.Iban.Substring(2);
            //!!!
            //Check for correct sum range is needed, and better implementation for formatting the sum!
            //!!!
            barcode += sum.ToString("000000.00").Replace(",", String.Empty);
            barcode += "000"; //Reserved
            barcode += reference.Reference.PadLeft(20, '0');
            barcode += date.ToString("yyMMdd");
            return barcode;
        }

        private static string buildBarcode5(IBAN iban, BankReference reference, Decimal sum, DateTime date)
        {
            //Format description, just temporarily included for development time purposes
            //Pankkiviivakoodin symboliversiota 5 käytetään, kun tilinumero on kansainvälisessä
            //IBAN - muodossa ja viite on kansainvälinen RF - viite.
            //Pankkiviivakoodi rakennetaan vasemmalta oikealle seuraavasti:
            //Versionumero 1 5
            //Saajan tilinumeron (IBAN)
            //numeerinen osa 16 N
            //Eurot 6 N
            //Sentit 2 N
            //RF - viitteen numeerinen osa 23 N
            //Eräpäivä 6 VVKKPP

            string barcode = String.Empty;
            barcode += "5"; //Version 5
            barcode += iban.Iban.Substring(2);
            //!!!
            //Check for correct sum range is needed!
            //!!!
            barcode += sum.ToString("000000.00").Replace(",", String.Empty);
            barcode += "000"; //Reserved
            barcode += reference.Reference.Substring(2, 2) + reference.Reference.Substring(4).PadLeft(21, '0');
            barcode += date.ToString("yyMMdd");
            return barcode;
        }
    }
}
