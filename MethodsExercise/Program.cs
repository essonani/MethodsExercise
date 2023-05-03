using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    public class Program
    {

    
        
        
            public static int Sum(int num1, int num2)
            {
                var answer = num1 + num2;
                return answer;
            }
            public static int Multiply(int num1, int num2, int num3)
            {
                var answer = num1 * num2 * num3;
                return answer;

            }
            static void Main(string[] args)
            {
                var plus = Sum(5, 4);
                var lol = Multiply(8, 2, 3);
                Console.WriteLine("Hello, what is your name!");
                var username = Console.ReadLine();
                Console.WriteLine("what is your favorite color?");
                var color = Console.ReadLine();
                Console.WriteLine("what is your favorite animal?");
                var animal = Console.ReadLine();
                Console.WriteLine("what band do you like?");
                var band = Console.ReadLine();
                Console.WriteLine(color);
                Console.WriteLine(animal);
                Console.WriteLine(band);
                Console.WriteLine(lol);
                Console.WriteLine(plus);
            }
        
    }


} 



   
 
        

    

  

