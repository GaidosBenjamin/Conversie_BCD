using System;

namespace BCD
{
    class Program
    {
        static string conversie2(int cif)
        {
            switch (cif)
            {
                case 0:
                    return "0000";
                case 1:
                    return "0001";
                case 2:
                    return "0010";
                case 3:
                    return "0011";
                case 4:
                    return "0100";
                case 5:
                    return "0101";
                case 6:
                    return "0110";
                case 7:
                    return "0111";
                case 8:
                    return "1000";
                case 9:
                    return "1001";
            }
            Console.WriteLine("Avem o problema Houston!");
            return "";
        }
        static void conversieBCD(int x)
        {
            string rez = "";
            for(int i = 0; i < 5; i++)
            {
                if(x > 0)
                {
                    rez = conversie2(x % 10) + " " + rez;

                    x /= 10;
                }
                else
                {
                    rez = "0000" + " " + rez;
                }
            }
           
            Console.WriteLine(rez);
        }

        static void conversie(int x)
        {
            if (x > 0)
                conversieBCD(x);
            else
                conversieBCD(99999 + x + 1);

        }

        static void Main(string[] args)
        {
            // algoritmul functioneaza pe intervalul [-49999,49999]
            while (true)
            {
                int n;
                Console.Write("Introduceti numarul de convertit in BCD: ");
                try
                {
                    n = int.Parse(Console.ReadLine());

                    if (n < -49999 || n > 49999)
                        Console.WriteLine("Input gresit!");
                    else
                        conversie(n);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong format!");
                }

            }
        }
    }
}
