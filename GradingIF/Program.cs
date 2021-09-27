using System;

namespace GradingIF
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
            
            //kasutame IF

            Console.WriteLine("Sisesta oma tulemus:");
            //char - character
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            if (userResult == 'A')
            {
                Console.WriteLine("Suurepärane.");       
            }
            else if (userResult == 'B')
            {
                Console.WriteLine("Väga hea.");
            }
            else if (userResult == 'C')
            {
                Console.WriteLine("Hea.");
            }
            else if (userResult == 'D')
            {
                Console.WriteLine("Rahuldav.");
            }
            else if (userResult == 'E')
            {
                Console.WriteLine("Kasin.");
            }
            else if (userResult == 'F')
            {
                Console.WriteLine("Puudulik.");
            }
            else
            {
                Console.WriteLine("Vale väärtus.");
            }
 
        }
        

    }
}
