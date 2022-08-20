using System;

namespace console_application
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Sagopa Kajmer -NABER ");
            Console.WriteLine("İsminizi Girin:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisminizi Girin:");
            string surname = Console.ReadLine();
            Console.WriteLine("Merhaba  "+ name + " " + surname);
        }
    }
}
