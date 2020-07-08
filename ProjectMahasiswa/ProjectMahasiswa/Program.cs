using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        HapusMahasiswa();
                        break;

                    case 3:
                        TampilMahasiswa();
                       
                        break;

                    case 4: // keluar dari program
                         Console.WriteLine("\nTekan enter untuk kembali ke menu pertama");
                        Console.ReadKey();
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine("");
            Console.WriteLine("1. Tambah data mahasiswa");
            Console.WriteLine("2. Hapus data mahasiswa");
            Console.WriteLine("3. Tampilkan data mahasiswa");
            Console.WriteLine("4. Keluar");

            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection
            Console.WriteLine("NIM Mahasiswa");
            Console.Write("NIM\t: ");
            double _NIM = double.Parse(Console.ReadLine());
            Console.Write("Nama Mahasiswa\t: ");
            string _nama = Console.ReadLine();
            Console.Write("kelamin\t: ");
            double _kelamin = double.Parse(Console.ReadLine());
            Console.Write("IPK\t: ");
            double _IPK = double.Parse(Console.ReadLine());

            _mahasiswa(_NIM,_nama,_kelamin,_IPK);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

           

        static void HapusMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus objek mahasiswa dari dalam collection
            

            TampilMahasiswa();
            Console.WriteLine("\n");
            Console.Write("Masukan Kode Produk : ");
            double _pilKode = double.Parse(Console.ReadLine());
            bool chek = false;
            for(int i =0; i < daftarMahasiswa.Count; i++)
            {
                if(daftarMahasiswa[i].NIM == _pilKode)
                {
                    var hapus = daftarMahasiswa.Single(r => r.NIM == _pilKode);
                    Console.WriteLine("Data berhasil ditemukan...");
                    Console.WriteLine("NIM\t\t: " + hapus.NIM);
                    Console.WriteLine("Nama\t\t: " + hapus.Nama);
                    Console.WriteLine("kelamin\t: " + hapus.kelamin);
                    Console.WriteLine("IPK\t: " + hapus.IPK);

                    //daftarProduk.Remove(hapus);
                    //chek = true;
                    Console.Write("Yakin ingin menghapus data??[y/n] : ");
                    char lanjut = char.Parse(Console.ReadLine());
                    if (lanjut == 'y' || lanjut == 'Y')
                    {
                        daftarMahasiswa.Remove(hapus);
                        Console.WriteLine("Data berhasil dihapus");
                    }
                    else
                    {
                        Console.WriteLine("Gagal menghapus data");
                    }
                    chek = true;
                }
                if(!chek)
                {
                    Console.WriteLine("Maaf, NIM tidak ditemukan");
                }
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection

            Console.WriteLine("\nTekan enter untuk kembali ke menu awal");
            Console.ReadKey();

              int nomorUrut = 1;
            foreach(Mahasiswa mahasiswa in daftarMahasiswa)
            {
                Console.WriteLine("NO.{0}" + " " + "NIM.{1}" + "\t" + "Nama : {2}" + "\t"+" kelamin : {3}"+"\t"+" IPK : {4}",
                     nomorUrut, mahasiswa.NIM, mahasiswa.Nama, mahasiswa.kelamin, mahasiswa.IPK);
                nomorUrut++;
            }
            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection
        }

        static void _mahasiswa(double _NIM, string _Nama, double _kelamin,double _IPK)
        {
            daftarMahasiswa.Add(new Mahasiswa {NIM = _NIM,Nama = _Nama,kelamin = _kelamin,IPK = _IPK });
        }
    }
}
