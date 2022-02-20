using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab selle numberi ära arvama;
            //kui kasutaja suutis selle numbri ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katega numbrit ära arvata,
            //siis mängu võidab arvuti.
            //*programm genereerib juhuslikku numbrit ühe korra.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            int i = 0;

            while(i < 3)
            {
                Console.WriteLine("Sisesta juhuslik number ühest kümneni:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if(userNumber == cpuNumber)
                {
                    Console.WriteLine($"Juhuslik number on {cpuNumber}");
                    Console.WriteLine("Palju õnne! Võitsid mängu!");
                    break;
                }
                else
                {
                    i++;
                    if(i == 1)
                    {
                        Console.WriteLine($"Juhuslik number ei ole {userNumber}. Proovi uuesti, Sul on {3 - i} katset.");
                        Console.WriteLine(""+"");
                    }
                    else if(i == 2)
                    {
                        Console.WriteLine($"Juhuslik number ei ole {userNumber}. Proovi uuesti, Sul on veel {3 - i} katse.");
                        Console.WriteLine(""+"");
                    }
                    else
                    {
                        Console.WriteLine($"Juhuslik number ei ole {userNumber}, numbriks oli {cpuNumber}. Arvuti võitis mängu!");
                    }
                }
            }

            Console.WriteLine(""+"");
            Console.WriteLine("Kena päeva!");
        }
    }
}
