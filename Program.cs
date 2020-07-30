using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AplikasiPekerja.ClassInduk;
using AplikasiPekerja.ClassAnak;

namespace AplikasiPekerja
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Pekerja> listPekerja = new List<Pekerja>();

            void tampilPekerja()
            {
                int noAntrian = 1;

                foreach (Pekerja pekerja in listPekerja)
                {
                    Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}, {4}", noAntrian, pekerja.Nik, pekerja.Nama, pekerja.Gaji(), pekerja.jenis_pekerja);

                    noAntrian++;
                }
            }

            void tambahPekerjaTetap(string jenisPekerja, string nik, string nama, int gajiBulanan)
            {
                listPekerja.Add(new PekerjaTetap { jenis_pekerja = jenisPekerja, Nik = nik, Nama = nama, GajiBulanan = gajiBulanan });
            }

            void tambahPekerjaHarian(string jenisPekerja, string nik, string nama, int jamkerja, int upah)
            {
                listPekerja.Add(new PekerjaHarian { jenis_pekerja = jenisPekerja, Nik = nik, Nama = nama, JumlahJamKerja = jamkerja, UpahPerJam = upah });
            }

            void tambahSales(string jenisPekerja, string nik, string nama, int jumlahjual, int komisi)
            {
                listPekerja.Add(new Sales { jenis_pekerja = jenisPekerja, Nik = nik, Nama = nama, JumlahPenjualan = jumlahjual, Komisi = komisi });
            }

            void hapusPekerja()
            {
                int no = 1;
                int jumlah_pek = 0;

                foreach (Pekerja pekerja in listPekerja)
                {
                    Console.WriteLine("{0}. Nik: {1}", no, pekerja.Nik);

                    no++;
                    jumlah_pek += 1;
                }
                Console.WriteLine();
                Console.Write("Pilih Data Yang Ingin Dihapus [1-");
                Console.Write(jumlah_pek);
                Console.Write("] : ");
                int index_nik = int.Parse(Console.ReadLine());
                index_nik = index_nik - 1;

                listPekerja.RemoveAt(index_nik);
                Console.WriteLine();
                Console.WriteLine("Data Pekerja Berhasil Dihapus ");
                Console.WriteLine();
                Console.WriteLine("\nTekan Enter Untuk Kembali ke Menu");
            }

            bool keluar = false;
            while (keluar == false)
            {
                Console.Title = "Tugas Lab 9 (Pertemuan 12)- Polymorphsim, Inheritance, Abstraction & Collection Part #2";
                Console.WriteLine("Pilih Menu Aplikasi :");
                Console.WriteLine();
                Console.WriteLine("1. Tambah Data Pekerja");
                Console.WriteLine("2. Hapus Data Pekerja");
                Console.WriteLine("3. Tampilkan Data Pekerja");
                Console.WriteLine("4. Keluar");
                Console.WriteLine();
                Console.Write("Nomer Menu [1..4] = ");
                int menu = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine();
                if (menu < 1)
                {
                    Console.WriteLine("Maaf, Menu Yang Anda Pilih Tidak Tersedia");
                }
                else if (menu > 4)
                {
                    Console.WriteLine("Maaf, Menu Yang Anda Pilih Tidak Tersedia");
                }
                else if (menu == 1)
                {
                    Console.WriteLine("Tambah Data Pekerja");
                    Console.WriteLine();
                    Console.Write("Jenis Pekerja [1. Pekerja Tetap, 2. Pekerja Harian, 3. Sales] : ");
                    int jk = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if (jk == 1)
                    {
                        Console.Write("Nik = ");
                        string nik = Console.ReadLine();
                        Console.Write("Nama = ");
                        string nama = Console.ReadLine();
                        Console.Write("Gaji Bulanan = ");
                        int gb = int.Parse(Console.ReadLine());
                        string jenis = "Pekerja Tetap";

                        tambahPekerjaTetap(jenis, nik, nama, gb);
                    }
                    else if (jk == 2)
                    {
                        Console.Write("Nik = ");
                        string nik = Console.ReadLine();
                        Console.Write("Nama = ");
                        string nama = Console.ReadLine();
                        Console.Write("Jumlah Jam Kerja = ");
                        int jamkerja = int.Parse(Console.ReadLine());
                        Console.Write("Upah Per Jam = ");
                        int upah = int.Parse(Console.ReadLine());
                        string jenis = "Pekerja Harian";

                        tambahPekerjaHarian(jenis, nik, nama, jamkerja, upah);
                    }
                    else if (jk == 3)
                    {

                        Console.Write("Nik = ");
                        string nik = Console.ReadLine();
                        Console.Write("Nama = ");
                        string nama = Console.ReadLine();
                        Console.Write("Jumlah Terjual = ");
                        int jumlahjual = int.Parse(Console.ReadLine());
                        Console.Write("Komisi = ");
                        int komisi = int.Parse(Console.ReadLine());
                        string jenis = "Sales";

                        tambahSales(jenis, nik, nama, jumlahjual, komisi);
                    }
                    else
                    {
                        Console.WriteLine("Menu salah");
                    }
                    Console.WriteLine();
                    Console.WriteLine("\nTekan Enter Untuk Kembali ke Menu");


                }
                else if (menu == 2)
                {
                    hapusPekerja();
                }
                else if (menu == 3)
                {
                    Console.WriteLine("Data Pekerja");
                    Console.WriteLine();
                    tampilPekerja();

                    Console.WriteLine("\nTekan Enter Untuk Kembali ke Menu");
                }
                else if (menu == 4)
                {
                    keluar = true;
                }

                Console.ReadKey();
            }
        }
    }
}
