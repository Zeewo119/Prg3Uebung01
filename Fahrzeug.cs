using System;
using System.Collections.Generic;
using System.Text;

namespace Prg3Uebung01
{
    public class Fahrzeug
    {
        private String hersteller;
        private String modell;
        private Bremse[] bremsen;

        public Fahrzeug(String hersteller, String modell, Bremse[] bremsen)
        {
            this.bremsen = bremsen;
            this.hersteller = hersteller;
            this.modell = modell;
        }

        public String toString()
        {
            return "Ich bin ein " + hersteller + " " + modell
                    + " mit " + bremsen.Length + " Bremsen ("
                    + string.Join(", ", (Array) bremsen) + ")";
        }
    }
}
