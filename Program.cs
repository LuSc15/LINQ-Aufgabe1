using System;
using System.Linq;
namespace LINQ_Aufgabe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0, 22, 12, 16, 18, 11, 19, 13 };

            var kleiner7 = numbers.Where(x => x < 7);
            var gerade = numbers.Where(x => x > 0 && x % 2 == 0);
            var geradeEinstellig = numbers.Where(x => x < 10 && x % 2 == 1);
            var geradeAb6Element = numbers.Skip(5).Where(x => x % 2 == 0);

            Console.WriteLine("Kleiner 7:");
            foreach (var x in kleiner7)
            {
                Console.WriteLine(x.ToString());
            }
            Console.WriteLine("Gerade:");
            foreach(var x in gerade)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Gerade ab 6. Element");
            foreach(var x in geradeAb6Element)
            {
                Console.WriteLine(x);
            }


            string[] numbersString = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen" };
            var dreiZeichen = numbersString.Where(x => x.Length == 3);
            var mitO = numbersString.Where(x => x.Contains('o'));
            var teen = numbersString.Where(x => x.EndsWith("teen"));
            var teenGrossbuchstaben = numbersString.Where(x => x.EndsWith("teen")).Select(x => x.ToUpper());
            var four = numbersString.Where(x => x.Contains("four"));
            Console.WriteLine("Mit drei Zeichen:");
            foreach(var x in dreiZeichen)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Enthält o:");
            foreach (var x in mitO)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Endet auf teen:");
            foreach (var x in teen)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Endet auf teen in Großbuchstaben:");
            foreach (var x in teenGrossbuchstaben)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Enthält four:");
            foreach (var x in four)
            {
                Console.WriteLine(x);
            }

            int[] numbersAggregat = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0, 22, 12, 16, 18, 11, 19, 13 };
            var summe = numbersAggregat.Sum(x => x);
            var min = numbersAggregat.Min(x => x);
            var max = numbersAggregat.Max(x => x);
            var avg = numbersAggregat.Average(x => x);
            var klGerade = numbersAggregat.Where(x=> x%2 == 0).Min(x => x);
            var grUngerade = numbersAggregat.Where(x=>x%2 == 1).Max(x => x);
            var sumGerade = numbersAggregat.Where(x => x % 2 == 0).Sum(x =>x);
            var avgUngerade = numbersAggregat.Where(x => x % 2 == 1).Average(x => x);
            Console.WriteLine("Summe:");
            Console.WriteLine(summe);
            Console.WriteLine("Min:");
            Console.WriteLine(min);
            Console.WriteLine("Max:");
            Console.WriteLine(max);
            Console.WriteLine("Durchschnitt");
            Console.WriteLine(avg);
            Console.WriteLine("Kleinste gerade Zahl:");
            Console.WriteLine(klGerade);
            Console.WriteLine("Größte ungerade Zahl:");
            Console.WriteLine(grUngerade);
            Console.WriteLine("Summe gerader Zahlen:");
            Console.WriteLine(sumGerade);
            Console.WriteLine("Durchschnitt ungerader Zahlen:");
            Console.WriteLine(avgUngerade);
        }
    }
}
