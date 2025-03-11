using System;

namespace Modul4_103022300025
{
    class Program
    {
        static void Main()
        {
            //    KodeProduk kodeProduk = new KodeProduk();

            //    Console.Write("Masukan nama Produk : ");
            //    String Produk = Console.ReadLine();

            //    string? KodeProdukResult = kodeProduk.GetKodeProduk(Produk);

            //    if (KodeProdukResult != null)
            //    {
            //        Console.WriteLine($"Nama Produk untuk {Produk} adalah: {KodeProdukResult}");
            //    }
            //    else 
            //    {
            //        Console.WriteLine("Produk Tidak ditemukan.");
            //    }
            //}

            FanLaptop fan = new FanLaptop();
            Console.WriteLine("\n perubahan fan laptop: ");
            fan.FanBalance();
            fan.Fanperformence();
            fan.Fanturbo();
            
        }
    }
}
