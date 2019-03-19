using System;

namespace LatihanClassProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa saya = new Mahasiswa();
            Mahasiswa kamu = new Mahasiswa();
            saya.Nim = "12345";
            saya.Nama = "Farhan";
            saya.Ipk = 3.95f;

            kamu.Nim = "12345";
            kamu.Nama = "Sukijah";
            kamu.Ipk = 3.50f;

            saya.Registrasi();
            saya.IsiKrs();

            kamu.Registrasi();
            kamu.IsiKrs();

            Console.ReadKey();
        }
    }
}
