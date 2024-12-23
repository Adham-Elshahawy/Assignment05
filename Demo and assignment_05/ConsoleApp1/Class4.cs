using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class4
    {
        public static void Add_subtract (int x , int y , out int sum , out int sub)
        {
            sum = x + y; 
            sub = x - y;
        }
        
        public static int individual_digits ( int num  )
        {
            int result = 0; 

            while ( num > 0 )
            {
                 result  +=  num % 10 ;
                Console.WriteLine (result);
                num /= 10;
            }
            return result;
        }

        public static bool isprime ( int num )
        {
            if ( num <=1 )
            {
                return false; 
            }

            for ( int i = 2 ; i*i <= num; i++ )
            {
                if (num%2 == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static void Max_Min_Array ( int [] Arr , out int min , out int max  )
        {
            max = Arr[0];
            min = Arr[0];

            for ( int i = 1 ; i < Arr.Length ; i++)
            {
                if ( Arr[i] > max)
                {
                    max = Arr[i];
                }
                if ( Arr[i] < min)
                {
                    min = Arr[i];
                }
            }

        }

        public static int Factorial(int number )
        {
            int  result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i; 
            }

            return result;
        }

       public static string ChangeChar(string str, int position, char newChar)
       {
            
            char[] charArray = str.ToCharArray();

            
            if (position >= 0 && position < charArray.Length)
            {
                charArray[position] = newChar; 
            }
            else
            {
                Console.WriteLine("Invalid position.");
                return str; 
            }
            return new string(charArray);
        }

    }
}
