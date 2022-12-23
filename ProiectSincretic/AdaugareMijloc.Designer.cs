
namespace ProiectSincretic
{
    partial class AdaugareMijloc
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxNumar = new System.Windows.Forms.TextBox();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCapacitate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Numar de vehicule";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nume mijloc transport";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(67, 228);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(200, 41);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Adauga mijloc de transport";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxNumar
            // 
            this.textBoxNumar.Location = new System.Drawing.Point(67, 132);
            this.textBoxNumar.Name = "textBoxNumar";
            this.textBoxNumar.Size = new System.Drawing.Size(200, 20);
            this.textBoxNumar.TabIndex = 12;
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(67, 84);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(200, 20);
            this.textBoxNume.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Capacitate vehicul";
            // 
            // textBoxCapacitate
            // 
            this.textBoxCapacitate.Location = new System.Drawing.Point(67, 180);
            this.textBoxCapacitate.Name = "textBoxCapacitate";
            this.textBoxCapacitate.Size = new System.Drawing.Size(200, 20);
            this.textBoxCapacitate.TabIndex = 19;
            // 
            // AdaugareMijloc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 297);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCapacitate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxNumar);
            this.Controls.Add(this.textBoxNume);
            this.Name = "AdaugareMijloc";
            this.Text = "AdaugareMijloc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxNumar;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCapacitate;
    }
}