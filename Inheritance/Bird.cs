using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public bool HasBeak { get; set; } = true;

        public bool IsColorful { get; set; }
        public bool CanTalk { get; set; }
        public string BirdSpecies { get; set; }

        public void PrintBirdDetails()
        {
            Console.WriteLine("The Bird");
            Console.WriteLine($"The bird has a beak: {HasBeak}");
            Console.WriteLine($"The bird is colorful: {IsColorful}");
            Console.WriteLine($"The bird can talk: {CanTalk}");
            Console.WriteLine($"This bird is a {BirdSpecies}.");
            Console.WriteLine($"The bird can fly: {CanFly}");
        }
    }
}
