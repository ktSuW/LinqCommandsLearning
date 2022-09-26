using LinqCommandsLearning.DataTypesPetVet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCommandsLearning.MethodSyntax
{
    static class Any
    {
        public static void Run()
        {
            var numbers = new[] { 5, 9, 2, 12, 6 };

            bool isAnyLargerThan10 = numbers.Any(num => num > 10);

            Console.WriteLine(isAnyLargerThan10);

            var pets = new[]
            {
                new Pet(1, "Hannibal", PetType.Fish, 1.1f),
                new Pet(2, "Anthony", PetType.Cat, 3.2f),
                new Pet(3, "Eddie", PetType.Cat, 0.7f),
                new Pet(4, "Suzuki", PetType.Dog, 30f),
                new Pet(5, "Lucky", PetType.Dog, 5f),
                new Pet(6, "Nuget", PetType.Fish, 2.1f),
                new Pet(7, "CutiePie", PetType.Fish, 1.1f),
                new Pet(8, "Kawaii", PetType.Cat, 3f),

            };

            var isANyPetNameBruce = pets.Any(pet => pet.Name == "Bruce Lee");

            Console.WriteLine($"isAnyPetNameBrue:  {isANyPetNameBruce}" );

            var isAnyFish = pets.Any(pet => pet.PetType == PetType.Fish);
            Console.WriteLine($"isAnyFish: {isAnyFish}");

            var specialPet = "";
            var isThereVerySpecificPet = pets.Any(
                pet =>
                pet.Name.Length > 6 &&
                pet.Id % 2 == 0 &&
                pet.PetType == PetType.Cat
                );
            Console.WriteLine($" The spefici pet is present in this list:  {isThereVerySpecificPet}");

            //Check whether the collection is empty or not
            var isNotEmpty = pets.Any();
        }


    }
}
