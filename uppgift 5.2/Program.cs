using System;
namespace Uppgift_5_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hur många heltal vill du skriva?");
            int antal = int.Parse(Console.ReadLine());
            string[] heltal = new string[antal]; 

            for(int i = 0; i < antal; i++)
            {
                Console.WriteLine("Skriv din heltal här:");
                heltal[i] = Console.ReadLine();
            }
            Console.WriteLine("Du skrev in talen:");

            for(int i = 0; i < antal; i++)
            {
                Console.Write($"Tal{i+1}: {heltal[i]} \n");
            }

        }
    }
}
