namespace Discoteca
{
    partial class CantanteForm
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
            this.btnAltaCantante = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCantante = new System.Windows.Forms.Label();
            this.txtNombreArtista = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAltaCantante
            // 
            this.btnAltaCantante.Location = new System.Drawing.Point(279, 116);
            this.btnAltaCantante.Name = "btnAltaCantante";
            this.btnAltaCantante.Size = new System.Drawing.Size(85, 36);
            this.btnAltaCantante.TabIndex = 0;
            this.btnAltaCantante.Text = "Alta";
            this.btnAltaCantante.UseVisualStyleBackColor = true;
            this.btnAltaCantante.Click += new System.EventHandler(this.btnAltaCantante_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(585, 334);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 36);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCantante
            // 
            this.lblCantante.AutoSize = true;
            this.lblCantante.Location = new System.Drawing.Point(43, 56);
            this.lblCantante.Name = "lblCantante";
            this.lblCantante.Size = new System.Drawing.Size(207, 20);
            this.lblCantante.TabIndex = 2;
            this.lblCantante.Text = "Introduce Nombre Cantante";
            // 
            // txtNombreArtista
            // 
            this.txtNombreArtista.Location = new System.Drawing.Point(264, 53);
            this.txtNombreArtista.Name = "txtNombreArtista";
            this.txtNombreArtista.Size = new System.Drawing.Size(100, 26);
            this.txtNombreArtista.TabIndex = 3;
            // 
            // CantanteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNombreArtista);
            this.Controls.Add(this.lblCantante);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAltaCantante);
            this.Name = "CantanteForm";
            this.Text = "CantanteForm";
            this.Load += new System.EventHandler(this.CantanteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAltaCantante;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCantante;
        private System.Windows.Forms.TextBox txtNombreArtista;
    }
}