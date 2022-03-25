using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InsertDataPABDTugas2
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().InsertData();
        }

        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source =NOP\\MSSQLSERVER01;database=Toko_Kue_Naufal;UserID=sa;Password=kontoru555");
                con.Open();

                SqlCommand cm = new SqlCommand ("insert into Kasir(Id_Kasir, Nama_Kasir, Jenis_Kelamin) values('K000000001', 'Naufal', 'L')"
                    + "insert into Kasir(Id_Kasir, Nama_Kasir, Jenis_Kelamin) values('K000000002', 'Gita', 'L')"
                    + "insert into Kasir(Id_Kasir, Nama_Kasir, Jenis_Kelamin) values('K000000003', 'Mahardika', 'L')"
                    + "insert into Kasir(Id_Kasir, Nama_Kasir, Jenis_Kelamin) values('K000000004', 'Rizky', 'L')"
                    + "insert into Kasir(Id_Kasir, Nama_Kasir, Jenis_Kelamin) values('K000000005', 'Alam', 'L')"

                    +"insert into Customer(Id_Customer, Nama_Customer, Jenis_Kelamin, No_Telp) values('C000000001', 'Budi', 'L', '0821282932102')"
                    +"insert into Customer(Id_Customer, Nama_Customer, Jenis_Kelamin, No_Telp) values('C000000002', 'Lana', 'L', '0822321243212')"
                    +"insert into Customer(Id_Customer, Nama_Customer, Jenis_Kelamin, No_Telp) values('C000000003', 'Lone', 'L', '0821282923102')"
                    +"insert into Customer(Id_Customer, Nama_Customer, Jenis_Kelamin, No_Telp) values('C000000004', 'Lala', 'L', '0821282932102')"
                    +"insert into Customer(Id_Customer, Nama_Customer, Jenis_Kelamin, No_Telp) values('C000000005', 'Buna', 'L', '0821282936102')"

                    + "insert into Produk(Id_Produk, Nama_Produk, Stok) values('P000000001', 'Bolu', '20')"
                    + "insert into Produk(Id_Produk, Nama_Produk, Stok) values('P000000002', 'Kukus', '30')"
                    + "insert into Produk(Id_Produk, Nama_Produk, Stok) values('P000000003', 'Gandum', '25')"
                    + "insert into Produk(Id_Produk, Nama_Produk, Stok) values('P000000004', 'Brownies', '10')"
                    + "insert into Produk(Id_Produk, Nama_Produk, Stok) values('P000000005', 'Crumpet', '40')"

                    + "insert into Transaksi(Id_Transaksi, Tanggal_Transaksi, Jumlah_Kue, Total_Pembayaran, Jenis_Pembayaran, Id_Kasir, Id_Customer, Id_Produk) values('T000000001', '06-12-2021', '20','200000','Tunai','K000000001','C000000001','P000000001')"
                    + "insert into Transaksi(Id_Transaksi, Tanggal_Transaksi, Jumlah_Kue, Total_Pembayaran, Jenis_Pembayaran, Id_Kasir, Id_Customer, Id_Produk) values('T000000002', '07-11-2021', '30','300000','Debit','K000000002','C000000002','P000000002')"
                    + "insert into Transaksi(Id_Transaksi, Tanggal_Transaksi, Jumlah_Kue, Total_Pembayaran, Jenis_Pembayaran, Id_Kasir, Id_Customer, Id_Produk) values('T000000003', '08-10-2021', '25','250000','Tunai','K000000003','C000000003','P000000003')"
                    + "insert into Transaksi(Id_Transaksi, Tanggal_Transaksi, Jumlah_Kue, Total_Pembayaran, Jenis_Pembayaran, Id_Kasir, Id_Customer, Id_Produk) values('T000000004', '09-09-2021', '10','100000','Debit','K000000004','C000000004','P000000004')"
                    + "insert into Transaksi(Id_Transaksi, Tanggal_Transaksi, Jumlah_Kue, Total_Pembayaran, Jenis_Pembayaran, Id_Kasir, Id_Customer, Id_Produk) values('T000000005', '10-08-2021', '40','400000','Tunai','K000000005','C000000005','P000000005')"
                    ,
                    con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses menambahkan data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal menambahkan data. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
