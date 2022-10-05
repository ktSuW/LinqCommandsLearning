using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LinqCommandsLearning.MethodSyntax;
using LinqCommandsLearning.DataTypesPetVet;
using LinqCommandsLearning.Exercises;
using System.Drawing.Printing;
using Microsoft.Graph;

namespace LinqTutorial
{
    public static class StringExtensions
    {
        // this keyword => makes it extension method 
        public static int GetCountOfLines(this string input)
        {
            return input.Split("\n").Length;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            //=========================================
            //var wordsNoUpperCase = new String[]
            //{
            //    "quick", "brown", "fox"
            //};
            //Console.WriteLine(IsAnyWordUpperCase(wordsNoUpperCase));

            //var wordsWithUpperCase = new String[]
            //{
            //    "quick", "brown", "FOX"
            //};
            //Console.WriteLine(IsAnyWordUpperCase(wordsWithUpperCase));

            //var orderedWords = wordsNoUpperCase.OrderBy(word => word.ToUpper());

            //// Any
            //// - is any number in an array larger than 100
            //// Any string in a list start with letter P
            //var numbers = new[] { 1, 4, 3, 99, 256, 2 };
            ////bool isAnyLargerThan100 = IsAnyLargerThan100(numbers);
            ////bool isAnyLargerThan100 = IsAny(numbers, IsLargerThan100);

            ////bool isAnyLargerThan100 = IsAny(numbers, num => num > 100);
            //bool isAnyLargerThan100 = IsAny(numbers, num => 
            //{ 
            //    const int max = 100;          return num > max;
            // });

            //Console.WriteLine($"Is any >100: {isAnyLargerThan100}");

            //Func<int, bool> isAnyEvenFuc = num => num % 2 == 0;
            ////bool isAnyEven = IsAny(numbers, IsAnyEven);
            //bool isAnyEven = IsAny(numbers, num => num % 2 == 0);
            //Console.WriteLine($"Is any even: {isAnyEven}");

            //var words = new[] { "aaa", "BBB", "ccc" };
            //bool isAnyOfLength4 = IsAny(words, word => word.Length > 4);
            //Console.WriteLine($"Length of the string is not greater than {words.Length}, therefore it is {isAnyOfLength4}");

            //========== LINQ extension methods =====================
            //var words = new[] { "a", "bb", "ccc" , "dddd"};
            //var wordsLongerThan2Letters = words.Where(word => word.Length > 2);

            //Console.WriteLine(string.Join(", ", wordsLongerThan2Letters));

            //var multilineString = @"ays off for niche sports isn't just an Australian thing, either. 
            //Hong Kong takes one day off for the Dragon Boat Festival. 
            //This takes place on the fifth day of the fifth month on the Chinese calendar, 
            //which is generally around May or June.It starts to make more sense 
            //when you realise there's a long-standing Chinese tradition of warding off bad luck on this day. 
            //The dragon boat races came much later – 
            //but became such a focal point that the public holiday took their name.";
            //var countOfLines = multilineString.GetCountOfLines();
            //====================== IEnumerable<T> and method chaining ===================================
            //var nums = new List<int> { 5, 3, 7, 1, 2, 4 };
            //var numbersWith10 = nums.Append(10);
            //Console.WriteLine("Nums are : " + string.Join(", ", nums));
            //Console.WriteLine("NumsWith10 are : " + string.Join(", ", numbersWith10));

            // Perform linq methods on another linq method
            //var oddNumbers = nums.Where(num => num % 2 == 1);
            //    var orderedOddNumbers = oddNumbers.OrderBy(num => num);
            //    Console.WriteLine("Ordered oddNumbers are: " + string.Join(", ", orderedOddNumbers));
            //var orderedOddNumbers = nums
            //    .Where(num => num %2 ==1)
            //    .OrderBy(num => num);
            //Console.WriteLine("Ordered oddNumbers are: " + string.Join(", ", orderedOddNumbers));
            //============= Deferred Evaluation ==============

            //var words = new List<string> { "a", "bb", "ccc", "dddd"};
            // if you add ToList(), it will materialise it and e will not be added.
            //var shortWords = words
            //    .Where(word => word.Length < 3).ToList();

            //foreach (var word in shortWords)
            //{
            //    Console.WriteLine(word);
            //}
            //words.Add("e");
            //foreach (var word in shortWords)
            //{
            //    Console.WriteLine(word);
            //}

            //var people = new List<Person>
            //{
            //    new Person("Sagawa", "Japan"),
            //    new Person("Hishimoto", "Australia");
            //};
            //var allJapanese = people.Where(person => person.Country == "Japan");

            //var notAllJapanese = notAllJapanese.Take(100);

            //    var animals = new List<string>
            //{
            //    "Duck", "Lion", "Dolphin", "Tiger"
            //};
            //    var animalsWithD = animals.Where(
            //        animal =>
            //        {
            //            Console.WriteLine("Checking animal starts with D: " + animal);
            //            return animal.StartsWith('D');
            //        });
            //    // Deferred execution
            //    foreach(var animal in animalsWithD)
            //    {
            //        Console.WriteLine(animal);
            //    }

            //=============Method Syntax vs Query Syntax =================

            //var nums = new[] { 4, 2, 7, 10, 12, 5 , 4, 2};
            //var smallOrderedMethodSyntax = nums
            //    .Where(num => num < 10)
            //    .OrderBy(num => num)
            //    .Distinct();
            //Console.WriteLine(
            //    string.Join(", ", smallOrderedMethodSyntax));

            //var smallOrderedQuerySyntax = (from num in nums
            //where num < 10
            //orderby num
            //select num).Distinct(); Console.WriteLine(
            //    string.Join(", ", smallOrderedQuerySyntax));
            /**
             *  METHOD SYNTAX
             */
            //============ ANY ==============
            //Any.Run();

            //=============== All =====================================
            //var numbers = new[] { 5, 9, 2, 12, 6 };
            //var areAllLargerThanZero = numbers.All(n => n > 0);
            ////Printer.Print(areAllLargerThanZero, nameof(areAllLargerThanZero));

            //var pets = new[]
            //{
            //    new Pet(1, "Hannibal", PetType.Fish, 1.1f),
            //    new Pet(2, "Anthony", PetType.Cat, 2f),
            //    new Pet(3, "Ed", PetType.Cat, 0.7f),
            //    new Pet(4, "Taiga", PetType.Dog, 35f),
            //    new Pet(5, "Rex", PetType.Dog, 40f),
            //    new Pet(6, "Lucky", PetType.Dog, 5f),
            //    new Pet(7, "Storm", PetType.Cat, 0.9f)
            //};
            //var doAllHaveNonEmptyNames = pets.All(pet => !string.IsNullOrEmpty(pet.Name));
            //Console.WriteLine("doAllHaveNonEmptyNames " , doAllHaveNonEmptyNames);

            //=============== All =====================================

            //var numbers = new[] { 5, 9, 2, 12, 6 };
            //var areAllLargerThanZero = numbers.All(n => n > 0);
            ////Printer.Print(areAllLargerThanZero, nameof(areAllLargerThanZero));

            //var pets = new[]
            //{
            //    new Pet(1, "Hannibal", PetType.Fish, 1.1f),
            //    new Pet(2, "Anthony", PetType.Cat, 2f),
            //    new Pet(3, "Ed", PetType.Cat, 0.7f),
            //    new Pet(4, "Taiga", PetType.Dog, 35f),
            //    new Pet(5, "Rex", PetType.Dog, 40f),
            //    new Pet(6, "Lucky", PetType.Dog, 5f),
            //    new Pet(7, "Storm", PetType.Cat, 0.9f)
            //};

            //====================== Count =================================
            //var countOfDogs = pets.Count(pet => pet.PetType == PetType.Dog);
            //Console.WriteLine("Numbers of dog is " +  countOfDogs);
            //var countOfPetNameBruce = pets.Count(pet => pet.Name == "Bruce");
            //Console.WriteLine(countOfPetNameBruce);

            //var countOfDogsSmallerThan10Kg = pets.Count(pet => pet.PetType == PetType.Dog && pet.Weight < 10);
            //Console.WriteLine("Small dogs numbers " + countOfDogsSmallerThan10Kg);

            //======================== Contains =================================

            var numbers = new[] { 16,8, 9, -1, 2 };
            bool is7Present = numbers.Contains(7);
            global::System.Console.WriteLine("7 is present in the numbers : " + is7Present);

            var words = new[] { "lion", "tiger", "snow leopard" };
            bool isTigerPresent = words.Contains("tiger");
            

            var pets = new[]
            {
                new Pet(1, "Hannibal", PetType.Fish, 1.1f),
                new Pet(2, "Anthony", PetType.Cat, 2f),
                new Pet(3, "Ed", PetType.Cat, 0.7f),
                new Pet(4, "Taiga", PetType.Dog, 35f),
                new Pet(5, "Rex", PetType.Dog, 40f),
                new Pet(6, "Lucky", PetType.Dog, 5f),
                new Pet(7, "Storm", PetType.Cat, 0.9f)
            };
            var hannibal = pets[0];
            bool isHannibalPresent = pets.Contains(hannibal);
            Console.WriteLine("Hannibal is present " + isHannibalPresent);


            Console.ReadKey();
        }




    //private static bool IsAnyLargerThan100(int[] numbers)

    // Make it parameterised
    private static bool IsAny<T>(IEnumerable<T> numbers, Func<T, bool> predicate)
            /**Function taking a number and returning a bool  **/
        {
            foreach(var n in numbers)
            {
                if(/*IsAnyLargerThan100(n)*/predicate(n))
                {
                    return true;    
                }
            }
            return false;
        }
        
        //private static bool IsLargerThan100(int num)
        //{
        //    return num > 100;
        //}

        private static bool IsAnyEven(int[] numbers)
        {
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        //private static bool IsEven(int num)
        //{
        //    return num % 2 == 0;
        //}

        public static bool IsAnyWordUpperCase(IEnumerable<string> words)
        {
            foreach (var word in words)
            {
                bool areAllUppercase = true;
                foreach (var letter in word)
                {
                    if (char.IsLower(letter))
                    {
                        areAllUppercase = false;
                    }
                }
                if (areAllUppercase)
                {
                    return true;
                }

            }

            return false;
        }


        public static bool IsAnyWordUpperCase2(IEnumerable<string> words)
        {
            return words.Any(word => word.All(letter => char.IsUpper(letter)));
        }

    }
}
