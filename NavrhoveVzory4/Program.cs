using NavrhoveVzory4.Model;
using NavrhoveVzory4.Model.výčty;
using System;
using System.Collections.Generic;

namespace NavrhoveVzory4
{
    class Program
    {

        // dobře psaný kód se komentuje sám :)

        static void Main(string[] args)
        {
            Směrovač smeřovač = new Směrovač();

            List <Vysílač> vysílače = new List<Vysílač>();
            vysílače.Add(new Vysílač(1, Typ_vysílání.FILMY));
            vysílače.Add(new Vysílač(2, Typ_vysílání.SPORT));

            Console.WriteLine(smeřovač.registrujNovýPřijímač(1, Typ_vysílání.LIBOVOLNÝ_TEXT, Typ_vysílání.FILMY));
            Console.WriteLine(smeřovač.NaŘetězec());
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            Console.WriteLine(smeřovač.přepniVysílání(vysílače[1], 0));
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            Console.WriteLine(smeřovač.změňTypVysílání(Typ_vysílání.SPORT, 0));
            Console.WriteLine(smeřovač.NaŘetězec());
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            Console.WriteLine(smeřovač.přepniVysílání(vysílače[1], 0));
            Console.WriteLine(smeřovač.NaŘetězec());
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            Console.WriteLine(smeřovač.odeberPřijímačDleIndexu(0));
            Console.WriteLine(smeřovač.NaŘetězec());
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            Console.ReadKey();
        }
    }
}
