using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscotecaData
{
    public class Track
    {
     
        string titulo;
        int album;
        int duracion;

    
        public string Titulo { get => titulo; set => titulo = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        public int Album { get => album; set => album = value; }

        public Track(string titulo, int album, int duracion)
        {
           
            this.titulo = titulo;
            this.Album = album;
            this.duracion = duracion;

        }

        public Track()
        {

        }

        

    }
}
