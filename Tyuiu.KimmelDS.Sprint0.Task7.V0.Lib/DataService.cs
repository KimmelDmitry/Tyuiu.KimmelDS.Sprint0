

namespace Tyuiu.KimmelDS.Sprint0.Task7.V0.Lib
{
    public class DataService 
    {
        public static int[] AdditionArray(int[] numOne, int[] numTwo) => numOne.Zip(numTwo, (f, s) => f += s).ToArray();
    }
}
