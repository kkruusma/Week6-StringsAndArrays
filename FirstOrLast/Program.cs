using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja ees- ja perekonnanime
            //programm kontrollib andmete pikkust eraldi
            //programm kuvab, kumb on pikem, kas ees- või perekonnanimi

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Sisesta perekonnanimi:");
            string lastName = Console.ReadLine();

            if (firstName.Length > lastName.Length)
            {
                Console.WriteLine("Sinu eesnimi on pikem");
            }
            else if (lastName.Length > firstName.Length)
            {
                Console.WriteLine("Sinu perekonnanimi on pikem");
            }
            else
            {
                Console.WriteLine("Sinu ees- ja perekonnanimi on sama pikkusega");
            }

        }
    }
}
