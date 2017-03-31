using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 测试
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            string ei = "ei";
            string ci = "ci";
=======
            string di = "di";
>>>>>>> master
            string bi = "bi";
            string ai = "ai";
            string sql = "select * from Star";
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MyQQ.accdb;");
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(sql ,conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            textBox1.Text = Convert.ToString(reader[1]);
            textBox2.Text = Convert.ToString(reader[0]);
            reader.Close();
            conn.Close();
        }
    }
}
