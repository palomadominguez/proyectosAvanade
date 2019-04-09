using DiscotecaData;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DiscotecaBL;
namespace DiscotecaBL
{
    public class ArtistDAL
    {
        private string connectionString;
        private SqlConnection conn;

        public ArtistDAL()
        {
            connectionString = Connection.GetConnectionString();
        }

        public int insertArtist(Artist cantante)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                int affectedRows;
                SqlCommand cmdInsert = new SqlCommand("INSERT INTO Artist(Name) VALUES (@Name)", conn);
                cmdInsert.Parameters.AddWithValue("@Name", cantante.Nombre);

                conn.Open();
                affectedRows = cmdInsert.ExecuteNonQuery();
                return affectedRows;
            }
        }

        public int insertAlbum(Album album)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                int affectedRows;
                SqlCommand cmdInsert = new SqlCommand("INSERT INTO Album(Title, ArtistId) VALUES (@Title, @ArtistId)", conn);
                cmdInsert.Parameters.AddWithValue("@Title", album.Titulo);
                cmdInsert.Parameters.AddWithValue("@ArtistId", album.Artist);


                conn.Open();
                affectedRows = cmdInsert.ExecuteNonQuery();
                return affectedRows;
            }
        }

        public DataTable selectArtist(string nombre)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmdSelect = new SqlCommand("SELECT Name FROM Artist WHERE Name = @Name", conn);
                cmdSelect.Parameters.AddWithValue("@Name", nombre);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdSelect;
                DataTable dbDataTable = new DataTable();
                sda.Fill(dbDataTable);
                return dbDataTable;
            }

        }
        public DataTable selectArtistForm(string cantante)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmdSelect = new SqlCommand("SELECT ArtistId,Name FROM Artist WHERE Name = @Name", conn);
                cmdSelect.Parameters.AddWithValue("@Name", cantante);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdSelect;
                DataTable dbDataTable = new DataTable();
                sda.Fill(dbDataTable);
                return dbDataTable;
            }
        }
        public DataTable selectAllArtist()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmdSelect = new SqlCommand("SELECT * FROM Artist", conn);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdSelect;
                DataTable dbDataTable = new DataTable();
                sda.Fill(dbDataTable);
                return dbDataTable;
            }
        }

        public DataTable selectArtistByTrack(string nombre)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmdSelect = new SqlCommand("SELECT   dbo.Artist.Name, dbo.Album.Title, dbo.Track.Name " +
                    "FROM  dbo.Album INNER JOIN " +
                     "dbo.Artist ON dbo.Album.ArtistId = dbo.Artist.ArtistId INNER JOIN "
                     + "dbo.Track ON dbo.Album.AlbumId = dbo.Track.AlbumId " +
                     "where Track.Name = @Name", conn);
                cmdSelect.Parameters.AddWithValue("@Name", nombre);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdSelect;
                DataTable dbDataTable = new DataTable();
                sda.Fill(dbDataTable);
                return dbDataTable;
            }
        }

        public DataTable selectArtistByAlbum(string nombre)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmdSelect = new SqlCommand("SELECT   dbo.Artist.Name, dbo.Album.Title " +
                    "FROM  dbo.Album INNER JOIN " +
                     "dbo.Artist ON dbo.Album.ArtistId = dbo.Artist.ArtistId " +
                     "where Album.Title = @Name", conn);
                cmdSelect.Parameters.AddWithValue("@Name", nombre);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdSelect;
                DataTable dbDataTable = new DataTable();
                sda.Fill(dbDataTable);
                return dbDataTable;
            }

        }

        public DataTable selectTrack(string nombreAlbum)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmdSelect = new SqlCommand("SELECT dbo.Track.Name, dbo.Track.Milliseconds FROM dbo.Album INNER JOIN dbo.Track ON dbo.Album.AlbumId = dbo.Track.AlbumId WHERE Album.Title = @Name", conn);
                cmdSelect.Parameters.AddWithValue("@Name", nombreAlbum);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdSelect;

                DataTable dbDataTable = new DataTable();
                sda.Fill(dbDataTable);
                return dbDataTable;
            }
        }
        public DataTable selectAlbum(string nombreAlbum)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmdSelect = new SqlCommand("SELECT AlbumId FROM Album WHERE Title = @Title", conn);
                cmdSelect.Parameters.AddWithValue("@Title", nombreAlbum);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdSelect;

                DataTable dbDataTable = new DataTable();
                sda.Fill(dbDataTable);
                return dbDataTable;
            }
        }
        public int insertTrack(Track track)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                int affectedRows;
                SqlCommand cmdInsert = new SqlCommand("INSERT INTO Track(Name, AlbumId,MediaTypeId,GenreId,Composer,Milliseconds,Bytes,UnitPrice)" +
                    " VALUES (@Name, @AlbumId,1,1,NULL,@duracion,NULL,0.99)", conn);
                cmdInsert.Parameters.AddWithValue("@Name", track.Titulo);
                cmdInsert.Parameters.AddWithValue("@AlbumId", track.Album);
                cmdInsert.Parameters.AddWithValue("@duracion", track.Duracion);


                conn.Open();
                affectedRows = cmdInsert.ExecuteNonQuery();
                return affectedRows;
            }
        }
    }
}