using System.ComponentModel;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("what is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("what is your favorite animal");
            string animal = Console.ReadLine();
            Console.WriteLine("what is your favorite band?");
            string band = Console.ReadLine();
            Console.WriteLine("your name is " + name + " and your favorite color is " + color + " you like " + animal + band + " is your favorite band ");
            Console.WriteLine("give me  first number ");
            int number1;
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("give me a second number");
            int number2;
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine(number1 + number2);
            Console.WriteLine(number1 * number2);

        }
    }
   
 
        

    

    
}

