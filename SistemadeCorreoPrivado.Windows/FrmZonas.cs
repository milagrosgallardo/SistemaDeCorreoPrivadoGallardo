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

        private void TsbNuevo_Click(object sender, EventArgs e)
        {
            FrmZonasAE frm = new FrmZonasAE();
            frm.Text = "Agregar una Zona";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    Zona zona = frm.GetZona();

                    if (!_servicio.Existe(zona))
                    {
                        _servicio.Guardar(zona);
                        DataGridViewRow r = ConstruirFila();
                        SetearFila(r, zona);
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
            if (DgvDatosZonas.SelectedRows.Count > 0)
            {
                DataGridViewRow r = DgvDatosZonas.SelectedRows[0];
                Zona zona= (Zona)r.Tag;

                DialogResult dr = MessageBox.Show($@"¿Desea dar de baja el registro seleccionado: {zona.NombreZona}?",
                    @"Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (dr == DialogResult.Yes)
                {

                    try
                    {
                        _servicio.Borrar(zona.ZonaId);
                        DgvDatosZonas.Rows.Remove(r);
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
            if (DgvDatosZonas.SelectedRows.Count > 0)
            {
                DataGridViewRow r = DgvDatosZonas.SelectedRows[0];
                Zona zona = (Zona)r.Tag;
                Zona zonaAuxiliar = (Zona)zona.Clone();
                FrmZonasAE frm = new FrmZonasAE();
                frm.Text = "Editar zona";
                frm.SetZona(zona);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        zona = frm.GetZona();

                        if (!_servicio.Existe(zona))
                        {
                            _servicio.Guardar(zona);

                            zona.NombreZona = zona.NombreZona;
                            SetearFila(r, zona);
                            MessageBox.Show("Registro Agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            SetearFila(r, zonaAuxiliar);
                            MessageBox.Show("Registro ya existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    catch (Exception exception)
                    {
                        SetearFila(r, zonaAuxiliar);

                        MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
