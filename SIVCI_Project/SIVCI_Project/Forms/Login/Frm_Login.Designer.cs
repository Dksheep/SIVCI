namespace SIVCI_Project.Forms.Login
{
    partial class Frm_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.picture_user = new System.Windows.Forms.PictureBox();
            this.timer1_inicio = new System.Windows.Forms.Timer(this.components);
            this.timer2_salir = new System.Windows.Forms.Timer(this.components);
            this.timer3_login = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.picture_logo = new System.Windows.Forms.PictureBox();
            this.lbl_userin = new System.Windows.Forms.Label();
            this.lbl_passin = new System.Windows.Forms.Label();
            this.timer4_incor = new System.Windows.Forms.Timer(this.components);
            this.timer5_user = new System.Windows.Forms.Timer(this.components);
            this.timer6_pass = new System.Windows.Forms.Timer(this.components);
            this.timer7_load = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picture_user)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_user
            // 
            this.txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(433, 183);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(135, 22);
            this.txt_user.TabIndex = 0;
            this.txt_user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_user_KeyPress);
            this.txt_user.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_user_PreviewKeyDown_1);
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(433, 232);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(135, 22);
            this.txt_pass.TabIndex = 1;
            this.txt_pass.UseSystemPasswordChar = true;
            this.txt_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pass_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña:";
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar.Location = new System.Drawing.Point(416, 298);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(88, 28);
            this.btn_ingresar.TabIndex = 4;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(416, 342);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(88, 28);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // picture_user
            // 
            this.picture_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_user.ErrorImage = null;
            this.picture_user.Location = new System.Drawing.Point(394, 23);
            this.picture_user.Name = "picture_user";
            this.picture_user.Size = new System.Drawing.Size(142, 127);
            this.picture_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_user.TabIndex = 6;
            this.picture_user.TabStop = false;
            // 
            // timer1_inicio
            // 
            this.timer1_inicio.Interval = 30;
            this.timer1_inicio.Tick += new System.EventHandler(this.timer1_inicio_Tick);
            // 
            // timer2_salir
            // 
            this.timer2_salir.Interval = 5;
            this.timer2_salir.Tick += new System.EventHandler(this.timer2_salir_Tick);
            // 
            // timer3_login
            // 
            this.timer3_login.Interval = 30;
            this.timer3_login.Tick += new System.EventHandler(this.timer3_login_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.picture_logo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 381);
            this.panel1.TabIndex = 7;
            // 
            // picture_logo
            // 
            this.picture_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_logo.ErrorImage = null;
            this.picture_logo.Location = new System.Drawing.Point(94, 127);
            this.picture_logo.Name = "picture_logo";
            this.picture_logo.Size = new System.Drawing.Size(142, 127);
            this.picture_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_logo.TabIndex = 7;
            this.picture_logo.TabStop = false;
            // 
            // lbl_userin
            // 
            this.lbl_userin.AutoSize = true;
            this.lbl_userin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_userin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userin.ForeColor = System.Drawing.Color.Red;
            this.lbl_userin.Location = new System.Drawing.Point(435, 205);
            this.lbl_userin.Name = "lbl_userin";
            this.lbl_userin.Size = new System.Drawing.Size(101, 13);
            this.lbl_userin.TabIndex = 8;
            this.lbl_userin.Text = "*Usuario Incorrecto.";
            this.lbl_userin.Visible = false;
            // 
            // lbl_passin
            // 
            this.lbl_passin.AutoSize = true;
            this.lbl_passin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_passin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passin.ForeColor = System.Drawing.Color.Red;
            this.lbl_passin.Location = new System.Drawing.Point(435, 257);
            this.lbl_passin.Name = "lbl_passin";
            this.lbl_passin.Size = new System.Drawing.Size(92, 13);
            this.lbl_passin.TabIndex = 9;
            this.lbl_passin.Text = "*Clave Incorrecta.";
            this.lbl_passin.Visible = false;
            // 
            // timer4_incor
            // 
            this.timer4_incor.Interval = 3000;
            this.timer4_incor.Tick += new System.EventHandler(this.timer4_incor_Tick);
            // 
            // timer5_user
            // 
            this.timer5_user.Interval = 3000;
            this.timer5_user.Tick += new System.EventHandler(this.timer5_user_Tick);
            // 
            // timer6_pass
            // 
            this.timer6_pass.Interval = 3000;
            this.timer6_pass.Tick += new System.EventHandler(this.timer6_pass_Tick);
            // 
            // timer7_load
            // 
            this.timer7_load.Interval = 1;
            this.timer7_load.Tick += new System.EventHandler(this.timer7_load_Tick);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(593, 381);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_passin);
            this.Controls.Add(this.lbl_userin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picture_user);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Login";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_user)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.PictureBox picture_user;
        private System.Windows.Forms.Timer timer1_inicio;
        private System.Windows.Forms.Timer timer2_salir;
        private System.Windows.Forms.Timer timer3_login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picture_logo;
        private System.Windows.Forms.Label lbl_userin;
        private System.Windows.Forms.Label lbl_passin;
        private System.Windows.Forms.Timer timer4_incor;
        private System.Windows.Forms.Timer timer5_user;
        private System.Windows.Forms.Timer timer6_pass;
        private System.Windows.Forms.Timer timer7_load;
    }
}