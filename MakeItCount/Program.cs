using MakeItCount.Models;
using MakeItCount.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MakeItCount
{
    public class Program
    {
        public static void Main()
        {

            var prog = new Program();
            prog.mainloop();
        }

        public void mainloop()
        {

            Console.WriteLine("Press enter to start");
            Console.ReadLine();
            Console.WriteLine("..or..");
            Console.ReadLine();
            Console.WriteLine(".. Hold enter to find balance");
            Console.ReadLine();

            var attempt = 1;
            var totalLoss = 0;
            while (true)
            {
                Console.WriteLine($"Planting eden attempt #{attempt}..");
                var eden = new Orchard();

                Console.WriteLine("Success.");
                Console.WriteLine("Initializing forbidden fruit...");
                var fruitful = new Counter<cart<apple>>();

                Console.WriteLine("Success.");
                Console.WriteLine("Locating Tree of knowledge...");
                var TreeOfKnowledge = eden.GenoCider();
                Console.WriteLine("Success.");

                Console.WriteLine("Commencing fall...");
                foreach (var cart in TreeOfKnowledge)
                {
                    fruitful.Add(cart);
                }

                Console.WriteLine($"manual count of casualties : {eden.countApplesula}");
                Console.WriteLine($"fruitful count of casualties : {fruitful.Count}");
                totalLoss += fruitful.Count;
                Console.WriteLine("Counting divisons..");

                var allApples = new List<apple>();

                foreach (var _cart in TreeOfKnowledge)
                {
                    foreach (var _box in _cart.items)
                    {
                        _box.items.ForEach(allApples.Add);
                    }
                }
                
                Console.WriteLine("checking for lost casualties...");
                var findings = allApples.Count() == fruitful.Count ? "none found." : (fruitful.Count - allApples.Count) + " are missing";
                Console.WriteLine(findings);
                
                var redDivision = new Counter<apple>(i => i.Colour == Enums.Colour.Red);
                var greenDivision = new Counter<apple>(i => i.Colour == Enums.Colour.Green);

                allApples.ForEach(redDivision.Add);
                allApples.ForEach(greenDivision.Add);

                Console.WriteLine($"{redDivision.Count} casualties were from the red division");
                Console.WriteLine($"{greenDivision.Count} casualties were from the green division");
                Console.WriteLine($"totaling {greenDivision.Count + redDivision.Count} lives lost");

                if (redDivision.Count == greenDivision.Count)
                {
                    Console.WriteLine($"balance was achived after {attempt} attempts");
                    Console.WriteLine($"costing a total of {totalLoss} lives");
                    var cost = Convert.ToDouble(totalLoss) * 0.22;
                    Console.WriteLine($"Given the average cost of apples in london on 11th of May 2018 this would cost £{cost}");
                    Console.WriteLine();
                    Console.WriteLine("..wow.");
                    Console.WriteLine();
                    Console.WriteLine();
                    while (true) { }
                }
                Console.WriteLine("Press any key to beggin new universe...");
                Console.ReadLine();
                attempt++;
            }
        }
    }
}