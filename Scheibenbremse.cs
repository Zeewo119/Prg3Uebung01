using System;
using System.Collections.Generic;
using System.Text;

namespace Prg3Uebung01
{
    public class Scheibenbremse : Bremse
    {
        private static readonly int MAX_RIEFENTIEFE = 4;
        private static readonly int MIN_BELAG = 1;
        private static readonly int MAX_BELAG = 8;

        private int riefentiefe;
        private int belag;

        public Scheibenbremse()
        {
            this.riefentiefe = 0;
            this.belag = MAX_BELAG;
        }

        public void bremsen()
        {
            Console.WriteLine("Scheibembremse bremst!");
        }

        public bool brauchtService()
        {
            return riefentiefe < MAX_RIEFENTIEFE && belag > MIN_BELAG;
        }

        public String toString()
        {
            return "Scheibenbremse";
        }
    }
}

