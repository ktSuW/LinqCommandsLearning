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

        // Coding exercise 3
    }
}
