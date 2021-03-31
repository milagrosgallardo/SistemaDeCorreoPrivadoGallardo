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
    }
}
