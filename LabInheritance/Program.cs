using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabInheritance
{
   public class Program
   {
      public static void Main()
      {
         Pet myPet = new Pet("Furry");
         Console.WriteLine("myPet: {0}", myPet);

         // TODO 3) create a Dog with the name "Snoopy"; print it
         Pet myDog = new Dog("Snoopy");
         Console.WriteLine("myDog: {0}", myDog);

         // TODO 4) create a Cat with the name "Sylvester"; print it
         Pet myCat = new Cat("Sylvester");
         Console.WriteLine("myCat: {0}", myCat);

         Console.WriteLine("\nDemonstrate Polymorphism:\n");

         // TODO 5) create an array of pets and initialize it with myPet, myDog, and myCat
         Pet[] myPets = {myPet, myDog, myCat};

         // TODO 6) use a foreach loop to print all pets and how they communicate
         foreach (Pet pet in myPets)
         {
             Console.WriteLine("pet: {0}, communication: {1}", pet, pet.Communicate());
         }
      }
   }
}