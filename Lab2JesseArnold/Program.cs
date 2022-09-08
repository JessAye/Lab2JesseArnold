using System.Threading.Channels;

namespace Program
{
    class Lab2
    {
        static void Main(string[] args)
        {
            var userSelection = 0;
            Console.WriteLine("Welcome\nWhat would you like to do");
            Console.WriteLine("1 - Add two numbers\n" +
                              "2 - Gets multiplications of a number\n" +
                              "3- Show datatype sizes\n" +
                              "4- Calculator");
               userSelection = Int32.Parse(Console.ReadLine()!);
            switch (userSelection){
                case 1:
                    AddTwoNums();
                    break;
                case 2:
                    Multiply();
                    break;
            }
            
           
        }

        static void AddTwoNums()
        {
            var firstNumber = 0;
            var secondNumber = 0;


            Console.WriteLine("Enter 2 Numbers and they will be added together");
            Console.WriteLine("First Number?: ");
            firstNumber = Int32.Parse(Console.ReadLine()!);
            Console.WriteLine("Second Number?: ");
            secondNumber = Int32.Parse(Console.ReadLine()!);
            Console.WriteLine(string.Format("{0} + {1} = {2}", firstNumber, secondNumber, firstNumber + secondNumber));
        }

        static void Multiply()
        {
            var firstNumber = 0;
            var secondNumber = 0;


            Console.WriteLine("Enter a number and how many multiples you want");
            Console.WriteLine("Number?: ");
            firstNumber = Int32.Parse(Console.ReadLine()!);
            Console.WriteLine("How many multiples: ");
            secondNumber = Int32.Parse(Console.ReadLine()!);
            for (int i = 0; i <= secondNumber; i++)
            {
                Console.WriteLine(string.Format("{0} * {1} = {2}",firstNumber, i, firstNumber*i));
            }
        }
    }
}
