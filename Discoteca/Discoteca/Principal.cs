using DiscotecaBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discoteca
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //ArtistDAL aD = new ArtistDAL();
            //DataTable dt = new DataTable();
            //dt = aD.selectArtist(textBox1.Text);
            
            //textBox2.Text = dt.Rows[0].ItemArray[0].ToString();

            //string dasd= dt.Rows[0].ItemArray[0].ToString();
            //string dasd2 = dt.Rows[0].ItemArray[1].ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ArtistDAL aD = new ArtistDAL();
            //DataTable dt = new DataTable();
            //dt = aD.selectAllArtist();
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    comboBox1.Items.Add(dt.Rows[i].ItemArray[1].ToString());
            //}
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable Items = new DataTable();
            ArtistDAL aD = new ArtistDAL();

            if ((txtBusqueda.Text != "")&&((cmbBuscar.Text == "Artista") || (cmbBuscar.Text == "Album") || (cmbBuscar.Text == "Canción")))
            {
                dataGridBuscar.Rows.Clear();
                dataGridBuscar.Columns.Clear();
                switch (cmbBuscar.Text)
                {
                    case "Artista":
                        Items = aD.selectArtist(txtBusqueda.Text);
                        dataGridBuscar.Columns.Add("Artista","Artista");
                        try
                        {
                            dataGridBuscar.Rows.Add(Items.Rows[0].ItemArray);
                        }catch
                        {
                            MessageBox.Show("Artista no encontrado.");
                        }
                        break;

                    case "Album":
                        Items = aD.selectArtistByAlbum(txtBusqueda.Text);
                        dataGridBuscar.Columns.Add("Artista", "Artista");
                        dataGridBuscar.Columns.Add("Album", "Album");
                        try
                        {
                            dataGridBuscar.Rows.Add(Items.Rows[0].ItemArray);
                        }
                        catch
                        {
                            MessageBox.Show("Album no encontrado.");
                        }
                        break;

                    case "Canción":
                        Items = aD.selectArtistByTrack(txtBusqueda.Text);
                        dataGridBuscar.Columns.Add("Artista", "Artista");
                        dataGridBuscar.Columns.Add("Album", "Album");
                        dataGridBuscar.Columns.Add("Canción", "Canción");
                        try
                        {
                            dataGridBuscar.Rows.Add(Items.Rows[0].ItemArray);
                        }
                        catch
                        {
                            MessageBox.Show("Canción no encontrada.");
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("¡Introduce un tipo y/o un nombre de elemento a buscar!");
            }
        }

        private void btnAltaArtista_Click(object sender, EventArgs e)
        {
            CantanteForm cantante = new CantanteForm();
            cantante.Show();
        }

        private void btnAltaAlbum_Click(object sender, EventArgs e)
        {
            AlbumForm album = new AlbumForm();
            album.Show();
        }

        private void btnMostrarTodosArtistas_Click(object sender, EventArgs e)
        {
            ArtistDAL aD = new ArtistDAL();
            DataTable dt = new DataTable();
            dataGridBuscar.Columns.Add("Artista", "Artista");
            dt = aD.selectAllArtist();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataGridBuscar.Rows.Add(dt.Rows[i].ItemArray[1].ToString());
            }
        }

        private void dataGridBuscar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
