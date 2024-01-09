using System;
using System.Collections.Generic;
using System.Data.SqlClient;//agregue esta using
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;


namespace negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;//atributos
        private SqlCommand comando;//atributo
        private SqlDataReader lector;//atributo
        public SqlDataReader Lector//para poder leer private sqldatareader lector desde otro lugar
        {
            get { return lector; }
       }

        public AccesoDatos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS;database=POKEDEX_DB;integrated security= true");
            comando = new SqlCommand();
        }
        public void stearConsulta(string consulta)
        {
            comando.CommandType= System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }
        public void ejecutarLectura()//realiza la lectura
        {
            comando.Connection = conexion;
       
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch(Exception ex) 
            {
                throw ex;
            }
        }
        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public void setearParametro(string nombre,object valor)
        {

            comando.Parameters.AddWithValue(nombre,valor);
        }
        public void cerrarConexion()
        {
            if(lector!= null)
                lector.Close();
            conexion.Close();
        }
    }
}
