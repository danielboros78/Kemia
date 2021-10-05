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
    static List<Elem> elemek = new List<Elem>();
    static void Main(string[] args)
    {
      MasodikFeladat();
      HarmadikFeladat();
      Console.ReadKey();
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
