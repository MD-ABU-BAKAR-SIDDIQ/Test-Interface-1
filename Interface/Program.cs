using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" \n   Basic Calculator Interface \n");
            
            Basicc b = new Basicc();

            Console.WriteLine("Addition ");
          
            b.sum(5, 5);
            b.showinfo();

            Console.WriteLine("\nSubtraction  ");
         
            b.sub(6, 1);
            b.showinfo();

            Console.WriteLine("\nMultiplication ");
           
            b.multiplication(17, 15);
            b.showinfo();

            Console.WriteLine("\nDivision ");
           
            b.division(22, 22);
            b.showinfo();

        }
    }
}
