using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemSCADA.Modelo;

namespace SystemSCADA.Controlador
{
    class ClaseVideosDelSistema
    {
        /*****************************************************************************************************************************************************
        Descripcion: Conexion a la base de datos
        *****************************************************************************************************************************************************/
        static claseMetodosBaseDeDatos conexionBD;
        public static void setDgrw(ref DataGridView grv, string storeProcedure, string Busqueda = "")
        {
            conexionBD = new claseMetodosBaseDeDatos(claseControlBaseDeDatos.SQlsistemaSCADA, claseControlBaseDeDatos.SQLNomDBsistemaSCADA, claseControlBaseDeDatos.SQLUsersistemaSCADA,
                claseControlBaseDeDatos.SQLPasssistemaSCADA);
            DataGridViewCheckBoxColumn sts = new DataGridViewCheckBoxColumn();
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

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


                grv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grv.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12f, FontStyle.Bold, 0);

                grv.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grv.Columns["Nombre"].HeaderText = "Area de Trabajo";
                grv.Columns["Nombre"].ReadOnly = true;
                grv.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                grv.Columns["Descripcion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grv.Columns["Descripcion"].HeaderText = "Descripcion";
                grv.Columns["Descripcion"].ReadOnly = true;
                grv.Columns["Descripcion"].Width = 360;
                grv.Columns["Video"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grv.Columns["Video"].HeaderText = "Ruta del Video";
                grv.Columns["Video"].Width= 390;
                grv.Columns["Video"].ReadOnly = true;
                grv.Columns["Fecha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grv.Columns["Fecha"].HeaderText = "Fecha";
                grv.Columns["Fecha"].ReadOnly = true;
                grv.Columns["Fecha"].Width = 150;
                grv.Columns.Insert(grv.Columns.Count, btn);
                grv.Columns[grv.Columns.Count - 1].Name = "Ir a la ruta del Video";
                grv.Columns[grv.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                grv.Columns["Id_AreaDeTrabajo"].Visible = false;
               
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
    }
}
