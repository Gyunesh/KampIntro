using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string KategoriEtiketi = "Kategoriler";
            int OgrenciSayisi = 32000;
            double FaizOrani = 1.45;
            bool SistemeGirisYapmisMi = true;

            if (SistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanici Ayarlari Butonu");

            }
            else
            {
                Console.WriteLine("Giris Yap butonu");
            }
            
            Console.WriteLine("Hello World!");
        }
    }
}
