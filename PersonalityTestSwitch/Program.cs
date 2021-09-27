using System;

namespace PersonalityTestSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma lemmik värv:");
            string userColor = Console.ReadLine().ToLower();

            switch (userColor)
            {
                case "punane":
                    Console.WriteLine("Oled romantiline.");
                    break;
                case "roheline":
                    Console.WriteLine("Oled looduse sõber.");
                    break;
                case "sinine":
                    Console.WriteLine("Oled töökas.");
                    break;
                default:
                    Console.WriteLine($"Oled {userColor} ükssarvik");
                    break;
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
