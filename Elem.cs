using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kémia
{
  class Elem
  {
    private string ev;

    public string Ev
    {
      get { return ev; }
    }

    private string nev;

    public string Nev
    {
      get { return nev; }
    }

    private string vegyjel;

    public string Vegyjel
    {
      get { return vegyjel; }
    }

    private int rendszam;

    public int Rendszam
    {
      get { return rendszam; }
    }

    private string tudos;

    public string Tudos
    {
      get { return tudos; }
    }

    public Elem(string ev, string nev, string vegyjel, int rendszam, string tudos)
    {
      this.ev = ev;
      this.nev = nev;
      this.vegyjel = vegyjel;
      this.rendszam = rendszam;
      this.tudos = tudos;
    }
  }
}
