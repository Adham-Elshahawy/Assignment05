using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    // class 
    // interface 
    // enum 
    // struct 
    
    internal class Program
    {
        // Functions 
        // data 

        // type function 
        // 1- class member fumction [static function]
        // 2- object member function [non static function]
        

        static void Main(string[] args)
        {

            #region Demo 05

            #region casting [boxing_unboxing]
            /* refrence type => from reference to reference */
            /*boxing casting => from value type to refrence {safe casting}*/
            /*unboxing casting => from refrence type to value  {unsafe casting}*/

            //object obj = new object();
            //obj = "mostafa"; /*refrence type */
            //obj = 2; /*boxing casting*/

            //int x = 10;
            //object obj01 = new object();  /*boxing*/
            // obj01 = x ;

            //int x = 10; 
            //object obj01 = new object();    /*unboxing*/
            //int x = obj01;        /*not valid */
            /*we can fix it by typing int x = (int)obj01; but not safe */




            #endregion

            #region nullable data type 

            #region value type 
            //int x = null;  /* number only so we cant say that */
            //int ? x = null; /*works on number and allow null too */

            //Nullable<int> number; /*we can write as that but not usable now days */

            //int x = 10;
            //int? y = /*(int?)*/x;

            //int? x = null;
            //int y; 

            //if (x != null)
            //{
            //    y = (int)x; 
            //}
            //else
            //{
            //    y = 0;
            //}

            //y = x.HasValue ? X.Value : 0; 


            //Console.WriteLine(y);
            #endregion

            #region reference type
            //string? name = null;

            //Console.WriteLine("name");

            #endregion

            #endregion

            #region Null propagation operator 
            //int[] numbers = null; 

            //if (numbers != null )
            //{
            //    for (int i = 0; i < numbers?.Length; i++)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //} 



            // i < numbers?.length 
            // numbers  => object [length]
            // numbers => null [null]

            //int length = numbers?.length ?? 0;

            //Console.WriteLine(length);

            //Employee Emp = new Employee();

            //Emp.Department = new Department();  

            //if (name != null)
            //{
            //    if (Emp.Department != null )
            //    {
            //        Console.WriteLine(Emp.Department.Name);

            //    }
            //}

            //Console.WriteLine(Emp.Department?.Name ?? "Not found");

            #endregion

            #region Functions 

            //Class2.PrintShape(10 , "(*-*)");

            //Class2.PrintShape(count:10 , pattern:"fkdsm");

            //Console.WriteLine("hello \n ahmed "); /*new line*/ 
            //Console.WriteLine("hello \t ahmed "); /*four spaces */
            //Console.WriteLine("hello \\ ahmed "); /*print \ */

            #endregion

            #region value Type parameters 
            //int A = 5;
            //int B = 10;
            //Console.WriteLine(A);
            //Console.WriteLine(B);

            //Class3.Swap(A , B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);

            #endregion

            #region by refrences 
            //int A = 5;
            //int B = 10;
            //Console.WriteLine(A);
            //Console.WriteLine(B);

            //Class3.Swap01( ref A, ref B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            #endregion

            #region refrence type 

            #region value
            //int[] numbers = { 1, 2, 3 };
            //Console.WriteLine(Class3.SumArr(numbers));
            //Console.WriteLine(numbers[0]);
            #endregion


            #region reference
            //int[] numbers = { 1, 2, 3 };
            //Console.WriteLine(Class3.SumArr1(ref numbers));
            //Console.WriteLine(numbers[0]);
            #endregion

            #endregion

            #region Functions - parsing by out 
            //int A = 10; 
            //int B = 20;
            //int sum = 0;
            //int mul = 0;

            //Class3.SumMul (A , B , out sum, out mul);

            //Console.WriteLine(sum);            /* value */
            //Console.WriteLine(mul);

            //int A = 10; 
            //int B = 20;
            //int sum = 0;
            //int mul = 0;

            //Class3.SumMul01 (A , B , ref sum, ref mul);

            //Console.WriteLine(sum);            /* refrence */
            //Console.WriteLine(mul);

            #endregion

            #region function params 
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine(Class3.SumArr(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));

            //int a = 12 , b = 13 , c = 14 ;
            //Console.WriteLine("A : {0} , b: {1} , c :  {2} " , a , b, c);


            #endregion

            #endregion

            #region Q1
            #region value Type parameters 
            //int A = 5;
            //int B = 10;
            //Console.WriteLine(A);
            //Console.WriteLine(B);

            //Class3.Swap(A , B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);

            #endregion

            #endregion

            #region Q2 
            #region by refrences parameters  
            //int A = 5;
            //int B = 10;
            //Console.WriteLine(A);
            //Console.WriteLine(B);

            //Class3.Swap01( ref A, ref B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            #endregion
            #endregion

            #region Q3
            //int x = 10; 
            //int y = 20;
            //int result = x + y ;

            //Console.WriteLine(result); /*normal adding */


            /* by using function at class 4 that I  made as in 4 parameters  */

            //Console.Write("Enter your first Number : ");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("Enter your seconde Number : ");
            //int y = int.Parse(Console.ReadLine());

            //int sum = 0;
            //int sub = 0;

            //Class4.Add_subtract(x, y, out sum, out sub);

            //Console.WriteLine($"summation  will be  {x} + {y} = {sum}");

            //Console.WriteLine($"subtraction will be {x} - {y} = {sub}");


            #endregion

            #region Q4
            //Console.Write ("Enter your number that you want to indvidual it : ");

            //int num = int.Parse(Console.ReadLine());

            //int result = Class4.individual_digits(num) ;


            //Console.WriteLine("             ");

            //Console.WriteLine($"your number that you enterd {num} , its indvidual number = {result}");

            #endregion

            #region Q5
            //Console.WriteLine("Enter your number");

            //int x = int.Parse(Console.ReadLine());

            //bool result = Class4.isprime(x);

            //if (result)
            //{
            //    Console.WriteLine("its prime ");
            //}

            //else 
            //{
            //    Console.WriteLine(" its not prime");
            //}
            #endregion

            #region Q6


            //int[] Arr = { 1, 2, 3, 4, 5, 6, 8 };

            //int max = 0;
            //int min = 0; 

            //Class4.Max_Min_Array(Arr, out max, out min);

            //Console.WriteLine($" minimum one = {min}");
            //Console.WriteLine($" minimum one = {max}");

            #endregion

            #region Q7
            //Console.Write("Enter a number to calculate its factorial: ");
            //int number = int.Parse(Console.ReadLine());

            //Class4.Factorial(number);

            //int result = Class4.Factorial(number);

            

            //Console.WriteLine($"The factorial of {number} is: {result} ");
            #endregion

            #region Q8
            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();

            
            //Console.Write("Enter the position (0-based index) to modify: ");
            //int position = int.Parse(Console.ReadLine());

            
            //Console.Write("Enter the new character: ");
            //char newChar = char.Parse(Console.ReadLine());

            
           
            //string result = Class4.ChangeChar(input, position, newChar);

            //Console.WriteLine($"Updated string: {result}");
            #endregion
        }
    }
}
