using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class3
    {
        public static void Swap (int x , int y)
        {
            int temp = x; 
            x=y;
            y=temp;
        }
        public static void Swap01(ref int x, ref  int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public static int SumArr( params int[] arr)
        {
            int sum = 0;
            arr [0] = 100;    
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum ;

        }
        public static int SumArr1(ref int[] arr)
        {
            int sum = 0;
            arr[0] = 100;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;

        }

        public static void SumMul(int x , int y , out int sum , out int mul)

        {
             sum = x + y;
             mul = x * y;
        }
        public static void SumMul01(int x, int y, ref int sum, ref int mul)

        {
            sum = x + y;
            mul = x * y;
        }
    }
}
