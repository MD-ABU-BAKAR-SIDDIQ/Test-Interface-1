using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface BasicCalculatorInterface
    {
        int sum(int x, int y);
        int sub(int x, int y);
        int multiplication(int x, int y);
        int division(int x, int y);
    }
    class Basicc : BasicCalculatorInterface
    {
        int result;
        public int sum(int num1, int num2)
        {
            result = num1 + num2;
            return result;
        }
        public int sub(int num1, int num2)
        {
            result = num1 - num2;
            return result;
        }
        public int multiplication(int num1, int num2)
        {
            result = num1 * num2;
            return result;
        }
        public int division (int num1, int num2)
        {
            result = num1 / num2;
            return result;
        }
        public void showinfo()
        {
            Console.WriteLine("Result : " + result);
        }
    }
}