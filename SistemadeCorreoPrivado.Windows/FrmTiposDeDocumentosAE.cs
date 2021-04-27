using SistemadeCorreoPrivado.BL.Entidades;
using System;
using System.Windows.Forms;

namespace SistemadeCorreoPrivado.Windows
{
    public partial class FrmTiposDeDocumentosAE : Form
    {
        public FrmTiposDeDocumentosAE()
        {
            InitializeComponent();
        }

        private void FrmTiposDeDocumentosAE_Load(object sender, EventArgs e)
        {

        }
        private TiposDeDocumento tiposDeDocumento;
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public void SetTiposDeDocumento(TiposDeDocumento tiposDeDocumento)
        {
            this.tiposDeDocumento = tiposDeDocumento;
        }

        public TiposDeDocumento GetTiposDeDocumento()
        {
            return tiposDeDocumento;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (tiposDeDocumento == null)
                {
                    tiposDeDocumento = new TiposDeDocumento();
                }

                tiposDeDocumento.NombreDocumento =txtTiposDeDocumentos.Text;
                DialogResult = DialogResult.OK;
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (tiposDeDocumento != null)
            {
                txtTiposDeDocumentos.Text = tiposDeDocumento.NombreDocumento;
            }
        }
        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtTiposDeDocumentos.Text) || string.IsNullOrWhiteSpace(txtTiposDeDocumentos.Text))
            {
                valido = false;
                errorProvider1.SetError(txtTiposDeDocumentos, "El nombre de el Tipo De Documento es requerido");
            }

            return valido;
        }

        private void txtTiposDeDocumentos_TextChanged(object sender, EventArgs e)
        {
            txtTiposDeDocumentos.SelectAll();
        }
    }
}
