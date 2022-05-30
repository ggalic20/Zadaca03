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
    public partial class FrmEdit : Form
    {
        Oprema oprema;
        public FrmEdit(Oprema oprema)
        {
            InitializeComponent();
            this.oprema = oprema;
        }

        private void FrmEdit_Load(object sender, EventArgs e)
        {
            if (oprema != null)
            {
                txtIzvor.Text = oprema.IzvorFinanciranja;
                txtNaziv.Text = oprema.NazivOpreme;
                txtOpis.Text = oprema.OpisOpreme;
                txtProjekt.Text = oprema.NazivProjekta;
                cboCIP.Text = oprema.Zaprimio;
                cboVrsta.Text = oprema.VrstaOpreme;
                dtpZaprimanja.Value = oprema.DatumZaprimanja;
                dtpZaprimanja.Enabled = false;
            }
            else return;
            
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            Oprema oprema1 = new Oprema(); 
            oprema.IzvorFinanciranja = txtIzvor.Text;
            oprema.NazivOpreme = txtNaziv.Text;
            oprema.OpisOpreme = txtOpis.Text;
            oprema.NazivProjekta = txtProjekt.Text;
            oprema.Zaprimio = cboCIP.Text;
            oprema.VrstaOpreme = cboVrsta.Text;
            oprema.DatumZaprimanja = dtpZaprimanja.Value;
            Repository.OpremaRepos.UpdateObject(oprema1);
            this.Close();
        }
    }
}
