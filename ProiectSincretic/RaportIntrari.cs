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
    public partial class RaportIntrari : Form
    {
        public RaportIntrari()
        {
            InitializeComponent();
        }

        private void buttonTotalIntrari_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT SUM(CantitatePrimita) FROM dateintrare WHERE DataIntrare > @data1 AND DataIntrare < @data2 AND IdProdus=@id_produs", DBConnexion.con);
            cmd.Parameters.AddWithValue("@data1", dateTimePicker1.Value.Date);
            cmd.Parameters.AddWithValue("@data2", dateTimePicker2.Value.Date);
            cmd.Parameters.AddWithValue("@id_produs", Convert.ToInt32(textBoxProdus.Text));
            string suma = cmd.ExecuteScalar().ToString();
            Console.WriteLine(cmd.ExecuteScalar());
            if (cmd.ExecuteScalar().ToString() == "")
            {
                suma = "0";
            }
            labelAfisare.Text = "Total intrari intre cele doua date: " + suma;
        }
    }
}
