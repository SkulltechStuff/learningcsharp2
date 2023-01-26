namespace learningcsharp2;
class Program
{
    static void Main(string[] args)
    {
        ageCalculator();
        Console.Write("Press any key to close program");
        Console.ReadKey(true);
    }

    static void ageCalculator()
    {
        string name = ("John");
        int birthYear = 1999;
        string birthday = ("No");
        int age = 0;
        int year = DateTime.Now.Year;
        Console.WriteLine(year);

        Console.Write("Enter your name: ");
        name = Console.ReadLine();
        Console.Write("Enter your year of birth: ");
        birthYear = Convert.ToInt32(Console.ReadLine());
        Console.Write("Have you had your birthday this year? ");
        birthday = Console.ReadLine().ToLower();

        if(birthday == "yes" || birthday =="y")
        {
            age = (year-birthYear);
        }
        else
        {
            age = (year-birthYear-1);
        }
        if(age<18)
        {
            Console.WriteLine("You are a junior, " + name);
        }
        else if(age >=18 && age <30)
        {
            Console.WriteLine("You are a young adult, " + name);
        }
        else if(age >=30 && age <60)
        {
            Console.WriteLine("You are an adult, " + name);
        }
        else
        {
            Console.WriteLine("You are a senior, " + name);
        }
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
