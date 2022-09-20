// Programmer: David Flannery 
// Due Date: 9/20/2022 
// Description: delivary 4 Fibonachi sequence 


using System;
using System.Linq; 

namespace delivary_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 26;

            int f1 = 0, f2 = 1, f3;

            Console.WriteLine(f1 + " " + f2 + " ");
            

            for(int i = 2; i < x; ++i)
            {

                f3 = f1 + f2;

                Console.WriteLine(f3 + " " + "fibonachi" + " " + (i));


                f1 = f2;
                f2 = f3;
            }
        }   
    }
}