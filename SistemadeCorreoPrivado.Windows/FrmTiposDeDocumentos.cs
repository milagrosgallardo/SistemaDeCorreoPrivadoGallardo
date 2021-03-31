using SistemadeCorreoPrivado.BL.Entidades;
using SistemadeCorreoPrivado.Servicios.Servicios;
using SistemadeCorreoPrivado.Servicios.Servicios.facades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemadeCorreoPrivado.Windows
{
    public partial class FrmTiposDeDocumentos : Form
    {
        public FrmTiposDeDocumentos()
        {
            InitializeComponent();
        }

        private void TsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private IServiciosTiposDeDocumentos _servicio;
        List<TiposDeDocumento> _lista;
        private void FrmTiposDeDocumentos_Load(object sender, EventArgs e)
        {
            _servicio = new ServiciosTiposDeDocumentos();
            try
            {
                _lista = _servicio.GetTiposDeDocumentos();
                MostrarDatosEnGrilla();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void MostrarDatosEnGrilla()
        {
            DgvDatosTiposDeDocumentos.Rows.Clear();
            foreach (var tiposDeDocumento in _lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, tiposDeDocumento);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DgvDatosTiposDeDocumentos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, TiposDeDocumento tiposDeDocumento)
        {
            r.Cells[CmnTiposDeDocumentos.Index].Value = tiposDeDocumento.NombreDocumento;
            r.Tag = tiposDeDocumento;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(DgvDatosTiposDeDocumentos);
            return r;
        }


    }
}
