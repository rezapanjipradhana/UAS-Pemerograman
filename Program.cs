using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace PendaftaranMahasiswa
{
    class Program
    {
        static void Main(string[] args)
        {
            teknik[] teknik = new teknik[20];
            bahasa[] bahasa = new bahasa[20];

            List<Data> listdata = new List<Data>();

            int menu, kr;
            int i = 0, j = 0;
            do
            {
            awal:
                Console.WriteLine("PILIH MENU APLIKASI PENDAFTARAN MAHASISWA\n");
                Console.WriteLine("\n1. Tambah Data Pendaftar");
                Console.WriteLine("2. Hapus Data Pendaftar");
                Console.WriteLine("3. Tampilkan Data Pendaftar");
                Console.WriteLine("4. Keluar\n");

                Console.Write("Nomor Menu [1..4] : ");
                menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        do
                        {
                            Console.WriteLine("TAMBAH DATA PENDAFTAR");
                            Console.WriteLine("Silahkan pilih ingin mendaftar ke Jurusan apa");
                            Console.WriteLine("\n[1] Teknik | [2] Bahasa");
                            Console.WriteLine("Atau pilih [3] untuk kembali ke menu");
                            Console.Write("\nJurusan yang dipilij 1/2 : ");

                            kr = Convert.ToInt32(Console.ReadLine());

                            switch (kr)
                            {
                                case 1:
                                    i++;
                                    teknik[i] = new teknik();

                                    Console.Clear();
                                    Console.WriteLine("Masukkan Data Calon Pendaftar Jurusan Teknik\n");
                                    Console.Write("Nomor Pendaftaran : ");
                                    teknik[i].no = Console.ReadLine();
                                    Console.Write("Nama : ");
                                    teknik[i].nama = Console.ReadLine();
                                    Console.Write("SPP : ");
                                    teknik[i].spp = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Biaya Gedung : ");
                                    teknik[i].gedung = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Biaya Praktik : ");
                                    teknik[i].praktik = Convert.ToDouble(Console.ReadLine());

                                    listdata.Add(teknik[i]);
                                    Console.WriteLine("\n");
                                    break;

                                case 2:
                                    j++;
                                    bahasa[j] = new bahasa();

                                    Console.Clear();
                                    Console.WriteLine("Masukkan Data Calon Pendaftar Jurusan Bahasa\n");
                                    Console.Write("Nomor Pendaftaran : ");
                                    bahasa[i].no = Console.ReadLine();
                                    Console.Write("Nama : ");
                                    bahasa[i].nama = Console.ReadLine();
                                    Console.Write("SPP : ");
                                    bahasa[i].spp = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Biaya Gedung : ");
                                    bahasa[i].gedung = Convert.ToDouble(Console.ReadLine());

                                    listdata.Add(bahasa[j]);
                                    Console.WriteLine("\n");
                                    break;

                                case 3:
                                    Console.Clear();
                                    goto awal;
                            }
                        }
                        while (kr != 4);
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Hapus Pendaftar\n");
                        Console.Write("Masukkan Nomor Pendaftaran yang ingin di hapus : ");
                        string hapus = Console.ReadLine();

                        if (listdata.Any(n => n.no == hapus))
                        {
                            listdata.RemoveAll(x => x.no == hapus);
                            Console.WriteLine("Data pendaftar berhasil dihapus!\n");
                        }
                        else
                        {
                            Console.WriteLine("Data pendaftar tidak ditemukan");
                        }

                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("DATA CALON PENDAFTAR MAHASISWA\n");
                        int noUrut = 0;

                        foreach (Data data in listdata)
                        {
                            noUrut++;
                            Console.WriteLine("{0}. No Pendaftaran : {1} \n   Nama : {2} \n   Biaya : {3:N0} \n", noUrut, data.no, data.nama, data.biaya()) ;
                        }

                        Console.WriteLine("");
                        break;

                    case 4:
                        Console.WriteLine("TERIMAKASIH !");
                        Thread.Sleep(2000);
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Tidak ada pilihan dalam menu!");
                        break;
                }

            }
            while (menu != 4);
            Console.WriteLine("");
            Environment.Exit(0);
        }
    }
}
