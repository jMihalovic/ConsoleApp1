using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Clovek
    {

        public Clovek()
        {

            Jmeno = "Nezname";
            Prijmeni = "Nezname";

        }

        public Clovek(string jmenoTemp, string prijmeniTemp)
        {

            Jmeno = jmenoTemp;
            Prijmeni = prijmeniTemp;

        }

        public override string ToString()
        {

            return $"Jméno - {Jmeno}" +
                $"Příjmení - {Prijmeni}";

        }

        public string Jmeno
        {

            get; set;

        }

        public string Prijmeni
        {

            get; set;

        }
    }
}
