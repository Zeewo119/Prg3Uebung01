using System;
using System.Collections.Generic;
using System.Text;

namespace Prg3Uebung01
{
    public class Fahrrad : Fahrzeug
    {

    private int gaenge;
    private bool ruecktrittbremse;

    public Fahrrad(String hersteller, String modell, int gaenge, bool ruecktrittbremse) : base(hersteller, modell, new Cantileverbremse[] { new Cantileverbremse(), new Cantileverbremse() })
    {
        this.gaenge = gaenge;
        this.ruecktrittbremse = ruecktrittbremse;
    }

    public String toString()
    {
        return base.toString() + " mit "
                + gaenge + " Gängen"
                + (ruecktrittbremse ? ", Rücktrittbremse" : "");
    }
}
}
