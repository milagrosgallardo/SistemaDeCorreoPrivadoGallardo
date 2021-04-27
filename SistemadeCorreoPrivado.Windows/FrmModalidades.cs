using SistemadeCorreoPrivado.BL.Entidades;
using SistemadeCorreoPrivado.Servicios.Servicios;
using SistemadeCorreoPrivado.Servicios.Servicios.facades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemadeCorreoPrivado.Windows
{
    public partial class FrmModalidades : Form
    {
        public FrmModalidades()
        {
            InitializeComponent();
        }

        private void TsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private IServiciosModalidades _servicio;
        List<Modalidad> _lista;
        private void FrmModalidades_Load(object sender, EventArgs e)
        {
            _servicio = new ServiciosModalidades();
            try
            {
                _lista = _servicio.GetModalidades();
                MostrarDatosEnGrilla();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void MostrarDatosEnGrilla()
        {
            DgvDatosModalidad.Rows.Clear();
            foreach (var modalidad in _lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, modalidad);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DgvDatosModalidad.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Modalidad modalidad)
        {
            r.Cells[CmnModalidades.Index].Value = modalidad.NombreModalidad;
            r.Tag = modalidad;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(DgvDatosModalidad);
            return r;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TsbNuevo_Click(object sender, EventArgs e)
        {

            FrmModalidadesAE frm = new FrmModalidadesAE();
            frm.Text = "Agregar una Modalidad";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    Modalidad modalidad = frm.GetModalidad();

                    if (!_servicio.Existe(modalidad))
                    {
                        _servicio.Guardar(modalidad);
                        DataGridViewRow r = ConstruirFila();
                        SetearFila(r, modalidad);
                        AgregarFila(r);
                        MessageBox.Show("Registro Agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Registro ya existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TsbBorrar_Click(object sender, EventArgs e)
        {
            if (DgvDatosModalidad.SelectedRows.Count > 0)
            {
                DataGridViewRow r = DgvDatosModalidad.SelectedRows[0];
                Modalidad modalidad = (Modalidad)r.Tag;

                DialogResult dr = MessageBox.Show($@"¿Desea dar de baja el registro seleccionado: {modalidad.NombreModalidad}?",
                    @"Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (dr == DialogResult.Yes)
                {
                 
                    try
                    {
                        _servicio.Borrar(modalidad.ModalidadId);
                        DgvDatosModalidad.Rows.Remove(r);
                        MessageBox.Show(@"Registro Borrado", @"Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void TsbEditar_Click(object sender, EventArgs e)
        {
            if (DgvDatosModalidad.SelectedRows.Count > 0)
            {   
                DataGridViewRow r = DgvDatosModalidad.SelectedRows[0];
                Modalidad modalidad = (Modalidad)r.Tag; 

                Modalidad modalidadAuxiliar = (Modalidad)modalidad.Clone();

                FrmModalidadesAE frm = new FrmModalidadesAE();
                frm.Text = "Editar Modalidad";
                //se lo paso al formulario
                frm.SetModalidad(modalidad);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        modalidad = frm.GetModalidad();

                        if (!_servicio.Existe(modalidad))
                        {
                            _servicio.Guardar(modalidad);

                            modalidad.NombreModalidad = modalidad.NombreModalidad;
                            SetearFila(r, modalidad);
                            MessageBox.Show("Registro Agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            SetearFila(r, modalidadAuxiliar);
                            MessageBox.Show("Registro ya existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    catch (Exception exception)
                    {
                        SetearFila(r, modalidadAuxiliar);

                        MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
