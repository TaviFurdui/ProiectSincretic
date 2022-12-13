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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DBConnexion.con.Open();
        }

        private void buttonAddMaterial_Click(object sender, EventArgs e)
        {
            var adaugareMaterial = new AdaugareMaterial();
            adaugareMaterial.Show();
        }

        private void buttonAddAmbalaj_Click(object sender, EventArgs e)
        {
            var adaugareAmbalaj = new AdaugareAmbalaj();
            adaugareAmbalaj.Show();
        }

        private void buttonAfisareMaterial_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM produse", DBConnexion.con);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dt;
            dataGridView1.DataSource = bSource;
        }

        private void buttonAfisareAmbalaj_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM ambalaje", DBConnexion.con);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dt;
            dataGridView1.DataSource = bSource;
        }

        private void buttonAfisareTransport_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM mijloacetransport ORDER BY Capacitate DESC", DBConnexion.con);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dt;
            dataGridView1.DataSource = bSource;
        }

        private void buttonRaportIntrari_Click(object sender, EventArgs e)
        {
            var raportIntrari = new RaportIntrari();
            raportIntrari.Show();
        }

        private void buttonRaportIesiri_Click(object sender, EventArgs e)
        {
            var raportIesire = new RaportIesiri();
            raportIesire.Show();
        }

        private void buttonVanzare_Click(object sender, EventArgs e)
        {
            var vanzare = new Vanzare();
            vanzare.Show();
        }
    }
}
