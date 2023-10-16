class Program
{
    static void Main()
    {

        Console.Write("Enter an integer: ");
        string userInput = Console.ReadLine();

        if (int.TryParse(userInput, out int num))
        {
            if (num >= 1 && num <= 18)
            {
                long result = FirstFactorial(num);
                Console.WriteLine("Factorial of " + num + " is " + result);
            }
            else
            {
                Console.WriteLine("Please enter a number between 1 and 18.");
            }
        }
        else
        {
            Console.WriteLine("Input is not a valid integer.");
        }
    }

    static long FirstFactorial(int num)
    {
        if (num == 1)
        {
            return 1;
        }
        return num * FirstFactorial(num - 1);
    }
}