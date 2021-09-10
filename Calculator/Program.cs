using System;

namespace Calculator
{
    class Program
    {
        private double add(double num1, double num2)
        {
            return num1 + num2;
        }
        private double subtraction(double num1, double num2)
        {
            return num1 - num2;
        }
        private double divide(double num1, double num2)
        {
            return num1 / num2;
        }
        private double multiple(double num1, double num2)
        {
            return num1 * num2;
        }
        void caller(double[] arr)
        {
            double[] ArrayDouble = new double[4];
            string[] calc = { "addition:", "subtraction :", "Multipication :", "Divide :" };
            //Program instance1 = new Program();
            ArrayDouble[0] = this.add(arr[0], arr[1]);
            ArrayDouble[1] = this.subtraction(arr[0], arr[1]);
            ArrayDouble[2] = this.multiple(arr[0], arr[1]);
            ArrayDouble[3] = this.divide(arr[0], arr[1]);
            
            int i = 0;
            while (i < ArrayDouble.Length)
            {
                Console.Write(calc[i]);                
                Console.WriteLine(ArrayDouble[i++]);
            }
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("please enter two numbers separate with a space ie (num1 num2)");
            double[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToDouble(arrTemp));
            
            Program p = new Program();
            p.caller(arr);
            Console.ReadLine();
        }
    }
}
