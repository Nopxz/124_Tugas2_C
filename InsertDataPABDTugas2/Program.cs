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
                    +"insert into Customer(Id_Customer, Nama_Customer, Jenis_Kelamin, No_Telp) values('C000000005', 'Buna', 'L', '0821282936102')",
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
