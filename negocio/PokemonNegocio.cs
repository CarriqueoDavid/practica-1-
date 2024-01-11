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
                comando.CommandText = "select Numero,Nombre,P.Descripcion,UrlImagen,E.Descripcion as Tipo,D.Descripcion Debilidad,P.IdTipo,P.IdDebilidad,P.Id From POKEMONS P,ELEMENTOS E,ELEMENTOS D where E.Id=P.IdTipo And D.Id=P.IdDebilidad And P.Activo=1";
                comando.Connection = conexion;

                conexion.Open();
                lector= comando.ExecuteReader();

                while (lector.Read()) 
                {
                    Pokemon aux = new Pokemon();
                    aux.Id = (int)lector["id"];
                    aux.Numero = lector.GetInt32(0);
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];

                    //if(!(lector.IsDBNull(lector.GetOrdinal("UrlImagen"))))
                    //aux.UrlImagen=(string)lector["UrlImagen"];
                    if (!(lector["UrlImagen"] is DBNull))
                    aux.UrlImagen = (string)lector["UrlImagen"];


                    aux.Tipo = new Elemento();
                    aux.Tipo.Id = (int)lector["idTipo"];    
                    aux.Tipo.Descripcion = (string)lector["Tipo"];
                    aux.Debilidad =new Elemento();
                    aux.Debilidad.Id = (int)lector["IdDebilidad"];
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
        public void modificar(Pokemon poke)
        {
            AccesoDatos datos= new AccesoDatos();
            try
            {
                datos.stearConsulta("update POKEMONS set Numero = @numero, Nombre = @nombre, Descripcion = @desc, UrlImagen = @img, IdTipo = @idTipo, IdDebilidad = @idDebilidad Where Id = @id");
                datos.setearParametro("@numero", poke.Numero);
                datos.setearParametro("@nombre", poke.Nombre);
                datos.setearParametro("@desc", poke.Descripcion);
                datos.setearParametro("@img", poke.UrlImagen);
                datos.setearParametro("@idTipo", poke.Tipo.Id);
                datos.setearParametro("@idDebilidad", poke.Debilidad.Id);
                datos.setearParametro("@id", poke.Id);

                datos.ejecutarAccion();

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion();}

        }
        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.stearConsulta("delete from pokemons where id=@id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();

            }catch(Exception)
            {
                throw;
            }
        }
        public void eliminarLogico(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.stearConsulta("update POKEMONS set Activo=0 where id=@id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<Pokemon> filtrar(string campo, string criterio, string filtro)
        {
            List<Pokemon> lista = new List<Pokemon>();
            AccesoDatos datos=new AccesoDatos();
            try
            {
                string consulta= "select Numero,Nombre,P.Descripcion,UrlImagen,E.Descripcion as Tipo,D.Descripcion Debilidad,P.IdTipo,P.IdDebilidad,P.Id From POKEMONS P,ELEMENTOS E,ELEMENTOS D where E.Id=P.IdTipo And D.Id=P.IdDebilidad And P.Activo=1 And ";
                switch(campo)
                {
                    case "Numero":
                        switch(criterio)
                        {
                            case "mayor a":
                                consulta += "Numero > " + filtro;
                                break;
                            case "menor a":
                                consulta += "Numero < " + filtro;
                                break;
                            default:
                                consulta += "Numero = " + filtro;
                                break;

                        }
                        break;
                    case "Nombre":
                        switch (criterio)
                        {
                            case "comiena con":
                                consulta += "Nombre like '"+filtro+"%' "; 
                                break;
                            case "termina con":
                                consulta += "Nombre like '%" + filtro + "' ";
                                break;
                            default:
                                consulta += "Nombre like '%" + filtro + "%' ";
                                break;

                        }
                        break;
                    case "Descripcion":
                        switch (criterio)
                        {
                            case "comiena con":
                                consulta += "P.Descripcion like '" + filtro + "%' ";
                                break;
                            case "termina con":
                                consulta += "P.Descripcion like '%" + filtro + "' ";
                                break;
                            default:
                                consulta += "P.Descripcion like '%" + filtro + "%' ";
                                break;

                        }
                        break;
                    default:
                        break;
                }
                datos.stearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Id = (int)datos.Lector["id"];
                    aux.Numero = datos.Lector.GetInt32(0);
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    //if(!(lector.IsDBNull(lector.GetOrdinal("UrlImagen"))))
                    //aux.UrlImagen=(string)lector["UrlImagen"];
                    if (!(datos.Lector["UrlImagen"] is DBNull))
                        aux.UrlImagen = (string)datos.Lector["UrlImagen"];


                    aux.Tipo = new Elemento();
                    aux.Tipo.Id = (int)datos.Lector["idTipo"];
                    aux.Tipo.Descripcion = (string)datos.Lector["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Id = (int)datos.Lector["IdDebilidad"];
                    aux.Debilidad.Descripcion = (string)datos.Lector["Debilidad"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
