using System;
using System.Text;

namespace ConsoleApp1;

class Program
{

    static void Main(string[] args)
    {

        float mynum = 0.0f;


        Console.WriteLine("how much is the item worth?");

        mynum = Single.Parse(Console.ReadLine());

        Console.WriteLine($"this apple is worth {mynum.ToString("C2")}");




        
    }

}
