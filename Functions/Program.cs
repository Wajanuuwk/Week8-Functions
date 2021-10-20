using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta oma eesnime");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi");
            string lastName = Console.ReadLine();
            Console.WriteLine("sisesta sünniaastat");
            int userAge = Convert.ToInt32(Console.ReadLine());
            //lisa perekonnanime
            Greetings(userName, userAge, lastName);     
        }

        private static void Greetings(string someString, int someInt, string anotherString)
        {
            //lisa perekonnanime
            Console.WriteLine($"Tere, {someString} {anotherString}!");
            Console.WriteLine($"Oled {2021 - someInt}.");
        }


    }
}
