using System;

namespace GradingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib, mis hinde kasutaja sai
            //kui kasutaja sai "A", siis konsool kuvab "suurepärane"
            //kui tulemus on "B", siis konsool kuvab "väga hea"
            //kui tulemus on "C", siis konsool kuvab "hea"
            //kui tulemus on "D", siis konsool kuvab "rahuldav"
            //kui tulemus on "E", siis konsool kuvab "kasin"
            //kui tulemus on "F", siis konsool kuvab "puudulik"
            //kui kasutaja sisestab midagi muud, siis konsool kuvab "vale väärtus".

            //kasutame SWITCH

            Console.WriteLine("Sisesta oma tulemus:");

            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (userResult)
            {
                case 'A':
                    Console.WriteLine("Suurepärane.");
                    break;
                case 'B':
                    Console.WriteLine("Väga hea.");
                    break;
                case 'C':
                    Console.WriteLine("Hea.");
                    break;
                case 'D':
                    Console.WriteLine("Rahuldav.");
                    break;
                case 'E':
                    Console.WriteLine("Kasin.");
                    break;
                case 'F':
                    Console.WriteLine("Puudulik.");
                    break;
                default:
                    Console.WriteLine("Vale väärtus");
                    break;
            }
            
        }
    }
}
