using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscotecaData
{
    public class Artist
    {
        
        string nombre;
        List<Album> albums = new List<Album>();

       
        public string Nombre { get => nombre; set => nombre = value; }
        public List<Album> Discos { get => albums; set => albums = value; }

        public Artist(string nombre )
        {
          
            this.nombre = nombre;
            this.albums = new List<Album>();
        }

        public Artist()
        {

        }


    }
}
