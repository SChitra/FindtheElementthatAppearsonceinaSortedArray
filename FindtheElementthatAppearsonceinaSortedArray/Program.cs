using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindtheElementthatAppearsonceinaSortedArray
{
    class Program
    {
        /***Find the element that appears once in a sorted array where all other elements appear twice one after another.
        Find that element in 0(logn) complexity.***/

        static void Main(string[] args)
        {
            //int[] arr = { 1, 1, 3, 3, 4, 5, 5, 6, 6, 7, 7, 8, 8 };
            int[] arr = { 1, 1, 3, 3, 4, 4, 5,5, 6, 6, 7, 8, 8 };
            int end = arr.Length - 1;
            int start = 0;
            BinarySearch(arr, start, end);
            


        }

        public static void BinarySearch(int[] arr,int start, int end)
        {
            if (start == end)
            {
                Console.WriteLine("The duplicate number is {0}", arr[start]);
                return;
            }
            //Find the middle index
            int mid = (start+end) / 2;
            //Check if even or odd
            if(mid%2 == 0)
            {
                //if even compare the middle element and next element if same then the element is on the right side else left
                if (arr[mid] == arr[mid + 1])
                {
                    BinarySearch(arr, mid + 2, end);
                }
                else BinarySearch(arr, start, mid);
            }
            else
            {
                if (arr[mid] == arr[mid - 1])
                    BinarySearch(arr, mid + 1, end);
                else BinarySearch(arr, start, mid - 1);
            }
        }
    }
}
