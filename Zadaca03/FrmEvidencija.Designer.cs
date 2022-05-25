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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBrisanje = new System.Windows.Forms.Button();
            this.btnDodavanje = new System.Windows.Forms.Button();
            this.btnUredivanje = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(594, 279);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnBrisanje
            // 
            this.btnBrisanje.Location = new System.Drawing.Point(19, 324);
            this.btnBrisanje.Name = "btnBrisanje";
            this.btnBrisanje.Size = new System.Drawing.Size(88, 43);
            this.btnBrisanje.TabIndex = 1;
            this.btnBrisanje.Text = "Brisanje";
            this.btnBrisanje.UseVisualStyleBackColor = true;
            // 
            // btnDodavanje
            // 
            this.btnDodavanje.Location = new System.Drawing.Point(130, 322);
            this.btnDodavanje.Name = "btnDodavanje";
            this.btnDodavanje.Size = new System.Drawing.Size(154, 44);
            this.btnDodavanje.TabIndex = 2;
            this.btnDodavanje.Text = "Dodavanje";
            this.btnDodavanje.UseVisualStyleBackColor = true;
            // 
            // btnUredivanje
            // 
            this.btnUredivanje.Location = new System.Drawing.Point(22, 392);
            this.btnUredivanje.Name = "btnUredivanje";
            this.btnUredivanje.Size = new System.Drawing.Size(125, 33);
            this.btnUredivanje.TabIndex = 3;
            this.btnUredivanje.Text = "Uređivanje";
            this.btnUredivanje.UseVisualStyleBackColor = true;
            // 
            // FrmEvidencija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUredivanje);
            this.Controls.Add(this.btnDodavanje);
            this.Controls.Add(this.btnBrisanje);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmEvidencija";
            this.Text = "Evidencija";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBrisanje;
        private System.Windows.Forms.Button btnDodavanje;
        private System.Windows.Forms.Button btnUredivanje;
    }
}

