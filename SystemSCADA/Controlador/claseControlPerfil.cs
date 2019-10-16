
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemSCADA.Vista;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using SystemSCADA.Modelo;

namespace SystemSCADA.Controlador
{
    public class claseControlPerfil
    {
       

        public static int IdEmpresa { get; set; }
        public static int IdPerfil { get; set; }
        public static string Nombre { get; set; }
        public static bool Agregar { get; set; }
        public static bool Modificar { get; set; }
        public static bool Eliminar { get; set; }

        public static int Elimina;

        // Instancia para la clase de metodos de base de datos
        static claseMetodosBaseDeDatos conexionBD = new claseMetodosBaseDeDatos(claseControlBaseDeDatos.SQlsistemaSCADA, claseControlBaseDeDatos.SQLNomDBsistemaSCADA,
       claseControlBaseDeDatos.SQLUsersistemaSCADA, claseControlBaseDeDatos.SQLPasssistemaSCADA);


        /*****************************************************************************************************************************************************
       Descripcion: Procedimiento para Modificar datagridview de los permisos asociados a un perfil
       *****************************************************************************************************************************************************/
        public static void ModificarDgv(ref DataGridView dgv, string storeProcedure)
        {         
            try
            {
                SqlParameter[] Parametros = new SqlParameter[0];

                dgv.DataSource = conexionBD.TablaSP(ref Parametros, storeProcedure, "Error:");

                dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12f, FontStyle.Bold, 0);
                foreach (DataGridViewRow Row in dgv.Rows)
                {
                    Row.Cells["Agregar"].Value = false;
                    Row.Cells["Modificar"].Value = false;
                    Row.Cells["Eliminar"].Value = false;
                }

                dgv.Columns["IdOpciones"].Visible = false;
                dgv.Columns["IdPerfil"].Visible = false;

            }
            catch (SqlException) { }
            catch (Exception ex)
            {
                ClaseComunes.MsjShow(ex.Message, 1, 1);
            }
        }


        /*****************************************************************************************************************************************************
       Nombre del Creador:Juan Sanchez
       Fecha de Creacion: Octubre del 2018
       Descripcion: Procedimiento para actualizar los modulos del sistema
       *****************************************************************************************************************************************************/
        public static void ActualizarModulos()
        {
            SqlParameter[] Parametros = new SqlParameter[0];          
            conexionBD.EjecutarSP(ref Parametros, "usp_ActualizarModulos", "Error");
        }


        /*****************************************************************************************************************************************************
       Nombre del Creador:Juan Sanchez
       Fecha de Creacion: Octubre del 2018
       Descripcion: Procedimiento para verificar si falta algun perfil por un modulo nuevo agregado al sistema, Si no lo posee, lo inserta.
       *****************************************************************************************************************************************************/
        public static bool ChequearModulos(ref DataGridView dgv)
        {
            try
            {
                SqlParameter[] Parametros = new SqlParameter[0];
                conexionBD.EjecutarSP(ref Parametros, "usp_ChequearModulos", "Error");

                return true;
            }
            catch (SqlException SQLex)
            {
                ClaseComunes.MsjShow(SQLex.Message, 1, 1);
                return false;
            }
            catch (Exception ex)
            {
                ClaseComunes.MsjShow(ex.Message, 1, 1);
                return false;
            }

        }


        /*****************************************************************************************************************************************************
       Nombre del Creador:Juan Sanchez
       Fecha de Creacion: Octubre del 2018
       Descripcion: Procedimiento para eliminar un perfil. Recibe el DataGridView del perfil por parametro con el fin de ver la celda actual seleccionada con 
       la finalidad de consultar el Id para borrarrla de la base de datos mediante un procedimiento almacenado. 
       *****************************************************************************************************************************************************/
        public static void EliminarPerfil()
        {
            try
            {
                SqlParameter[] Parametros = new SqlParameter[1];
                Parametros[0] = new SqlParameter();
                Parametros[0].ParameterName = "@IdPerfil";
                Parametros[0].SqlDbType = SqlDbType.Int;
                Parametros[0].Value = IdPerfil;

                Elimina = Convert.ToInt32(conexionBD.ScalarSP(ref Parametros, "usp_EliminarPerfil", "Error"));
            }
            catch(SqlException SQLex)
            {
                ClaseComunes.MsjShow(SQLex.Message, 1, 1);
                Elimina = 1;
            }
            catch (Exception ex)
            {
                ClaseComunes.MsjShow(ex.Message, 1, 1);
                Elimina = 1;
            }
        }


        /*****************************************************************************************************************************************************
       Nombre del Creador:Juan Sanchez
       Fecha de Creacion: 
       Descripcion: Limpiar DataGridView del modulo perfil.
       *****************************************************************************************************************************************************/
        public static void LimpiarDataGridView(DataGridView dgvListadoModulo )
        {
            foreach (DataGridViewRow Row in dgvListadoModulo.Rows)
            {
                Row.Cells["Agregar"].Value = 0;
                Row.Cells["Modificar"].Value = 0;
                Row.Cells["Eliminar"].Value = 0;        
             }
         }


        /*****************************************************************************************************************************************************
       Descripcion: Procedimiento para guardar un perfil. Recibe la DataGridView por referencia del perfil, para extraer la descripcion y el Id
       actualmente seleccionado. Recibe la DataGridView por referencia del listado de modulo para saber cuales fueron los parametros requeridos para asi
       insertalos en la base de datos.
       *****************************************************************************************************************************************************/
        public static bool GuardarPerfil(DataGridView dgvListadoModulo)
        {
            try
            {
                SqlParameter[] Parametros = new SqlParameter[2];
                SqlParameter[] Parametros2 = new SqlParameter[6];
                int L_ConsultaPerfil=0;

                Parametros[0] = new SqlParameter();
                Parametros[0].ParameterName = "@sPerfil";
                Parametros[0].SqlDbType = SqlDbType.VarChar;
                Parametros[0].Size = 50;
                Parametros[0].Value = Nombre;

                Parametros[1] = new SqlParameter();
                Parametros[1].ParameterName = "@Perfil_Id";
                Parametros[1].SqlDbType = SqlDbType.Int;
                Parametros[1].Value = IdPerfil;

                conexionBD.EjecutarSP(ref Parametros, "usp_GuardarPerfil", "Error guardanto los datos del Perfil");

                if (IdPerfil == 0)
                {
                   
                    L_ConsultaPerfil = Convert.ToInt32(conexionBD.ScalarText("Select Max([Perfil_Id]) from " +
                            "[dbo].[Perfil]", "Error obteniendo datos del Perfil"));
                   
                }

                  
               if(IdPerfil != 0)
                {
                    foreach (DataGridViewRow Row in dgvListadoModulo.Rows)
                    {
                        Parametros2[0] = new SqlParameter();
                        Parametros2[0].ParameterName = "@IdModulo";
                        Parametros2[0].SqlDbType = SqlDbType.Int;

                        Parametros2[1] = new SqlParameter();
                        Parametros2[1].ParameterName = "@nIdPerfil";
                        Parametros2[1].SqlDbType = SqlDbType.Int;

                        Parametros2[2] = new SqlParameter();
                        Parametros2[2].ParameterName = "@Agregar";
                        Parametros2[2].SqlDbType = SqlDbType.Bit;

                        Parametros2[3] = new SqlParameter();
                        Parametros2[3].ParameterName = "@Modificar";
                        Parametros2[3].SqlDbType = SqlDbType.Bit;

                        Parametros2[4] = new SqlParameter();
                        Parametros2[4].ParameterName = "@Eliminar";
                        Parametros2[4].SqlDbType = SqlDbType.Bit;

                        Parametros2[5] = new SqlParameter();
                        Parametros2[5].ParameterName = "@Acceder";
                        Parametros2[5].SqlDbType = SqlDbType.Bit;

                        Parametros2[0].Value =  Convert.ToInt32(Row.Cells["IdModulo"].Value);
                        if (IdPerfil == 0)
                        {
                            Parametros2[1].Value = L_ConsultaPerfil;
                        } else{
                            Parametros2[1].Value = IdPerfil;
                        }                            

                        Parametros2[2].Value = (Row.Cells["Agregar"].Value);
                        Parametros2[3].Value = (Row.Cells["Modificar"].Value);
                        Parametros2[4].Value = (Row.Cells["Eliminar"].Value);
                        Parametros2[5].Value = (Row.Cells["Acceder"].Value);

                        conexionBD.EjecutarSP(ref Parametros2, "usp_GuardarPermiso", "Error actualizando los permisos del Perfil");

                    }
                }
                    
                ClaseComunes.MsjShow("Los cambios se han guardado correctamente, " + claseUsuarioAct.NombreUsuario + ".",
                1, 5);

                return true;
            }
            catch (SqlException SqlEx)
            {
                ClaseComunes.MsjShow(SqlEx.Message, 1, 1);
                return false;
            }
            catch (Exception ex)
            {
                ClaseComunes.MsjShow(ex.Message, 1, 1);
                return false;
            }
        }


        /*****************************************************************************************************************************************************
        Descripcion: Procedimiento para modificar la DataGridView y la etiqueta del perfil  
        *****************************************************************************************************************************************************/
        public static void setDgrw(ref DataGridView grv, string storeProcedure, string caso , int id,  string busqueda = "")
        {
            DataGridViewCheckBoxColumn Estatus = new DataGridViewCheckBoxColumn();

            try
            {
                SqlParameter[] Parametros;
                Parametros = new SqlParameter[1];
                Parametros[0] = new SqlParameter();
                Parametros[0].ParameterName = "@IdPerfil";
                Parametros[0].SqlDbType = SqlDbType.Int;
                Parametros[0].Value = id;

                if (busqueda != "")
                {
                    Array.Resize<SqlParameter>(ref Parametros,2);
                    Parametros[1] = new SqlParameter();
                    Parametros[1].ParameterName = "@Busqueda";
                    Parametros[1].SqlDbType = SqlDbType.VarChar;
                    Parametros[1].Size = 150;
                    Parametros[1].Value = busqueda;
                }

                grv.DataSource = conexionBD.TablaSP(ref Parametros, storeProcedure, "Error obteniedo los datos.");
                

                grv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                
                grv.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12f, FontStyle.Bold, 0);

                switch (caso)
                {
                    case "ListaPerfil":
                       
                        break;
                    case "ListaModulo":
                        //grv.Columns["IdPerfil"].Visible = false;
                        grv.Columns["Modulo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        grv.Columns["Modulo"].HeaderText = "Modulo";
                        grv.Columns["Modulo"].Width = 200;
                        grv.Columns["Acceder"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        grv.Columns["Acceder"].HeaderText = "Acceder";
                        grv.Columns["Acceder"].Width = 200;
                        grv.Columns["Agregar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        grv.Columns["Agregar"].HeaderText = "Agregar";
                        grv.Columns["Agregar"].Width = 200;
                        grv.Columns["Modificar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        grv.Columns["Modificar"].HeaderText = "Modificar";
                        grv.Columns["Modificar"].Width = 200;
                        grv.Columns["Eliminar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        grv.Columns["Eliminar"].HeaderText = "Eliminar";
                        grv.Columns["Eliminar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        grv.Columns["IdModulo"].Visible = false;
                        break;
                }
            }
            catch (SqlException SqlEx)
            {
                ClaseComunes.MsjShow(SqlEx.Message, 1, 1);
            }
            catch (Exception ex)
            {
                ClaseComunes.MsjShow(ex.Message, 1, 1);
            }
        }

        /*****************************************************************************************************************************************************
        Descripcion: Funcion para verificar si exite un perfil
        *****************************************************************************************************************************************************/
        public static bool VerificarExitenciaPerfil()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Application.DoEvents();
                SqlParameter[] Parametros = new SqlParameter[2];

                Parametros[0] = new SqlParameter();
                Parametros[0].ParameterName = "@nombre";
                Parametros[0].SqlDbType = SqlDbType.VarChar;
                Parametros[0].Size = 20;
                Parametros[0].Value = Nombre;

                Parametros[1] = new SqlParameter();
                Parametros[1].ParameterName = "@idPerfil";
                Parametros[1].SqlDbType = SqlDbType.Int;
                Parametros[1].Value = IdPerfil;


                DataTable L_TablaPerfil = conexionBD.TablaSP(ref Parametros, "usp_VerificarExistenciaPerfil", "Error obteniendo datos del Perfil");

                if (L_TablaPerfil.Rows.Count > 0)
                {
                    return true;
                }
                else
                {

                    return false;
                }

            }
            catch
            {
                return true;
            }
        }
    }
}