using System;

namespace YanlısCarpmaOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            // ÇOK ÖNEMLİ NOT!!! : Öncelikle maratona çalışmamız için ödev süresini uzattığınız için teşekkürlerimi sunuyorum hocam :) İlk boş vaktimde özenerek clean ve akıcı bir kod yazdığımı ve bu uzatmayı boşa çıkarmadığımı düşünüyorum. Saygılarımla... 

            // 633 +  633 = 266 , 744 + 99  = 733 ve 299 + 8 = 297 sonucu vermektedir.

            int girilenSayi1 = 0, girilenSayi2=0;

            Console.WriteLine("Toplamak istediğiniz birinci sayıyı giriniz");
             girilenSayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Toplamak istediğiniz ikinci sayıyı giriniz");
             girilenSayi2 = Convert.ToInt32(Console.ReadLine());

            BasamakBul(girilenSayi1, girilenSayi2, out int birlerBasamagi, out int onlarBasamagi, out int yuzlerBasamagi, out int birlerBasamagi2, out int onlarBasamagi2, out int yuzlerBasamagi2);

            YanlisToplama(birlerBasamagi,onlarBasamagi,yuzlerBasamagi,birlerBasamagi2,onlarBasamagi2,yuzlerBasamagi2);
        }
        private static void  YanlisToplama(int birlerBasamagi, int onlarBasamagi, int yuzlerBasamagi, int birlerBasamagi2, int onlarBasamagi2, int yuzlerBasamagi2)
        {
            int toplamBirler,toplamOnlar,ToplamYuzler;
            if (yuzlerBasamagi + yuzlerBasamagi2 >= 10)
                ToplamYuzler = (yuzlerBasamagi + yuzlerBasamagi2) % 10;
            else
                ToplamYuzler = yuzlerBasamagi + yuzlerBasamagi2;
            if (onlarBasamagi + onlarBasamagi2 >= 10)
                toplamOnlar = (onlarBasamagi + onlarBasamagi2) % 10;
            else
                toplamOnlar = onlarBasamagi + onlarBasamagi2;
            if (birlerBasamagi + birlerBasamagi2 >= 10)
                toplamBirler = (birlerBasamagi + birlerBasamagi2) % 10;
            else
                toplamBirler = birlerBasamagi + birlerBasamagi2;
            Console.WriteLine(ToplamYuzler+""+toplamOnlar+""+toplamBirler);
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
