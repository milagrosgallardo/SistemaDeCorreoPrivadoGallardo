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

        private void TsbNuevo_Click(object sender, EventArgs e)
        {
            FrmTiposDeDocumentosAE frm = new FrmTiposDeDocumentosAE();
            frm.Text = "Agregar un nuevo tipo de documento";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    TiposDeDocumento tiposDeDocumento = frm.GetTiposDeDocumento();

                    if (!_servicio.Existe(tiposDeDocumento))
                    {
                        _servicio.Guardar(tiposDeDocumento);
                        DataGridViewRow r = ConstruirFila();
                        SetearFila(r, tiposDeDocumento);
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
            if (DgvDatosTiposDeDocumentos.SelectedRows.Count > 0)
            {
                DataGridViewRow r = DgvDatosTiposDeDocumentos.SelectedRows[0];
                TiposDeDocumento tiposDeDocumento = (TiposDeDocumento)r.Tag;

                DialogResult dr = MessageBox.Show($@"¿Desea dar de baja el registro seleccionado: {tiposDeDocumento.NombreDocumento}?",
                    @"Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (dr == DialogResult.Yes)
                {

                    try
                    {
                        _servicio.Borrar(tiposDeDocumento.TipoDeDocumentoId);
                        DgvDatosTiposDeDocumentos.Rows.Remove(r);
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
            if (DgvDatosTiposDeDocumentos.SelectedRows.Count > 0)
            {
                DataGridViewRow r = DgvDatosTiposDeDocumentos.SelectedRows[0];
                TiposDeDocumento tiposDeDocumento = (TiposDeDocumento)r.Tag;
                TiposDeDocumento tiposDeDocumentoAuxiliar = (TiposDeDocumento)tiposDeDocumento.Clone();
                FrmTiposDeDocumentosAE frm = new FrmTiposDeDocumentosAE();
                frm.Text = "Editar Tipo De Documento";
                frm.SetTiposDeDocumento(tiposDeDocumento);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        tiposDeDocumento = frm.GetTiposDeDocumento();

                        if (!_servicio.Existe(tiposDeDocumento))
                        {
                            _servicio.Guardar(tiposDeDocumento);

                            tiposDeDocumento.NombreDocumento = tiposDeDocumento.NombreDocumento;
                            SetearFila(r, tiposDeDocumento);
                            MessageBox.Show("Registro Agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            SetearFila(r, tiposDeDocumentoAuxiliar);
                            MessageBox.Show("Registro ya existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    catch (Exception exception)
                    {
                        SetearFila(r, tiposDeDocumentoAuxiliar);

                        MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
