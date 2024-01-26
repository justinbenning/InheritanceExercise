using System;

namespace Inheritance
{
 
    
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
