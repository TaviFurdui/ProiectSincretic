
namespace ProiectSincretic
{
    partial class AdaugareMaterial
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
            this.textBoxCodProdus = new System.Windows.Forms.TextBox();
            this.textBoxCodAmbalaj = new System.Windows.Forms.TextBox();
            this.textBoxNumeProdus = new System.Windows.Forms.TextBox();
            this.textBoxCantitate = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBoxCodProdus
            // 
            this.textBoxCodProdus.Location = new System.Drawing.Point(136, 52);
            this.textBoxCodProdus.Name = "textBoxCodProdus";
            this.textBoxCodProdus.Size = new System.Drawing.Size(200, 20);
            this.textBoxCodProdus.TabIndex = 0;
            // 
            // textBoxCodAmbalaj
            // 
            this.textBoxCodAmbalaj.Location = new System.Drawing.Point(136, 100);
            this.textBoxCodAmbalaj.Name = "textBoxCodAmbalaj";
            this.textBoxCodAmbalaj.Size = new System.Drawing.Size(200, 20);
            this.textBoxCodAmbalaj.TabIndex = 1;
            // 
            // textBoxNumeProdus
            // 
            this.textBoxNumeProdus.Location = new System.Drawing.Point(136, 151);
            this.textBoxNumeProdus.Name = "textBoxNumeProdus";
            this.textBoxNumeProdus.Size = new System.Drawing.Size(200, 20);
            this.textBoxNumeProdus.TabIndex = 2;
            // 
            // textBoxCantitate
            // 
            this.textBoxCantitate.Location = new System.Drawing.Point(136, 201);
            this.textBoxCantitate.Name = "textBoxCantitate";
            this.textBoxCantitate.Size = new System.Drawing.Size(200, 20);
            this.textBoxCantitate.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(136, 305);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(200, 41);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Adauga produs";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cod produs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cod ambalaj";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nume produs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantitate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data primire";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(136, 250);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 4;
            // 
            // AdaugareMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBoxCantitate);
            this.Controls.Add(this.textBoxNumeProdus);
            this.Controls.Add(this.textBoxCodAmbalaj);
            this.Controls.Add(this.textBoxCodProdus);
            this.Name = "AdaugareMaterial";
            this.Text = "Adaugare Material";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCodProdus;
        private System.Windows.Forms.TextBox textBoxCodAmbalaj;
        private System.Windows.Forms.TextBox textBoxNumeProdus;
        private System.Windows.Forms.TextBox textBoxCantitate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}