using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsiPemrograman3360
{
    class karyawan
    {
        public karyawan(string nama, string nik, double gajibulanan)
        {
            Nama = nama;
            Nik = nik;
            Gajibulanan = gajibulanan;
            Naik = (gajibulanan * 0.1)+gajibulanan;
        }


        public string Nama { get; set; }
        public string Nik { get; set; }
        public double Gajibulanan { get; set; }
        public double Naik { get; set; }
    }
}
