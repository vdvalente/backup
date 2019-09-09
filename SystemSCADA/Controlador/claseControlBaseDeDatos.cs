using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemSCADA.Modelo;

namespace SystemSCADA.Controlador
{

    public class claseControlBaseDeDatos
    {
        /*****************************************************************************************************************************************************
        Nombre del Creador:Victor Valente
        Fecha de Creacion: 8/09/19
        Descripcion: Propiedades de la Clase
        *****************************************************************************************************************************************************/
         public static string SQlsistemaSCADA { get; set; }      //Nombre del Servidor SQL EtqLinProd
        public static string SQLNomDBsistemaSCADA { get; set; }     //Nombre de la Base de Datos EtqLinProd
        public static string SQLUsersistemaSCADA { get; set; }      //Usuario de la Base de Datos EtqLinProd
        public static string SQLPasssistemaSCADA { get; set; }      //Contraseña de la Base de Datos EtqLinProd
        public static int ERP { get; set; }                 //Id del ERP con que se trabajara
        public static string ServERP { get; set; }          //Nombre del Servidor ERP
        public static string NomDBERP { get; set; }         //Nombre de la Base de Datos ERP
        public static string UserERP { get; set; }          //Usuario de la Base de Datos ERP
        public static string PassERP { get; set; }          //Contraseña de la Base de Datos ERP


        private string G_SqlConn;                           //Guarda el String de conexion SystemSCADA
        private string G_ERPConn;                           //Guarda el String de conexion ERP

        /*****************************************************************************************************************************************************
        Nombre del Creador:Victor Valente
        Fecha de Creacion: septiembre del 2019
        Descripcion: Guarda los parametros para la conexion con el servidor
        *****************************************************************************************************************************************************/
        public void Guardar( string ServSCADA, string DBNomSCADA, string UserSCADA, string PassSCADA)
        {
            SQlsistemaSCADA = ServSCADA;
            SQLNomDBsistemaSCADA = DBNomSCADA;
            SQLUsersistemaSCADA = UserSCADA;
            SQLPasssistemaSCADA = PassSCADA;
        }

        public void GuardarERP(int IdERP, string ServiERP, string DBNomERP, string UsrERP, string PasERP)
        {
            ERP = IdERP;
            ServERP = ServiERP;
            NomDBERP = DBNomERP;
            UserERP = UsrERP;
            PassERP = PasERP;
        }

        /*****************************************************************************************************************************************************
        Nombre del Creador:Victor Valente
        Fecha de Creacion: septiembre del 2019
        Descripcion: Encripta una cadena
        *****************************************************************************************************************************************************/
        public string Encriptar(string _cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }


        /*****************************************************************************************************************************************************
        Nombre del Creador:Victor Valente
        Fecha de Creacion: septiembre del 2019
        Descripcion: función desencripta la cadena que le envíamos en el parámentro de entrada.
        *****************************************************************************************************************************************************/
        public string DesEncriptar(string _cadenaAdesencriptar)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
            result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            return result;
        }



        /*****************************************************************************************************************************************************
        Nombre del Creador:Victor Valente
        Fecha de Creacion: septiembre del 2019
        Descripcion: Procedimiento para probar el estado de la conexion con el servidor
        *****************************************************************************************************************************************************/
        public bool ProbarConeccion()
        {
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
            G_SqlConn = "Data Source=" + SQlsistemaSCADA + ";Initial Catalog=" +
                SQLNomDBsistemaSCADA + ";User ID=" + SQLUsersistemaSCADA + ";Password=" + SQLPasssistemaSCADA;

            SqlConnection con = new SqlConnection(G_SqlConn);
            try
            {
                con.Open();
                Cursor.Current = Cursors.Default;
                return true;
            }
            catch (SqlException SQLex)
            {
                MessageBox.Show("Error al conectarse a Servidor, verifique los datos e intente de nuevo." +
                        "\nServidor: " + SQlsistemaSCADA +
                        "\nBase de Datos: " + SQLNomDBsistemaSCADA +
                        "\n" + SQLex.Message,
                        "SistemaSCADA",
                        MessageBoxButtons.OK);
                Cursor.Current = Cursors.Default;
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse a Servidor, verifique los datos e intente de nuevo." +
                        "\nServidor: " + SQlsistemaSCADA +
                        "\nBase de Datos: " + SQLNomDBsistemaSCADA +
                        "\nUsuario: " + SQLUsersistemaSCADA +
                        "\n" + ex.Message,"SistemaSCADA",
                        MessageBoxButtons.OK,MessageBoxIcon.Error);
                Cursor.Current = Cursors.Default;
                return false;
            }
            finally
            {
                if (con != null)
                { con.Close(); }
                con.Dispose();
            }
        }

        public bool ProbarConeccionERP()
        {
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
            switch(ERP)
            {
                #region SQL
                case 1:

                    G_ERPConn = "Data Source=" + ServERP + ";Initial Catalog=" +
                        NomDBERP + ";User ID=" + UserERP + ";Password=" + PassERP;

                    SqlConnection conSQL = new SqlConnection(G_ERPConn);
                    try
                    {
                        conSQL.Open();
                        Cursor.Current = Cursors.Default;
                    }
                    catch (SqlException SQLex)
                    {
                        MessageBox.Show("Error al conectarse a Servidor ERP, verifique los datos e intente de nuevo." +
                                "\nServidor: " + ServERP +
                                "\nBase de Datos: " + NomDBERP +
                                "\nUsuario: " + UserERP +
                                "\n" + SQLex.Message,
                                "sistemaSCADA",
                                MessageBoxButtons.OK);
                        Cursor.Current = Cursors.Default;
                        return false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al conectarse a Servidor ERP, verifique los datos e intente de nuevo." +
                                "\nServidor: " + ServERP +
                                "\nBase de Datos: " + NomDBERP +
                                "\nUsuario: " + UserERP +
                                "\n" + ex.Message, "sistemaSCADA",
                                MessageBoxButtons.OK);
                        Cursor.Current = Cursors.Default;
                        return false;
                    }
                    finally
                    {
                        if (conSQL != null)
                        { conSQL.Close(); }
                        conSQL.Dispose();
                    }
                    break;
                #endregion

                #region Oracle
                case 2:
                    G_ERPConn = "DATA SOURCE=" + ServERP + ";PERSIST SECURITY INFO=True" +
                       ";USER ID=" + UserERP + ";password=" + PassERP + "; Pooling=False;";

                    OracleConnection conOracle = new OracleConnection();
                    try
                    {
                        conOracle.ConnectionString = G_ERPConn;
                        conOracle.Open();
                        Cursor.Current = Cursors.Default;
                    }
                    catch (OracleException ORACLEex)
                    {
                        MessageBox.Show("Error al conectarse a Servidor ERP, verifique los datos e intente de nuevo." +
                                "\nServidor: " + ServERP +
                                "\nUsuario: " + UserERP +
                                "\n" + ORACLEex.Message,
                                "SistemaSCADA",
                                MessageBoxButtons.OK);
                        Cursor.Current = Cursors.Default;
                        return false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al conectarse a Servidor ERP, verifique los datos e intente de nuevo." +
                                "\nServidor: " + ServERP +
                                "\nUsuario: " + UserERP +
                                "\n" + ex.Message, "sistemaSCADA",
                                MessageBoxButtons.OK);
                        Cursor.Current = Cursors.Default;
                        return false;
                    }
                    finally
                    {
                        if (conOracle != null)
                        { conOracle.Close(); }
                        conOracle.Dispose();
                    }
                    break;
                #endregion
            }
            return true;
        }

        public static void llenarCmbERP(ref ComboBox cmb)
        {
            claseMetodosBaseDeDatos conexionBD = new claseMetodosBaseDeDatos(SQlsistemaSCADA, SQLNomDBsistemaSCADA, SQLUsersistemaSCADA, SQLPasssistemaSCADA);
            SqlParameter[] Parametros = new SqlParameter[0];
            conexionBD.SetCmbSP(ref Parametros, "usp_SetcmbERP", "No se puede obtener informacion", ref cmb);
        }

        /*****************************************************************************************************************************************************
        Nombre del Creador: Victor Valente
        Fecha de Creacion: 7/10/2019
        Descripcion: Valida que todos los TextBox no esten vacios y que el ComboBox no este sin seleccion
        Dependiendo del parametro TipoValidacion verifica solo los campos de SystemSCADA (1), solo los campos del ERP (2) o 
        todos los campos(0)
        *****************************************************************************************************************************************************/
        public bool ValidarCampos(int TipoValidacion = 0)
        {
            if (TipoValidacion == 1 || TipoValidacion == 0)
            {
                if (SQlsistemaSCADA == "")
                {
                    MessageBox.Show("Hace falta el nombre del servidor", "SistemaSCADA", MessageBoxButtons.OK);
                    return false;
                }
                if (SQLNomDBsistemaSCADA == "")
                {
                    MessageBox.Show("Hace falta el nombre de la base de datos ", "SistemaSCADA", MessageBoxButtons.OK);
                    return false;
                }
                if (SQLUsersistemaSCADA == "")
                {
                    MessageBox.Show("Hace falta el usuario de la base de datos", "SistemaSCADA", MessageBoxButtons.OK);
                    return false;
                }
                if (SQLPasssistemaSCADA == "")
                {
                    MessageBox.Show("Hace falta la contraseña de la base de datos", "SistemaSCADA", MessageBoxButtons.OK);
                    return false;
                }
            }
            if(TipoValidacion == 2 || TipoValidacion == 0)
            {
                if (ERP == 0)
                {
                    MessageBox.Show("Hace falta seleccionar el ERP con el que se va a trabajar", "SistemaSCADA", MessageBoxButtons.OK);
                    return false;
                }
                if (ServERP == "")
                {
                    MessageBox.Show("Hace falta el nombre del servidor del ERP", "SistemaSCADA", MessageBoxButtons.OK);
                    return false;
                }
                if (NomDBERP == "")
                {
                    MessageBox.Show("Hace falta el nombre de la base de datos del ERP", "SistemaSCADA", MessageBoxButtons.OK);
                    return false;
                }
                if (UserERP == "")
                {
                    MessageBox.Show("Hace falta el usuario de la base de datos del ERP", "SistemaSCADA", MessageBoxButtons.OK);
                    return false;
                }
                if (PassERP == "")
                {
                    MessageBox.Show("Hace falta la contraseña de la base de datos del ERP", "SistemaSCADA", MessageBoxButtons.OK);
                    return false;
                }
            }
            return true;
        }
    }
}
