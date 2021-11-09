using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haromszogek
{
  class DHaromszog
  {
    double aOldal;
    double bOldal;
    double cOldal;
    public double a
    {
      get { return aOldal; }
      set
      {
        if (value>0)
        {
          aOldal = value;
        }
        else
        {
          throw new OldalNemJoException("Az \'a\' oldal nem lehet negatív vagy nulla");
        }
      }
    }
    public double b
    {
      get { return bOldal; }
      set
      {
        if (value>0)
        {
          bOldal = value;
        }
        else
        {
          throw new OldalNemJoException("Az \'b\' oldal nem lehet negatív vagy nulla");
        }
      }
    }
    public double c
    {
      get { return cOldal; }
      set
      {
        if (value>0)
        {
          cOldal = value;
        }
        else
        {
          throw new OldalNemJoException("Az \'c\' oldal nem lehet negatív vagy nulla");
        }
      }
    }

    private bool EllDerekszogu
    {
      get { return Math.Pow(aOldal,2) + Math.Pow(bOldal,2) == Math.Pow(cOldal,2); }
    }


    private bool EllMegszerkesztheto
    {
      get { return aOldal+bOldal>cOldal; }
    }


    private bool EllNovekvoSorrend
    {
      get { return aOldal<=bOldal && bOldal<= cOldal; }
    }

    private double kerulet;

    public double Kerulet
    {
      get { return kerulet; }
    }

    private int sorszama;

    public int Sorszama
    {
      get { return sorszama; }
      set { sorszama = value; }
    }
    private double terulet;

    public double Terulet
    {
      get { return terulet; }
    }

    public DHaromszog(string sor, int sorSzama)
    {
      string[] adatok = sor.Split();
      a = Convert.ToDouble(adatok[0]);
      b = Convert.ToDouble(adatok[1]);
      c = Convert.ToDouble(adatok[2]);

      //a > 0 ? aOldal = a :"Az a oldal nem lehet nulla";
      //b > 0 ? bOldal = a :"A b oldal nem lehet nulla";
      //c > 0 ? cOldal = a :"A c oldal nem lehet nulla";
      if (!EllNovekvoSorrend)
      {
        throw new NovekvoSorrendException("Az adatok nincsenek sorrendben");
      }
      if (!EllMegszerkesztheto)
      {
        throw new MegszerkeszthetoException("A háromszög nem megszerkeszthető!");
      }
      if (!EllDerekszogu)
      {
        throw new DerekszoguException("A háromszög nem derékszögű");
      }
      
      terulet = a + b + c;
      kerulet = a * b / 2;
    }
  }
}
