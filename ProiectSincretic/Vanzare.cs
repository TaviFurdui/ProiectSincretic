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
    public partial class Vanzare : Form
    {
        public Vanzare()
        {
            InitializeComponent();
        }

        private void buttonVinde_Click(object sender, EventArgs e)
        {
            int stoc, stocAmbalaje, capacitateAmbalaj;
            MySqlCommand cmdSelect = new MySqlCommand("SELECT stoc from produse where IdProdus = @IdProdus", DBConnexion.con);
            cmdSelect.Parameters.AddWithValue("@IdProdus", Convert.ToInt32(textBoxIdProdus.Text));

            if (cmdSelect.ExecuteScalar() == null || Convert.ToInt32(cmdSelect.ExecuteScalar()) <= 0 || Convert.ToInt32(cmdSelect.ExecuteScalar()) - Convert.ToInt32(textBoxCantitate.Text) < 0)
            {
                MessageBox.Show("Nu se poate vinde. Verifica stocul.", "Eroare",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                stoc = Convert.ToInt32(cmdSelect.ExecuteScalar());
                MySqlCommand cmdUpdate = new MySqlCommand("UPDATE `produse` SET stoc = @Stoc WHERE IdProdus = @CodProdus", DBConnexion.con);
                cmdUpdate.Parameters.AddWithValue("@CodProdus", Convert.ToInt32(textBoxIdProdus.Text));
                cmdUpdate.Parameters.AddWithValue("@Stoc", stoc - Convert.ToInt32(textBoxCantitate.Text));
                cmdUpdate.ExecuteNonQuery();

                MySqlCommand cmdSelectStocAmbalaje = new MySqlCommand("SELECT ambalaje.stoc FROM ambalaje INNER JOIN produse ON produse.IdAmbalaj = ambalaje.IdAmbalaj WHERE IdProdus = @IdProdus", DBConnexion.con);
                cmdSelectStocAmbalaje.Parameters.AddWithValue("@IdProdus", Convert.ToInt32(textBoxIdProdus.Text));
                stocAmbalaje = Convert.ToInt32(cmdSelectStocAmbalaje.ExecuteScalar());

                MySqlCommand cmdSelectCapacitateAmbalaje = new MySqlCommand("SELECT ambalaje.capacitate FROM ambalaje INNER JOIN produse ON produse.IdAmbalaj = ambalaje.IdAmbalaj WHERE IdProdus = @IdProdus", DBConnexion.con);
                cmdSelectCapacitateAmbalaje.Parameters.AddWithValue("@IdProdus", Convert.ToInt32(textBoxIdProdus.Text));
                capacitateAmbalaj = Convert.ToInt32(cmdSelectCapacitateAmbalaje.ExecuteScalar());

                MySqlCommand cmdUpdateAmbalaje = new MySqlCommand("UPDATE `ambalaje` INNER JOIN produse ON ambalaje.IdAmbalaj = produse.IdAmbalaj SET ambalaje.stoc = @Stoc WHERE IdProdus = @CodProdus", DBConnexion.con);
                cmdUpdateAmbalaje.Parameters.AddWithValue("@CodProdus", Convert.ToInt32(textBoxIdProdus.Text));
                cmdUpdateAmbalaje.Parameters.AddWithValue("@Stoc", stocAmbalaje - Math.Ceiling( Convert.ToDecimal(textBoxCantitate.Text) / capacitateAmbalaj ));
                cmdUpdateAmbalaje.ExecuteNonQuery();

                MySqlCommand cmdInsertIesiri = new MySqlCommand("INSERT INTO `dateiesire`(`IdProdus`, `DataIesire`, `CantitateVanduta`) VALUES (@IdProdus, @DataIesire, @Cantitate)", DBConnexion.con);
                cmdInsertIesiri.Parameters.AddWithValue("@IdProdus", Convert.ToInt32(textBoxIdProdus.Text));
                cmdInsertIesiri.Parameters.AddWithValue("@DataIesire", dateTimePicker.Value.Date);
                cmdInsertIesiri.Parameters.AddWithValue("@Cantitate", Convert.ToInt32(textBoxCantitate.Text));
                cmdInsertIesiri.ExecuteNonQuery();

                MessageBox.Show("Stocul s-a modificat cu succes.", "Succes",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
