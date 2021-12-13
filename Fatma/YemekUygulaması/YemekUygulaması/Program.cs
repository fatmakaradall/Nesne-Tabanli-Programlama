using System;

namespace YemekListeleme
{
    class yemek
    {
        static void Main(string[] args)
        {
            string Kullaniciad;
            string yemek_adi;
            string malzeme_isim;

            //  Kullanıcı Adını Girmek İçin
            Console.WriteLine("Lütfen İsminizi Giriniz :");
            Kullaniciad = Console.ReadLine();

            // Yemeğin Adını Girmek İçin
            Console.WriteLine("Lütfen Yemeğin Adını Giriniz : ");
            yemek_adi = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("lütfen malzemeleri yazarken araya virgül koyunuz");
            Console.WriteLine();

            // Yemeğin Malzemlerini Girmek İçin 
            Console.WriteLine("Lütfen Malzeme EKleyiniz");
            malzeme_isim = Console.ReadLine();

            Console.WriteLine("İsminiz: " + Kullaniciad);
            Console.WriteLine("Yapılacak Yemeğin Adı: " + yemek_adi);
            Console.WriteLine("Yemeğe Konulacak malzemeler: " + malzeme_isim);
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}