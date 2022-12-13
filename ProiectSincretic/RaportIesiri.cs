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
    public partial class RaportIesiri : Form
    {
        public RaportIesiri()
        {
            InitializeComponent();
        }

        private void buttonTotalIesiri_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT SUM(CantitatePrimita) FROM dateiesire WHERE DataIesire > @data1 AND DataIesire < @data2 AND IdProdus=@id_produs", DBConnexion.con);
            cmd.Parameters.AddWithValue("@data1", dateTimePicker1.Value.Date);
            cmd.Parameters.AddWithValue("@data2", dateTimePicker2.Value.Date);
            cmd.Parameters.AddWithValue("@id_produs", Convert.ToInt32(textBoxProdus.Text));
            labelAfisare.Text = "Total iesiri intre cele doua date: " + cmd.ExecuteScalar().ToString();
        }
    }
}
