
namespace SistemadeCorreoPrivado.Windows
{
    partial class FrmProvincias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProvincias));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.TsbBorrar = new System.Windows.Forms.ToolStripButton();
            this.TsbEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.TsabActualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TsbImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.DgvDatosProvincia = new System.Windows.Forms.DataGridView();
            this.CmnProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatosProvincia)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbNuevo,
            this.TsbBorrar,
            this.TsbEditar,
            this.toolStripSeparator1,
            this.TsbBuscar,
            this.TsabActualizar,
            this.toolStripSeparator2,
            this.TsbImprimir,
            this.toolStripSeparator3,
            this.TsbCerrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 86);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // TsbNuevo
            // 
            this.TsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("TsbNuevo.Image")));
            this.TsbNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbNuevo.Name = "TsbNuevo";
            this.TsbNuevo.Size = new System.Drawing.Size(68, 83);
            this.TsbNuevo.Text = "Nuevo";
            this.TsbNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsbNuevo.Click += new System.EventHandler(this.TsbNuevo_Click);
            // 
            // TsbBorrar
            // 
            this.TsbBorrar.Image = ((System.Drawing.Image)(resources.GetObject("TsbBorrar.Image")));
            this.TsbBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsbBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbBorrar.Name = "TsbBorrar";
            this.TsbBorrar.Size = new System.Drawing.Size(68, 83);
            this.TsbBorrar.Text = "Borrar";
            this.TsbBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // TsbEditar
            // 
            this.TsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("TsbEditar.Image")));
            this.TsbEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbEditar.Name = "TsbEditar";
            this.TsbEditar.Size = new System.Drawing.Size(68, 83);
            this.TsbEditar.Text = "Editar";
            this.TsbEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 86);
            // 
            // TsbBuscar
            // 
            this.TsbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("TsbBuscar.Image")));
            this.TsbBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbBuscar.Name = "TsbBuscar";
            this.TsbBuscar.Size = new System.Drawing.Size(68, 83);
            this.TsbBuscar.Text = "Buscar";
            this.TsbBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // TsabActualizar
            // 
            this.TsabActualizar.Image = ((System.Drawing.Image)(resources.GetObject("TsabActualizar.Image")));
            this.TsabActualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsabActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsabActualizar.Name = "TsabActualizar";
            this.TsabActualizar.Size = new System.Drawing.Size(68, 83);
            this.TsabActualizar.Text = "Actualizar";
            this.TsabActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 86);
            // 
            // TsbImprimir
            // 
            this.TsbImprimir.Image = ((System.Drawing.Image)(resources.GetObject("TsbImprimir.Image")));
            this.TsbImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbImprimir.Name = "TsbImprimir";
            this.TsbImprimir.Size = new System.Drawing.Size(68, 83);
            this.TsbImprimir.Text = "Imprimir";
            this.TsbImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 86);
            // 
            // TsbCerrar
            // 
            this.TsbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("TsbCerrar.Image")));
            this.TsbCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsbCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbCerrar.Name = "TsbCerrar";
            this.TsbCerrar.Size = new System.Drawing.Size(68, 83);
            this.TsbCerrar.Text = "Cerrar";
            this.TsbCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsbCerrar.Click += new System.EventHandler(this.TsbCerrar_Click);
            // 
            // DgvDatosProvincia
            // 
            this.DgvDatosProvincia.AllowUserToAddRows = false;
            this.DgvDatosProvincia.AllowUserToDeleteRows = false;
            this.DgvDatosProvincia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDatosProvincia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CmnProvincia});
            this.DgvDatosProvincia.Location = new System.Drawing.Point(0, 90);
            this.DgvDatosProvincia.MultiSelect = false;
            this.DgvDatosProvincia.Name = "DgvDatosProvincia";
            this.DgvDatosProvincia.ReadOnly = true;
            this.DgvDatosProvincia.RowHeadersVisible = false;
            this.DgvDatosProvincia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDatosProvincia.Size = new System.Drawing.Size(800, 364);
            this.DgvDatosProvincia.TabIndex = 1;
            // 
            // CmnProvincia
            // 
            this.CmnProvincia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CmnProvincia.HeaderText = "Provincia";
            this.CmnProvincia.Name = "CmnProvincia";
            this.CmnProvincia.ReadOnly = true;
            // 
            // FrmProvincias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.DgvDatosProvincia);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "FrmProvincias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Provincias";
            this.Load += new System.EventHandler(this.FrmProvincias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatosProvincia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView DgvDatosProvincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn CmnProvincia;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsbNuevo;
        private System.Windows.Forms.ToolStripButton TsbBorrar;
        private System.Windows.Forms.ToolStripButton TsbEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TsbBuscar;
        private System.Windows.Forms.ToolStripButton TsabActualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TsbImprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton TsbCerrar;
    }
}