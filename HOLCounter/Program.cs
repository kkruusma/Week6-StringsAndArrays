using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu 'h', 'o' ja 'l' tähte on lauses "Hello world!"

            string sentence = "Hello world!".ToLower();

            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == 'h')
                {
                    hCounter++;
                }
            }
            for (int ii = 0; ii < sentence.Length; ii++)
            {
                if (sentence[ii] == 'o')
                {
                    oCounter++;
                }
            }
            for (int iii = 0; iii < sentence.Length; iii++)
            {
                if (sentence[iii] == 'l')
                {
                    lCounter++;
                }
            }

            Console.WriteLine($"Lauses 'Hello world!' on:");

            if (hCounter != 1)
            {
                Console.WriteLine($"{hCounter} 'h' tähte.");
            }
            else
            {
                Console.WriteLine($"{hCounter} 'h' täht.");
            }
            if (oCounter != 1)
            {
                Console.WriteLine($"{oCounter} 'o' tähte.");
            }
            else
            {
                Console.WriteLine($"{oCounter} 'o' täht.");
            }
            if (lCounter != 1)
            {
                Console.WriteLine($"{lCounter} 'l' tähte.");
            }
            else
            {
                Console.WriteLine($"{lCounter} 'l' täht.");
            }
            
        }
    }
}
