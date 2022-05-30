namespace Zadaca03
{
    partial class FrmEdit
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
            this.cboVrsta = new System.Windows.Forms.ComboBox();
            this.dtpZaprimanja = new System.Windows.Forms.DateTimePicker();
            this.cboCIP = new System.Windows.Forms.ComboBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProjekt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIzvor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboVrsta
            // 
            this.cboVrsta.FormattingEnabled = true;
            this.cboVrsta.Items.AddRange(new object[] {
            "Računalna oprema",
            "Softvare licenca",
            "Printeri i skeneri"});
            this.cboVrsta.Location = new System.Drawing.Point(55, 222);
            this.cboVrsta.Name = "cboVrsta";
            this.cboVrsta.Size = new System.Drawing.Size(162, 24);
            this.cboVrsta.TabIndex = 38;
            // 
            // dtpZaprimanja
            // 
            this.dtpZaprimanja.Location = new System.Drawing.Point(293, 93);
            this.dtpZaprimanja.Name = "dtpZaprimanja";
            this.dtpZaprimanja.Size = new System.Drawing.Size(200, 22);
            this.dtpZaprimanja.TabIndex = 37;
            // 
            // cboCIP
            // 
            this.cboCIP.FormattingEnabled = true;
            this.cboCIP.Location = new System.Drawing.Point(52, 95);
            this.cboCIP.Name = "cboCIP";
            this.cboCIP.Size = new System.Drawing.Size(201, 24);
            this.cboCIP.TabIndex = 36;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(556, 75);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(144, 44);
            this.btnOdustani.TabIndex = 35;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(556, 273);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(144, 44);
            this.btnSpremi.TabIndex = 34;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "Opis opreme";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(55, 295);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(337, 22);
            this.txtOpis.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Osoba koja je zaprimila opremu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Datum i vrijeme zaprimanja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Naziv opreme";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(290, 221);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(165, 22);
            this.txtNaziv.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Naziv projekta";
            // 
            // txtProjekt
            // 
            this.txtProjekt.Location = new System.Drawing.Point(293, 152);
            this.txtProjekt.Name = "txtProjekt";
            this.txtProjekt.Size = new System.Drawing.Size(165, 22);
            this.txtProjekt.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Vrsta opreme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Izvor financiranja";
            // 
            // txtIzvor
            // 
            this.txtIzvor.Location = new System.Drawing.Point(52, 152);
            this.txtIzvor.Name = "txtIzvor";
            this.txtIzvor.Size = new System.Drawing.Size(165, 22);
            this.txtIzvor.TabIndex = 23;
            // 
            // FrmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboVrsta);
            this.Controls.Add(this.dtpZaprimanja);
            this.Controls.Add(this.cboCIP);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProjekt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIzvor);
            this.Name = "FrmEdit";
            this.Text = "FrmEdit";
            this.Load += new System.EventHandler(this.FrmEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboVrsta;
        private System.Windows.Forms.DateTimePicker dtpZaprimanja;
        private System.Windows.Forms.ComboBox cboCIP;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProjekt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIzvor;
    }
}