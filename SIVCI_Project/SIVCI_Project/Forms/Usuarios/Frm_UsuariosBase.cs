using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace SIVCI_Project.Forms.Usuarios
{
    public partial class Frm_UsuariosBase : Form
    {
        public string idusuario = "";   
        string tabla = "Empleado";

        Login.Conexion c = new Login.Conexion();

        public Frm_UsuariosBase()
        {
            InitializeComponent();
            this.CenterToScreen();
            c.cargargrid(migridusuario, tabla);
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Eliminar este Usuario?", "Eliminar Usuario",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                c.cndbc.Open();
                idusuario = this.migridusuario.CurrentRow.Cells[0].Value.ToString();

                string query = "DELETE FROM Usuarios WHERE Id_Usuario=@idusuario";
                SqlCommand comando = new SqlCommand(query, c.cndbc);
                comando.Parameters.AddWithValue("@idusuario", idusuario);
                comando.ExecuteNonQuery();
                c.cndbc.Close();
                MessageBox.Show("Usuario eliminado.");

                c.cargargrid(migridusuario, tabla);
            }
            else
            {

            }
        }
    }
}
