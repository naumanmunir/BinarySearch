using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] searchList = { 10, 11, 12, 16, 18, 23, 33, 48, 54, 57, 68, 77, 84, 98 };

            Array.Sort(searchList);

            Console.WriteLine("Input number to search: \n");
            int key = Convert.ToInt32(Console.ReadLine());
            

            while (true)
            {
                if (rank(key, searchList) < 0)
                {

                    Console.WriteLine("The number " + key + " could not be found!");
                    break;
                }
                else
                {
                    Console.WriteLine("Number " + key + " succesfully found!");
                    break;
                }
            }
            
        }

        public static int rank(int key, int[] a)
        {
            int lo = 0;
            int hi = a.Length - 1;
             
            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;

                if (key < a[mid])
                {
                    hi = mid - 1;
                }
                else if (key > a[mid])
                {
                    lo = mid + 1;
                }
                else
                    return mid;
            }

            return -1;
        }
    }
}
