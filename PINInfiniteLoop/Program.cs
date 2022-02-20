using System;

namespace PINInfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada PIN-koodi;
            //programm võrdleb sisestatud PIN-koodi arvuga 1234;
            //kui sisestatud PIN-kood on 1234, siis konsool kuvab "Tere tulemast!";
            //kui sisestatud PIN-kood on mindagi muud, siis konsool kuvab "Vale PIN. Proovi uuesti";
            //katsete arv on piiramatu.

            bool loopActive = true; //boolean --> true/false
            int i = 0;

            while(loopActive)
            {
                Console.WriteLine("Sisestage PIN:"); //cw+double TAB
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    loopActive = false;
                }
                else
                {
                    i++; //i = i + 1;
                    Console.WriteLine("Vale PIN. Proovi uuesti!");
                    Console.WriteLine($"Oled vale PIN-koodi {i} korda sisestnud.");
                }
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
