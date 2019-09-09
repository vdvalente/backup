using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using SystemSCADA.Modelo;

namespace SystemSCADA.Controlador
{
    public class claseUsuarioAct
    {
        public static int IdUsuario { get; set; }         //Id del usuario actual del sistema
        public static int IdPerfil { get; set; }          //Id del perfil del usuario actual
        public static string NombreUsuario { get; set; }  //Nombre del Usuario 
        public static string Usuario { get; set; }        //Alias del Usuario Actual del Sistema
        public static string Contraseña { get; set; }     //Contraseña del usuario actual del sistema
        public static string ConfirContraseña { get; set; }

      
        
        static claseMetodosBaseDeDatos conexionBD = new claseMetodosBaseDeDatos(claseControlBaseDeDatos.SQlsistemaSCADA, claseControlBaseDeDatos.SQLNomDBsistemaSCADA,
        claseControlBaseDeDatos.SQLUsersistemaSCADA, claseControlBaseDeDatos.SQLPasssistemaSCADA);

        public static bool CambiarCavle()
        {
            try
            {
                string Sentencia;

                Sentencia = "Update [dbo].[Usuario] Set [Contraseña] = '" + Contraseña + "' Where [UserName] = '" + Usuario + "'";

                conexionBD.EjecutarText(Sentencia, "Error cambiando contraseña");
                return true;
            }
            catch (SqlException SqlEx)
            {
                MessageBox.Show(SqlEx.Message,"SistemaSCADA", MessageBoxButtons.OK);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"SistemaSCADA", MessageBoxButtons.OK);
                return false;
            }
        }
    }
}
