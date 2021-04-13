using System;

namespace ResponsiPemrograman3360
{
    class Program
    {
        static void Main(string[] args)
        {
            karyawan kry1 = new karyawan("iqbal","20119090",3000000);
            karyawan kry2 = new karyawan("santoso","20118080", 2000000);

            if (kry1.Gajibulanan <= 0 || kry2.Gajibulanan <= 0)
            {
                kry1.Gajibulanan = 0;
                kry2.Gajibulanan = 0;
            }

            Console.WriteLine("No   NIK/Nama\t\t Gaji");
            Console.WriteLine("--------------------------");
            Console.WriteLine("1.   {0} {1} \t {2}", kry1.Nik, kry1.Nama, kry1.Gajibulanan);
            Console.WriteLine("2.   {0} {1} \t {2}", kry2.Nik, kry2.Nama, kry2.Gajibulanan);
            Console.WriteLine();

            Console.WriteLine("Alhamdulillah dapat kenaikan gaji 10%");
            Console.WriteLine();
            Console.WriteLine("No   NIK/Nama\t\t Gaji");
            Console.WriteLine("--------------------------");
            Console.WriteLine("1.   {0} {1} \t {2}", kry1.Nik, kry1.Nama, kry1.Naik);
            Console.WriteLine("2.   {0} {1} \t {2}", kry2.Nik, kry2.Nama, kry2.Naik);
        }
    }
}
