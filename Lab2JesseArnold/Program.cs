
namespace Program
{
    class addition
    {
        static void Main(string[] args)
        {
            var firstNumber = 0;
            var secondNumber = 0;
            
            //question 1 addition
            Console.WriteLine("Enter 2 Numbers and they will be added together");
            Console.WriteLine("First Number?: ");
            firstNumber = Int32.Parse(Console.ReadLine()!);
            Console.WriteLine("Second Number?: ");
            secondNumber = Int32.Parse(Console.ReadLine()!);
            Console.WriteLine(string.Format("{0} + {1} = {2}",firstNumber,secondNumber,firstNumber+secondNumber));
        }

      
    }

}

