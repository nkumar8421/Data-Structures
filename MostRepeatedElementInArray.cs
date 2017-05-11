using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class Program
    {
        public static int MostRepeatingElementON2(int[] a)
        {
            int MostRepeatedNumSofar = 0, MostRepeatedNum=0;
            for(int i=0;i<a.Length-1;i++)
            {
                MostRepeatedNumSofar = 0;
                for (int j=i+1;j<a.Length-1;j++)
                {
                    if(a[j]==a[i])
                    {
                        MostRepeatedNumSofar++;
                    }
                }
                if(MostRepeatedNumSofar>MostRepeatedNum)
                {
                    MostRepeatedNum = a[i];
                }
            }
            return MostRepeatedNum;
        }
        public static int MostRepeatingElementON1(int[] a, int[] a1)
        {
            for(int i=0;i<a.Length-1;i++)
            {
                a1[a[i]]++;
            }
            return  Array.IndexOf(a1,a1.Max());
        }
        public static int MostRepeatingElementON1NoExtraSpace(int[] a,int k)
        {
            for(int i=0;i<a.Length-1;i++)
            {
                a[a[i] % k] = a[a[i] % k] + k;
            }
            return Array.IndexOf(a, a.Max());
        }
        static void Main(string[] args)
        {
            int k=11;
            int[] a = { 1, 3, 3, 3, 0, 2, 0, 2, 3, 8, 0, 9, 2, 3 };
            int[] a1 = new int[k - 1];
            Console.WriteLine("O(n2) with O(n) extra space : " +MostRepeatingElementON2(a));
            Console.WriteLine("O(n) with O(k) extra space : " +MostRepeatingElementON1(a, a1));
            Console.WriteLine("O(n) with O(1) extra space : " +MostRepeatingElementON1NoExtraSpace(a,k-1));
            Console.ReadLine();
        }
    }
}
