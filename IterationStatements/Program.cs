namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
        static void PrintNumbers()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()
        static void PrintEveryThirdNumber()
        {

            for (int i = 0; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.

        static bool AreNumbersEqual(int a = 5, int b = 3)
        {
            var first = a + 3;
            var second = b + 5;

            if (first == second)
            {
                Console.WriteLine("These numbers are equal");
                return true;
            }
            else
            {
                Console.WriteLine("These numbers are not equal");
                return false;
            }
        }

        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.
        static bool IsEven(int num = 33)
        {
            var max = num * 15;

            if (max % 6 != 0)
            {
                Console.WriteLine("It is not even");
                return true;
            }
            else
            {
                Console.WriteLine("It is even");
                return false;
            }
        }

    // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.
        static bool IsPositive(int num)
        {
            num = 3;
            var maybeint = num * -4 % 5;

            if (maybeint > 0)
            {
                Console.WriteLine($"{maybeint} is positive");
                return true;
            }
            else
            {
                Console.WriteLine($"{maybeint} is negative");
                return false;
            }
        }
        
        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        static bool CanVote(int age)
        { 
            Console.WriteLine("Alright, let's see if you are allowed to vote. How old are you?");
            
            var userAge = int.Parse(Console.ReadLine());
            age = userAge;
            
            if (age >= 18)
            {
                Console.WriteLine("You are allowed to vote.");
                return true;
            }
            else
            {
                Console.WriteLine("You are not allowed to vote.");
                return false;
            }
        }
        
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.
        static bool IsInRange(int number)
        {
            Console.WriteLine("Guess the range of a net.");
            var userGuess = int.Parse(Console.ReadLine());
            number = userGuess;

            if (number > 10)
            {
                Console.WriteLine("This is beyond the range.");
                return false;
            }
            else if (number < -10)
            {
                Console.WriteLine("This isn't far enough.");
                return false;
            }
            else
            {
                Console.WriteLine("Right within range.");
                return true;
            }
        }
        
        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"
        static void DisplayMultiplicationTable(int number)
        {
            Console.WriteLine("Want some help with multiplication? Give me a number and I'll help.");
            var gvnnum = int.Parse(Console.ReadLine());
            number = gvnnum;

            int i = 1;

            while (i <= 12)
            {
                var result = gvnnum * i;
                Console.WriteLine($"{gvnnum} x {i} = {result}");
                i++;
            }
        }

        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
            PrintNumbers();
            PrintEveryThirdNumber();
            AreNumbersEqual();
            IsEven(32);
            IsPositive(5);
            CanVote(age:0);
            IsInRange(0);
            DisplayMultiplicationTable(number:0);
        }
    }
}
