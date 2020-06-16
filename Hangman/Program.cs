using System;
using System.Collections.Generic;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dobrodošli v igri Vislice! Srečno :)\n");

            string[] listaBesed = new string[10];
            listaBesed[0] = "pes";
            listaBesed[1] = "macka";
            listaBesed[2] = "pomaranca";
            listaBesed[3] = "abakus";
            listaBesed[4] = "otorinolaringolog";
            listaBesed[5] = "skodelica";
            listaBesed[6] = "briketi";
            listaBesed[7] = "pozlatiti";
            listaBesed[8] = "piksna";
            listaBesed[9] = "papir";

            Random r = new Random();

            var id = r.Next(0, 9);
            string skritaBeseda = listaBesed[id];
            char[] poskus = new char[skritaBeseda.Length];
            Console.WriteLine("Beseda vsebuje {0} znakov", skritaBeseda.Length); // izpiše koliko znakov ima beseda
            Console.Write("Vnesi črko: ");

            for (int i = 0; i < skritaBeseda.Length; i++)
            {
                poskus[i] = '*';
            }

            while (true)
            {
                char poskusIgralca = char.Parse(Console.ReadLine());
                for (int j = 0; j < skritaBeseda.Length; j++)
                {
                    if (poskusIgralca == skritaBeseda[j])
                    {
                        poskus[j] = poskusIgralca;
                    }
                }
                Console.WriteLine(poskus);
            }
        }
    }
}
