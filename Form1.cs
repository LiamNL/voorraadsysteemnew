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
using System.Data.SqlTypes;

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
            comm.CommandText = "select naam, gewicht, id, prijs, vegetarisch from gerecht";
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



        public void Emptytxt()
        {
            txtnaam.Text = "";
            txtId.Text = "";
            txtgewicht.Text = "";
            txtprijs.Text = "";
            txtvege.Text = "";
            barcodeId.Text = "";
            txtId.Text = "";




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
                    cmd = "select naam, gewicht, id, prijs, vegetarisch from gerecht";
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
            string _vege = txtvege.Text;
            string _prijs = txtprijs.Text;
            barcodeId.Text = "";
            

            if (txtId.Visible == false && lblId.Visible == false)
            {
                txtId.Visible = true;
                lblId.Visible = true;
                barcodeId.Visible = false;
                Barcode.Visible = false;
            }

            else if (!string.IsNullOrEmpty(_PId))
            {
                try
                {
                    
                    con.Open();

                   // cmd = "UPDATE gerecht SET naam = \"naam\", gewicht = Gewicht WHERE id = id "; ;
                    cmd = "Update gerecht SET naam = @Name, gewicht = '"+_gw+"', vegetarisch = @vegetarisch, prijs = '"+_prijs+"' WHERE id = '"+_PId+"' " ;
                    
                    command = new NpgsqlCommand(cmd, con);
                   
                    
                    command.Parameters.AddWithValue("@Name", _naam); 
                    command.Parameters.AddWithValue("5", _prijs);
                    command.Parameters.AddWithValue("@vegetarisch", _vege);


                    int _result1 = command.ExecuteNonQuery();

                    if (_result1 > 0)
                    {
                        MessageBox.Show("User Updated");

                        Emptytxt();

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
                MessageBox.Show("Please fill in an ID to update an item");
            }



        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            RefreshGridView();
        }

        private void dgvgerecht_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _barcode = barcodeId.Text;

            if (Barcode.Visible == false && barcodeId.Visible == false)
            {
                barcodeId.Visible = true;
                Barcode.Visible = true;
                txtId.Visible = false;
                lblId.Visible = false;
                txtId.Text = "";

            }

            else if (!string.IsNullOrEmpty(_barcode))
            {
                try
                {
                    con.Open();

                    cmd = "delete from gerecht where naam ='" + barcodeId.Text + "' ";
                    command = new NpgsqlCommand(cmd, con);



                    int _result1 = command.ExecuteNonQuery();

                    if (_result1 > 0)
                    {
                        MessageBox.Show("Item removed");


                        Emptytxt();

                        RefreshGridView();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Item not removed");
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Record is not Removed or Found!" + ex);
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
                MessageBox.Show("Please fill in barcode");
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
