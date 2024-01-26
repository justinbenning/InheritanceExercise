using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public bool CanRegrowLegs { get; set; }
        public string ReptileSpecies { get; set; }
        public bool IsShedding { get; set; }
        public bool CanCamouflage { get; set; }
        public void PrintReptileDetails()
        {
            Console.WriteLine("The Reptile");
            Console.WriteLine($"Can regrow legs: {CanRegrowLegs}");
            Console.WriteLine($"This reptile is a {ReptileSpecies}.");
            Console.WriteLine($"Is it shedding: {IsShedding}");
            Console.WriteLine($"Can it camouflage: {CanCamouflage}");
            Console.WriteLine($"Is is warm blooded: {IsWarmBlooded}");
        }
    }
}
