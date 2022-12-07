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
    public partial class AdaugareAmbalaj : Form
    {
        public AdaugareAmbalaj()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int stoc;
            MySqlCommand cmdSelect = new MySqlCommand("SELECT stoc FROM ambalaje WHERE IdAmbalaj = @CodAmbalaj", DBConnexion.con);
            cmdSelect.Parameters.AddWithValue("@CodAmbalaj", Convert.ToInt32(textBoxCodAmbalaj.Text));

            if (cmdSelect.ExecuteScalar() == null)
            {
                MySqlCommand cmdInsert = new MySqlCommand("INSERT INTO `ambalaje`(`IdAmbalaj`, `NumeAmbalaj`, `Capacitate`, `Stoc`) VALUES (@CodAmbalaj, @NumeAmbalaj, @Capacitate, @Stoc)", DBConnexion.con);
                cmdInsert.Parameters.AddWithValue("@CodAmbalaj", Convert.ToInt32(textBoxCodAmbalaj.Text));
                cmdInsert.Parameters.AddWithValue("@NumeAmbalaj", textBoxNumeAmbalaj.Text);
                cmdInsert.Parameters.AddWithValue("@Capacitate", Convert.ToInt32(textBoxCapacitate.Text));
                cmdInsert.Parameters.AddWithValue("@Stoc", Convert.ToInt32(textBoxStoc.Text));
                cmdInsert.ExecuteNonQuery();
            }
            else
            {
                stoc = Convert.ToInt32(cmdSelect.ExecuteScalar());
                MySqlCommand cmdInsert = new MySqlCommand("UPDATE `ambalaje` SET stoc = @Stoc WHERE IdAmbalaj = @CodAmbalaj", DBConnexion.con);
                cmdInsert.Parameters.AddWithValue("@CodAmbalaj", Convert.ToInt32(textBoxCodAmbalaj.Text));
                cmdInsert.Parameters.AddWithValue("@Stoc", stoc + Convert.ToInt32(textBoxStoc.Text));
                cmdInsert.ExecuteNonQuery();
            }
        }
    }
}
