using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Hekimler;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            var ad = textBox1.Text;
            var soyad = textBox2.Text;
            var sobe = textBox3.Text;
            var tetilgunu = textBox4.Text;
            var phone = textBox5.Text;
            var email = textBox6.Text;


            var sql = "insert into Hekimler(Ad,Soyad,Sobe,Tetilgunu,Phone,Email) values('" + ad + "','" + soyad + "','" + sobe + "','" + tetilgunu + "','" + phone + "','" + email + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
