using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Obcan : Clovek
    {
        Regex rg = new Regex(@"/[0-9]{6}\/[0-9]{4}/");
        public Obcan()
        {

            Jmeno = "Nezname";
            Prijmeni = "Nezname";
            RodneCislo = "000000/0000";

        }

        public Obcan(Clovek cl, string rodneCis)
        {

            Jmeno = cl.Jmeno;
            Prijmeni = cl.Prijmeni;
            RodneCislo = rodneCis;

        }

        public override string ToString()
        {

            return $"Jméno - {Jmeno}" +
                $"Příjmení - {Prijmeni}" +
                $"Rodné číslo - {RodneCislo}";

        }

        public string RodneCislo
        {

            get
            {

                return RodneCislo;

            }

            set
            {

                if(rg.IsMatch(value))
                {

                    RodneCislo = value;

                }

                else
                {

                    Exception ex = new FormatException("Rodné číslo neopdpovídá formátu čččččč/čččč");
                    throw ex;

                }

            }

        }

    }
}
