using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemSCADA.Controlador;
using SystemSCADA.Vista;

namespace SystemSCADA.Modelo
{
    public class claseMetodosBaseDeDatos
    {

        #region Declaracion de Variables
        SqlConnection Sqlconexion = null;
        SqlCommand ComandoSql = null;
        SqlDataAdapter AdaptadorDeDatosSql = null;
        DataTable TablaDeDatos = null;
        string ScalarStr = string.Empty;
        string strConexion = string.Empty;
        
        #endregion


        #region Constructor
        public claseMetodosBaseDeDatos(string Servidor, string NombreDB, string User, string Pass)
        {
            strConexion = "Data Source=" + Servidor + ";Initial Catalog=" +
                NombreDB + ";User ID=" + User + ";Password=" + Pass;
        }
        #endregion

        public string ObtenerStringConexion()
        {
            return strConexion;
        }
      

        #region Metodos a Ejecutar
        //Ejecuta un procedimiento almacenado, sin retornar ningun dato
        public bool EjecutarSP(ref SqlParameter[] parParametros, string SpNom, string msgError)
        {
            try
            {
                //Instanciamos el objeto Conexión con la cadena de Conexión.
                Sqlconexion = new SqlConnection(strConexion);
                //Abrimos la Conexión
                Sqlconexion.Open();
                //Instanciamos el objeto comando con el TSQL y Conexión a utilizar.
                ComandoSql = new SqlCommand();//(SpNom, con);
                ComandoSql.Connection = Sqlconexion;
                //Asignamos el tipo de comando a ejecutar.
                ComandoSql.CommandType = CommandType.StoredProcedure;
                //Agregamos el nombre del Srore procedure.
                ComandoSql.CommandText = SpNom;
                //Agregmos los parametros a ejecutar
                for (int x = 0; x < parParametros.Length; x++)
                    ComandoSql.Parameters.Add(parParametros[x]);
                //Ejecutamos el TSQL(Transaction SQL) en el servidor.
                ComandoSql.ExecuteNonQuery();
                for (int x = 0; x < parParametros.Length; x++)
                    parParametros[x].Value = ComandoSql.Parameters[parParametros[x].ParameterName].Value;
                return true;
            }
            catch (SqlException Sqlex)
            {
                Cursor.Current = Cursors.Default;
                ClaseComunes.MsjShow(msgError + ": " + Sqlex.Message, 1, 1);
                return false;
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                //Controladores.claseControlComunes.MsjShow(msgError + ": " + ex.Message, 1, 1);
                return false;
            }
            finally
            {
                if (Sqlconexion != null)
                { Sqlconexion.Close(); }
                Sqlconexion.Dispose();
            }
        }
        
        //Ejecuta un texto, sin retornar ningun dato
        public void EjecutarText(string Texto, string msgError)
        {
            try
            {
                //Instanciamos el objeto Conexión con la cadena de Conexión.
                Sqlconexion = new SqlConnection(strConexion);
                //Abrimos la Conexión
                Sqlconexion.Open();
                //Instanciamos el objeto comando con el TSQL y Conexión a utilizar.
                ComandoSql = new SqlCommand();//(SpNom, con);
                ComandoSql.Connection = Sqlconexion;
                //Asignamos el tipo de comando a ejecutar.
                ComandoSql.CommandType = CommandType.Text;
                //Agregamos el nombre del Srore procedure.
                ComandoSql.CommandText = Texto;
                //Ejecutamos el TSQL(Transaction SQL) en el servidor.
                ComandoSql.ExecuteNonQuery();
            }
            catch (SqlException Sqlex)
            {
                Cursor.Current = Cursors.Default;
                //Controladores.claseControlComunes.MsjShow(msgError + ": " + Sqlex.Message, 1, 1);*/
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                //Controladores.claseControlComunes.MsjShow(msgError + ": " + ex.Message, 1, 1);
            }
            finally
            {
                if (Sqlconexion != null)
                { Sqlconexion.Close(); }
                Sqlconexion.Dispose();
            }
        }
        //Retornar una tabla resuldado de una sentencia en un SP
        public DataTable TablaSP(ref SqlParameter[] parParametros, string SpNom, string msgError)
        {
            TablaDeDatos = null;
            try
            {
                TablaDeDatos = new DataTable();
                //Instanciamos el objeto Conexión con la cadena de Conexión.
                Sqlconexion = new SqlConnection(strConexion);
                //Abrimos la Conexión
                Sqlconexion.Open();
                //Instanciamos el objeto comando con el TSQL
                ComandoSql = new SqlCommand();//(SpNom, con);
                ComandoSql.Connection = Sqlconexion;
                //Asignamos el tipo de comando a ejecutar.
                ComandoSql.CommandType = CommandType.StoredProcedure;
                //Agregamos el nombre del Srore procedure.
                ComandoSql.CommandText = SpNom;
                //Agregmos los parametros a ejecutar
                for (int x = 0; x < parParametros.Length; x++)
                    ComandoSql.Parameters.Add(parParametros[x]);
                //Instanciamos el objeto Adaptador con el comando a utilizar
                AdaptadorDeDatosSql = new SqlDataAdapter(ComandoSql);
                //Llenamos el Dataset con el adaptador de datos.
                AdaptadorDeDatosSql.Fill(TablaDeDatos);
                for (int x = 0; x < parParametros.Length; x++)
                    parParametros[x].Value = ComandoSql.Parameters[parParametros[x].ParameterName].Value;
            }
            catch (SqlException Sqlex)
            {
                MessageBox.Show(Sqlex.Message, "", MessageBoxButtons.OK);
                Cursor.Current = Cursors.Default;
                return null;
            }
            catch (Exception ex)
            {
                ClaseComunes.MsjShow(ex.Message, 1, 1);
                Cursor.Current = Cursors.Default;
                return null;
            }
            finally
            {
                if (Sqlconexion != null)
                { Sqlconexion.Close(); }
                Sqlconexion.Dispose();
            }
            return TablaDeDatos;
        }
        //Retornar una tabla resuldado de una sentencia en un texto
        public DataTable TablaText(string Texto, string msgError)
        {
            TablaDeDatos = null;
            try
            {
                TablaDeDatos = new DataTable();
                //Instanciamos el objeto Conexión con la cadena de Conexión.
                Sqlconexion = new SqlConnection(strConexion);
                //Abrimos la Conexión
                Sqlconexion.Open();
                //Instanciamos el objeto comando con el TSQL
                ComandoSql = new SqlCommand();//(SpNom, con);
                ComandoSql.Connection = Sqlconexion;
                //Asignamos el tipo de comando a ejecutar.
                ComandoSql.CommandType = CommandType.Text;
                //Agregamos el nombre del Srore procedure.
                ComandoSql.CommandText = Texto;
                //Instanciamos el objeto Adaptador con el comando a utilizar
                AdaptadorDeDatosSql = new SqlDataAdapter(ComandoSql);
                //Llenamos el Dataset con el adaptador de datos.
                AdaptadorDeDatosSql.Fill(TablaDeDatos);
            }
            catch (SqlException Sqlex)
            {
                Cursor.Current = Cursors.Default;
                //Controladores.claseControlComunes.MsjShow(msgError + ": " + Sqlex.Message, 1, 1);
                return null;
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                //Controladores.claseControlComunes.MsjShow(msgError + ": " + ex.Message, 1, 1);
                return null;
            }
            finally
            {
                if (Sqlconexion != null)
                { Sqlconexion.Close(); }
                Sqlconexion.Dispose();
            }
            return TablaDeDatos;
        }
        //Retornar un escalar resuldado de una sentencia en un SP
        public string ScalarSP(ref SqlParameter[] parParametros, string SpNom, string msgError)
        {
            try
            {
                //Instanciamos el objeto Conexión con la cadena de Conexión.
                Sqlconexion = new SqlConnection(strConexion);
                //Abrimos la Conexión
                Sqlconexion.Open();
                //Instanciamos el objeto comando con el TSQL
                ComandoSql = new SqlCommand();//(SpNom, con);
                ComandoSql.Connection = Sqlconexion;
                //Asignamos el tipo de comando a ejecutar.
                ComandoSql.CommandType = CommandType.StoredProcedure;
                //Agregamos el nombre del Srore procedure.
                ComandoSql.CommandText = SpNom;
                //Agregmos los parametros a ejecutar
                for (int x = 0; x < parParametros.Length; x++)
                    ComandoSql.Parameters.Add(parParametros[x]);
                ScalarStr = ComandoSql.ExecuteScalar().ToString();
                for (int x = 0; x < parParametros.Length; x++)
                    parParametros[x].Value = ComandoSql.Parameters[parParametros[x].ParameterName].Value;
            }
            catch (SqlException Sqlex)
            {
                Cursor.Current = Cursors.Default;
                //Controladores.claseControlComunes.MsjShow(msgError + ": " + Sqlex.Message, 1, 1);
                return null;
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                //Controladores.claseControlComunes.MsjShow(msgError + ": " + ex.Message, 1, 1);
                return null;
            }
            finally
            {
                if (Sqlconexion != null)
                { Sqlconexion.Close(); }
                Sqlconexion.Dispose();
            }
            return ScalarStr;
        }
        //Retornar un escalar resuldado de una sentencia en un texto
        public string ScalarText(string Texto, string msgError)
        {
            try
            {
                //Instanciamos el objeto Conexión con la cadena de Conexión.
                Sqlconexion = new SqlConnection(strConexion);
                //Abrimos la Conexión
                Sqlconexion.Open();
                //Instanciamos el objeto comando con el TSQL
                ComandoSql = new SqlCommand();//(SpNom, con);
                ComandoSql.Connection = Sqlconexion;
                //Asignamos el tipo de comando a ejecutar.
                ComandoSql.CommandType = CommandType.Text;
                //Agregamos el nombre del Srore procedure.
                ComandoSql.CommandText = Texto;
                ScalarStr = ComandoSql.ExecuteScalar().ToString();
            }
            catch (SqlException Sqlex)
            {
                Cursor.Current = Cursors.Default;
                //Controladores.claseControlComunes.MsjShow(msgError + ": " + Sqlex.Message, 1, 1);
                return null;
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                //Controladores.claseControlComunes.MsjShow(msgError + ": " + ex.Message, 1, 1);
                return null;
            }
            finally
            {
                if (Sqlconexion != null)
                { Sqlconexion.Close(); }
                Sqlconexion.Dispose();
            }
            return ScalarStr;
        }

        public bool SetCmbSP(ref SqlParameter[] parParametros, string SpNom, string msgError, ref ComboBox ComboBox, int Id = 0)
        {
            TablaDeDatos = null;
            try
            {
                TablaDeDatos = new DataTable();
                //Instanciamos el objeto Conexión con la cadena de Conexión.
                Sqlconexion = new SqlConnection(strConexion);
                //Abrimos la Conexión
                Sqlconexion.Open();
                //Instanciamos el objeto comando con el TSQL
                ComandoSql = new SqlCommand();//(SpNom, con);
                ComandoSql.Connection = Sqlconexion;
                //Asignamos el tipo de comando a ejecutar.
                ComandoSql.CommandType = CommandType.StoredProcedure;
                //Agregamos el nombre del Srore procedure.
                ComandoSql.CommandText = SpNom;
                //Agregamos el parametro de Id de Usuario Logueado si se esta pasando como parametro
                if (Id != 0)
                {
                    SqlParameter user = new SqlParameter();
                    user.ParameterName = "@IdUsr";
                    user.SqlDbType = SqlDbType.Int;
                    user.Value = Id;
                    ComandoSql.Parameters.Add(user);
                }
                //Agregamos los parametros a ejecutar
                for (int x = 0; x < parParametros.Length; x++)
                    ComandoSql.Parameters.Add(parParametros[x]);
                //Instanciamos el objeto Adaptador con el comando a utilizar
                AdaptadorDeDatosSql = new SqlDataAdapter(ComandoSql);
                //Llenamos el Dataset con el adaptador de datos.
                AdaptadorDeDatosSql.Fill(TablaDeDatos);
                for (int x = 0; x < parParametros.Length; x++)
                    parParametros[x].Value = ComandoSql.Parameters[parParametros[x].ParameterName].Value;

                //Agrega un nuevo item
                DataRow row = TablaDeDatos.NewRow();
                row["id"] = 0;
                row["Descripcion"] = "seleccione...";
                TablaDeDatos.Rows.InsertAt(row, 0);

                //carga el control con los datos del data set
                ComboBox.DataSource = TablaDeDatos;
                ComboBox.DisplayMember = "descripcion";
                ComboBox.ValueMember = "id";
                ComboBox.SelectedIndex = 0;
            }
            catch (SqlException Sqlex)
            {
                Cursor.Current = Cursors.Default;
                ClaseComunes.MsjShow(msgError + ": " + Sqlex.Message, 1, 1);
                return false;
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                ClaseComunes.MsjShow(msgError + ": " + ex.Message, 1, 1);
                return false;
            }
            finally
            {
                if (Sqlconexion != null)
                { Sqlconexion.Close(); }
                Sqlconexion.Dispose();
            }
            return true;
        }

        public bool SetCmbText(string Texto, string msgError, ref ComboBox ComboBox)
        {
            TablaDeDatos = null;
            try
            {
                TablaDeDatos = new DataTable();
                //Instanciamos el objeto Conexión con la cadena de Conexión.
                Sqlconexion = new SqlConnection(strConexion);
                //Abrimos la Conexión
                Sqlconexion.Open();
                //Instanciamos el objeto comando con el TSQL
                ComandoSql = new SqlCommand();//(SpNom, con);
                ComandoSql.Connection = Sqlconexion;
                //Asignamos el tipo de comando a ejecutar.
                ComandoSql.CommandType = CommandType.Text;
                //Agregamos el nombre del Srore procedure.
                ComandoSql.CommandText = Texto;
                //Instanciamos el objeto Adaptador con el comando a utilizar
                AdaptadorDeDatosSql = new SqlDataAdapter(ComandoSql);
                //Llenamos el Dataset con el adaptador de datos.
                AdaptadorDeDatosSql.Fill(TablaDeDatos);
                //Agrega un nuevo item
                DataRow row = TablaDeDatos.NewRow();
                row["id"] = 0;
                row["Descripcion"] = "seleccione...";
                TablaDeDatos.Rows.InsertAt(row, 0);

                //carga el control con los datos del data set
                ComboBox.DataSource = TablaDeDatos;
                ComboBox.DisplayMember = "descripcion";
                ComboBox.ValueMember = "id";
                ComboBox.SelectedIndex = 0;
            }
            catch (SqlException Sqlex)
            {
                Cursor.Current = Cursors.Default;
                //Controladores.claseControlComunes.MsjShow(msgError + ": " + Sqlex.Message, 1, 1);
                return false;
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                //Controladores.claseControlComunes.MsjShow(msgError + ": " + ex.Message, 1, 1);
                return false;
            }
            finally
            {
                if (Sqlconexion != null)
                { Sqlconexion.Close(); }
                Sqlconexion.Dispose();
            }

            return true;
        }

        #endregion
    }
}
