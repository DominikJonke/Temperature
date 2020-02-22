using System;

namespace Temperature
{
    public static class Temperature
    {
        private static char Input { get; set; }
        private static double Temp { get; set; }
        public static void ShowTitle()
        {
            Console.WriteLine();
            Console.WriteLine("\t\t\tTemeperature Calculator C <==> F");
            Console.WriteLine();
        }
        public static void SetUnit()
        {
            bool ok = false;
            do
            {
                Console.Write("Which temperature unit [C / F]: ");
                Input = Convert.ToChar(Console.ReadLine());

                if (Input == char.ToUpper('c') || Input == char.ToUpper('f'))
                {
                    ok = true;
                }

                else
                {
                    Console.WriteLine("Try again!"); ;
                }

            } while (ok == false);
        }
        public static void SetTemp()
        {
            bool ok = false;

            Console.Write("Which temperature: ");
            Temp = Convert.ToDouble(Console.ReadLine());

            do
            {
                if (Temp >= -459.67 && Temp <= 212)
                {
                    ok = true;
                }
                else
                {
                    Console.WriteLine("Try again!");
                }

            } while (ok == false);
        }
        public static void CalcTemp()
        {
            if(Input == char.ToUpper('c'))
            {
                Temp = (Temp * (9 / 5) + 32);

                Console.Write($"Celsius <==> Fahrenheit: {Temp} Fahrenheit");
            }

            else if(Input == char.ToUpper('f'))
            {
                Temp = (Temp - 32) * (5 / 9);

                Console.Write($"Fahrenheit <==> Celsius: {Temp} Celsius");
            }
        }
    }
}