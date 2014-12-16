namespace VFLauncher
{
    partial class ConfirmForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmForm));
            this.btn_close = new System.Windows.Forms.Button();
            this.lb_activegame = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.btn_activate = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.btn_close.Location = new System.Drawing.Point(360, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(28, 28);
            this.btn_close.TabIndex = 11;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lb_activegame
            // 
            this.lb_activegame.BackColor = System.Drawing.Color.Transparent;
            this.lb_activegame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_activegame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_activegame.ForeColor = System.Drawing.Color.Silver;
            this.lb_activegame.Location = new System.Drawing.Point(21, 28);
            this.lb_activegame.Name = "lb_activegame";
            this.lb_activegame.Size = new System.Drawing.Size(333, 23);
            this.lb_activegame.TabIndex = 21;
            this.lb_activegame.Text = "ShowInfo";
            this.lb_activegame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.SystemColors.WindowText;
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_password.ForeColor = System.Drawing.Color.LightGray;
            this.tb_password.Location = new System.Drawing.Point(115, 54);
            this.tb_password.MaxLength = 255;
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(184, 27);
            this.tb_password.TabIndex = 22;
            // 
            // lb_password
            // 
            this.lb_password.BackColor = System.Drawing.Color.Transparent;
            this.lb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_password.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lb_password.Location = new System.Drawing.Point(21, 57);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(88, 20);
            this.lb_password.TabIndex = 25;
            this.lb_password.Text = "Password :";
            // 
            // btn_activate
            // 
            this.btn_activate.BackColor = System.Drawing.Color.Transparent;
            this.btn_activate.BackgroundImage = global::VFLauncher.Properties.Resources.Btn_MActive_Nomal;
            this.btn_activate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_activate.FlatAppearance.BorderSize = 0;
            this.btn_activate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_activate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_activate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_activate.ImageKey = "(none)";
            this.btn_activate.Location = new System.Drawing.Point(302, 53);
            this.btn_activate.Margin = new System.Windows.Forms.Padding(0);
            this.btn_activate.Name = "btn_activate";
            this.btn_activate.Size = new System.Drawing.Size(70, 28);
            this.btn_activate.TabIndex = 29;
            this.btn_activate.UseVisualStyleBackColor = false;
            this.btn_activate.Visible = false;
            this.btn_activate.Click += new System.EventHandler(this.btn_activate_Click);
            this.btn_activate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_activate_MouseDown);
            this.btn_activate.MouseLeave += new System.EventHandler(this.btn_activate_Leave);
            this.btn_activate.MouseHover += new System.EventHandler(this.btn_activate_Hover);
            this.btn_activate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_activate_MouseUp);
            // 
            // ConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VFLauncher.Properties.Resources.ConfirmForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(392, 92);
            this.Controls.Add(this.btn_activate);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lb_activegame);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfirmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lb_activegame;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Button btn_activate;
    }
}