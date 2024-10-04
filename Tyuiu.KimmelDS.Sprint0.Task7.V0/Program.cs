using Tyuiu.KimmelDS.Sprint0.Task7.V0.Lib;
namespace Tyuiu.KimmelDS.Sprint0.Task7.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(new char[] { ' ' }).Select(s => int.Parse(s)).ToArray();

            var test = new int[] { 1, 2, 3, 5, 6, 7, 8, 9, 10 };
            var res = SumNumbers(test);
        }

        public static int SumNumbers(params int[] ints)
        {
            int result = 0;
            foreach (var item in ints)
            {
                result += item; 
            }
            return result;
        }
    }
}