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
using System.Data.SqlClient;

namespace voorraadsysteemnew
{
    public partial class Form1 : Form
    {
        NpgsqlCommand command = new NpgsqlCommand();
        string cmd;
        NpgsqlConnection con = new NpgsqlConnection("server=10.10.10.40;port=5432;Database=tappas;User Id=softwareguys;Password=T^jTc4rv*!M6FKYVybFbuQG&v^HVkJ$KfRd1PCuAc$$@rEVvrJvKH%9#7gFQ;");
        public Form1()
        {
            InitializeComponent();
            
            //hiermee maak je de connection
            con.Open();
            //hiermee zorg je dat de database open connectie staat voor de applicatie
            NpgsqlCommand comm = new NpgsqlCommand();
            //dit is dat alle commands hierin new worden gemaakt, voor als je al meer commands hebt van dit soort, bijvoorbeeld je hebt een command dat hij data moet vasthouden,
            comm.Connection = con;
           // dit zorgd dat de commands connecten met de database, zodat je ze kan gebruiken
            comm.CommandType = CommandType.Text;
            //dit is dat de command die je wilt doen als datatype een text type is.
            comm.CommandText = "select * from gerecht";
            //dit is de query
            NpgsqlDataReader dr = comm.ExecuteReader();
            //dit zorgd ervoor dat de datareader zijn werk doet, hij doet: datapakken van de database en stopt het in een datatable(de gridview)
            if (dr.HasRows)
                // als de datareader rows terug krijgt van info dan laad hij dat zien in de datagridview.
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvgerecht.DataSource = dt;
            }
            comm.Dispose();
            //dit zorgt ervoor dat hij geen info onthoud dus hij laat alle info los.
            con.Close();
            //zorg ervoor dat de database gesloten word.


        }


        public void RefreshGridView()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                    RefreshGridView();
                }
                else if (con.State != ConnectionState.Open)
                {
                    con.Open();
                    cmd = "select * from gerecht";
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dgvgerecht.DataSource = dt;
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("No Records Found!!");
                    con.Close();
                }
            }
            catch
            {
                MessageBox.Show("There are no Users Found!!");

            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Weet u zeker dat u wilt afsluiten?", "Afsluiten", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtnaam_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblnaam_Click(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string _PId = txtId.Text;
            string _naam = txtnaam.Text;
            string _gw = txtgewicht.Text;

            if (txtId.Visible == false && lblId.Visible == false)
            {
                txtId.Visible = true;
                lblId.Visible = true;
            }

            else if (!string.IsNullOrEmpty(_PId))
            {
                try
                {
                    //test
                    int _Fid = Convert.ToInt32(txtId.Text);
                    con.Open();

                    cmd = "UPDATE gerecht SET naam = "+ _naam+" gewicht = "+14.6 + " WHERE productid = "+14 ;
                    command = new NpgsqlCommand(cmd, con);

                   /* command.Parameters.AddWithValue("ProductID", 14);
                    command.Parameters.AddWithValue("Naam", _naam);
                    command.Parameters.AddWithValue("gewicht", 14.6);*/
                    

                   int _result1 = command.ExecuteNonQuery();

                    if (_result1 > 0)
                    {
                        MessageBox.Show("User Updated");

                        txtnaam.Text = "";
                        txtId.Text = "";
                        txtgewicht.Text = "";

                        RefreshGridView();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("User not updated");
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Record is not Updated or Found!" + ex);
                    con.Close();
                }
                finally
                {
                    command.Dispose();
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("There is an error");
            }



        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            RefreshGridView();
        }

        private void dgvgerecht_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
