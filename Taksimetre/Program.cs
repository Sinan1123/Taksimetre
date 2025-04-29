namespace Taksimetre
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double kmUcret = 25;
            int basUcret = 150;
            Console.WriteLine("Taksimetre hesaplama uygulamasına hoşgeldiniz!\nLütfen Gidilen km giriniz (1 veya !.25 gibi)");
            
            
        başlangıç:

            double km = Convert.ToDouble(Console.ReadLine());

        tekrar:
            if (km <= 0)
            {
                Console.WriteLine("Geçersiz km bilgisi girdiniz! Lütfen sıfırdan büyük bir sayı giriniz. (1 veya !.25 gibi)");
                goto başlangıç;
            }

            Console.WriteLine("Gece tarifesi İse 1 e Degilse 2 ye basın");

            int tarife = Convert.ToInt32(Console.ReadLine());



            if (tarife <= 0 || tarife > 2)
            {
                Console.WriteLine("Tarife türü yanlış girildi!");
                goto tekrar;
            }

            if (km > 0)
            {
                double ucret;

                if (tarife == 1)
                    ucret = km * (kmUcret * 1.2) + basUcret;
                else
                    ucret = km * kmUcret + basUcret;

                Console.WriteLine($"Ödeyeceğiniz tutar: {ucret} TL");
            }
            else
            {
                Console.WriteLine("Kilometre değeri sıfırdan büyük olmalı.");
                goto başlangıç;
            }
        }
    }
}
