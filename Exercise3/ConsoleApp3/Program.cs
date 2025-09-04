


public class ConsoleApp3
{

    static void Main(string[] args)
    {
        Console.WriteLine($"Int info: size={sizeof(int)}, max={int.MaxValue.ToString("E3")}, min={int.MinValue.ToString("E3")}");
        Console.WriteLine($"Long info: size={sizeof(long)}, max={long.MaxValue.ToString("E3")}, min={long.MinValue.ToString("E3")}");
        Console.WriteLine($"Double info: size={sizeof(double)} , max={double.MaxValue.ToString("E3")}, min={double.MinValue.ToString("E3")}");
        Console.WriteLine($"Decimal info: size={sizeof(decimal)} , max={decimal.MaxValue.ToString("E3")}, min={decimal.MinValue.ToString("E3")}");
    }
}

