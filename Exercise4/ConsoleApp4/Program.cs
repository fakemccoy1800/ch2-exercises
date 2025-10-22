
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

public class ConsoleApp4
{
    static void Main(string[] a)
    {

        Console.WriteLine("Say your first name.");
        string firstname = Console.ReadLine()!;


        Console.WriteLine("Say your last name");
        string lastname = Console.ReadLine()!;


        Console.WriteLine("How old are you?");
        int age = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("What are ya buying?");
        string item = Console.ReadLine()!;


        Console.WriteLine("how many are you buying?");
        int item_ammount = Convert.ToInt32(Console.ReadLine());

        

        Console.WriteLine("That will cost you about... uh, can you help me out here?\n(type out a float)");
        float item_cost = Single.Parse(Console.ReadLine()!);


        Console.WriteLine($@"
        {firstname} {lastname} is {age}. {firstname} has {item_ammount} {item}.
        each {item} costs {item_cost.ToString("C2")}.
        The total cost is {(item_cost * item_ammount).ToString("C2")}."
         );



    }

}