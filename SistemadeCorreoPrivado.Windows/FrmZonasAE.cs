using SistemadeCorreoPrivado.BL.Entidades;
using System;
using System.Windows.Forms;

namespace SistemadeCorreoPrivado.Windows
{
    public partial class FrmZonasAE : Form
    {
        public FrmZonasAE()
        {
            InitializeComponent();
        }

        private void FrmZonasAE_Load(object sender, EventArgs e)
        {

        }
        private Zona zona;
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public void SetZona(Zona zona)
        {
            this.zona = zona;
        }


        public Zona GetZona()
        {
            return zona;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (zona == null)
                {
                    zona = new Zona();
                }

                zona.NombreZona = txtZonas.Text;
                DialogResult = DialogResult.OK;
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (zona != null)
            {
                txtZonas.Text = zona.NombreZona;
            }
        }
        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtZonas.Text) || string.IsNullOrWhiteSpace(txtZonas.Text))
            {
                valido = false;
                errorProvider1.SetError(txtZonas, "El nombre de la zona es requerido");
            }

            return valido;
        }

        private void txtZonas_TextChanged(object sender, EventArgs e)
        {
            txtZonas.SelectAll();
        }
    }
}

