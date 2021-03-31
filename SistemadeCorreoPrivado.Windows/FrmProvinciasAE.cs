using SistemadeCorreoPrivado.BL.Entidades;
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
    public partial class FrmProvinciasAE : Form
    {
        public FrmProvinciasAE()
        {
            InitializeComponent();
        }
        private Provincia provincia;
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public void SetProvincia(Provincia provincia)
        {
            this.provincia = provincia;
        }
        private void FrmProvinciasAE_Load(object sender, EventArgs e)
        {

        }

        public Provincia GetProvincia()
        {
            return provincia;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (provincia == null)
                {
                    provincia= new Provincia();
                }

                provincia.NombreProvincia = txtProvincia.Text;
                DialogResult = DialogResult.OK;
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (provincia != null)
            {
                txtProvincia.Text = provincia.NombreProvincia;
            }
        }
        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtProvincia.Text) || string.IsNullOrWhiteSpace(txtProvincia.Text))
            {
                valido = false;
                errorProvider1.SetError(txtProvincia, "El nombre de la provincia es requerido");
            }

            return valido;
        }

        private void txtProvincia_TextChanged(object sender, EventArgs e)
        {
            txtProvincia.SelectAll();
        }
    }
}
