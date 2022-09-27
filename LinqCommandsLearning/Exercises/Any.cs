using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCommandsLearning.Exercises
{
    public static class Any
    {
        // Coding exercise 1
        public static bool IsAnyNumberNegative(IEnumerable<int> numbers)
        {
            return numbers.Any(num => num < 0);
        }
        // Coding exercise 2
        public static bool AreThereAnyBigCats(IEnumerable<Pet> pets)
        {
            return pets.Any(pet => pets.Any(pet => pet.PetType == PetType.Cat && pet.Weight > 2));
        }
        public enum PetType
        {
            Cat,
            Dog,
            Fish
        }

        public class Pet
        {
            public int Id { get; }
            public string Name { get; }
            public PetType PetType { get; }
            public float Weight { get; }

            public Pet(int id, string name, PetType petType, float weight)
            {
                Id = id;
                Name = name;
                PetType = petType;
                Weight = weight;
            }

            public override string ToString()
            {
                return $"Id: {Id}\nName: {Name}\nType: {PetType}\nWeight: {Weight}";
            }
        }


        // Coding exercise 3
        public static bool AreAllNamesValid(string[] names)
        {
            foreach (var name in names)
            {
                if (char.IsLower(name[0]))
                {
                    return false;
                }
                if (name.Length < 2)
                {
                    return false;
                }
                if (name.Length > 25)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool AreAllNamesValidRefactored(string[] names)
        {
            return !names.Any(name =>
                char.IsLower(name[0]) ||
                name.Length < 2 ||
                name.Length > 25
            );
        }
    }
}
