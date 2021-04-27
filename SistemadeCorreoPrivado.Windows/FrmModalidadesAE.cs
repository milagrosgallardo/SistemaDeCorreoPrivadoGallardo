using SistemadeCorreoPrivado.BL.Entidades;
using System;
using System.Windows.Forms;

namespace SistemadeCorreoPrivado.Windows
{
    public partial class FrmModalidadesAE : Form
    {
        public FrmModalidadesAE()
        {
            InitializeComponent();
        }
        private Modalidad modalidad;
        private void FrmModalidadesAE_Load(object sender, EventArgs e)
        {

        }
        public void SetModalidad(Modalidad modalidad)
        {
            this.modalidad = modalidad;
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (modalidad == null)
                {
                    modalidad = new Modalidad();
                }

                modalidad.NombreModalidad = txtModalidades.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtModalidades.Text) || string.IsNullOrWhiteSpace(txtModalidades.Text))
            {
                valido = false;
                errorProvider1.SetError(txtModalidades, "El nombre de la Modalidad es requerido");
            }

            return valido;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (modalidad != null)
            {
                txtModalidades.Text = modalidad.NombreModalidad;
            }
        }
        public Modalidad GetModalidad()
        {
            return modalidad;
        }
        private void txtModalidades_TextChanged(object sender, EventArgs e)
        {
            txtModalidades.SelectAll();
        }
    }
}

