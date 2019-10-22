using System;
using System.Collections.Generic;
using System.Text;

namespace Prg3Uebung01
{
    public class Kraftfahrzeug : Fahrzeug
    {

    private int ps;
    private int hubraum;
    private int tankvolumen;
    private int zulGesamtGewicht;

    public Kraftfahrzeug(String hersteller, String modell, Bremse[] bremsen, int ps, int hubraum, int tankvolumen, int zulGesamtGewicht):base(hersteller, modell, bremsen)
    {

        this.ps = ps;
        this.hubraum = hubraum;
        this.tankvolumen = tankvolumen;
        this.zulGesamtGewicht = zulGesamtGewicht;
    }

    public String toString()
    {
        return base.toString() + " "
                + ps + " PS, "
                + hubraum + " Hubraum, "
                + tankvolumen + " Tankvolumen, "
                + zulGesamtGewicht + " zul. Gesamtgewicht";
    }
}
}
