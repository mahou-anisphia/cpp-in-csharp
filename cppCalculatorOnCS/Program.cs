using System;
using cppCalculatorOnCS;

public class Program
{
    public static void Main(string[] args)
    {
        int x = 2;
        Console.WriteLine($"Perform program initialization with x = {x} and y = 3");
        IntPtr i = Wrapper.Initialize(x);

        // Perform addition
        int totalAdd = Wrapper.Add(i, 3);
        Console.WriteLine($"Addition result: {totalAdd}");

        // Perform multiplication
        int totalMultiply = Wrapper.Multiply(i, 3);
        Console.WriteLine($"Multiplication result: {totalMultiply}");

        // Perform division
        int totalDivide = Wrapper.Divide(i, 3);
        Console.WriteLine($"Division result: {totalDivide}");

        // Perform subtraction
        int totalSubtract = Wrapper.Subtract(i, 3);
        Console.WriteLine($"Subtraction result: {totalSubtract}");
        Console.ReadLine();
    }
}
