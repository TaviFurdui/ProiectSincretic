
namespace ProiectSincretic
{
    partial class AdaugareAmbalaj
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxStoc = new System.Windows.Forms.TextBox();
            this.textBoxCapacitate = new System.Windows.Forms.TextBox();
            this.textBoxNumeAmbalaj = new System.Windows.Forms.TextBox();
            this.textBoxCodAmbalaj = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Stoc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Capacitate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nume ambalaj";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cod ambalaj";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(160, 281);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(200, 41);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Adauga ambalaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxStoc
            // 
            this.textBoxStoc.Location = new System.Drawing.Point(160, 222);
            this.textBoxStoc.Name = "textBoxStoc";
            this.textBoxStoc.Size = new System.Drawing.Size(200, 20);
            this.textBoxStoc.TabIndex = 14;
            // 
            // textBoxCapacitate
            // 
            this.textBoxCapacitate.Location = new System.Drawing.Point(160, 172);
            this.textBoxCapacitate.Name = "textBoxCapacitate";
            this.textBoxCapacitate.Size = new System.Drawing.Size(200, 20);
            this.textBoxCapacitate.TabIndex = 13;
            // 
            // textBoxNumeAmbalaj
            // 
            this.textBoxNumeAmbalaj.Location = new System.Drawing.Point(160, 121);
            this.textBoxNumeAmbalaj.Name = "textBoxNumeAmbalaj";
            this.textBoxNumeAmbalaj.Size = new System.Drawing.Size(200, 20);
            this.textBoxNumeAmbalaj.TabIndex = 12;
            // 
            // textBoxCodAmbalaj
            // 
            this.textBoxCodAmbalaj.Location = new System.Drawing.Point(160, 73);
            this.textBoxCodAmbalaj.Name = "textBoxCodAmbalaj";
            this.textBoxCodAmbalaj.Size = new System.Drawing.Size(200, 20);
            this.textBoxCodAmbalaj.TabIndex = 11;
            // 
            // AdaugareAmbalaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 396);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxStoc);
            this.Controls.Add(this.textBoxCapacitate);
            this.Controls.Add(this.textBoxNumeAmbalaj);
            this.Controls.Add(this.textBoxCodAmbalaj);
            this.Name = "AdaugareAmbalaj";
            this.Text = "Adaugare Ambalaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxStoc;
        private System.Windows.Forms.TextBox textBoxCapacitate;
        private System.Windows.Forms.TextBox textBoxNumeAmbalaj;
        private System.Windows.Forms.TextBox textBoxCodAmbalaj;
    }
}