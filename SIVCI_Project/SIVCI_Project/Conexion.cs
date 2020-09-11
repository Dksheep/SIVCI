using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIVCI_Project.Forms.Login
{
    class Conexion

    {

        public SqlConnection cndbc = new SqlConnection("server=SERVER; database=SIVCI;Integrated Security=True"); //\\SQLEXPRESS 

        DataTable dt;
        SqlDataAdapter da;

        //Carga los dataGrid
        public void cargargrid(DataGridView dgv, string tab)
        {
            try
            {

                da = new SqlDataAdapter("Select * from " + tab, cndbc);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontraron registros en la tabla SQL: " + ex.ToString());
            }

        }
    }
}
