using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SystemSCADA.Modelo;
using SystemSCADA.Controlador;
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
        Nombre del Creador:Juan Sanchez
        Fecha de Creacion: septiembre del 2018
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

    }
}
