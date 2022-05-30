namespace Zadaca03
{
    partial class FrmEvidencija
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
            this.dgvEvidencija = new System.Windows.Forms.DataGridView();
            this.btnBrisanje = new System.Windows.Forms.Button();
            this.btnDodavanje = new System.Windows.Forms.Button();
            this.btnUredivanje = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencija)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEvidencija
            // 
            this.dgvEvidencija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvidencija.Location = new System.Drawing.Point(12, 12);
            this.dgvEvidencija.Name = "dgvEvidencija";
            this.dgvEvidencija.RowHeadersWidth = 51;
            this.dgvEvidencija.RowTemplate.Height = 24;
            this.dgvEvidencija.Size = new System.Drawing.Size(1118, 279);
            this.dgvEvidencija.TabIndex = 0;
            this.dgvEvidencija.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvidencija_CellContentClick);
            // 
            // btnBrisanje
            // 
            this.btnBrisanje.Location = new System.Drawing.Point(169, 392);
            this.btnBrisanje.Name = "btnBrisanje";
            this.btnBrisanje.Size = new System.Drawing.Size(115, 33);
            this.btnBrisanje.TabIndex = 1;
            this.btnBrisanje.Text = "Brisanje";
            this.btnBrisanje.UseVisualStyleBackColor = true;
            this.btnBrisanje.Click += new System.EventHandler(this.btnBrisanje_Click);
            // 
            // btnDodavanje
            // 
            this.btnDodavanje.Location = new System.Drawing.Point(22, 321);
            this.btnDodavanje.Name = "btnDodavanje";
            this.btnDodavanje.Size = new System.Drawing.Size(262, 44);
            this.btnDodavanje.TabIndex = 2;
            this.btnDodavanje.Text = "Dodavanje";
            this.btnDodavanje.UseVisualStyleBackColor = true;
            this.btnDodavanje.Click += new System.EventHandler(this.btnDodavanje_Click);
            // 
            // btnUredivanje
            // 
            this.btnUredivanje.Location = new System.Drawing.Point(22, 392);
            this.btnUredivanje.Name = "btnUredivanje";
            this.btnUredivanje.Size = new System.Drawing.Size(115, 33);
            this.btnUredivanje.TabIndex = 3;
            this.btnUredivanje.Text = "Uređivanje";
            this.btnUredivanje.UseVisualStyleBackColor = true;
            this.btnUredivanje.Click += new System.EventHandler(this.btnUredivanje_Click);
            // 
            // FrmEvidencija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 515);
            this.Controls.Add(this.btnUredivanje);
            this.Controls.Add(this.btnDodavanje);
            this.Controls.Add(this.btnBrisanje);
            this.Controls.Add(this.dgvEvidencija);
            this.Name = "FrmEvidencija";
            this.Text = "Evidencija";
            this.Activated += new System.EventHandler(this.FrmEvidencija_Load_1);
            this.Load += new System.EventHandler(this.FrmEvidencija_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencija)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEvidencija;
        private System.Windows.Forms.Button btnBrisanje;
        private System.Windows.Forms.Button btnDodavanje;
        private System.Windows.Forms.Button btnUredivanje;
    }
}

