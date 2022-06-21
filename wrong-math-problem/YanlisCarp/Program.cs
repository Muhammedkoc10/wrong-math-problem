using System;

namespace YanlisCarp
{
    class Program
    {
        static void Main(string[] args)
        {
        // 211 *33 = 1266 , 134*12 = 402 , 111 * 333 = 999 sonuçlarını vermektedir.
        basa: Console.WriteLine("Çarpmak istediğiniz birinci sayıyı giriniz");
            string sayiMi = Console.ReadLine();
         if (sayiMi == "")
            {
                Console.Write("Lütfen sayi değerini boş geçmeyiniz! ");
                goto basa;
            }
        ortaya: Console.WriteLine("Çarpmak istediğiniz ikinci sayıyı giriniz");
            string sayiMi2 = Console.ReadLine();

            if (sayiMi2 == "")
            {
                Console.Write("Lütfen sayi değerini boş geçmeyiniz! ");
                goto ortaya;
            }
            else
            {
                int sayi2 = Convert.ToInt32(sayiMi2);
                if (sayi2 <= 999)
                {

                }
                else
                {
                    Console.WriteLine("Lütfen 3 basamağa kadar bir sayı giriniz ");
                    goto ortaya;
                }
            }
            int sayi1 = Convert.ToInt32(sayiMi);
            int sayi3 = Convert.ToInt32(sayiMi2);

            BasamakBul(sayi1, sayi3, out int birlerBasamagi, out int onlarBasamagi, out int yuzlerBasamagi, out int birlerBasamagi2, out int onlarBasamagi2, out int yuzlerBasamagi2);

            YanlisCarp(birlerBasamagi, onlarBasamagi, yuzlerBasamagi, birlerBasamagi2, onlarBasamagi2, yuzlerBasamagi2);
        }

        private static void YanlisCarp(int birlerBasamagi, int onlarBasamagi, int yuzlerBasamagi, int birlerBasamagi2, int onlarBasamagi2, int yuzlerBasamagi2)
        {
            int toplamBirler, toplamOnlar, toplamYuzler, toplamBirler2, toplamOnlar2, toplamYuzler2, toplamBirler3, toplamOnlar3, toplamYuzler3;
            if (birlerBasamagi * birlerBasamagi2 <= 10)
                toplamBirler = (birlerBasamagi * birlerBasamagi2) % 10;
            else
                toplamBirler = birlerBasamagi * birlerBasamagi2;
            if (birlerBasamagi * onlarBasamagi2 <= 10)
                toplamBirler2 = (birlerBasamagi * onlarBasamagi2) % 10;
            else
                toplamBirler2 = birlerBasamagi * birlerBasamagi2;
            if (birlerBasamagi * yuzlerBasamagi2 <= 10)
                toplamBirler3 = (birlerBasamagi * yuzlerBasamagi2) % 10;
            else
                toplamBirler3 = birlerBasamagi * yuzlerBasamagi2;

            if (onlarBasamagi * birlerBasamagi2 <= 10)
                toplamOnlar = (onlarBasamagi * birlerBasamagi2) % 10;
            else
                toplamOnlar = onlarBasamagi * birlerBasamagi2;
            if (onlarBasamagi * onlarBasamagi2 <= 10)
                toplamOnlar2 = (onlarBasamagi * onlarBasamagi2) % 10;
            else
                toplamOnlar2 = onlarBasamagi * onlarBasamagi2;
            if (onlarBasamagi * yuzlerBasamagi2 <= 10)
                toplamOnlar3 = (onlarBasamagi * yuzlerBasamagi2) % 10;
            else
                toplamOnlar3 = onlarBasamagi * yuzlerBasamagi2;

            if (yuzlerBasamagi * birlerBasamagi2 <= 10)
                toplamYuzler = (yuzlerBasamagi * birlerBasamagi2) % 10;
            else
                toplamYuzler = yuzlerBasamagi * birlerBasamagi2;
            if (yuzlerBasamagi * onlarBasamagi2 <= 10)
                toplamYuzler2 = (yuzlerBasamagi * onlarBasamagi2) % 10;
            else
                toplamYuzler2 = yuzlerBasamagi * onlarBasamagi2;
            if (yuzlerBasamagi * yuzlerBasamagi2 <= 10)
                toplamYuzler3 = (yuzlerBasamagi * yuzlerBasamagi2) % 10;
            else
                toplamYuzler3 = yuzlerBasamagi * yuzlerBasamagi2;
            int carpan1 = toplamBirler + (toplamOnlar * 10) + (toplamYuzler * 100);
            int carpan2 = toplamBirler2 + (toplamOnlar2 * 10) + (toplamYuzler2 * 100);
            int carpan3 = toplamBirler3 + (toplamOnlar3 * 10) + (toplamYuzler3 * 100);

            Console.WriteLine(carpan1 + carpan2 + carpan3);
        }

        private static void BasamakBul(int sayi1, int sayi2, out int birlerBasamagi, out int onlarBasamagi, out int yuzlerBasamagi, out int birlerBasamagi2, out int onlarBasamagi2, out int yuzlerBasamagi2)
        {
            yuzlerBasamagi = sayi1 / 100;
            onlarBasamagi = (sayi1 / 10) % 10;
            birlerBasamagi = sayi1 % 10;

            yuzlerBasamagi2 = sayi2 / 100;
            onlarBasamagi2 = (sayi2 / 10) % 10;
            birlerBasamagi2 = sayi2 % 10;
        }
    }
}
