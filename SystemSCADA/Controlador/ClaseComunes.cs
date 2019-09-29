﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SystemSCADA.Modelo;
using SystemSCADA.Controlador;
using SystemSCADA.Vista;
using System.Security.Cryptography;

namespace SystemSCADA.Controlador
{
    class ClaseComunes
    {
        static claseMetodosBaseDeDatos conexionBD;
        public static int G_ChequearModulo;


        /*****************************************************************************************************************************************************
        Nombre del Creador:Victor Valente
        Fecha de Creacion: 28/7/2019
        Descripcion: Funcion que recibe como parametro una clave de tipo string y retorna la clave encriptada
        *****************************************************************************************************************************************************/
        public static string ObtenerHash(string sPassword)
        {
            string _result = string.Empty;
            using (MD5 hasher = MD5.Create())
            {
                byte[] dbytes = hasher.ComputeHash(Encoding.UTF8.GetBytes(sPassword));
                StringBuilder sBuilder = new StringBuilder();

                for (int i = 0; i < dbytes.Length; i++)
                {
                    sBuilder.Append(dbytes[i].ToString("X2"));
                }
                _result = sBuilder.ToString();
            }
            return _result;
        }


        /*****************************************************************************************************************************************************
        Descripcion: metodos para mostrar mensajes personalizados
        *****************************************************************************************************************************************************/
        public static bool MsjShow(string Mensaje, int Botones, int Icono, bool FormAbrir = false)
        {
            try
            {
                Vista.formMensaje Msj = new formMensaje(Mensaje, Botones, Icono);
                if (FormAbrir)
                    Msj.ShowDialog();
                else
                    Msj.ShowDialog();
                return Msj.g_boolRespuesta;
            }
            catch { return false; }
        }

        public static bool MsjShow(string Mensaje, int Botones, int Icono, string Titulo, bool FormAbrir = false)
        {
            Vista.formMensaje Msj = new formMensaje(Mensaje, Botones, Icono, Titulo);
            if (FormAbrir)
                Msj.Show();
            else
                Msj.ShowDialog();
            return Msj.g_boolRespuesta;
        }

        public static bool MsjShow(string Mensaje, int Botones, int Icono, string Titulo, int Tamaño, bool FormAbrir = false)
        {
            Vista.formMensaje Msj = new formMensaje(Mensaje, Botones, Icono, Titulo, Tamaño);
            if (FormAbrir)
                Msj.Show();
            else
                Msj.ShowDialog();
            return Msj.g_boolRespuesta;
        }

        public static bool MsjShow(string Mensaje, int Botones, int Icono, int Tamaño, bool FormAbrir = false)
        {
            Vista.formMensaje Msj = new formMensaje(Mensaje, Botones, Icono, "Etiquetado", Tamaño);
            if (FormAbrir)
                Msj.Show();
            else
                Msj.ShowDialog();
            return Msj.g_boolRespuesta;
        }

        /*****************************************************************************************************************************************************
        Descripcion: Funcion que recibe como parametro una cadena y separa en dos cadenas al encontrar 
        el caracter ";"
        *****************************************************************************************************************************************************/
        public static string getCampo(ref string sStrSource)
        {
            string sCampo = "";
            if (sStrSource.Trim() == "")
            {
                return sCampo;
            }

            int i = -1;
            i = sStrSource.IndexOf(";");
            if (i >= 0)
            {
                sCampo = sStrSource.Substring(0, i);
                sStrSource = sStrSource.Substring(i + 1);
            }
            else
            {
                if (sStrSource.Length > 0)
                {
                    sCampo = sStrSource;
                    sStrSource = "";
                    return sCampo;
                }
            }
            return sCampo;
        }

        public static bool chkPermiso(bool wbActivar, int wnIdModulo, string wsUsrName, int optionalint = 0, Boolean bMsg = true)
        {
            conexionBD = new claseMetodosBaseDeDatos(claseControlBaseDeDatos.SQlsistemaSCADA, claseControlBaseDeDatos.SQLNomDBsistemaSCADA,
                claseControlBaseDeDatos.SQLUsersistemaSCADA, claseControlBaseDeDatos.SQLPasssistemaSCADA);
            try
            {
                SqlParameter[] Parametros = new SqlParameter[2];

                Parametros[0] = new SqlParameter();
                Parametros[0].ParameterName = "@nIdModulo";
                Parametros[0].SqlDbType = SqlDbType.Int;
                Parametros[0].Value = wnIdModulo;

                Parametros[1] = new SqlParameter();
                Parametros[1].ParameterName = "@sUsrName";
                Parametros[1].SqlDbType = SqlDbType.VarChar;
                Parametros[1].Size = 300;
                Parametros[1].Value = wsUsrName;

                DataTable Permisos  = conexionBD.TablaSP(ref Parametros, "USP_getPermiso_PerfilItem", "Error obteniendo los permisos");
                
                
                if (!Convert.ToBoolean(Permisos.Rows[0]["Acceder"].ToString()))
                {
                    MsjShow("El usuario: " + claseControlUsuario.UserName + ", no tiene acceso a esta opción.",1, 1);
                    return false;
                }
                else
                {
                    if (wbActivar == true)
                    {
                        if (!Convert.ToBoolean(Permisos.Rows[0]["Acceder"].ToString()))
                        {
                            if (bMsg)
                            { MsjShow("El usuario: " + claseControlUsuario.Nombre  + ", no tiene acceso a esta opción.",1,1,"Atencion");}
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    else
                    {
                        Boolean a = false;
                        switch (optionalint)
                        {
                            case 10:
                                a = (Permisos.Rows[0]["Incluir"].ToString() == "True");
                                break;
                            case 20:
                                a = (Permisos.Rows[0]["Modificar"].ToString() == "True");
                                break;
                            case 30:
                                a = (Permisos.Rows[0]["Eliminar"].ToString() == "True");
                                break;
                            case 40:
                                a = (Permisos.Rows[0]["Acceder"].ToString() == "True");
                                break;
                        }
                        if (a == false && bMsg)
                        {
                            MsjShow("El usuario: " + claseControlUsuario.Nombre + ", no tiene acceso a esta opción.",1,1, "Atención");
                        }
                        return a;
                    }
                }
            }
            catch (SqlException Sqlex)
            {
                MsjShow(Sqlex.Message,1,1);
                return false;
            }
            catch (Exception ex)
            {
                MsjShow(ex.Message,1,1);
                return false;
            }
        }

    }
}
