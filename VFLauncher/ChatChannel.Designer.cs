namespace VFLauncher
{
    partial class ChatChannel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatChannel));
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lb_channel_name = new System.Windows.Forms.Label();
            this.lb_channel_info = new System.Windows.Forms.Label();
            this.pb_channel = new System.Windows.Forms.PictureBox();
            this.tb_chat_info = new System.Windows.Forms.RichTextBox();
            this.tb_chat_send = new System.Windows.Forms.RichTextBox();
            this.btn_send = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_channel)).BeginInit();
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
            this.btn_min.Location = new System.Drawing.Point(612, 5);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(28, 28);
            this.btn_min.TabIndex = 13;
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
            this.btn_close.Location = new System.Drawing.Point(646, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(28, 28);
            this.btn_close.TabIndex = 12;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lb_channel_name
            // 
            this.lb_channel_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_channel_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_channel_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_channel_name.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lb_channel_name.Location = new System.Drawing.Point(86, 21);
            this.lb_channel_name.Name = "lb_channel_name";
            this.lb_channel_name.Size = new System.Drawing.Size(196, 23);
            this.lb_channel_name.TabIndex = 14;
            this.lb_channel_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_channel_info
            // 
            this.lb_channel_info.BackColor = System.Drawing.Color.Transparent;
            this.lb_channel_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_channel_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_channel_info.ForeColor = System.Drawing.Color.Silver;
            this.lb_channel_info.Location = new System.Drawing.Point(87, 44);
            this.lb_channel_info.Name = "lb_channel_info";
            this.lb_channel_info.Size = new System.Drawing.Size(309, 23);
            this.lb_channel_info.TabIndex = 16;
            this.lb_channel_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pb_channel
            // 
            this.pb_channel.BackColor = System.Drawing.Color.Transparent;
            this.pb_channel.BackgroundImage = global::VFLauncher.Properties.Resources.WoWIcon_01_Hover;
            this.pb_channel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_channel.Location = new System.Drawing.Point(5, 5);
            this.pb_channel.Name = "pb_channel";
            this.pb_channel.Size = new System.Drawing.Size(75, 75);
            this.pb_channel.TabIndex = 17;
            this.pb_channel.TabStop = false;
            // 
            // tb_chat_info
            // 
            this.tb_chat_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.tb_chat_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_chat_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_chat_info.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_chat_info.Location = new System.Drawing.Point(6, 88);
            this.tb_chat_info.Name = "tb_chat_info";
            this.tb_chat_info.ReadOnly = true;
            this.tb_chat_info.Size = new System.Drawing.Size(674, 315);
            this.tb_chat_info.TabIndex = 18;
            this.tb_chat_info.Text = "";
            this.tb_chat_info.TextChanged += new System.EventHandler(this.tb_chat_info_TextChanged);
            // 
            // tb_chat_send
            // 
            this.tb_chat_send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(34)))));
            this.tb_chat_send.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_chat_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_chat_send.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.tb_chat_send.Location = new System.Drawing.Point(12, 437);
            this.tb_chat_send.Multiline = false;
            this.tb_chat_send.Name = "tb_chat_send";
            this.tb_chat_send.Size = new System.Drawing.Size(662, 59);
            this.tb_chat_send.TabIndex = 19;
            this.tb_chat_send.Text = "";
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.Transparent;
            this.btn_send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_send.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_send.FlatAppearance.BorderSize = 0;
            this.btn_send.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_send.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_send.Location = new System.Drawing.Point(670, 502);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(10, 10);
            this.btn_send.TabIndex = 20;
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // ChatChannel
            // 
            this.AcceptButton = this.btn_send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VFLauncher.Properties.Resources.ChatChannel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(686, 508);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.tb_chat_send);
            this.Controls.Add(this.tb_chat_info);
            this.Controls.Add(this.pb_channel);
            this.Controls.Add(this.lb_channel_info);
            this.Controls.Add(this.lb_channel_name);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_close);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChatChannel";
            this.Text = "ChatChannel";
            ((System.ComponentModel.ISupportInitialize)(this.pb_channel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lb_channel_name;
        private System.Windows.Forms.Label lb_channel_info;
        private System.Windows.Forms.PictureBox pb_channel;
        private System.Windows.Forms.RichTextBox tb_chat_send;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.RichTextBox tb_chat_info;
    }
}