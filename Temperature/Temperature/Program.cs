using System;

namespace Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature.ShowTitle();

            Temperature.SetUnit();
            Temperature.SetTemp();

            Temperature.CalcTemp();

            Console.ReadKey();
        }
    }
}
