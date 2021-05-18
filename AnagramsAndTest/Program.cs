using System;
using System.Linq;
namespace AnagramsAndTest
{
    public static class Program
    {
        public static Boolean IsAnagram(string str1, string str2)
        {

            string x = str1.ToLower();
            string y = str2.ToLower();

            if (x == null || y == null)
                return false;

            if (x.Length != y.Length)
                return false;

            string ordered1 = String.Concat(x.OrderBy(p => p));
            string ordered2 = String.Concat(y.OrderBy(p => p));

            if (ordered1 == ordered2)
                return true;


            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
