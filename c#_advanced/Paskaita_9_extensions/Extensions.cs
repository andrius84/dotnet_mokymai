using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_9_extensions
{
    internal static class Extensions
    {
        public static bool IsPositiveOrNegative(this int number)
        {
            return number > 0;
        }
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }
        public static bool IsNumberBiggerThan(this int number, int otherNumber)
        {
            return number > otherNumber;
        }
        public static bool IsThereSpace(this string sentence)
        {
            return sentence.Contains(" ");
        }
        public static string FormatEmail(this string fullname, string yearOfBirth, string domain)
        {
            string cleanedFullname = fullname.Replace(" ", "");
            return $"{cleanedFullname}{yearOfBirth}@gmail.{domain}";
        }
        public static T FindAndReturnIfEqual<T>(this List<T> list, T item)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list), "The list cannot be null.");
            }
            foreach (var listItem in list)
            {
                if (listItem.Equals(item))
                {
                    return listItem;
                }
            }
            return default(T);
        }

        public static List<T> EveryOtherWord<T>(this List<T> list)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list), "The list cannot be null.");

            }
            List<T> everyOtherWord = new List<T>();
            foreach (var listItem in list)
            {
                if (list.IndexOf(listItem) % 2 == 0)
                {
                    everyOtherWord.Add(listItem);
                }
            }
            return everyOtherWord;
        }


    }
}
