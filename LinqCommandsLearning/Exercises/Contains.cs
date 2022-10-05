using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCommandsLearning.Exercises
{
    public class Contains
    {
        public static bool IsAppointmentAvailable(DateTime date, IEnumerable<DateTime> existingAppointDates)
        {
            return !existingAppointDates.Contains(date);
        }

        public static int CountFriendsOf(Friend friend, IEnumerable<Person> people)
        {
            return people.Count(person => person.Friends.Contains(friend));
        }

        // NOt refactored
        public static bool ContainsBannedWords(IEnumerable<string> words, IEnumerable<string> bannedWords)
        {
            foreach(var word in words)
            {
                foreach(var bannedWord in bannedWords)
                {
                    if(word == bannedWord)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        // Refactored
        public static bool ContainsBannedWords_Refactored(IEnumerable<string> words, IEnumerable<string> bannedWords)
        {
            return words.Any(word => bannedWords.Contains(word));
        }

    }

    public class Friend
    {
        public int Name { get; }
    }

    public class Person
    {
        public string Name { get; }
        public IEnumerable<Friend> Friends { get; }

        public Person(string name, IEnumerable<Friend> friends)
        {
            this.Name = name;
            this.Friends = friends;
        }
    }
}
