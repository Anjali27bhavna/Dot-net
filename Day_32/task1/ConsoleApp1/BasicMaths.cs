using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class BasicMaths
    {
        public int factorial(int num)
        {
            if (num < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid Number");
            }
            else if (num == 0 || num == 1) return 1;
            else
            {
                int fact = 1;
                while (num > 0)
                {
                    fact *= num;
                    num--;
                }
                return fact;
            }
            
           
               
        }
        public bool prime(int num)
        {
            if (num < 0)  throw new ArgumentOutOfRangeException("Invalid");
           for(int i=2;i<num;i++)
            {
                if (num % i == 0) return false;               
            }
            return true;

        }

        //public double add(double num1,double num2)
        //{
        //    return num1 + num2;
        //}
        //public double subtract(double num1, double num2)
        //{
        //    return num1 - num2;
        //}
        //public double divide(double num1, double num2)
        //{
        //    return num1 / num2;
        //}
        //public double multiply(double num1, double num2)
        //{
        //    return num1 * num2;
        //}
    }
}



