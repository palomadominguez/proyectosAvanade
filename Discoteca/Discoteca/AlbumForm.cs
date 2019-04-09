using DiscotecaData;
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
    public partial class AlbumForm : Form
    {
        public AlbumForm()
        {
            InitializeComponent();
        }

        


        private void AlbumForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chinookDataSet.Track' table. You can move, or remove it, as needed.
       //     this.trackTableAdapter.Fill(this.chinookDataSet.Track);
            ArtistDAL aD = new ArtistDAL();
                DataTable dt = new DataTable();
                dt = aD.selectAllArtist();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbArtistas.Items.Add(dt.Rows[i].ItemArray[1].ToString());
                }

        }

        private void btnAlbumAlta_Click(object sender, EventArgs e)
        {
            ArtistDAL dal = new ArtistDAL();
           
            DataTable dt = new DataTable();
            string nombreArtista = cbArtistas.SelectedItem.ToString();
            dt =dal.selectArtistForm(nombreArtista);
            string s = dt.Rows[0].ItemArray[0].ToString();
            Album album = new Album(int.Parse(s),txtNombreAlbum.Text);
            dal.insertAlbum(album);
            MessageBox.Show("Alta Correcta");

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAltaCancion_Click(object sender, EventArgs e)
        {
            ArtistDAL dal = new ArtistDAL();
            DataTable dt = new DataTable();
            dt = dal.selectAlbum(txtNombreAlbum.Text);
            int albumId = int.Parse(dt.Rows[0].ItemArray[0].ToString());
            Track pista = new Track(txtNombreCancion.Text, albumId, int.Parse(txtDuracion.Text));
            dal.insertTrack(pista);

            DataTable dtCancion = dal.selectTrack(txtNombreAlbum.Text);
            DataRow workRow = dtCancion.NewRow();
            workRow[0] = dtCancion.Rows[0].ItemArray[0];
            workRow[1] = int.Parse(txtDuracion.Text);

            //dtCancion.Rows.Add(workRow);
            dataGridView1.DataSource = dtCancion;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDuracion.Text = "";
            txtNombreCancion.Text = "";
                

        }

        private void cbArtistas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
