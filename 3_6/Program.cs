using System;
using System.Linq;
using System.Collections.Generic;
using RandomDataGenerator.Randomizers;
using RandomDataGenerator.FieldOptions;

namespace _3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = Enumerable.Range(150, 100).ToList();

            var generatorFirstName =
                RandomizerFactory.GetRandomizer(new FieldOptionsFirstName());
            var generatorLastName =
                RandomizerFactory.GetRandomizer(new FieldOptionsLastName());

            List<Osoba> osoby = lista.Select(
                x => new Osoba(
                    generatorFirstName.Generate(),
                    generatorLastName.Generate(),
                    x)).ToList();

            //foreach (var item in osoby)
            //{
            //    Console.WriteLine($"{item.imie}:{item.nazwisko}:{item.id}");
            //}

            //posortuj liste po imieniu a potem po nazwisku

            osoby.OrderBy(x => x.imie);
            foreach (var item in osoby)
            {
                Console.WriteLine($"{item.imie}:{item.nazwisko}:{item.id}");
            }

            #region stare2
            //List<int> lista = Enumerable.Range(150, 100).ToList();
            //lista.ForEach(x => Console.WriteLine(x));

            //List<Osoba> osoby = lista
            //    .Select(x => new Osoba()
            //    {
            //        imie = x.ToString(),
            //        nazwisko = "aa",
            //        id = x
            //    }).ToList();

            //foreach (var item in osoby)
            //{
            //    Console.WriteLine($"{item.id}:{item.imie}:{item.nazwisko}");
            //}

            //osoby.Select(x => x.nazwisko)
            //    .Distinct().ToList().ForEach(Console.WriteLine);

            //int iloscElementowNaStronie = 10;
            //int stronaNr = 2;
            //List<Osoba> strona = osoby.Skip(iloscElementowNaStronie * (stronaNr - 1)).Take(iloscElementowNaStronie).ToList();

            //foreach (var item in strona)
            //{
            //    Console.WriteLine($"{item.id}:{item.imie}:{item.nazwisko}");
            //}
            #endregion

            #region Stare
            /*
            //List<double> lista = Enumerable.Range(150, 100).
            //    Select(x=>(double)x).ToList();

            List<int> lista = Enumerable.Range(150, 100).ToList();

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            IEnumerable<int> podzielnePrzez3 = lista.Where(x => x % 3 == 0);
            foreach (var item in podzielnePrzez3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(podzielnePrzez3.Sum());
            Console.WriteLine(podzielnePrzez3.Average());
            */
            #endregion
        }
    }
}
