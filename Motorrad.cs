using System;
using System.Collections.Generic;
using System.Text;

namespace Prg3Uebung01
{
    public class Motorrad : Kraftfahrzeug
    {


    public Motorrad(String hersteller, String modell, int ps, int tankvolumen) :base(hersteller, modell, new Bremse[] {
                new Scheibenbremse(),
                new Trommelbremse()
        }, ps, 0, tankvolumen, 100)
    {

    }

    public void anlassen()
    {
        Console.WriteLine("Starte Motor...");
    }
}

}
