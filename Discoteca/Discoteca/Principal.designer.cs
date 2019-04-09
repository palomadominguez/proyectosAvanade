namespace Discoteca
{
    partial class MainMenu
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
            this.btnAltaArtista = new System.Windows.Forms.Button();
            this.btnAltaAlbum = new System.Windows.Forms.Button();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridBuscar = new System.Windows.Forms.DataGridView();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnMostrarTodosArtistas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAltaArtista
            // 
            this.btnAltaArtista.Location = new System.Drawing.Point(99, 32);
            this.btnAltaArtista.Name = "btnAltaArtista";
            this.btnAltaArtista.Size = new System.Drawing.Size(132, 36);
            this.btnAltaArtista.TabIndex = 0;
            this.btnAltaArtista.Text = "Alta Artista";
            this.btnAltaArtista.UseVisualStyleBackColor = true;
            this.btnAltaArtista.Click += new System.EventHandler(this.btnAltaArtista_Click);
            // 
            // btnAltaAlbum
            // 
            this.btnAltaAlbum.Location = new System.Drawing.Point(375, 32);
            this.btnAltaAlbum.Name = "btnAltaAlbum";
            this.btnAltaAlbum.Size = new System.Drawing.Size(132, 36);
            this.btnAltaAlbum.TabIndex = 1;
            this.btnAltaAlbum.Text = "Alta Album";
            this.btnAltaAlbum.UseVisualStyleBackColor = true;
            this.btnAltaAlbum.Click += new System.EventHandler(this.btnAltaAlbum_Click);
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.Items.AddRange(new object[] {
            "Artista",
            "Album",
            "Canción"});
            this.cmbBuscar.Location = new System.Drawing.Point(375, 102);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(132, 28);
            this.cmbBuscar.TabIndex = 3;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(80, 102);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(188, 20);
            this.lblBuscar.TabIndex = 2;
            this.lblBuscar.Text = "Buscar (seleccionar qué):";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(99, 162);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 36);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridBuscar
            // 
            this.dataGridBuscar.AllowUserToAddRows = false;
            this.dataGridBuscar.AllowUserToDeleteRows = false;
            this.dataGridBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBuscar.Location = new System.Drawing.Point(12, 300);
            this.dataGridBuscar.Name = "dataGridBuscar";
            this.dataGridBuscar.ReadOnly = true;
            this.dataGridBuscar.RowTemplate.Height = 28;
            this.dataGridBuscar.Size = new System.Drawing.Size(603, 183);
            this.dataGridBuscar.TabIndex = 6;
            this.dataGridBuscar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBuscar_CellContentClick);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(267, 167);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(322, 26);
            this.txtBusqueda.TabIndex = 4;
            // 
            // btnMostrarTodosArtistas
            // 
            this.btnMostrarTodosArtistas.Location = new System.Drawing.Point(169, 230);
            this.btnMostrarTodosArtistas.Name = "btnMostrarTodosArtistas";
            this.btnMostrarTodosArtistas.Size = new System.Drawing.Size(310, 36);
            this.btnMostrarTodosArtistas.TabIndex = 7;
            this.btnMostrarTodosArtistas.Text = "Mostrar todos los artistas";
            this.btnMostrarTodosArtistas.UseVisualStyleBackColor = true;
            this.btnMostrarTodosArtistas.Click += new System.EventHandler(this.btnMostrarTodosArtistas_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(627, 495);
            this.Controls.Add(this.btnMostrarTodosArtistas);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.dataGridBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.cmbBuscar);
            this.Controls.Add(this.btnAltaAlbum);
            this.Controls.Add(this.btnAltaArtista);
            this.Name = "MainMenu";
            this.Text = "Discoteca - MAIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAltaArtista;
        private System.Windows.Forms.Button btnAltaAlbum;
        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnMostrarTodosArtistas;
    }
}

