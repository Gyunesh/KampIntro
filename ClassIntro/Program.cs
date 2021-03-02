using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Gunes Ganaz";
            kurs1.IzlenmeOrani = 78;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Emel Ucan";
            kurs2.IzlenmeOrani = 84;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Ugur Eryurek";
            kurs3.IzlenmeOrani = 45;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Mesut Vatansever";
            kurs4.IzlenmeOrani = 96;

            Kurs kurs5 = new Kurs();
            kurs5.KursAdi = ".Net";
            kurs5.Egitmen = "Muharrem Deniz";
            kurs5.IzlenmeOrani = 78;





            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4,kurs5 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmen);

            }
           
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}

