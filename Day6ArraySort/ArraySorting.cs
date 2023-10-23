/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6ArraySort
{
    internal class ArraySorting
    {
        int[] arr;
        

        public ArraySorting(int size)
        {
            arr = new int[size];
        }
        public void ArrayData()
        {

            Console.WriteLine("Enter The Data of Array");
            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine($"Enter the {i+1} element ");
                int data = Convert.ToInt32(Console.ReadLine());
                arr[i] = data;
            }
            GetChoice();
        }

        public void GetChoice() {
            Console.WriteLine("Please Enter 'A' to print in Ascending Order or 'D' to Print in Descending Order ");
            char c = Convert.ToChar(Console.ReadLine().ToLower());
            GetData(c);
        }

        

        public void GetData(char c)
        {
            if(c=='a')
            {
                Ascending();
            }
            else if(c=='d')
            {
                Descending();
            }
        }
        public void Ascending()
        {
            Array.Sort(arr);
            Display(arr);
        }
        public void Descending()
        {
            Array.Sort(arr);
            Array.Reverse(arr);
            Display(arr);
        }
        public void Display(int[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
