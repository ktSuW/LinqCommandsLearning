using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqCommandsLearning.DataTypesPetVet;

namespace LinqCommandsLearning.Exercises
{
    public class All
    {
        public static bool AreAllNumbersDivisibleBy10(int[] numbers)
        {
            return numbers.All(n => n % 10 == 0);
        }

        public static bool AreAllPetsOfTheSameType(IEnumerable<Pet> pets)
        {
            //return pets.All(pet => pet.PetType == PetType.Cat) ||
            //    pets.All(pet => pet.PetType == PetType.Dog) ||
            //    pets.All(pet => pet.PetType == PetType.Fish);

            var allPetTypes = Enum.GetValues(typeof(Pet)).Cast<PetType>();
            return allPetTypes.Any(petType => pets.All(pet => pet.PetType == petType));
        }


        public static bool AreAllWordsOfTheSameLength_Refactored(List<string> words)
        {
            return words.All(word => word.Length == words[0].Length);
        }

    
        public static bool AreAllWordsOfTheSameLength(List<string> words)
        {
            if (words.Count == 0 || words.Count == 1)
            {
                return true;
            }
            var length0 = words[0].Length;
            for (int i = 1; i < words.Count; ++i)
            {
                if (words[i].Length != length0)
                {
                    return false;
                }
            }
            return true;
        }
    }

}
