using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            //array - dizi
            //tek tek tanımlamak yerine arraylerde tutuyoruz

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs", "Java", "Python" };



            for (int i = 0; i < kurslar.Length; i++) //kurslar.Length  Lrnght = eleman sayısını verir. 0 dan başlar kursların eleman sayıları kadar döner.
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti"); // ayrımı göstermek için yazdık.

            foreach (string kurs in kurslar) // buradaki kurs her bir elemanı dolaşırken verdiğimiz takma isimdir - alliastır.
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}