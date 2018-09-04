using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        public static int KaprekarsConstant(int num, int count = 0)
        {
            count++;
            string num1 = num.ToString();
            /*if(num < 1000)
            {
                num1 += 0;
            }*/
            List<int> list = new List<int>();
            for (int i = 0; i < num1.Length; i++)
            {
                list.Add(int.Parse(num1[i].ToString()));
            }
            List<int> ascending = new List<int>(list);
            ascending.Sort();
            List<int> descending = new List<int>(list);
            descending.Sort();
            descending.Reverse();
            List<string> asclist = ascending.ConvertAll(delegate (int i) { return i.ToString(); });
            List<string> dsclist = descending.ConvertAll(delegate (int i) { return i.ToString(); });
            string asc = string.Empty;
            string dsc = string.Empty;
            for (int i = 0; i < asclist.Count; i++)
            {
                asc += asclist[i];
            }
            for (int i = 0; i <dsclist.Count; i++)
            {
                dsc += dsclist[i];
            }

            int ascnum=Int32.Parse(asc);
            int dscnum = Int32.Parse(dsc);

            /*while (ascnum<1000)
            {
                ascnum *= 10;
            }*/

            while (dscnum < 1000)
            {
                dscnum *= 10;
            }

            int diff = dscnum > ascnum ? dscnum - ascnum : ascnum - dscnum;
            if (diff != 6174)
            {
                return KaprekarsConstant(diff, count);
            }
            else
            {
                return count;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Liul");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number in ascending order {0}", KaprekarsConstant(input));
            Console.ReadLine();
        }
    }
}
