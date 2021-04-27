using SistemadeCorreoPrivado.BL.Entidades;
using SistemadeCorreoPrivado.Servicios.Servicios;
using SistemadeCorreoPrivado.Servicios.Servicios.facades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemadeCorreoPrivado.Windows
{
    public partial class FrmTareas : Form
    {
        public FrmTareas()
        {
            InitializeComponent();
        }

        private void TsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private IServiciosTareas _servicio;
        List<Tarea> _lista;
        private void FrmTareas_Load(object sender, EventArgs e)
        {
            _servicio = new ServiciosTareas();
            try
            {
                _lista = _servicio.GetTareas();
                MostrarDatosEnGrilla();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);

            }
        }

        private void MostrarDatosEnGrilla()
        {
            DgvDatosTareas.Rows.Clear();
            foreach (var tarea in _lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, tarea);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DgvDatosTareas.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Tarea tarea)
        {
            r.Cells[CmnTareas.Index].Value = tarea.NombreTarea;
            r.Tag = tarea;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(DgvDatosTareas);
            return r;

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TsbNuevo_Click(object sender, EventArgs e)
        {
            FrmTareasAE frm = new FrmTareasAE();
            frm.Text = "Agregar una Tarea";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    Tarea tarea = frm.GetTarea();

                    if (!_servicio.Existe(tarea))
                    {
                        _servicio.Guardar(tarea);
                        DataGridViewRow r = ConstruirFila();
                        SetearFila(r, tarea);
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
            if (DgvDatosTareas.SelectedRows.Count > 0)
            {
                DataGridViewRow r = DgvDatosTareas.SelectedRows[0];
                Tarea tarea = (Tarea)r.Tag;

                DialogResult dr = MessageBox.Show($@"¿Desea dar de baja el registro seleccionado: {tarea.NombreTarea}?",
                    @"Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (dr == DialogResult.Yes)
                {

                    try
                    {
                        _servicio.Borrar(tarea.TareaId);
                        DgvDatosTareas.Rows.Remove(r);
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
            if (DgvDatosTareas.SelectedRows.Count > 0)
            {
                DataGridViewRow r = DgvDatosTareas.SelectedRows[0];
                Tarea tarea = (Tarea)r.Tag;
                Tarea tareaAuxiliar = (Tarea)tarea.Clone();
                FrmTareasAE frm = new FrmTareasAE();
                frm.Text = "Editar Tarea";
                frm.SetTarea(tarea);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        tarea = frm.GetTarea();

                        if (!_servicio.Existe(tarea))
                        {
                            _servicio.Guardar(tarea);

                            tarea.NombreTarea = tarea.NombreTarea;
                            SetearFila(r, tarea);
                            MessageBox.Show("Registro Agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            SetearFila(r, tareaAuxiliar);
                            MessageBox.Show("Registro ya existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    catch (Exception exception)
                    {
                        SetearFila(r, tareaAuxiliar);

                        MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


    }
}
