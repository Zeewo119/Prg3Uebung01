using System;
using System.Collections.Generic;
using System.Text;

namespace Prg3Uebung01
{
    public class Lastwagen : Kraftfahrzeug
    {

    private int achsen;
    private int maxNutzlast;

    public Lastwagen(String hersteller, String modell, int achsen, int ps, int hubraum, int tankvolumen, int maxNutzlast, int zulGesamtGewicht) : base(hersteller, modell, erstelleBremsen(achsen* 2), ps, hubraum, tankvolumen, zulGesamtGewicht)
    {
        this.achsen = achsen;
        this.maxNutzlast = maxNutzlast;
    }

    private static Bremse[] erstelleBremsen(int n)
    {
        Bremse[] bs = new Bremse[n];
        for (int i = 0; i < n; i++)
            bs[i] = new Trommelbremse();
        return bs;
    }

    public String toString()
    {
        return base.toString()
                + achsen + " Achsen, "
                + maxNutzlast + " max. Nutzlast";
    }
}

}
