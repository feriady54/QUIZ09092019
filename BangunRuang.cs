using System;

namespace QUIZ09092019
{
    class BangunRuang
    {
        public void VolumeBalok()
        {
            int panjang, lebar, tinggi, Volume;

            Console.WriteLine("Menghitung Volume Balok");
            Console.WriteLine("-----------------------");
            
            Console.Write("Masukkan Nilai panjang : ");
            panjang = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan Nilai lebar : ");
            lebar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan Nilai tinggi : ");
            tinggi = Convert.ToInt32(Console.ReadLine());
            
            Volume = panjang * lebar * tinggi;

            Console.WriteLine("Volume Balok adalah "+Volume);
        }

        public void VolumeKubus()
        {
            int sisi ;

            Console.WriteLine("menghitung Volume Kubus");

            Console.Write("Masukkan Nilai sisi : ");
            sisi = Convert.ToInt32(Console.ReadLine());

            int Volume = sisi * sisi * sisi ;

            Console.WriteLine("Volume Kubus adalah "+Volume);
        }
    }
}