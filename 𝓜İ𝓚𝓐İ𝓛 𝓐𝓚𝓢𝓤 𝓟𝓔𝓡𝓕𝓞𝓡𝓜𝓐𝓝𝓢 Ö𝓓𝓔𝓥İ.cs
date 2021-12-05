using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boyanaliz
{
    class Program
    {
        /*
        AD: Mikail AKSU
        NO: 461
        Sınıf: 10/A
        Konu: Toplu Boy Analiz Uygulaması.
            */


        static void Main(string[] args)
        {
            Console.WriteLine("******* T O P L U   B O Y   A N A L İ Z İ *******");
            Console.WriteLine("Kaç Kişisiniz?: ");
            int kisi = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("******* T O P L U   B O Y   A N A L İ Z İ *******");
            for (int i = 0; i < kisi; i++)
            {
                Console.WriteLine("Cinsiyetinizi seçin(e/k) : ");
                string secim = Convert.ToString(Console.ReadLine());

                if (secim == "e" || secim == "E")
                {
                    Console.WriteLine("Boyunuzu giriniz: ");
                    int boy = Convert.ToInt16(Console.ReadLine());

                    eboy(boy);
                }
                else if (secim == "k" || secim == "K")
                {
                    Console.WriteLine("Boyunuzu giriniz: ");
                    int boy = Convert.ToInt16(Console.ReadLine());

                    kboy(boy);
                }

                else
                    Console.WriteLine("YANIŞ SEÇİM!!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine((kisi-1)+" Kişi Kaldı.\nDevam etmek için bir tuşa basın: ");

                Console.ReadKey();

            }
        }
        public static int kboy(int a)
        {
            if (a > 160)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Boyunuz ortalamaya göre uzun.");
            }
            else if (a < 160)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Boyunuz ortalamadan kısa.");
            }
            else
                Console.WriteLine("Boyunuz normal");
            return a;
        }
        public static int eboy(int a)
        {
            if (a > 173)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Boyunuz ortalamaya göre uzun.");
            }
            else if (a < 173)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Boyunuz ortalamadan kısa.");
            }
            else
                Console.WriteLine("Boyunuz normal");
            return a;
        }
    }
}
