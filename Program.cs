namespace learningcsharp2;
class Program
{
    static void Main(string[] args)
    {
        conditions();
        Console.Write("Press any key to close program");
        Console.ReadKey(true);
    }

    static void conditions()
    {
        //Check if x is larger than y
        int x = 20;
        int y = 20;

        if(x > y)
        {
            Console.WriteLine("x is greater than y");
        }
        else if(y > x)
        {
            Console.WriteLine("y is greater than x");
        }
        else
        {
            Console.WriteLine("x and y are equal");
        }
    }
    static void numbersSum()
    {
        double number1 = 7;
        double number2 = 12;
        Console.Write("Enter the first number: ");
        number1 = Convert.ToDouble( Console.ReadLine() );
        Console.Write("Enter the second number: ");
        number2 = Convert.ToDouble( Console.ReadLine() );
        
        Console.WriteLine($"The sum of {number1} and {number2} is {number1+number2}");
        Console.WriteLine($"{number1} divided by {number2} is {number1/number2}"); 
    }
}
