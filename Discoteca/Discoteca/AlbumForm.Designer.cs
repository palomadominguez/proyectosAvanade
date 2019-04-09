namespace Discoteca
{
    partial class AlbumForm
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
            this.txtNombreAlbum = new System.Windows.Forms.TextBox();
            this.lblAlbumName = new System.Windows.Forms.Label();
            this.lblArtistName = new System.Windows.Forms.Label();
            this.btnAlbumAlta = new System.Windows.Forms.Button();
            this.cbArtistas = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreCancion = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.btnAltaCancion = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.trackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreAlbum
            // 
            this.txtNombreAlbum.Location = new System.Drawing.Point(278, 30);
            this.txtNombreAlbum.Name = "txtNombreAlbum";
            this.txtNombreAlbum.Size = new System.Drawing.Size(100, 26);
            this.txtNombreAlbum.TabIndex = 0;
            // 
            // lblAlbumName
            // 
            this.lblAlbumName.AutoSize = true;
            this.lblAlbumName.Location = new System.Drawing.Point(12, 33);
            this.lblAlbumName.Name = "lblAlbumName";
            this.lblAlbumName.Size = new System.Drawing.Size(114, 20);
            this.lblAlbumName.TabIndex = 2;
            this.lblAlbumName.Text = "Nombre Album";
            // 
            // lblArtistName
            // 
            this.lblArtistName.AutoSize = true;
            this.lblArtistName.Location = new System.Drawing.Point(12, 76);
            this.lblArtistName.Name = "lblArtistName";
            this.lblArtistName.Size = new System.Drawing.Size(201, 20);
            this.lblArtistName.TabIndex = 3;
            this.lblArtistName.Text = "Introduce Artista del Album";
            // 
            // btnAlbumAlta
            // 
            this.btnAlbumAlta.Location = new System.Drawing.Point(471, 66);
            this.btnAlbumAlta.Name = "btnAlbumAlta";
            this.btnAlbumAlta.Size = new System.Drawing.Size(119, 40);
            this.btnAlbumAlta.TabIndex = 4;
            this.btnAlbumAlta.Text = "Alta Album";
            this.btnAlbumAlta.UseVisualStyleBackColor = true;
            this.btnAlbumAlta.Click += new System.EventHandler(this.btnAlbumAlta_Click);
            // 
            // cbArtistas
            // 
            this.cbArtistas.FormattingEnabled = true;
            this.cbArtistas.Location = new System.Drawing.Point(219, 73);
            this.cbArtistas.Name = "cbArtistas";
            this.cbArtistas.Size = new System.Drawing.Size(235, 28);
            this.cbArtistas.TabIndex = 5;
            this.cbArtistas.SelectedIndexChanged += new System.EventHandler(this.cbArtistas_SelectedIndexChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(620, 66);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 40);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(693, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Introduce Nombre Cancion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Introduce duracion en milisegundos";
            // 
            // txtNombreCancion
            // 
            this.txtNombreCancion.Location = new System.Drawing.Point(278, 143);
            this.txtNombreCancion.Name = "txtNombreCancion";
            this.txtNombreCancion.Size = new System.Drawing.Size(100, 26);
            this.txtNombreCancion.TabIndex = 10;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(278, 196);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(100, 26);
            this.txtDuracion.TabIndex = 11;
            // 
            // btnAltaCancion
            // 
            this.btnAltaCancion.Location = new System.Drawing.Point(471, 182);
            this.btnAltaCancion.Name = "btnAltaCancion";
            this.btnAltaCancion.Size = new System.Drawing.Size(119, 40);
            this.btnAltaCancion.TabIndex = 12;
            this.btnAltaCancion.Text = "Alta Cancion";
            this.btnAltaCancion.UseVisualStyleBackColor = true;
            this.btnAltaCancion.Click += new System.EventHandler(this.btnAltaCancion_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(622, 182);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(83, 40);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // trackBindingSource
            // 
            this.trackBindingSource.DataMember = "Track";
            // 
            // AlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAltaCancion);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.txtNombreCancion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cbArtistas);
            this.Controls.Add(this.btnAlbumAlta);
            this.Controls.Add(this.lblArtistName);
            this.Controls.Add(this.lblAlbumName);
            this.Controls.Add(this.txtNombreAlbum);
            this.Name = "AlbumForm";
            this.Text = "AlbumForm";
            this.Load += new System.EventHandler(this.AlbumForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreAlbum;
        private System.Windows.Forms.Label lblAlbumName;
        private System.Windows.Forms.Label lblArtistName;
        private System.Windows.Forms.Button btnAlbumAlta;
        private System.Windows.Forms.ComboBox cbArtistas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dataGridView1;
      //  private ChinookDataSet chinookDataSet;
        private System.Windows.Forms.BindingSource trackBindingSource;
      //  private ChinookDataSetTableAdapters.TrackTableAdapter trackTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreCancion;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Button btnAltaCancion;
        private System.Windows.Forms.Button btnClear;
    }
}