using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cesaretti.elia._4j.giocodicarte.Models;

namespace cesaretti.elia._4j.giocodicarte
{
    class Program
    {
        static void Main(string[] args)
        {
            int valore1=0, valore2=0;
            string seme1 = "", seme2 = "";
            Console.WriteLine("Che valore ha la prima carta?");
            valore1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Che seme ha la prima carta?");
            seme1 = Console.ReadLine();
            Carta Carta1 = new Carta(valore1, seme1);
            Console.WriteLine(Carta1.Visualizza(Carta1));
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Che valore ha la seconda carta?");
            valore2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Che seme ha la seconda carta?");
            seme2 = Console.ReadLine();
            Carta Carta2 = new Carta(valore2, seme2);
            Console.WriteLine(Carta2.Visualizza(Carta2));
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(Carta1.Vince(Carta1,Carta2));
            Console.ReadLine();
        }
    }
}
