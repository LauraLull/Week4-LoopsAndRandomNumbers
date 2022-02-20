using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab selle numberi ära arvama;
            //kui kasutaja suutis selle numbri ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu.
            //*programm genereerib juhuslikku numbrit ühe korra.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            bool loopActive = true;
            int i = 1;

            while(loopActive)
            {
                Console.WriteLine("Sisesta juhuslik number ühest kümneni:");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                
                if(userNumber == cpuNumber)
                {
                    Console.WriteLine($"Juhuslik number on {cpuNumber}");
                    Console.WriteLine("Palju õnne! Võitsid mängu!");
                    Console.WriteLine($"Õige numbri leidsid {i} katsega.");
                    loopActive = false;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Juhuslik number ei ole {userNumber}. Proovi uuesti arvata.");
                    Console.WriteLine(""+"");
                }
            }

            Console.WriteLine(""+"");
            Console.WriteLine("Kena päeva!");
        }
    }
}
