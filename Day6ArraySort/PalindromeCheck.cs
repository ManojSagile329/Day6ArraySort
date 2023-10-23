using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6ArraySort
{
    internal class PalindromeCheck
    {
        public static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number of sentences ");
            n=Convert.ToInt32(Console.ReadLine());
            PalindromeSentence ps = new PalindromeSentence();
            string sent = ps.GetSent(n);
            Console.WriteLine(sent);
            Console.WriteLine();
            Console.ReadLine();


        }

    }
}
