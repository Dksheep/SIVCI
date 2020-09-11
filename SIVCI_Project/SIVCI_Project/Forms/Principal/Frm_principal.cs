using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace SIVCI_Project.Forms.Principal
{
    public partial class Frm_principal : Form
    {
        bool nmax = false;
        int LX, LY;
        
        public Frm_principal()
        {
            InitializeComponent();

        }

        /*  INICIO ---Mover con el mouse el Formulario */

            [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
            private extern static void ReleaseCapture();
            [DllImport("user32.DLL", EntryPoint = "SendMessage")]
            private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        /*  FIN ---Mover con el mouse el Formulario */

        private void btn_slidemenu_Click(object sender, EventArgs e)
        {
            //Slide panel izquierdo
            if(panel_vertical.Width == 194)
            {
                panel_vertical.Width = 73;

            }
            else
            {
                panel_vertical.Width = 194;
            }
        }

        private void icon_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void icon_max_min_Click(object sender, EventArgs e)
        {
            /*  Maximizar y Restaurar  */
            if(nmax == true)
            {
                this.Size = new Size(1280, 720);
                this.Location = new Point(LX, LY);
                nmax = false;

            }
            else{

                LX = this.Location.X;
                LY = this.Location.Y;
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;       
                nmax = true;
            }
        }

        private void icon_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            /*  Mover con el mouse el Formulario */
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void Frm_principal_Load(object sender, EventArgs e)
        {
            
        }

        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.panel_contenedor.Controls.Count > 0)
                this.panel_contenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_contenedor.Controls.Add(fh);
            this.panel_contenedor.Tag = fh;
            fh.Show();
        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Productos.Frm_Productos());
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Usuarios.Frm_UsuariosBase());
        }
    }
}
