using SistemadeCorreoPrivado.BL.Entidades;
using SistemadeCorreoPrivado.Servicios.Servicios;
using SistemadeCorreoPrivado.Servicios.Servicios.facades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace SistemadeCorreoPrivado.Windows
{
    public partial class FrmZonas : Form
    {
        public FrmZonas()
        {
            InitializeComponent();
        }
        private IServiciosZonas _servicio;
        List<Zona> _lista;
        private void FrmZonas_Load(object sender, EventArgs e)
        {
            _servicio = new ServiciosZonas();
            try
            {
                _lista = _servicio.GetZonas();
                MostrarDatosEnGrilla();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                
            }
        }

        private void MostrarDatosEnGrilla()
        {
            DgvDatosZonas.Rows.Clear();
            foreach (var zona in _lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, zona);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DgvDatosZonas.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Zona zona)
        {
            r.Cells[CmnZonas.Index].Value = zona.NombreZona;
            r.Tag = zona;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(DgvDatosZonas);
            return r;
        }



        private void TsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
