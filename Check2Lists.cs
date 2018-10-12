using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Palindromas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good day, type a sentence which might be a Palidnrome:");
            string userInput = Console.ReadLine();
            string trimmedInput = userInput.ToLower().Replace(" ", "");
            List<char> listedChars = new List<char>(trimmedInput.ToList());
            int lengthOfListedChars = listedChars.Count;
            double center = Convert.ToDouble(lengthOfListedChars);
            center = Math.Round(center / 2);
            int centerInt = Convert.ToInt32(center);
            listedChars.RemoveAt(centerInt);
            List<char> reversedList = new List <char> (listedChars);
            reversedList.Reverse();

            var firstList = listedChars.Except(reversedList);
            var secondList = reversedList.Except(listedChars);
            foreach (var item in secondList)
            {
                Console.Write($"no items{item}");
            }
            foreach (var item in firstList)
            {
                Console.Write(item+"no items");
            }



            if (firstList==secondList)
            {
                Console.WriteLine("Congratulations, it matches");
            }
            else
            {
                Console.WriteLine("This is completely wrong");
            }

            Console.ReadLine();
            

        }
    }
}
