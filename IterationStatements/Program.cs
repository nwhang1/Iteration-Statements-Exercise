namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        
        //Write a method to check whether a given number is even or odd
        
        //Write a method to check whether a given number is positive or negative
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            for(int i = -1000; i < 1000; i++)
            {
                Console.WriteLine($"{i}");
            }

            for(int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine($"{i}");
            }

            // Equality Method
            Console.WriteLine("Lets check equality, what's the first number?");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("What's the second number?");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Yes, these are equal");
            }
            else
            {
                Console.WriteLine("No, these are not equal");
            }
            
            // Even Odd Method
            Console.WriteLine("Let's check if the number is even or odd, what's the number you want to check?");
            int num3 = int.Parse(Console.ReadLine());
            
            if (num3 % 2 == 0)
            {
                Console.WriteLine("This is an even number");
            }
            else
            {
                Console.WriteLine("This is an odd number");
            }

            // Positive or negative method
            Console.WriteLine("Let's check if the number is positive or negative, what's the number you want to check?");
            int num4 = int.Parse(Console.ReadLine());

            if (num4 > 0)
            {
                Console.WriteLine("It's positive");
            }
            else
            {
                Console.WriteLine("It's negative");
            }
     
            // Voting Method
            Console.WriteLine("Voting season is coming up, how old are you?");
            int age = int.Parse(Console.ReadLine());
            
            if (age > 18)
            {
                Console.WriteLine("Pokemon Go to the polls!");
            }
            else
            {
                Console.WriteLine("You can't vote, bummer");
            }

            // Range Method
            Console.WriteLine("Give me a number");

            int num5 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Is {num5} in the range of -10 and 10? {IsInRange(num5)}");

            // Multiplication Table Method
            Console.WriteLine("Let's do multiplication tables, I only know 1-12 though, so be nice");

            int num6 = int.Parse(Console.ReadLine());
            MultiplicationTable(num6);
        }

        // Range method
        static bool IsInRange(int num5)
        {
            return num5 >= -10 && num5 <= 10;
        }

        //Multiplication table method
        static void MultiplicationTable(int num6)
        {
            Console.WriteLine($"Mulitplication table of {num6}");

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{num6} * {i} = {num6 *i}");
            }
        }
    }
}
