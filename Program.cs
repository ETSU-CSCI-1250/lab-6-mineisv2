public class Program
{
    public static void Main(String[] args)
    {
        bool sentenial = true;
        while (sentenial) { 
            Console.WriteLine("Methods for Lab #6 ");
            Console.Write("select a number 1-4 to pick a method");
            int choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case (1):
                    Console.WriteLine("output from show character method");
                    ShowCharacter("New York", 2);
                    break;
                case (2):
                    Console.WriteLine(CalculateRetail());
                    break;
                case (3):
                    Console.WriteLine("Fahrenheit Temperatures");
                    Console.WriteLine("Celsius Temperature    | Farenhenheit Temperature");
                    Console.WriteLine("-----------------------|-------------------------");
                    for (int i = 80; i < 100; i++)
                    {
                        Console.Write($"Celsius: {i}            |");
                        Console.WriteLine($"Farenheit: {Celsius(i)}");
                    }
                    Console.WriteLine(Celsius(60));
                    break;
                case (4):
                    for (int i = 0; i < 20; i++)
                    {
                        if (IsPrime(i))
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;
                default:
                    sentenial = false;
                    break;
            }
        }   
    }

    static void ShowCharacter(string userString, int charPos)
    {
        Console.WriteLine(userString[charPos-1]);
    }

    static double CalculateRetail()
    {
        Console.Write("What is the cost of your item? ");
        double cost = Double.Parse(Console.ReadLine());

        Console.Write("What is the markup of your item? ");
        double markup = Double.Parse(Console.ReadLine());

        double profit = (markup * cost) / 100;

        return profit + cost;
    }

    static double Celsius(double fahrenheit)
    {
        double celsius = fahrenheit - 32;
        return celsius * (5.0 / 9.0);
    }
    static bool IsPrime(int number)
    {
        if (number % 2 == 0 && number != 2)
        {
            return false;
        }

        for(int denominator = 2; denominator < Math.Sqrt(number); denominator++)
        {
            if (number % denominator == 0)
            {
                return false;
            }
        }
        return true;
    }
}