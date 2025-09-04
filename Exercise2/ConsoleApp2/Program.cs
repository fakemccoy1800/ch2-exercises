// See https://aka.ms/new-console-template for more information



using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
public class Consoleapp2
{

    static void Main(string[] args)
    {

        List<string> mynum = new List<string>();



        int iteration = 0;



        bool isvalid = true;


        
        while (isvalid)
        {

            mynum.Add(Console.ReadLine());


            Console.WriteLine(mynum[iteration]);


            Console.WriteLine(iteration + 1);



            if (mynum[iteration] == "escape")
            {
                break;
            }


            iteration = iteration + 1;
        }





    }
}