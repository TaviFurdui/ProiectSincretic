using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectSincretic
{
    public partial class RaportMijloace : Form
    {
        public RaportMijloace()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand(@"SELECT mijloacetransport.NumeMijlocTransport AS ocupate
                FROM mijloacetransport
                INNER JOIN datemijloacetransport
                ON datemijloacetransport.IdMijlocTransport = mijloacetransport.IdMijlocTransport
                WHERE datemijloacetransport.DataPlecare <= @data1
                AND datemijloacetransport.DataIntoarcere >= @data1", DBConnexion.con);
            cmd.Parameters.AddWithValue("@data1", dateTimePicker1.Value.Date);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dt;
            dataGridView1.DataSource = bSource;

            MySqlCommand cmd1 = new MySqlCommand(@"SELECT mijloacetransport.NumeMijlocTransport FROM mijloacetransport
            EXCEPT (
                SELECT mijloacetransport.NumeMijlocTransport AS disponibile
                FROM mijloacetransport
                INNER JOIN datemijloacetransport
                ON datemijloacetransport.IdMijlocTransport = mijloacetransport.IdMijlocTransport
                WHERE datemijloacetransport.DataPlecare <= @data1
                AND datemijloacetransport.DataIntoarcere >= @data1
            )", DBConnexion.con);
            cmd1.Parameters.AddWithValue("@data1", dateTimePicker1.Value.Date);
            MySqlDataAdapter sda1 = new MySqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            cmd1.ExecuteNonQuery();
            BindingSource bSource1 = new BindingSource();
            bSource1.DataSource = dt1;
            dataGridView2.DataSource = bSource1;
        }
    }
}
