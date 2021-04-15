using SistemadeCorreoPrivado.BL.Entidades;
using SistemadeCorreoPrivado.Servicios.Servicios;
using SistemadeCorreoPrivado.Servicios.Servicios.facades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemadeCorreoPrivado.Windows
{
    public partial class FrmProvincias : Form
    {
        public FrmProvincias()
        {
            InitializeComponent();
        }

        private void TsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private IServiciosProvincias _servicio;
        List<Provincia> _lista;
        private void FrmProvincias_Load(object sender, EventArgs e)
        {
            _servicio = new ServiciosProvincias();
            try
            { //este objeto pide la lista de provincias
                _lista = _servicio.GetProvincias();
                MostrarDatosEnGrilla();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                
            }
        }

        private void MostrarDatosEnGrilla()
        { // limpio la grilla por las dudas
            DgvDatosProvincia.Rows.Clear();
            foreach (var provincia in _lista)
            { // por cada provincia de la lista creo la fila
                DataGridViewRow r = ConstruirFila();
                SetearFila(r,provincia);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DgvDatosProvincia.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Provincia provincia)
        {
            r.Cells[CmnProvincia.Index].Value = provincia.NombreProvincia;
            r.Tag = provincia;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(DgvDatosProvincia);
            return r;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TsbNuevo_Click(object sender, EventArgs e)
        {
            FrmProvinciasAE frm = new FrmProvinciasAE();
            frm.Text = "Agregar una Provincia";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    Provincia provincia = frm.GetProvincia();

                    if (!_servicio.Existe(provincia))
                    {
                        _servicio.Guardar(provincia);
                        DataGridViewRow r = ConstruirFila();
                        SetearFila(r, provincia);
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

        private void TsbEditar_Click(object sender, EventArgs e)
        { // tengo que tener una provincia seleccionada 
            if (DgvDatosProvincia.SelectedRows.Count > 0)
            {   // me fijo que fila tome
                DataGridViewRow r = DgvDatosProvincia.SelectedRows[0];
                Provincia provincia = (Provincia)r.Tag; // saco la provincia lo casteo 

                 Provincia provinciaAuxiliar = (Provincia)provincia.Clone();
                /* PaisEditDto paisEditDto = new PaisEditDto
                 {
                     PaisId = pais.PaisId,
                     NombrePais = pais.NombrePais
                 };*/
                FrmProvinciasAE frm = new FrmProvinciasAE();
                frm.Text = "Editar Provincia";
                //se lo paso al formulario
                frm.SetProvincia(provincia);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        provincia = frm.GetProvincia();

                        if (!_servicio.Existe(provincia))
                        {
                            _servicio.Guardar(provincia);

                            provincia.NombreProvincia = provincia.NombreProvincia;
                            SetearFila(r, provincia);
                            MessageBox.Show("Registro Agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                          SetearFila(r, provinciaAuxiliar);
                            MessageBox.Show("Registro ya existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    catch (Exception exception)
                    {
                       SetearFila(r, provinciaAuxiliar);

                        MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void TsbBorrar_Click(object sender, EventArgs e)
        {
            if (DgvDatosProvincia.SelectedRows.Count > 0)
            {
                DataGridViewRow r = DgvDatosProvincia.SelectedRows[0];
                Provincia provincia = (Provincia)r.Tag;

                DialogResult dr = MessageBox.Show($@"¿Desea dar de baja el registro seleccionado: {provincia.NombreProvincia}?",
                    @"Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (dr == DialogResult.Yes)
                {
                    //Verificar que no esta relacionado
                    try
                    {
                        _servicio.Borrar(provincia.ProvinciaId);
                        DgvDatosProvincia.Rows.Remove(r);
                        MessageBox.Show(@"Registro Borrado", @"Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
