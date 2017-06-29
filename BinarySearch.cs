using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class BinarySearch
    {
        public static int findIteration(int[] a, int l, int r, int num)
        {
            while (l <= r)
            {
                int mid = (l + r) / 2;
                if (a[mid] == num)
                    return mid;
                if (a[mid] > num)
                    r = mid;
                else
                    l = mid + 1;
            }
            return -1;
        }

        public static int findRecursion(int[] a, int l, int r, int n)
        {
            if (r >= l)
            {
                int mid = (l + r) / 2;
                if (a[mid] == n)
                    return mid;
                if (a[mid] > n)
                    return findRecursion(a, l, mid - 1, n);
                return findRecursion(a, mid + 1, r, n);
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int num = 10;
            if (findIteration(a, 0, a.Length - 1, num) != -1)
            {
                Console.WriteLine("Using Iteration elemet found at index : {0}", findIteration(a, 0, a.Length - 1, num));
            }

            if (findRecursion(a, 0, a.Length - 1, num) != -1)
            {
                Console.WriteLine("Using recursion elemet found at index : {0}", findRecursion(a, 0, a.Length - 1, num));
            }
            Console.ReadLine();
        }
    }
}
