using System;

namespace QUIZ09092019
{
    class BangunDatar
    {
        public void LuasPersegi()
        {
            int sisi;
            Console.Write("masukkan nilai sisi : ");
            sisi= Convert.ToInt32(Console.ReadLine());

            int luas = sisi * sisi;

            Console.WriteLine("luas persegi adalah "+luas);
        }

        public void LuasSegitiga()
        {
            int tinggi, alas;
            Console.Write("masukkan nilai tinggi : ");
            tinggi=Convert.ToInt32(Console.ReadLine());

            Console.Write("masukkan nilai alas : ");
            alas=Convert.ToInt32(Console.ReadLine());

            int luas= alas * tinggi / 2;

            Console.WriteLine("luas segitiga adalah "+luas);
        }

        public void LuasLingkaran()
        {
            const double phi = 3.14;
            double Luas;
            int r;

            Console.Write("Masukkan panjang jari-jari Lingkaran:");
            r = Convert.ToInt32(Console.ReadLine());
            Luas = phi * r * r;
            Console.WriteLine("Luas Lingkaran adalah " + Luas);
        }

     
     
    }
}