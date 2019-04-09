using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscotecaBL;
using DiscotecaData;
namespace Discoteca
{
    public partial class CantanteForm : Form
    {
        public CantanteForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAltaCantante_Click(object sender, EventArgs e)
        {
            ArtistDAL dal = new ArtistDAL();
            Artist artista = new Artist(txtNombreArtista.Text);
            dal.insertArtist(artista);
            MessageBox.Show("Alta Correcta");
        }

        private void CantanteForm_Load(object sender, EventArgs e)
        {

        }
    }
}
