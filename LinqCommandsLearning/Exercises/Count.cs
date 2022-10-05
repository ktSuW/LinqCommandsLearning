using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCommandsLearning.Exercises
{
    public class Count
    {
        public static int CountAllLongWords(IEnumerable<string> words)
        {
            return words.Count(word => word.Length > 10);
        }

        public static bool AreThereFewerOddThanEvenNumbers(IEnumerable<int> numbers)
        {
            int oddNums = numbers.Count(n => n % 2 != 0);
            int evenNums = numbers.Count(n => n % 2 == 0);
            return oddNums < evenNums;
        }

        // Refactored 
        public static bool IsAnySequenceTooLong_Refactored(IEnumerable<IEnumerable<int>> numberSequences, int maxLength)
        {
            return numberSequences.Any(numSeq => numSeq.Count() > maxLength);
        }

        //do not modify this method
        public static bool IsAnySequenceTooLong(IEnumerable<IEnumerable<int>> numberSequences, int maxLength)
        {
            foreach (var numberSequence in numberSequences)
            {
                var count = 0;
                foreach (var number in numberSequence)
                {
                    ++count;
                }
                if (count > maxLength)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
