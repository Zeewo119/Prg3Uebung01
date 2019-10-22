using System;
using System.Collections.Generic;
using System.Text;

namespace Prg3Uebung01
{
    public class Trommelbremse : Bremse
    {

    private int belag;
    private static readonly int MIN_BELAG = 2;
    private static readonly int MAX_BELAG = 8;

    public Trommelbremse()
    {
        this.belag = MAX_BELAG;
    }

    public void bremsen()
    {
        Console.WriteLine("Trommelbremse bremst!");
    }

    public bool brauchtService()
    {
        return belag < MIN_BELAG;
    }

    public String toString()
    {
        return "Trommelbremse";
    }
}
}
