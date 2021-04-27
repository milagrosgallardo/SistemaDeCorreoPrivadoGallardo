
namespace SistemadeCorreoPrivado.Windows
{
    partial class FrmTareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTareas));
            this.DgvDatosTareas = new System.Windows.Forms.DataGridView();
            this.CmnTareas = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatosTareas)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvDatosTareas
            // 
            this.DgvDatosTareas.AllowUserToAddRows = false;
            this.DgvDatosTareas.AllowUserToDeleteRows = false;
            this.DgvDatosTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDatosTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CmnTareas});
            this.DgvDatosTareas.Location = new System.Drawing.Point(0, 85);
            this.DgvDatosTareas.MultiSelect = false;
            this.DgvDatosTareas.Name = "DgvDatosTareas";
            this.DgvDatosTareas.ReadOnly = true;
            this.DgvDatosTareas.RowHeadersVisible = false;
            this.DgvDatosTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDatosTareas.Size = new System.Drawing.Size(800, 364);
            this.DgvDatosTareas.TabIndex = 2;
            // 
            // CmnTareas
            // 
            this.CmnTareas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CmnTareas.HeaderText = "Tarea";
            this.CmnTareas.Name = "CmnTareas";
            this.CmnTareas.ReadOnly = true;
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
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
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
            this.TsbBorrar.Click += new System.EventHandler(this.TsbBorrar_Click);
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
            this.TsbEditar.Click += new System.EventHandler(this.TsbEditar_Click);
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
            // FrmTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.DgvDatosTareas);
            this.Name = "FrmTareas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tareas";
            this.Load += new System.EventHandler(this.FrmTareas_Load);
            this.Click += new System.EventHandler(this.FrmTareas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatosTareas)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDatosTareas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CmnTareas;
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