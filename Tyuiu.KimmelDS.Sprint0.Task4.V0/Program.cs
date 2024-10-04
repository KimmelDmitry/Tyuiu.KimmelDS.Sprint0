using Tyuiu.KimmelDS.Sprint0.Task4.V0.Lib;
namespace Tyuiu.KimmelDS.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(2, 8));
            Console.WriteLine(DataService.Subtraction(5, 5));
            Console.WriteLine(DataService.Multiplication(5, 5));
            Console.WriteLine(DataService.Division(5, 5));

            Console.ReadKey();
        }
    }
}