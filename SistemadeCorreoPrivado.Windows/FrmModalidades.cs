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
    }
}
