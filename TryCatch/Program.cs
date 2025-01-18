using System;
namespace TryCath
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                try
                {
                    Console.WriteLine("Lütfen bir sayı giriniz:");
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    int sayininKaresi = sayi * sayi;
                    Console.WriteLine(sayininKaresi);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lütfen geçerli bir sayı girin!");
                }
            }
        }
    }
}