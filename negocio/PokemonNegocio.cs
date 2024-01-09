using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace negocio
{
    public class PokemonNegocio
    {
        public List<Pokemon> Listar()
        {
            List<Pokemon> lista = new List<Pokemon>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando= new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS;database=POKEDEX_DB;integrated security= true";
                comando.CommandType=System.Data.CommandType.Text;
                comando.CommandText = "select Numero,Nombre,P.Descripcion,UrlImagen,E.Descripcion as Tipo,D.Descripcion Debilidad From POKEMONS P,ELEMENTOS E,ELEMENTOS D where E.Id=P.IdTipo And D.Id=P.IdDebilidad";
                comando.Connection = conexion;

                conexion.Open();
                lector= comando.ExecuteReader();

                while (lector.Read()) 
                {
                    Pokemon aux = new Pokemon();
                    aux.Numero = lector.GetInt32(0);
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];

                    //if(!(lector.IsDBNull(lector.GetOrdinal("UrlImagen"))))
                    //aux.UrlImagen=(string)lector["UrlImagen"];
                    if (!(lector["UrlImagen"] is DBNull))
                    aux.UrlImagen = (string)lector["UrlImagen"];


                    aux.Tipo = new Elemento();
                    aux.Tipo.Descripcion = (string)lector["Tipo"];
                    aux.Debilidad =new Elemento();
                    aux.Debilidad.Descripcion = (string)lector["Debilidad"];
                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
          
        }
        public void agregar(Pokemon nuevo)//como solo va a insertar datos no neceisto una lista
        {
            AccesoDatos datos= new AccesoDatos();
            try
            {
                datos.stearConsulta("insert into POKEMONS (Numero, Nombre,Descripcion,Activo,IdTipo,IdDebilidad,UrlImagen)values(" + nuevo.Numero + ",'"+nuevo.Nombre+"','"+nuevo.Descripcion+"',1,@idTipo,@idDebilidad,@urlImagen)");
                datos.setearParametro("@idTipo", nuevo.Tipo.Id);
                datos.setearParametro("@idDebilidad", nuevo.Debilidad.Id);
                datos.setearParametro("@urlImagen", nuevo.UrlImagen);
                datos.ejecutarAccion();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
