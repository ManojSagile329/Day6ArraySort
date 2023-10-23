using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6ArraySort
{
    internal class PalindromeSentence
    {
        string[] sentences;
        StringBuilder sb = new StringBuilder();

        public string  GetSent(int num)
        {
            sentences = new string[num];    
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Enter the {i+1} sentence ");
                sentences[i] = Console.ReadLine();
                string sent = sentences[i];
                Check(sent);

            }
            return sb.ToString();  
        }
        public string Check(string sent)
        {
            
            
            string[] words = sent.Split(' ');
            foreach (string word in words)
            {
                char[] ch = word.ToCharArray();
                Array.Reverse(ch);
                string reverse = new string(ch);
                if(reverse != word )
                {
                    sb.Append(reverse);
                    sb.Append(' ');
                }

            }
            return sb.ToString().Trim();
        }
    }
}
