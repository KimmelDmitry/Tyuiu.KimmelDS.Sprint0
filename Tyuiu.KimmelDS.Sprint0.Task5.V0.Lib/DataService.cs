﻿

namespace Tyuiu.KimmelDS.Sprint0.Task5.V0.Lib
{
    public class DataService
    {
        public static int Addition(int a, int b) => a + b;
        public static int Subtraction(int a, int b) => a - b;
        public static int Multiplication(int a, int b) => a * b;
        public static double Division(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Переменная b = 0, на 0 делить нельзя!");
                return -1;
            }
            return a / b;
        }
    }
}
