using System;

namespace Inheritance
{
    internal class Animal
    {
        public bool IsWarmBlooded { get; set; }
        public bool HasEyes { get; set; }
        public string AnimalName { get; set; }
        public bool CanFly {  get; set; }
        
    }
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
    
    class Program
    {
        static void Main(string[] args)
        {
           Bird parrot = new Bird() { CanFly = true, HasBeak = true, IsColorful = true, CanTalk = true, BirdSpecies = "Parrot" };
            Reptile snake = new Reptile()
            {
                CanRegrowLegs = false,
                ReptileSpecies = "Copperhead",
                IsShedding = false,
                CanCamouflage = true,
                IsWarmBlooded = false
            };
            parrot.PrintBirdDetails();
            snake.PrintReptileDetails();



            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    
    }
}
