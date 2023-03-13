//Deklarasikan Pustaka / Library

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

namespace Data_Kasir
{
    //Membuat Public Class
    /// <summary>
    /// class <c>Point</c> memodelkan titik dalam bidang dua dimensi.
    /// </summary>
    public class Kasir
    {
        /// <summary>
        /// suatu perintah return akan mengakhiri suatu method seperti yang telah dijelaskan sebelumnya di bagian kondisi pada C#
        /// <example>
        /// sebagai contoh :
        /// <code>
        ///  public class ContohMethod {
        ///public void Pemisah()
        ///{
        ///    Console.WriteLine("----------------------");
        ///    Console.WriteLine("----------------------");
        ///}
        /// </code>
        /// </example>
        /// </summary>
    public void KasirCafe()
        {
            {

                Console.WriteLine("=============================================================");
                Console.WriteLine("                       Program Kasir Cafe                    ");
                Console.WriteLine("                           Okui Cafe                         ");
                Console.WriteLine("=============================================================");
                Console.Write("\n");
                Console.WriteLine("   Silahkan Memilih Menu Makanan Yang Telah Disediakan  ");
                Console.Write("\n");
                //Menampilkan Menu Makanan
                Console.WriteLine("==========MENU MAKANAN==========");
                Console.Write("\n");
                Console.WriteLine("  1. Chinese Fried Rice          : Rp.15000");
                Console.WriteLine("  2. Chicken Katsu Curry         : Rp.15000");
                Console.WriteLine("  3. American beef Burger        : Rp.20000");
                Console.WriteLine("  4. Double Beef Burger          : Rp.25000");
                Console.Write("\n");
                //Menampilkan Menu Minuman
                Console.WriteLine("==========MENU MINUMAN==========");
                Console.Write("\n");
                Console.WriteLine("  1. Thai Green Tea                 : Rp.10000");
                Console.WriteLine("  2. Orange Juice                   : Rp.8000");
                Console.WriteLine("  3. Americano Coffee Latte         : Rp.15000");
                Console.WriteLine("  4. Red Velvet Milkshake           : Rp.20000");
                Console.Write("\n");

                ///<summary>
                ///berisi beberapa list dari integer (int)
                ///Mendifinisan variabel data(string)
                ///</summary>
                int jumlah;
                //Looping dengan menginput jumlah barang menggunakan kondisi do while
                do
                {
                    Console.Write("\nMasukkan Jumlah Barang Customer:  ");
                    jumlah = int.Parse(Console.ReadLine());
                } while (jumlah <= 0 || jumlah > 100);

                //Mendeklarasikan atau mendefiniskan variabel data
                string[] nama = new string[jumlah];
                int[] harga = new int[jumlah];
                int total = 0;
                int bayar, kembalian;

                //Menampilkan nama pelanggan
                Console.WriteLine("===========================");
                Console.Write("Masukkan Nama Customer : ");
                //Mendeklarasikan variabel data string
                string namap1 = Console.ReadLine();


                ///<summary>
                ///mendeklarasikan syntax pengulangan
                //////<param>
                ///<code>
                ///int i = 0; i <jumlah; i++)
                ///</code>
                ///</param>
                //Looping menggunakan kombinasi array
                ///</summary>
                for (int i = 0; i < jumlah; i++)
                {
                    do
                    {
                        //Menampilkan input nama barang
                        Console.WriteLine("=================================");
                        Console.Write("Masukkan Nama Barang Ke-" + (i + 1) + ": ");
                        nama[i] = Console.ReadLine();
                    } //User harus menginput nama barang diatas 0 karakter sampai dengan 20 karakter
                    while (nama[i].Length <= 0 || nama[i].Length > 20);

                    do
                    {
                        //Menampilkan input harga data
                        Console.Write("Masukkan Harga Barang Ke-" + (i + 1) + ": ");
                        harga[i] = int.Parse(Console.ReadLine());
                    } //User harus menginput harga barang min 5000 sampai 1000000
                    while (harga[i] <= 4000 || harga[i] >= 1000000);

                }
                //Menampilkan barang yang sudah dipilih
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("==========================");
                Console.WriteLine("Daftar Barang Yang Dipesan");
                Console.WriteLine("==========================");
                for (int i = 0; i < jumlah; i++)
                {
                    Console.WriteLine((i + 1) + "." + nama[i] + " " + harga[i]);
                }
                foreach (int i in harga)
                {
                    total += i;
                }

                //Menampilkan total harga
                Console.WriteLine("===========================================");
                Console.WriteLine("Total Harga Yang Harus Dibayar : Rp" + total);

                do
                {
                    Console.Write("Masukkan Tunai: Rp");
                    bayar = int.Parse(Console.ReadLine());

                    //Menampilkan kembalian uang dari uang yang dibayarkan dikurangi uang total
                    kembalian = bayar - total;

                    //Kondisi jika input uang yang dibayarkan kurang
                    if (bayar < total)
                    {
                        Console.WriteLine("Maaf Uang Anda Tidak Cukup !");
                    }
                    //Kondisi dimana input uang yang diberikan lebih dan menambahkan uang kembalian
                    else
                    {
                        Console.WriteLine("Uang Kembalian Anda : Rp." + kembalian);
                    }

                } while (bayar < total);
                Console.Write("\n");
                Console.Write("Nama Pelanggan: {0}", namap1.ToString());
                Console.Write("\n");
                //Meanmpilkan tanggal dan waktu transaksi
                Console.WriteLine("Tanggal Transaksi:" + DateTime.Today.ToString("yyyy-MM-dd"));
                Console.WriteLine("Jam Transaksi: " + DateTime.Now.ToString("HH:mm:ss"));
                Console.WriteLine("========================================");
                Console.WriteLine("Nama Kasir  : Affan Nabil Ramadhan");
                Console.WriteLine("Thank You");
                Console.WriteLine("========================================");

                ///<summary>
                ///Untuk menulis  file text kita bisa menggunakan objek dari class StreamWriter dan untuk membaca file text  kita gunakan  objek dari class StreamReader.
                ///Class class tsb berada pada namespace System.IO.
                ///Mencetak nota dengan menggunakan streamwritter
                ///</summary>
                using (StreamWriter sw = new StreamWriter(@"C:\Users\LENOVO\Music\Nota\sample2.txt"))//merupakan lokasi file nota dicetak
                {
                    sw.WriteLine("==========================================");
                    sw.WriteLine("============= NOTA PEMBAYARAN ============");
                    sw.WriteLine("==========================================");
                    sw.WriteLine("         Nama Barang Yang Dibeli          ");
                    for (int i = 0; i < jumlah; i++)
                    {
                        sw.WriteLine((i + 1) + ". " + nama[i] + " " + harga[i]);
                    }
                    sw.WriteLine("+==========================================+");
                    sw.WriteLine("Total Harga       : Rp" + total);
                    sw.WriteLine("Tunai             : Rp" + bayar);
                    sw.WriteLine("Kembalian         : Rp" + kembalian);
                    sw.WriteLine("\n");
                    //Menampilkan nama pelanggan
                    sw.WriteLine("Nama Pelanggan: {0}", namap1.ToString());
                    //Menampilkan tanggal dan waktu transaksi
                    sw.WriteLine("Tanggal Transaksi" + DateTime.Today.ToString("yyyy-MM-dd"));
                    sw.WriteLine("Jam Transaksi: " + DateTime.Now.ToString("HH:mm:ss"));
                    sw.WriteLine("========================================");
                    sw.WriteLine("Nama Kasir  : Affan Nabil Ramadhan");
                    sw.WriteLine("Thank You");
                    sw.WriteLine("========================================");
                    Console.WriteLine("\n");
                    Console.WriteLine("Nota Telah Dicetak");
                }
                Console.WriteLine();
                Console.Write("Tekan ENTER untuk Keluar...");
                Console.ReadLine();
            }
        }
        /// <summary>
        /// prosedur yang menghasilkan nilai tetap dan bersifat public atau global yang dapat diakses dari prosedur atau fungsi manapun dengan syarat
        /// semua variabel didalam void / prosedur tersebut juga pubic static.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Memanggil kelas KasirCafe
            Kasir KasirB = new Kasir();
            KasirB.KasirCafe();
        }
    }
}