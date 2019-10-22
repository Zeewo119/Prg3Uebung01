using System;
using System.Collections.Generic;
using System.Text;

namespace Prg3Uebung01
{
    public class Auto : Kraftfahrzeug
    {


        private int sitze;
        private int tueren;

        public Auto(String hersteller, String modell, int ps, int hubraum, int tankvolumen, int sitze, int tueren, int zulGesamtGewicht) : base(hersteller, modell, new Scheibenbremse[] {
                new Scheibenbremse(),
                new Scheibenbremse(),
                new Scheibenbremse(),
                new Scheibenbremse()
        }, ps, hubraum, tankvolumen, zulGesamtGewicht)
        {


            this.sitze = sitze;
            this.tueren = tueren;
        }

        public String toString()
        {
            return base.toString() + " mit "
                    + sitze + " Sitzen, "
                    + tueren + " Türen";
        }
    }
}
