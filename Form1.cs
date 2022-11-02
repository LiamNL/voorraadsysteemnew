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
            //hiermee maak je de connection
            conn.Open();
            //hiermee zorg je dat de database open connectie staat voor de applicatie
            NpgsqlCommand comm = new NpgsqlCommand();
            //dit is dat alle commands hierin new worden gemaakt, voor als je al meer commands hebt van dit soort, bijvoorbeeld je hebt een command dat hij data moet vasthouden,
            comm.Connection = conn;
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
            conn.Close();
            //zorg ervoor dat de database gesloten word.


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
    }
}
