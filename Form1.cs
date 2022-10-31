using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace voorraadsysteemnew
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("server=10.10.10.40;port=5432;Database=tappas;User Id=softwareguys;Password=T^jTc4rv*!M6FKYVybFbuQG&v^HVkJ$KfRd1PCuAc$$@rEVvrJvKH%9#7gFQ;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from voorraadsysteem";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvgerecht.DataSource = dt;
            }
            comm.Dispose();
            conn.Close();




        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the application", "Exit message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
