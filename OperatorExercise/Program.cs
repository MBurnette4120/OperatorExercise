using System;
using System.Transactions;

namespace OperatorExercise
{
    class Program
    {

        
        
        static void Main(string[] args)
        {

            //-------------------
            //var a = 17;
            //var b = 4;

            ////-----------------------Exercise 1----Division with Modulus--------------------------
            //var div = a / b;
            //var mod = a % b;

            //Console.WriteLine($"{a} / {b} is {div} remainder {mod}");

            ////-----------------------Exercise 1a----Subtraction--------------------------

            //var sum = a + b;

            //Console.WriteLine($"{a} + {b} is {sum}");

            ////-----------------------Exercise 1b-----Addition----------------------------

            //var sub = a - b;

            //Console.WriteLine($"{a} - {b} is {sub}");

            ////-----------------------Exercise 1c--Multiplication----------------------------

            //var mult = a * b;

            //Console.WriteLine($"{a} * {b} is {mult}");


            //Console.WriteLine("Enter the radius of your circle");
            //var radius = double.Parse(Console.ReadLine());

            //var areaOfCircle = CalculateArea(radius);

            //Console.WriteLine($"The area of a circle with radius of {radius} is {areaOfCircle}");

            var i = 3;
            var j = 4;
            var k = ++i * j++;
            Console.WriteLine(k);






        }

        public static double CalculateArea(double radius)
        {
            return Math.PI * (radius * radius);

        }
    }
}
