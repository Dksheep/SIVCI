using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIVCI_Project.Forms.Login
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            timer1_inicio.Start();

            Image userpic = Image.FromFile(@"C:\SIVCI_Project\SIVCI_Project\Images\Login\Users_dos.png");
            picture_user.Image = userpic;

            Image logopic = Image.FromFile(@"C:\SIVCI_Project\SIVCI_Project\Images\Logo.png");
            picture_logo.Image = logopic;


        }

        /*  Variables & Conexiones  */

        int cont = 0;
        int userv = 0;
        int passv = 0;
        int log = 0;
        int lado = 94;

        Login.Conexion c = new Conexion();


        /*  BOTONES  */
        private void btn_salir_Click(object sender, EventArgs e)
        {
            timer2_salir.Start();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            logear(txt_user.Text, txt_pass.Text);
        }

        /*  LOGREAR  */
        public void logear(string usuario, string contrasena)
        {

            try
            {

                c.cndbc.Open();
                SqlCommand cmd = new SqlCommand("SELECT nombres, idcargo FROM Empleado WHERE Usuario= @usuario AND Clave= @contrasena", c.cndbc);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("contrasena", contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {

                    //this.Hide();

                    if (dt.Rows[0][1].ToString() == "1")
                    {

                        // MessageBox.Show("Usted es Admin");

                    }
                    else if (dt.Rows[0][1].ToString() == "2")
                    {
                        //MessageBox.Show("Usted es Usuario");
                    }

                    timer3_login.Start();

                }
                else
                {

                    if(userv == 1) //usuario y clave incorrectas
                    {
                        passv = 1;

                        lbl_passin.Visible = true;
                        lbl_userin.Visible = true;

                        timer4_incor.Start();

                    }
                    else         //solo clave incorrecta
                    {
                        passv = 1;

                        lbl_passin.Visible = true;
                        timer6_pass.Start();
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {

                c.cndbc.Close();

            }
        }

         
        /*  Verifica si el usuario Existe  */

        public void imguser(string usuario)
        {
            try
            {
                c.cndbc.Open();
                SqlCommand cmd = new SqlCommand("SELECT nombres, imagen FROM Empleado WHERE Usuario= @usuario", c.cndbc);
                cmd.Parameters.AddWithValue("usuario", usuario);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    //Cambia imagen de usuario

                    //String imagepr = dt.Rows[0][1].ToString().Trim() + ".png";
                    //Image userpic = Image.FromFile(imagepr);
                    //picture_user.Image = userpic;
                    //userv = 0;

                }
                else
                {

                    //MessageBox.Show("Usuario no encontrado.");
                    //Image userpic = Image.FromFile(@"C:\SIVCI_Project\SIVCI_Project\Images\Login\Users_dos.png");
                    //picture_user.Image = userpic;

                    userv = 1;
                    lbl_userin.Visible = true;
                    timer5_user.Start();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {

                c.cndbc.Close();

            }

        }

        /*  ENTER  */
        private void txt_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.imguser(txt_user.Text);
                txt_pass.Focus();
            }
        }

        /*  TAB  */
        private void txt_user_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {
                                 
            if (e.KeyData == Keys.Tab)
            {
                this.imguser(txt_user.Text);
            }
            //if (e.KeyData == (Keys.Tab | Keys.Shift))
            //   {
            //       MessageBox.Show("Shift + Tab");
            //       e.IsInputKey = true;
            //   }
               
        }

            private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btn_ingresar.Focus();
            }
        }

        /*  Timers  */
        private void timer1_inicio_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            cont = cont + 2;

            if (cont > 100)
            {
                timer1_inicio.Stop();
            }
        }

        private void timer2_salir_Tick(object sender, EventArgs e)
        {
            
            this.Opacity -= 0.05;

            if (this.Opacity == 0)
            {
                timer2_salir.Stop();
                this.Close();
            }
        }
            
    
        private void timer3_login_Tick(object sender, EventArgs e)
        {
            timer7_load.Start();

            if (log == 1)
            {
                this.Opacity -= 0.05;

                if (this.Opacity == 0)
                {
                    timer3_login.Stop();
                    Principal.Frm_principal FP = new Principal.Frm_principal();   
                    this.Hide();
                    FP.Show();
                }
            }
        }

        private void timer4_incor_Tick(object sender, EventArgs e)
        {
            lbl_passin.Visible = false;
            passv = 0;
            lbl_userin.Visible = false;
            userv = 0;

            timer4_incor.Stop();
        }

        private void timer5_user_Tick(object sender, EventArgs e)
        {
            lbl_userin.Visible = false;
           // userv = 0;

            timer5_user.Stop();
        }

        private void timer6_pass_Tick(object sender, EventArgs e)
        {
            lbl_passin.Visible = false;
           // passv = 0;

            timer6_pass.Stop();
        }

        private void timer7_load_Tick(object sender, EventArgs e)
        {                  
            
            panel1.Width += 5;

            lado = (panel1.Width/2) - 70;

            if (lado >= 227)
            {
               lado = 227;
            }

            picture_logo.Location = new Point(lado, 127);

            if (panel1.Width >= 594)
            {
                timer7_load.Stop();
                log = 1;
            }
        }
    }
}
