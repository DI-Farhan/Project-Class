using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanClassProject
{
    public class Mahasiswa
    {
        public string Nim { get; set; }
        public string Nama { get; set; }
        public float Ipk { get; set; }

        public void Registrasi()
        {
            Console.WriteLine("Nama: {0}", Nama);
            Console.WriteLine("NIM: {0}", Nim);
            Console.WriteLine("IPK: {0}", Ipk);
            Console.WriteLine("Telah melakukan registrasi");
        }
        public void IsiKrs()
        {
            Console.WriteLine("{0} Sedang melakukan proses KRS\n", Nama);
        }
    }
}