using System;
using System.Collections.Generic;
using System.Text;

namespace Prg3Uebung01
{
    public class Cantileverbremse : Bremse
    {

    private static readonly int MAX_BELAG = 5;
    private static readonly int MIN_BELAG = 1;

    private int belagLinks;
    private int belagRechts;

    public Cantileverbremse()
    {
        this.belagLinks = this.belagRechts = MAX_BELAG;
    }

    public void bremsen()
    {
        Console.WriteLine("Cantileverbremse bremst!");
    }

    public bool brauchtService()
    {
        return belagLinks > MIN_BELAG && belagRechts > MIN_BELAG;
    }

    public String toString()
    {
        return "Cantileverbremse";
    }
}
}
