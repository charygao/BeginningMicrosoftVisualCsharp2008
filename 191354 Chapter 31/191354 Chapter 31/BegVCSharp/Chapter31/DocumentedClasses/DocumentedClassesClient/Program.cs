using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DocumentedClasses;

namespace DocumentedClassesClient
{
   class Program
   {
      static void Main(string[] args)
      {
         int gardenWidth = 40;
         int gardenDepth = 20;

         Garden myGarden = new Garden(gardenWidth, gardenDepth);
         myGarden.Add(new Bench(4, 2));
         myGarden.Add(new Bench(10, 2));
         myGarden.Add(new Sprinkler(20, 10));
         myGarden.Add(new Tree(3, 13));
         myGarden.Add(new Tree(25, 7));
         myGarden.Add(new Tree(35, 15));
         myGarden.Add(new Flower(36, 0));
         myGarden.Add(new Flower(37, 0));
         myGarden.Add(new Flower(38, 0));
         myGarden.Add(new Flower(39, 0));
         myGarden.Add(new Flower(37, 1));
         myGarden.Add(new Flower(38, 1));
         myGarden.Add(new Flower(39, 1));
         myGarden.Add(new Flower(37, 2));
         myGarden.Add(new Flower(38, 2));
         myGarden.Add(new Flower(39, 2));
         myGarden.Add(new Statue(16, 3));
         myGarden.Add(new Bush(20, 17));

         char[,] plan = myGarden.GetPlan();

         for (int y = 0; y < gardenDepth; y++)
         {
            for (int x = 0; x < gardenWidth; x++)
            {
               Console.Write(plan[x, y]);
            }
            Console.WriteLine();
         }
         Console.ReadKey();
      }
   }
}
