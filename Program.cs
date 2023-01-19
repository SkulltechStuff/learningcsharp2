namespace learningcsharp2;
class Program
{
    static void Main(string[] args)
    {
        int number1 = 7;
        int number2 = 12;
        Console.Write("Enter the first number: ");
        number1 = Convert.ToInt32( Console.ReadLine() );
        Console.Write("Enter the second number: ");
        number2 = Convert.ToInt32( Console.ReadLine() );
        
        Console.WriteLine($"The sum of {number1} and {number2} is {number1+number2}");
        Console.Write("Press any key to close program");
        Console.ReadKey(true);
    }
}
