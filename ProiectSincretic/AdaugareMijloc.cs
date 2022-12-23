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
    public partial class AdaugareMijloc : Form
    {
        public AdaugareMijloc()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MySqlCommand cmdInsert = new MySqlCommand("INSERT INTO `mijloacetransport` (`NumeMijlocTransport`, `Disponibile`, `Capacitate`) VALUES (@NumeMijlocTransport, @Disponibile, @Capacitate)", DBConnexion.con);
            cmdInsert.Parameters.AddWithValue("@NumeMijlocTransport", textBoxNume.Text);
            cmdInsert.Parameters.AddWithValue("@Disponibile", Convert.ToInt32(textBoxNumar.Text));
            cmdInsert.Parameters.AddWithValue("@Capacitate", Convert.ToInt32(textBoxCapacitate.Text));
            cmdInsert.ExecuteNonQuery();
            MessageBox.Show("Inserarea a fost un succes.", "Succes",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
