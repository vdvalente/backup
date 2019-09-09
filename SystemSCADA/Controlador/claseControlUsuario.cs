using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemSCADA.Modelo;
using SystemSCADA.Controlador;
using SystemSCADA.Vista;
using System.Drawing;

namespace SystemSCADA.Controlador
{
    public class claseControlUsuario
    {

        /*****************************************************************************************************************************************************
       Nombre del Creador:Melanie Infante
       Fecha de Creacion: 27/09/18
       Descripcion: Propiedades de la Clase
       *****************************************************************************************************************************************************/
        public static int IdUsuario { get; set; }
        public static string Direccion { get; set; }
        public static string Nombre { get; set; }
        public static string Apellido { get; set; }
        public static string Tlf { get; set; }
        public static int IdPerfil { get; set; }
        public static string Contraseña { get; set; }
        public static string UserName { get; set; }
        public static string Correo { get; set; }
        public static bool Estatus { get; set; }
        public static string Cedula { get; set; }


        /*****************************************************************************************************************************************************
        Nombre del Creador:Melanie Infante
        Fecha de Creacion: 1/10/18
        Descripcion: Conexion a la base de datos
        *****************************************************************************************************************************************************/
        static claseMetodosBaseDeDatos conexionBD;

        /*****************************************************************************************************************************************************
        Nombr e del Creador:Melanie Infante
        Fecha de Creacion: 17/09/18
        Descripcion: Metodo que ejecuta el procedimiento de almacenado que permite guardar en la base de datos
        *****************************************************************************************************************************************************/
        //public bool GuardarUsuario(DataGridView dgv)
        //{
        //    conexionBD = new claseMetodosBaseDeDatos(claseControlBaseDeDatos.SQlSCADA, claseControlBaseDeDatos.SQLNomDBSCADA, claseControlBaseDeDatos.SQLUserSCADA, claseControlBaseDeDatos.SQLPassSCADA);
        //    try
        //    {
        //        SqlParameter[] Parametros = new SqlParameter[12];

        //        Parametros[0] = new SqlParameter();
        //        Parametros[0].ParameterName = "@IdUsuario";
        //        Parametros[0].SqlDbType = SqlDbType.Int;
        //        Parametros[0].Value = IdUsuario;

        //        Parametros[1] = new SqlParameter();
        //        Parametros[1].ParameterName = "@Direccion";
        //        Parametros[1].SqlDbType = SqlDbType.VarChar;
        //        Parametros[1].Size = 300;
        //        Parametros[1].Value = Direccion;

        //        Parametros[2] = new SqlParameter();
        //        Parametros[2].ParameterName = "@Nombre";
        //        Parametros[2].SqlDbType = SqlDbType.VarChar;
        //        Parametros[2].Size = 50;
        //        Parametros[2].Value = Nombre;

        //        Parametros[3] = new SqlParameter();
        //        Parametros[3].ParameterName = "@Apellido";
        //        Parametros[3].SqlDbType = SqlDbType.VarChar;
        //        Parametros[3].Size = 50;
        //        Parametros[3].Value = Apellido;

        //        Parametros[4] = new SqlParameter();
        //        Parametros[4].ParameterName = "@Cedula";
        //        Parametros[4].SqlDbType = SqlDbType.VarChar;
        //        Parametros[4].Size = 20;
        //        Parametros[4].Value = Cedula;

        //        Parametros[5] = new SqlParameter();
        //        Parametros[5].ParameterName = "@Estatus";
        //        Parametros[5].SqlDbType = SqlDbType.Bit;
        //        Parametros[5].Value = Estatus;

        //        Parametros[6] = new SqlParameter();
        //        Parametros[6].ParameterName = "@Tlf";
        //        Parametros[6].SqlDbType = SqlDbType.VarChar;
        //        Parametros[6].Size = 20;
        //        Parametros[6].Value = Tlf;

        //        Parametros[7] = new SqlParameter();
        //        Parametros[7].ParameterName = "@IdUsuarioEmi";
        //        Parametros[7].SqlDbType = SqlDbType.Int;
        //        Parametros[7].Value = claseUsuarioAct.IdUsuario;

        //        Parametros[8] = new SqlParameter();
        //        Parametros[8].ParameterName = "@IdPerfil";
        //        Parametros[8].SqlDbType = SqlDbType.Int;
        //        Parametros[8].Value = IdPerfil;

        //        Parametros[9] = new SqlParameter();
        //        Parametros[9].ParameterName = "@Contraseña";
        //        Parametros[9].SqlDbType = SqlDbType.VarChar;
        //        Parametros[9].Size = 100;
        //        Parametros[9].Value = Contraseña;

        //        Parametros[10] = new SqlParameter();
        //        Parametros[10].ParameterName = "@UserName";
        //        Parametros[10].SqlDbType = SqlDbType.VarChar;
        //        Parametros[10].Size = 20;
        //        Parametros[10].Value = UserName;

        //        Parametros[11] = new SqlParameter();
        //        Parametros[11].ParameterName = "@Correo";
        //        Parametros[11].SqlDbType = SqlDbType.VarChar;
        //        Parametros[11].Size = 60;
        //        Parametros[11].Value = Correo;

        //        if(IdUsuario == 0)
        //            IdUsuario = Convert.ToInt32(conexionBD.ScalarSP(ref Parametros, "usp_GuardarUsuario", 
        //                "Error guardanto los datos del Usuario"));
        //        else
        //            conexionBD.EjecutarSP(ref Parametros, "usp_GuardarUsuario",
        //                "Error guardanto los datos del Usuario");

        //        foreach(DataGridViewRow Row in dgv.Rows)
        //        {
        //            SqlParameter[] Parametros2 = new SqlParameter[3];

        //            Parametros2[0] = new SqlParameter();
        //            Parametros2[0].ParameterName = "@IdUsuario";
        //            Parametros2[0].SqlDbType = SqlDbType.Int;
        //            Parametros2[0].Value = IdUsuario;

        //            Parametros2[1] = new SqlParameter();
        //            Parametros2[1].ParameterName = "@IdEmpresa";
        //            Parametros2[1].SqlDbType = SqlDbType.Int;
        //            Parametros2[1].Value = Convert.ToInt32(dgv.Rows[Row.Index].Cells["Id"].Value);

        //            Parametros2[2] = new SqlParameter();
        //            Parametros2[2].ParameterName = "@Permiso";
        //            Parametros2[2].SqlDbType = SqlDbType.Bit;
        //            Parametros2[2].Value = Convert.ToBoolean(dgv.Rows[Row.Index].Cells["Permiso"].Value);

        //            conexionBD.EjecutarSP(ref Parametros2, "usp_GuardarEmpresaUsuario",
        //                "Error guardanto los permisos del Usuario");
        //        }
        //        return true;
        //    }
        //    catch (SqlException SQLex)
        //    {
        //        claseControlComunes.MsjShow(SQLex.Message, 1, 1);
        //        return false;
        //    }
        //    catch (Exception ex)
        //    {
        //        claseControlComunes.MsjShow(ex.Message, 1, 1);
        //        return false;
        //    }
        //}


        /*****************************************************************************************************************************************************
        Nombre del Creador:Melanie Infante
        Fecha de Creacion: 20/09/18
        Descripcion: Metodo para llenar una Grid View, en el que se definen las columnas y ls valores que se van a mostrar. Tambien
        es utilizado para la busqueda de uno o varios registros perteneciente a la Grid
        *****************************************************************************************************************************************************/
        public static void setDgrw(ref DataGridView grv, ref Label lbl, string storeProcedure, string Busqueda = "")
        {
            conexionBD = new claseMetodosBaseDeDatos(claseControlBaseDeDatos.SQlsistemaSCADA, claseControlBaseDeDatos.SQLNomDBsistemaSCADA, claseControlBaseDeDatos.SQLUsersistemaSCADA, 
                claseControlBaseDeDatos.SQLPasssistemaSCADA);
            DataGridViewCheckBoxColumn sts = new DataGridViewCheckBoxColumn();

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Application.DoEvents();
                SqlParameter[] Parametros;
                Parametros = new SqlParameter[0];
                if (Busqueda != "")
                {
                    Parametros = new SqlParameter[1];
                    Parametros[0] = new SqlParameter();
                    Parametros[0].ParameterName = "@Busqueda";
                    Parametros[0].SqlDbType = SqlDbType.VarChar;
                    Parametros[0].Size = 150;
                    Parametros[0].Value = Busqueda;
                }

                grv.DataSource = conexionBD.TablaSP(ref Parametros, storeProcedure, "Error obteniendo los datos");
                lbl.Text = grv.Rows.Count.ToString();

                grv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grv.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12f, FontStyle.Bold, 0);

                grv.Columns["NombreUsuario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grv.Columns["NombreUsuario"].HeaderText = "Nombre";
                grv.Columns["NombreUsuario"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                grv.Columns["NombreUsuario"].Width = 150;
                grv.Columns["Apellido"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grv.Columns["Apellido"].HeaderText = "Apellido";
                grv.Columns["Apellido"].Width = 150;
                grv.Columns["Cedula"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grv.Columns["Cedula"].HeaderText = "Cedula";
                grv.Columns["Cedula"].Width = 80;
                grv.Columns["FechaEmi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grv.Columns["FechaEmi"].HeaderText = "Creado el:";
                grv.Columns["FechaEmi"].Width = 80;
                grv.Columns["UserName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grv.Columns["UserName"].HeaderText = "Usuario";
                grv.Columns["UserName"].Width = 80;
                grv.Columns["Perfil"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grv.Columns["Perfil"].HeaderText = "Perfil";
                grv.Columns["Perfil"].Width = 100;


                grv.Columns.Remove("Estatus");
                grv.Columns.Insert(grv.Columns.Count, sts);
                grv.Columns[grv.Columns.Count - 1].Name = "Estatus";
                grv.Columns["Estatus"].DataPropertyName = "Estatus";
                grv.Columns["Estatus"].HeaderText = "Estado";
                grv.Columns["Estatus"].Width = 60;

                grv.Columns["IdUsuario"].Visible = false;
                grv.Columns["IdUsuarioEmi"].Visible = false;
                grv.Columns["Contraseña"].Visible = false;
                grv.Columns["IdPerfil"].Visible = false;
                grv.Columns["Direccion"].Visible = false;
                grv.Columns["Tlf"].Visible = false;
                grv.Columns["Correo"].Visible = false;
            }
            catch (SqlException SQLex)
            {
                MessageBox.Show(SQLex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*****************************************************************************************************************************************************
        Nombre del Creador: Melanie Infante
        Fecha de Creacion: 27/09/18
        Descripcion: Procedimiento para llenar ComboBox
        *****************************************************************************************************************************************************/
        public static void llenarCmbPerfil(ref ComboBox cmb)
        {
            conexionBD = new claseMetodosBaseDeDatos(claseControlBaseDeDatos.SQlsistemaSCADA, claseControlBaseDeDatos.SQLNomDBsistemaSCADA, 
                claseControlBaseDeDatos.SQLUsersistemaSCADA, claseControlBaseDeDatos.SQLPasssistemaSCADA);
            SqlParameter[] Parametros = new SqlParameter[0];
            conexionBD.SetCmbSP(ref Parametros, "usp_SetcmbPerfil", "No se puede obtener informacion", ref cmb);
        }

        /*****************************************************************************************************************************************************
        Nombre del Creador: Melanie Infante
        Fecha de Creacion: 3/10/18
        Descripcion: Procedimiento para borrar un Registro de la GridView
        *****************************************************************************************************************************************************/
        public static bool ActualizarEstatus()
        {
            conexionBD = new claseMetodosBaseDeDatos(claseControlBaseDeDatos.SQlsistemaSCADA, claseControlBaseDeDatos.SQLNomDBsistemaSCADA, 
                claseControlBaseDeDatos.SQLUsersistemaSCADA, claseControlBaseDeDatos.SQLPasssistemaSCADA);
            try
            {
                SqlParameter[] Parametros = new SqlParameter[1];


                Parametros[0] = new SqlParameter();
                Parametros[0].ParameterName = "@Id";
                Parametros[0].SqlDbType = SqlDbType.Int;
                Parametros[0].Value = IdUsuario;

                conexionBD.EjecutarSP(ref Parametros, "usp_ActualizarEstatusUsuario", "Error eliminando el registro");
                return true;
            }
            catch (SqlException SQLex)
            {
                MessageBox.Show(SQLex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /*****************************************************************************************************************************************************
        Nombre del Creador:Juan Sanchez
        Fecha de Creacion: septiembre del 2018
        Descripcion: Añade el control de usuario a un panel
        *****************************************************************************************************************************************************/
        //public void Guardar(int IdUser, int IdPerfil, string Nom, string User)
        //{
        //    claseUsuarioAct.IdUsuario = IdUser;
        //    claseUsuarioAct.IdPerfil = IdPerfil;
        //    claseUsuarioAct.NombreUsuario = Nom;
        //    claseUsuarioAct.Usuario = User;
        //    claseUsuarioAct.Contraseña = claseControlComunes.ObtenerHash(Contraseña);
        //}

        #region Chekear

        /*****************************************************************************************************************************************************
         Nombre del Creador:Juan Sanchez
         Fecha de Creacion: septiembre del 2018
         Descripcion: Funcion para verificar la existencia de usuarios
         *****************************************************************************************************************************************************/
        public bool ExistenciaDeUsuarios()
        {
            conexionBD = new claseMetodosBaseDeDatos(claseControlBaseDeDatos.SQlsistemaSCADA, claseControlBaseDeDatos.SQLNomDBsistemaSCADA, 
                claseControlBaseDeDatos.SQLUsersistemaSCADA, claseControlBaseDeDatos.SQLPasssistemaSCADA);

            try
            {
                int L_ConsultaUsuario;
                L_ConsultaUsuario = Convert.ToInt32(conexionBD.ScalarText("Select Count([IdUsuario]) from " +
                    "[dbo].[Usuario] where [Estatus] = 1",
                    "Error obteniendo datos del usuario"));
                if (L_ConsultaUsuario > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        /*****************************************************************************************************************************************************
        Nombre del Creador: Juan Sanchez
        Fecha de Creacion: 
        Descripcion: Valida que no se repita un usuario en particular
        *****************************************************************************************************************************************************/
        public bool VerificarExitenciaUsuario()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Application.DoEvents();
                SqlParameter[] Parametros = new SqlParameter[3];

                Parametros[0] = new SqlParameter();
                Parametros[0].ParameterName = "@cedula";
                Parametros[0].SqlDbType = SqlDbType.VarChar;
                Parametros[0].Size = 20;
                Parametros[0].Value = Cedula;

                Parametros[1] = new SqlParameter();
                Parametros[1].ParameterName = "@idUsuario";
                Parametros[1].SqlDbType = SqlDbType.Int;
                Parametros[1].Value = IdUsuario;

                Parametros[2] = new SqlParameter();
                Parametros[2].ParameterName = "@UserName";
                Parametros[0].SqlDbType = SqlDbType.VarChar;
                Parametros[0].Size = 20;
                Parametros[2].Value = UserName;

                DataTable L_TablaEmpresa = conexionBD.TablaSP(ref Parametros, "usp_VerificarExistenciaUsuario", "Error obteniendo datos del Usuario");

                if (L_TablaEmpresa.Rows.Count > 0)
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

        /*****************************************************************************************************************************************************
         Nombre del Creador:Juan Sanchez
         Fecha de Creacion: septiembre del 2018
         Descripcion: Funcion para verificar la existencia de un usuario en particular
         *****************************************************************************************************************************************************/
        public bool chkUsuario()
        {
            conexionBD = new claseMetodosBaseDeDatos(claseControlBaseDeDatos.SQlsistemaSCADA, claseControlBaseDeDatos.SQLNomDBsistemaSCADA, claseControlBaseDeDatos.SQLUsersistemaSCADA, 
                claseControlBaseDeDatos.SQLPasssistemaSCADA);
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Application.DoEvents();
                SqlParameter[] Parametros = new SqlParameter[2];

                Parametros[0] = new SqlParameter();
                Parametros[0].ParameterName = "@Login";
                Parametros[0].SqlDbType = SqlDbType.VarChar;
                Parametros[0].Value = UserName;

                Parametros[1] = new SqlParameter();
                Parametros[1].ParameterName = "@Pass";
                Parametros[1].SqlDbType = SqlDbType.VarChar;
                Parametros[1].Value = ClaseComunes.ObtenerHash(Contraseña);

                DataTable L_TablaUsuario = conexionBD.TablaSP(ref Parametros, "usp_BuscarUsuario", "Error obteniendo datos del usuario: ");

                if (L_TablaUsuario.Rows.Count > 0)
                {
                    Cursor.Current = Cursors.Default;
                    //Guardar(Convert.ToInt32(L_TablaUsuario.Rows[0]["IdUsuario"]), Convert.ToInt32(L_TablaUsuario.Rows[0]["IdPerfil"]), L_TablaUsuario.Rows[0]["Nombre"].ToString(), L_TablaUsuario.Rows[0]["UserName"].ToString());

                    /* #region Agrega nuevas opciones al perfil del usuario que esta entrando
                     SqlParameter[] Parametros2 = new SqlParameter[1];

                     Parametros2[0] = new SqlParameter();
                     Parametros2[0].ParameterName = "@IdPerfil";
                     Parametros2[0].SqlDbType = SqlDbType.Int;
                     Parametros2[0].Value = claseUsuario.IdPerfil;

                     conexionBD.EjecutarSP(Parametros2, "usp_ChequearModulos",
                         "Error obteniendo datos del usuario");
                     #endregion*/


                    return true;
                }
                else
                {
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("El Usuario y/o la contraceña no coinciden, esta inactivo o inexistente, " +
                        "Verifique, e intente nuevamente.", "SystemaSCADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            catch
            {
                return false;
            }
        }


        #endregion


        public bool ValidarCampos()
        {

            if (IdPerfil == 0)
            {
                MessageBox.Show("Se Debe seleccionar el perfil.", "SystemaSCADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Nombre == "")
            {
                MessageBox.Show("Se debe aregar el Nombre", "SystemaSCADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Apellido == "")
            {
                MessageBox.Show("Se debe aregar el Apellido", "SystemaSCADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Contraseña == "")
            {
                MessageBox.Show("Se debe aregar la contraseña", "SystemaSCADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (UserName == "")
            {
                MessageBox.Show("Se debe aregar el usuario", "SystemaSCADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Cedula == "")
            {
                MessageBox.Show("Se debe aregar la Cedula", "SystemaSCADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
