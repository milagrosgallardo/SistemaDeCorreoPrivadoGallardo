using SistemadeCorreoPrivado.BL.Entidades;
using System;
using System.Windows.Forms;

namespace SistemadeCorreoPrivado.Windows
{
    public partial class FrmTareasAE : Form
    {
        public FrmTareasAE()
        {
            InitializeComponent();
        }
        private Tarea tarea;
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public void SetTarea(Tarea tarea)
        {
            this.tarea = tarea;
        }
       
        public Tarea GetTarea()
        {
            return tarea;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (tarea == null)
                {
                    tarea = new Tarea();
                }

                tarea.NombreTarea = txtTareas.Text;
                DialogResult = DialogResult.OK;
            }
        }
        protected override void OnLoad(EventArgs e)
        {  
            base.OnLoad(e);
            if (tarea != null)
            {
                txtTareas.Text = tarea.NombreTarea;
            }
        }
        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtTareas.Text) || string.IsNullOrWhiteSpace(txtTareas.Text))
            {
                valido = false;
                errorProvider1.SetError(txtTareas, "El nombre de la Tarea es requerido");
            }

            return valido;
        }

        private void txtTareas_TextChanged(object sender, EventArgs e)
        {
            txtTareas.SelectAll();
        }

        private void FrmTareasAE_Load(object sender, EventArgs e)
        {

        }
    }
}
