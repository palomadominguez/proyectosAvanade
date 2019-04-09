using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscotecaData
{
    public class Album
    {

        //int idAlbum;
        int artist;
        string titulo;
        List<Track> tracks = new List<Track>();

        //public int IdAlbum { get => idAlbum; set => idAlbum = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public List<Track> Pistas { get => tracks; set => tracks = value; }
        public int Artist { get => artist; set => artist = value; }

        public Album( int artist, string titulo)
        {
            //this.idAlbum = idAlbum;
            this.artist= artist;
            this.titulo = titulo;
            this.tracks = new List<Track>();


        }
        public Album(int artist, string titulo, List<Track> tracks)
        {
            //this.idAlbum = idAlbum;
            this.artist = artist;
            this.titulo = titulo;
            this.tracks = tracks;


        }
    }
}
