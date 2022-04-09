using System;
using System.Collections.Generic;
using System.Linq;

namespace StringSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string text = "Ala ma kota, kot ma Ale";
            string[] textArray = text.Split(" ");
            Dictionary<int, List<string>> charCounter = new Dictionary<int, List<string>>();
            foreach (var item in textArray)
            {
                if (charCounter.ContainsKey(item.Length))
                {
                    charCounter[item.Length].Add(item);
                }
                else
                {
                    charCounter.Add(item.Length, new List<string> { item });
                }
                
            }
            foreach (var item in charCounter.Keys)
            {
                Console.WriteLine($"Wyrazów {item} literowych w tekście {text} jest: {charCounter[item].Count}");
                foreach (var item2 in charCounter[item])
                {
                    Console.WriteLine("\t"+item2);
                }
            }
            Console.WriteLine(new String('-', 15));
            int[] listInt = { 3, 4, 6, 7, 8, 9 };
            listInt.Select(x => x * 2).ToList().ForEach(Console.WriteLine);
            Console.WriteLine(new String('-', 15));
            textArray.OrderBy(x => x.Length).GroupBy(x => x.Length).ToList().ForEach(x =>
            {
                Console.WriteLine(x.Key);
                x.ToList().ForEach(Console.WriteLine);
            });
            Console.WriteLine(new String('-',15));
            listInt.OrderByDescending(x => x).Where(x => x < 6).Select(x => Math.Sqrt(x)).ToList().ForEach(Console.WriteLine);
        }
    }
}
