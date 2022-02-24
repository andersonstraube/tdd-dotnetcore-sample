using System;
using System.Collections.Generic;
using System.Text;

namespace TDD.Domain
{
    public class Calculator
    {
        public Calculator() {}

        public int Addition(int n1, int n2)
        {
            return n1 + n2;
        }

        public int Subtraction(int n1, int n2)
        {
            return n1 - n2;
        }
        
        public int Multiplication(int n1, int n2)
        {
            return n1 * n2;
        }


        public int Division(int n1, int n2)
        {
            if (n2 == 0)
            {
                throw new ArgumentException("Cannot division by zero");
            }
            else
            {
                return n1 / n2;
            }
        }

    }
       
}
