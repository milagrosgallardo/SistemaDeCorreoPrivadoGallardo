
namespace SistemadeCorreoPrivado.Windows
{
    partial class FrmTiposDeDocumentosAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTiposDeDocumentosAE));
            this.txtTiposDeDocumentos = new System.Windows.Forms.TextBox();
            this.LblTiposDeDocumentos = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTiposDeDocumentos
            // 
            this.txtTiposDeDocumentos.Location = new System.Drawing.Point(158, 36);
            this.txtTiposDeDocumentos.Name = "txtTiposDeDocumentos";
            this.txtTiposDeDocumentos.Size = new System.Drawing.Size(248, 20);
            this.txtTiposDeDocumentos.TabIndex = 5;
            // 
            // LblTiposDeDocumentos
            // 
            this.LblTiposDeDocumentos.AutoSize = true;
            this.LblTiposDeDocumentos.Location = new System.Drawing.Point(12, 39);
            this.LblTiposDeDocumentos.Name = "LblTiposDeDocumentos";
            this.LblTiposDeDocumentos.Size = new System.Drawing.Size(140, 13);
            this.LblTiposDeDocumentos.TabIndex = 4;
            this.LblTiposDeDocumentos.Text = "TIPOS DE DOCUMENTOS:";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.Location = new System.Drawing.Point(229, 85);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(143, 82);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.Location = new System.Drawing.Point(42, 85);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(143, 82);
            this.BtnGuardar.TabIndex = 6;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // FrmTiposDeDocumentosAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 184);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.txtTiposDeDocumentos);
            this.Controls.Add(this.LblTiposDeDocumentos);
            this.Name = "FrmTiposDeDocumentosAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTiposDeDocumentosAE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox txtTiposDeDocumentos;
        private System.Windows.Forms.Label LblTiposDeDocumentos;
    }
}