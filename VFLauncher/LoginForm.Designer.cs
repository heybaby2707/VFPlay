namespace VFLauncher
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.logo_01 = new System.Windows.Forms.PictureBox();
            this.logo_02 = new System.Windows.Forms.PictureBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_cantlogin = new System.Windows.Forms.Button();
            this.lb_login = new System.Windows.Forms.Label();
            this.lb_cantlogin = new System.Windows.Forms.Label();
            this.lb_createaccount = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.checkbox = new System.Windows.Forms.PictureBox();
            this.lb_remember = new System.Windows.Forms.Label();
            this.lb_info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_min
            // 
            this.btn_min.BackColor = System.Drawing.Color.Transparent;
            this.btn_min.BackgroundImage = global::VFLauncher.Properties.Resources.Btn_Min_;
            this.btn_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_min.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Location = new System.Drawing.Point(290, 12);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(28, 28);
            this.btn_min.TabIndex = 8;
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImage = global::VFLauncher.Properties.Resources.Btn_Close_;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(324, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(28, 28);
            this.btn_close.TabIndex = 9;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // logo_01
            // 
            this.logo_01.BackColor = System.Drawing.Color.Transparent;
            this.logo_01.BackgroundImage = global::VFLauncher.Properties.Resources.FireBear;
            this.logo_01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo_01.Location = new System.Drawing.Point(52, 41);
            this.logo_01.Name = "logo_01";
            this.logo_01.Size = new System.Drawing.Size(67, 76);
            this.logo_01.TabIndex = 10;
            this.logo_01.TabStop = false;
            // 
            // logo_02
            // 
            this.logo_02.BackColor = System.Drawing.Color.Transparent;
            this.logo_02.BackgroundImage = global::VFLauncher.Properties.Resources.VFireNetwork;
            this.logo_02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo_02.Location = new System.Drawing.Point(116, 62);
            this.logo_02.Name = "logo_02";
            this.logo_02.Size = new System.Drawing.Size(202, 34);
            this.logo_02.TabIndex = 11;
            this.logo_02.TabStop = false;
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.Transparent;
            this.btn_register.BackgroundImage = global::VFLauncher.Properties.Resources.Btn_Gray_Big_Nomal;
            this.btn_register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_register.FlatAppearance.BorderSize = 0;
            this.btn_register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Location = new System.Drawing.Point(33, 410);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(303, 44);
            this.btn_register.TabIndex = 12;
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            this.btn_register.MouseLeave += new System.EventHandler(this.createaccount_Leave);
            this.btn_register.MouseHover += new System.EventHandler(this.createaccount_Hover);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.BackgroundImage = global::VFLauncher.Properties.Resources.Btn_Blue_Nomal;
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Location = new System.Drawing.Point(33, 331);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(147, 34);
            this.btn_login.TabIndex = 13;
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            this.btn_login.MouseLeave += new System.EventHandler(this.login_Leave);
            this.btn_login.MouseHover += new System.EventHandler(this.login_Hover);
            // 
            // btn_cantlogin
            // 
            this.btn_cantlogin.BackColor = System.Drawing.Color.Transparent;
            this.btn_cantlogin.BackgroundImage = global::VFLauncher.Properties.Resources.Btn_Gray_Nomal;
            this.btn_cantlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cantlogin.FlatAppearance.BorderSize = 0;
            this.btn_cantlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_cantlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_cantlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cantlogin.Location = new System.Drawing.Point(189, 331);
            this.btn_cantlogin.Name = "btn_cantlogin";
            this.btn_cantlogin.Size = new System.Drawing.Size(147, 34);
            this.btn_cantlogin.TabIndex = 14;
            this.btn_cantlogin.UseVisualStyleBackColor = false;
            this.btn_cantlogin.Click += new System.EventHandler(this.btn_cantlogin_Click);
            this.btn_cantlogin.MouseLeave += new System.EventHandler(this.cantlogin_Leave);
            this.btn_cantlogin.MouseHover += new System.EventHandler(this.cantlogin_Hover);
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.BackColor = System.Drawing.Color.Transparent;
            this.lb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_login.ForeColor = System.Drawing.Color.White;
            this.lb_login.Image = global::VFLauncher.Properties.Resources.Btn_Blue_Nomal;
            this.lb_login.Location = new System.Drawing.Point(82, 337);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(48, 20);
            this.lb_login.TabIndex = 15;
            this.lb_login.Text = "Login";
            this.lb_login.Click += new System.EventHandler(this.btn_login_Click);
            this.lb_login.MouseLeave += new System.EventHandler(this.login_Leave);
            this.lb_login.MouseHover += new System.EventHandler(this.login_Hover);
            // 
            // lb_cantlogin
            // 
            this.lb_cantlogin.AutoSize = true;
            this.lb_cantlogin.BackColor = System.Drawing.Color.Transparent;
            this.lb_cantlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_cantlogin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_cantlogin.Image = global::VFLauncher.Properties.Resources.Btn_Gray_Nomal;
            this.lb_cantlogin.Location = new System.Drawing.Point(211, 337);
            this.lb_cantlogin.Name = "lb_cantlogin";
            this.lb_cantlogin.Size = new System.Drawing.Size(98, 20);
            this.lb_cantlogin.TabIndex = 16;
            this.lb_cantlogin.Text = "Can\'t Login?";
            this.lb_cantlogin.MouseLeave += new System.EventHandler(this.cantlogin_Leave);
            this.lb_cantlogin.MouseHover += new System.EventHandler(this.cantlogin_Hover);
            // 
            // lb_createaccount
            // 
            this.lb_createaccount.AutoSize = true;
            this.lb_createaccount.BackColor = System.Drawing.Color.Transparent;
            this.lb_createaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_createaccount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_createaccount.Image = global::VFLauncher.Properties.Resources.Btn_Gray_Big_Nomal;
            this.lb_createaccount.Location = new System.Drawing.Point(103, 421);
            this.lb_createaccount.Name = "lb_createaccount";
            this.lb_createaccount.Size = new System.Drawing.Size(168, 20);
            this.lb_createaccount.TabIndex = 17;
            this.lb_createaccount.Text = "Create a new account.";
            this.lb_createaccount.Click += new System.EventHandler(this.btn_register_Click);
            this.lb_createaccount.MouseLeave += new System.EventHandler(this.createaccount_Leave);
            this.lb_createaccount.MouseHover += new System.EventHandler(this.createaccount_Hover);
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.SystemColors.WindowText;
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_username.ForeColor = System.Drawing.Color.LightGray;
            this.tb_username.Location = new System.Drawing.Point(33, 148);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(303, 35);
            this.tb_username.TabIndex = 18;
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.SystemColors.WindowText;
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_password.ForeColor = System.Drawing.Color.LightGray;
            this.tb_password.Location = new System.Drawing.Point(33, 215);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(303, 35);
            this.tb_password.TabIndex = 19;
            // 
            // checkbox
            // 
            this.checkbox.BackColor = System.Drawing.Color.Transparent;
            this.checkbox.BackgroundImage = global::VFLauncher.Properties.Resources.cb_nomal;
            this.checkbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkbox.Location = new System.Drawing.Point(33, 280);
            this.checkbox.Name = "checkbox";
            this.checkbox.Size = new System.Drawing.Size(20, 20);
            this.checkbox.TabIndex = 20;
            this.checkbox.TabStop = false;
            this.checkbox.Click += new System.EventHandler(this.checkbox_Click);
            this.checkbox.MouseLeave += new System.EventHandler(this.checkbox_Leave);
            this.checkbox.MouseHover += new System.EventHandler(this.checkbox_Hover);
            // 
            // lb_remember
            // 
            this.lb_remember.AutoSize = true;
            this.lb_remember.BackColor = System.Drawing.Color.Transparent;
            this.lb_remember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_remember.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lb_remember.Location = new System.Drawing.Point(59, 280);
            this.lb_remember.Name = "lb_remember";
            this.lb_remember.Size = new System.Drawing.Size(149, 20);
            this.lb_remember.TabIndex = 21;
            this.lb_remember.Text = "Keep me logged in?";
            // 
            // lb_info
            // 
            this.lb_info.BackColor = System.Drawing.Color.Transparent;
            this.lb_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_info.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lb_info.Location = new System.Drawing.Point(12, 120);
            this.lb_info.Name = "lb_info";
            this.lb_info.Size = new System.Drawing.Size(340, 25);
            this.lb_info.TabIndex = 22;
            this.lb_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VFLauncher.Properties.Resources.LoginForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(364, 467);
            this.ControlBox = false;
            this.Controls.Add(this.lb_info);
            this.Controls.Add(this.lb_remember);
            this.Controls.Add(this.checkbox);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lb_createaccount);
            this.Controls.Add(this.lb_cantlogin);
            this.Controls.Add(this.lb_login);
            this.Controls.Add(this.btn_cantlogin);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.logo_02);
            this.Controls.Add(this.logo_01);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_min);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.logo_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.PictureBox logo_01;
        private System.Windows.Forms.PictureBox logo_02;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_cantlogin;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.Label lb_cantlogin;
        private System.Windows.Forms.Label lb_createaccount;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.PictureBox checkbox;
        private System.Windows.Forms.Label lb_remember;
        private System.Windows.Forms.Label lb_info;
    }
}