using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zadaca03.Models;

namespace Zadaca03
{
    public partial class FrmForma : Form
    {
        
        public FrmForma()
        {
            InitializeComponent();
        }

        private void FrmForma_Load(object sender, EventArgs e)
        {
            List<CIP> CIPs = Repository.CIPRepos.GetCIPs();
            foreach (CIP cip in CIPs)
            {
                cboCIP.Items.Add(cip.ImeiPrezime.ToString());
            }
            DateTime datum = DateTime.Now;
            dtpZaprimanja.Value = datum;
            dtpZaprimanja.Enabled = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Repository.CIPRepos.SaveObject(cboCIP.Text, dtpZaprimanja.Text, txtIzvor.Text, txtOpis.Text, txtNaziv.Text, txtProjekt.Text, cboVrsta.Text);
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboCIP_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
