﻿
namespace ProiectSincretic
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddMaterial = new System.Windows.Forms.Button();
            this.buttonAddAmbalaj = new System.Windows.Forms.Button();
            this.buttonAfisareAmbalaj = new System.Windows.Forms.Button();
            this.buttonAfisareMaterial = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAfisareTransport = new System.Windows.Forms.Button();
            this.buttonRaportIntrari = new System.Windows.Forms.Button();
            this.buttonRaportIesiri = new System.Windows.Forms.Button();
            this.buttonVanzare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddMaterial
            // 
            this.buttonAddMaterial.Location = new System.Drawing.Point(50, 33);
            this.buttonAddMaterial.Name = "buttonAddMaterial";
            this.buttonAddMaterial.Size = new System.Drawing.Size(132, 51);
            this.buttonAddMaterial.TabIndex = 2;
            this.buttonAddMaterial.Text = "Adaugare material";
            this.buttonAddMaterial.UseVisualStyleBackColor = true;
            this.buttonAddMaterial.Click += new System.EventHandler(this.buttonAddMaterial_Click);
            // 
            // buttonAddAmbalaj
            // 
            this.buttonAddAmbalaj.Location = new System.Drawing.Point(50, 100);
            this.buttonAddAmbalaj.Name = "buttonAddAmbalaj";
            this.buttonAddAmbalaj.Size = new System.Drawing.Size(132, 51);
            this.buttonAddAmbalaj.TabIndex = 3;
            this.buttonAddAmbalaj.Text = "Adaugare ambalaj";
            this.buttonAddAmbalaj.UseVisualStyleBackColor = true;
            this.buttonAddAmbalaj.Click += new System.EventHandler(this.buttonAddAmbalaj_Click);
            // 
            // buttonAfisareAmbalaj
            // 
            this.buttonAfisareAmbalaj.Location = new System.Drawing.Point(188, 100);
            this.buttonAfisareAmbalaj.Name = "buttonAfisareAmbalaj";
            this.buttonAfisareAmbalaj.Size = new System.Drawing.Size(132, 51);
            this.buttonAfisareAmbalaj.TabIndex = 5;
            this.buttonAfisareAmbalaj.Text = "Afisare ambalaj";
            this.buttonAfisareAmbalaj.UseVisualStyleBackColor = true;
            this.buttonAfisareAmbalaj.Click += new System.EventHandler(this.buttonAfisareAmbalaj_Click);
            // 
            // buttonAfisareMaterial
            // 
            this.buttonAfisareMaterial.Location = new System.Drawing.Point(188, 33);
            this.buttonAfisareMaterial.Name = "buttonAfisareMaterial";
            this.buttonAfisareMaterial.Size = new System.Drawing.Size(132, 51);
            this.buttonAfisareMaterial.TabIndex = 4;
            this.buttonAfisareMaterial.Text = "Afisare material";
            this.buttonAfisareMaterial.UseVisualStyleBackColor = true;
            this.buttonAfisareMaterial.Click += new System.EventHandler(this.buttonAfisareMaterial_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(379, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(505, 358);
            this.dataGridView1.TabIndex = 6;
            // 
            // buttonAfisareTransport
            // 
            this.buttonAfisareTransport.Location = new System.Drawing.Point(50, 170);
            this.buttonAfisareTransport.Name = "buttonAfisareTransport";
            this.buttonAfisareTransport.Size = new System.Drawing.Size(132, 92);
            this.buttonAfisareTransport.TabIndex = 7;
            this.buttonAfisareTransport.Text = "Listare mijloace de transport in ordine descrescatoare in functie de capacitate.";
            this.buttonAfisareTransport.UseVisualStyleBackColor = true;
            this.buttonAfisareTransport.Click += new System.EventHandler(this.buttonAfisareTransport_Click);
            // 
            // buttonRaportIntrari
            // 
            this.buttonRaportIntrari.Location = new System.Drawing.Point(188, 170);
            this.buttonRaportIntrari.Name = "buttonRaportIntrari";
            this.buttonRaportIntrari.Size = new System.Drawing.Size(132, 92);
            this.buttonRaportIntrari.TabIndex = 8;
            this.buttonRaportIntrari.Text = "Raport intrari intre doua date";
            this.buttonRaportIntrari.UseVisualStyleBackColor = true;
            this.buttonRaportIntrari.Click += new System.EventHandler(this.buttonRaportIntrari_Click);
            // 
            // buttonRaportIesiri
            // 
            this.buttonRaportIesiri.Location = new System.Drawing.Point(188, 277);
            this.buttonRaportIesiri.Name = "buttonRaportIesiri";
            this.buttonRaportIesiri.Size = new System.Drawing.Size(132, 92);
            this.buttonRaportIesiri.TabIndex = 9;
            this.buttonRaportIesiri.Text = "Raport iesiri intre doua date";
            this.buttonRaportIesiri.UseVisualStyleBackColor = true;
            this.buttonRaportIesiri.Click += new System.EventHandler(this.buttonRaportIesiri_Click);
            // 
            // buttonVanzare
            // 
            this.buttonVanzare.Location = new System.Drawing.Point(50, 277);
            this.buttonVanzare.Name = "buttonVanzare";
            this.buttonVanzare.Size = new System.Drawing.Size(132, 92);
            this.buttonVanzare.TabIndex = 10;
            this.buttonVanzare.Text = "Vanzare produs";
            this.buttonVanzare.UseVisualStyleBackColor = true;
            this.buttonVanzare.Click += new System.EventHandler(this.buttonVanzare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 416);
            this.Controls.Add(this.buttonVanzare);
            this.Controls.Add(this.buttonRaportIesiri);
            this.Controls.Add(this.buttonRaportIntrari);
            this.Controls.Add(this.buttonAfisareTransport);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAfisareAmbalaj);
            this.Controls.Add(this.buttonAfisareMaterial);
            this.Controls.Add(this.buttonAddAmbalaj);
            this.Controls.Add(this.buttonAddMaterial);
            this.Name = "Form1";
            this.Text = "Pietris SRL";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAddMaterial;
        private System.Windows.Forms.Button buttonAddAmbalaj;
        private System.Windows.Forms.Button buttonAfisareAmbalaj;
        private System.Windows.Forms.Button buttonAfisareMaterial;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAfisareTransport;
        private System.Windows.Forms.Button buttonRaportIntrari;
        private System.Windows.Forms.Button buttonRaportIesiri;
        private System.Windows.Forms.Button buttonVanzare;
    }
}

