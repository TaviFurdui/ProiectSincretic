
namespace ProiectSincretic
{
    partial class Vanzare
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIdProdus = new System.Windows.Forms.TextBox();
            this.buttonVinde = new System.Windows.Forms.Button();
            this.textBoxCantitate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ce vinzi?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id produs";
            // 
            // textBoxIdProdus
            // 
            this.textBoxIdProdus.Location = new System.Drawing.Point(35, 67);
            this.textBoxIdProdus.Name = "textBoxIdProdus";
            this.textBoxIdProdus.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdProdus.TabIndex = 2;
            // 
            // buttonVinde
            // 
            this.buttonVinde.Location = new System.Drawing.Point(35, 241);
            this.buttonVinde.Name = "buttonVinde";
            this.buttonVinde.Size = new System.Drawing.Size(100, 39);
            this.buttonVinde.TabIndex = 3;
            this.buttonVinde.Text = "Vinde";
            this.buttonVinde.UseVisualStyleBackColor = true;
            this.buttonVinde.Click += new System.EventHandler(this.buttonVinde_Click);
            // 
            // textBoxCantitate
            // 
            this.textBoxCantitate.Location = new System.Drawing.Point(35, 119);
            this.textBoxCantitate.Name = "textBoxCantitate";
            this.textBoxCantitate.Size = new System.Drawing.Size(100, 20);
            this.textBoxCantitate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantitate";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(35, 180);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cand vinzi?";
            // 
            // Vanzare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 314);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBoxCantitate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonVinde);
            this.Controls.Add(this.textBoxIdProdus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Vanzare";
            this.Text = "Vanzare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIdProdus;
        private System.Windows.Forms.Button buttonVinde;
        private System.Windows.Forms.TextBox textBoxCantitate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label4;
    }
}