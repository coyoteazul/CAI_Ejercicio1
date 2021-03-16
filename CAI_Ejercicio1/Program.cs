using System;

namespace CAI_Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 805; i++)
            {
                string sufix = "";
                if (i % 3 == 0)
                    sufix += "Foo";
                if (i % 5 == 0)
                    sufix += "Bar";

                Console.WriteLine(i + sufix);
            }

        }
    }
}
