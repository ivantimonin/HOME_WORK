using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    class Recurs
    {
        public static int Factorial(int n)
        {
            while (true)
            {
                if (n == 1) { return (1); }
                return n * Factorial(n - 1);
            }
        }

        public static int Binary_find(int[] arr, int key)
        {
            int mid = arr.Length / 2;
            int low = 0;
            int up = arr.Length - 1;

            if (arr[mid] == key)
            {
                return (mid);
            }
            int index = Find_key(key, low, up, arr);
            return (index);
        }

        public static int Find_key(int key, int low, int up, int[] arr)
        {
            int mid = (low + up) / 2;
            if (arr[mid] == key)
            {
                return (mid);
            }
            if (low > up)
            {
                return (-1);
            }
            if (arr[mid] > key)
            {
                up = mid - 1;
            }
            if (arr[mid] < key)
            {
                low = mid + 1;
            }

            return (Find_key(key, low, up, arr));

        }
    }
}
