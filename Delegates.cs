using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Algo
{
    public delegate void DelSumOfNumbers(int target);
    class MostRepeatedElementInArray
    {

        
        public static void PrintNumSum(int sum)
        {
            Console.WriteLine(sum);
        }
    static void Main(string[] args)
        {
            
            DelSumOfNumbers del = new DelSumOfNumbers(PrintNumSum);
            Number number = new Number(10,del);
            // Avoid using below mentioned parameterized thread start delegate as it expects object as parameter and we loose type safety instead use Thread start - or create constructor of class and pass parameter in class instead of passing it in delegate
            //ParameterizedThreadStart p = new ParameterizedThreadStart(number.PrintNumber);
            //Thread t = new Thread(number.PrintNumber);
            Thread t = new Thread(new ThreadStart(number.PrintNumber));
            t.Start();
            //number.PrintNumber();
            Console.ReadLine();
        }     
    }

    class Number
    {
        DelSumOfNumbers _delSumOfNumbers;
        int _num=0,sum=0;
        
        public Number(int num,DelSumOfNumbers delSumOfNumbers)
        {
            this._num = num;
            this._delSumOfNumbers = delSumOfNumbers;
        }
        public void PrintNumber()
        {
            //int num = 0;
            //int.TryParse(target.ToString(), out num);
            for (int i=1;i<=_num;i++)
            {
                sum = sum + i;
               // Console.WriteLine(i);
            }
           // if (_delSumOfNumbers != null)
                _delSumOfNumbers(sum);
        }
    }
 }

