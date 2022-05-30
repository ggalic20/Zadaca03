using DBLayer;
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
using Zadaca03.Repository;

namespace Zadaca03
{
    public partial class FrmEvidencija : Form
    {
        public FrmEvidencija()
        {
            InitializeComponent();
        }


        private void ShowOpremas()
        {
            

            List<Oprema> opremas = OpremaRepos.GetOpremas();
            dgvEvidencija.DataSource = opremas;
        }

        private void dgvEvidencija_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmEvidencija_Load_1(object sender, EventArgs e)
        {
            DB.SetConfiguration("ggalic20_DB", "ggalic20", "-V^DAfac");
            ShowOpremas();
        }

        private void btnDodavanje_Click(object sender, EventArgs e)
        {
            Oprema oprema = new Oprema();
            FrmEdit frmForma = new FrmEdit(oprema);
                frmForma.ShowDialog();
           
        }

        private void btnBrisanje_Click(object sender, EventArgs e)
        {
            Oprema oprema = dgvEvidencija.CurrentRow.DataBoundItem as Oprema;
            if(oprema != null)
            {
                string sql = $"DELETE FROM Oprema WHERE id={oprema.id}";
                DB.OpenConnection();
                DB.ExecuteCommand(sql);
                DB.CloseConnection();
                ShowOpremas();
            }
          
        }

        private void btnUredivanje_Click(object sender, EventArgs e)
        {
            Oprema oprema = dgvEvidencija.CurrentRow.DataBoundItem as Oprema;
            FrmEdit frm= new FrmEdit(oprema);
            frm.ShowDialog();
            Repository.OpremaRepos.UpdateObject(oprema);
            ShowOpremas();
        }
    }
}
