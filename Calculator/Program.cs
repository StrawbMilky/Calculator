namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1;
            float num2;

            float result;

            string answer;

            Console.WriteLine("Hello, welcome to my calculator!");
            Console.WriteLine("Please enter your first number.");

            num1 = Convert.ToInt32(Console.ReadLine()); //readline returns a string but num1 can only contain an int, therefore im using casting (converting one datatype to another)

            Console.WriteLine("Please enter your second number.");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What type of operation would you like to do?");
            Console.WriteLine("Please enter a for addition, s for substraction, m for multiplication or any other key for division.");

            answer = Console.ReadLine();

            if(answer == "a")
            {
                result = num1 + num2;
            }
            else if (answer == "s") 
            { 
                result = num1 - num2;
            }
            else if (answer == "m")
            {
                result = num1 * num2;
            }
            else
            {
                result = num1 / num2;
            }

            Console.WriteLine("The result is " + result);
            Console.WriteLine("Thank you for using my calculator!");

            Console.ReadKey();
        }
    }
}
