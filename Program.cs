using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kémia
{
  class Program
  {
    static string vegyjel = "";
    static List<Elem> elemek = new List<Elem>();
    static void Main(string[] args)
    {
      MasodikFeladat();
      HarmadikFeladat();
      NegyedikFeladat();
      OtodikFeladat();
      HatodikFeladat();
      HetedikFeladat();
      NyolcadikFeladat();
      Console.ReadKey();
    }

    private static void NyolcadikFeladat()
    {
      Console.WriteLine("8. feladat: Statisztika");
      Dictionary<string, int> stat = new Dictionary<string, int>();
      int j = 0;
      while (elemek[j].Ev == "Ókor")
      {
        j++;
      }
      for (int i = j; i < elemek.Count; i++)
      {
        if (!stat.ContainsKey(elemek[i].Ev))
        {
          stat.Add(elemek[i].Ev, 1);
        }
        else
        {
          stat[elemek[i].Ev]++;
        }
      }
      foreach (var s in stat)
      {
        if (s.Value > 3)
        {
          Console.WriteLine($"\t{s.Key} : {s.Value} db");
        }
      }
    }

    private static void HetedikFeladat()
    {
      int j = 0;
      int max = 0;
      while (elemek[j].Ev == "Ókor")
      {
        j++;
      }
      while (j < elemek.Count - 1)
      {
        if (max < Convert.ToInt32(elemek[j + 1].Ev) - Convert.ToInt32(elemek[j].Ev))
        {
          max = Convert.ToInt32(elemek[j + 1].Ev) - Convert.ToInt32(elemek[j].Ev);
        }
        j++;
      }
      Console.WriteLine($"7. feladat: {max} év volt a leghosszabb időszak két elem felfedezése között.");
    }

    private static void HatodikFeladat()
    {
      Console.Write("6. feladat: ");
      int i = 0;
      while (i < elemek.Count && elemek[i].Vegyjel.ToLower() != vegyjel.ToLower())
      {
        i++;
      }
      if (i < elemek.Count)
      {
        Console.WriteLine();
        Console.WriteLine($"Keresés\n\tAz elem vegyjele: {elemek[i].Vegyjel}\n\tAz elem neve: {elemek[i].Nev}\n\tRendszáma: {elemek[i].Rendszam}\n\tFelfedezés éve: {elemek[i].Ev}\n\tFelfedező: {elemek[i].Tudos}");
      }
      else
      {
        Console.WriteLine("Nincs ilyen elem az adatforrásban.");
      }
    }

    private static void OtodikFeladat()
    {
      bool nemjo = false;
      string abece = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      do
      {
        nemjo = false;
        Console.Write("5. feladat: Kérek egy vegyjelet: ");
        vegyjel = Console.ReadLine();
        vegyjel = vegyjel.ToUpper();
        for (int i = 0; i < vegyjel.Length; i++)
        {
          if (abece.Contains(vegyjel[i]))
          {
            nemjo = false;
          }
        }
        if (vegyjel.Length > 2 || vegyjel == "")
        {
          nemjo = true;
        }
      } while (nemjo); ;
    }

    private static void NegyedikFeladat()
    {
      int db = 0;
      foreach (var e in elemek)
      {
        if (e.Ev == "Ókor")
        {
          db++;
        }
      }
      Console.WriteLine($"4. feladat: Felfedezések száma az ókorban: {db}");
    }

    private static void HarmadikFeladat()
    {
      Console.WriteLine($"3. feladat: Elemek száma: {elemek.Count}");
    }

    private static void MasodikFeladat()
    {
      StreamReader be = new StreamReader("felfedezesek.csv");
      be.ReadLine();
      while (!be.EndOfStream)
      {
        string[] a = new string[5];
        a = be.ReadLine().Split(';');
        elemek.Add(new Elem(a[0], a[1], a[2], Convert.ToInt32(a[3]), a[4]));
      }
      be.Close();
    }
  }
}
