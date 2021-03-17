using IntensificacionBiblioteca.Datos.Repositorios.Facades;
using IntensificacionBiblioteca.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Datos.Repositorios
{
    public class RepositorioAutores : IRepositorioAutores
    {
        private readonly SqlConnection _conexion;

        public RepositorioAutores(SqlConnection conexion)
        {
            _conexion = conexion;
        }

        public void Borrar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Autor autor)
        {
            throw new NotImplementedException();
        }

        public List<Autor> GetAutores()
        {
            List<Autor> lista = new List<Autor>();
            try
            {
                string cadenaComando = "SELECT AutorId, NombreAutor FROM Autores";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Autor autor = ConstruirAutor(reader);
                    lista.Add(autor);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar leer los Autores");
            }
        }

        private Autor ConstruirAutor(SqlDataReader reader)
        {
            return new Autor
            {
                AutorId = reader.GetInt32(0),
                NombreAutor = reader.GetString(1)
            };
        }

        public Autor GetAutorPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Guardar(Autor autor)
        {
            throw new NotImplementedException();
        }
    }
}
