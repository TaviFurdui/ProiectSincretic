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
    public partial class SelectareMijloc : Form
    {
        public SelectareMijloc()
        {
            InitializeComponent();
        }
        // SET GLOBAL delayed_insert_timeout = 172800 ( 2 zile )
        private void SelectareMijloc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM dateiesire where trimis=0", DBConnexion.con);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dt;
            dataGridView1.DataSource = bSource;

            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM mijloacetransport WHERE status=='disponibil'", DBConnexion.con);
            MySqlDataAdapter sda1 = new MySqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            cmd1.ExecuteNonQuery();
            BindingSource bSource1 = new BindingSource();
            bSource1.DataSource = dt1;
            dataGridView2.DataSource = bSource1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int selectedRowCount1 = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            int selectedRowCount2 = dataGridView2.Rows.GetRowCount(DataGridViewElementStates.Selected);
            int suma = 0;

            if (selectedRowCount1 > 0)
            {
                for (int i = 0; i < selectedRowCount1; i++)
                {
                    suma += Convert.ToInt32(dataGridView1.SelectedRows[i].Cells[3].Value);
                }

                if (selectedRowCount2 == 1)
                {
                    Console.WriteLine(dataGridView2.SelectedRows[selectedRowCount2 - 1].Cells[2].Value.ToString());
                    if (dataGridView2.SelectedRows[selectedRowCount2 - 1].Cells[2].Value.ToString() == "disponibil")
                    {

                        if (suma > Convert.ToInt32(dataGridView1.SelectedRows[selectedRowCount2 - 1].Cells[3].Value))
                        {
                            MessageBox.Show("Vehiculul nu are capacitatea suficienta!", "Eroare",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            for (int i = 0; i < selectedRowCount1; i++)
                            {
                                MySqlCommand cmdUpdate = new MySqlCommand("UPDATE `dateiesire` SET trimis=1 WHERE IdVanzare = @IdVanzare", DBConnexion.con);
                                cmdUpdate.Parameters.AddWithValue("@IdVanzare", dataGridView1.SelectedRows[i].Cells[0].Value);
                                cmdUpdate.ExecuteNonQuery();
                            }
                            if (selectedRowCount2 == 1)
                            {
                                MySqlCommand cmdUpdate = new MySqlCommand("UPDATE `mijloacetransport` SET status='plecat' WHERE IdMijlocTransport = @IdMijlocTransport", DBConnexion.con);
                                cmdUpdate.Parameters.AddWithValue("@IdMijlocTransport", dataGridView2.SelectedRows[selectedRowCount2 - 1].Cells[0].Value);
                                cmdUpdate.ExecuteNonQuery();
                                MessageBox.Show("Vehiculul a fost incarcat cu materialele selectate.", "Succes",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                                MySqlCommand cmdInsert = new MySqlCommand("INSERT INTO `datemijloacetransport` ( IdMijlocTransport, DataPlecare, DataIntoarcere ) VALUES (@IdMijlocTransport,@DataPlecare,@DataIntoarcere)", DBConnexion.con);
                                cmdInsert.Parameters.AddWithValue("@IdMijlocTransport", dataGridView2.SelectedRows[selectedRowCount2 - 1].Cells[0].Value);
                                cmdInsert.Parameters.AddWithValue("@DataPlecare", dateTimePicker1.Value.Date);
                                cmdInsert.Parameters.AddWithValue("@DataIntoarcere", dateTimePicker2.Value.Date);
                                cmdInsert.ExecuteNonQuery();

                                LoadData();
                                dataGridView1.Update();
                                dataGridView1.Refresh();
                                dataGridView2.Update();
                                dataGridView2.Refresh();

                            }
                            else
                            {
                                MessageBox.Show("Selecteaza mijlocul de transport! Trebuie ales doar unul.", "Eroare",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mijlocul de transport selectat nu este disponibil.", "Eroare",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecteaza materialele!", "Eroare",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedRowCount2 = dataGridView2.Rows.GetRowCount(DataGridViewElementStates.Selected);

            MySqlCommand cmdUpdate = new MySqlCommand("UPDATE `mijloacetransport` SET status='disponibil' WHERE IdMijlocTransport = @IdMijlocTransport", DBConnexion.con);
            cmdUpdate.Parameters.AddWithValue("@IdMijlocTransport", dataGridView2.SelectedRows[selectedRowCount2 - 1].Cells[0].Value);
            cmdUpdate.ExecuteNonQuery();

            LoadData();
            dataGridView1.Update();
            dataGridView1.Refresh();
            dataGridView2.Update();
            dataGridView2.Refresh();
        }
    }
}
