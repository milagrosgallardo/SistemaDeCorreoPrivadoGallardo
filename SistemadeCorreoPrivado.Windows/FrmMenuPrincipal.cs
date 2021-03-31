using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemadeCorreoPrivado.Windows
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnProvincias_Click(object sender, EventArgs e)
        {
            FrmProvincias frm = new FrmProvincias();
            frm.ShowDialog(this);
        }

        private void BtnModalidades_Click(object sender, EventArgs e)
        {
            FrmModalidades frm = new FrmModalidades();
            frm.ShowDialog(this);
        }

        private void BtnTiposDeDocumentos_Click(object sender, EventArgs e)
        {
            FrmTiposDeDocumentos frm = new FrmTiposDeDocumentos();
            frm.ShowDialog(this);
        }

        private void BtnZonas_Click(object sender, EventArgs e)
        {
            FrmZonas frm = new FrmZonas();
            frm.ShowDialog(this);
        }

        private void BtnTareas_Click(object sender, EventArgs e)
        {
            FrmTareas frm = new FrmTareas();
            frm.ShowDialog(this);
        }
    }
}
