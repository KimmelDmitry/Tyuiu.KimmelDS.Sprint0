using Tyuiu.KimmelDS.Sprint0.Task5.V0.Lib;
namespace Tyuiu.KimmelDS.Sprint0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"A + B = {DataService.Addition(2, 8)}");
            Console.WriteLine($"A - B = {DataService.Subtraction(5, 5)}");
            Console.WriteLine($"A * B = {DataService.Multiplication(5, 5)}");
            Console.WriteLine($"A / B = {DataService.Division(5, 0)}");
            Console.ReadKey();
        }
    }
}