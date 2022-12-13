using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectSincretic
{
    public partial class AdaugareMaterial : Form
    {
        public AdaugareMaterial()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int stoc;
            MySqlCommand cmdSelect = new MySqlCommand("SELECT stoc from produse where IdProdus = @IdProdus", DBConnexion.con);
            cmdSelect.Parameters.AddWithValue("@IdProdus", Convert.ToInt32(textBoxCodProdus.Text));

            if (cmdSelect.ExecuteScalar() == null)
            {
                MySqlCommand cmdInsert = new MySqlCommand("INSERT INTO `produse`(`IdProdus`, `IdAmbalaj`, `NumeProdus`, `Stoc`) VALUES (@CodProdus, @CodAmbalaj, @NumeProdus, @CantitatePrimita)", DBConnexion.con);
                cmdInsert.Parameters.AddWithValue("@CodProdus", Convert.ToInt32(textBoxCodProdus.Text));
                cmdInsert.Parameters.AddWithValue("@CodAmbalaj", Convert.ToInt32(textBoxCodAmbalaj.Text));
                cmdInsert.Parameters.AddWithValue("@NumeProdus", textBoxNumeProdus.Text);
                cmdInsert.Parameters.AddWithValue("@CantitatePrimita", Convert.ToInt32(textBoxCantitate.Text));
                cmdInsert.ExecuteNonQuery();
                MessageBox.Show("Inserarea a fost un succes.", "Succes",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                stoc = Convert.ToInt32(cmdSelect.ExecuteScalar());
                MySqlCommand cmdInsert = new MySqlCommand("UPDATE `produse` SET stoc = @Stoc WHERE IdProdus = @CodProdus", DBConnexion.con);
                cmdInsert.Parameters.AddWithValue("@CodProdus", Convert.ToInt32(textBoxCodProdus.Text));
                cmdInsert.Parameters.AddWithValue("@Stoc", stoc + Convert.ToInt32(textBoxCantitate.Text));
                cmdInsert.ExecuteNonQuery();
                MessageBox.Show("Materialul si-a modificat stocul cu succes.", "Succes",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //IFormatProvider culture = new CultureInfo("en-US", true);
            //DateTime dateVal = DateTime.ParseExact(dateTimePicker.Text, "yyyy-MM-dd", culture);

            MySqlCommand cmdInsertIntrari = new MySqlCommand("INSERT INTO `dateintrare`(`IdProdus`, `DataIntrare`, `CantitatePrimita`) VALUES (@IdProdus, @DataIntrare, @Cantitate)", DBConnexion.con);
            cmdInsertIntrari.Parameters.AddWithValue("@IdProdus", Convert.ToInt32(textBoxCodProdus.Text));
            cmdInsertIntrari.Parameters.AddWithValue("@DataIntrare", dateTimePicker.Value.Date);
            cmdInsertIntrari.Parameters.AddWithValue("@Cantitate", Convert.ToInt32(textBoxCantitate.Text));
            cmdInsertIntrari.ExecuteNonQuery();
        }
    }
}
