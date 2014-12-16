namespace VFLauncher
{
    partial class ChatForm
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Game Channel", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Friends", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "In Development"}, 1, System.Drawing.SystemColors.InactiveCaption, System.Drawing.Color.Empty, null);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_addfriend = new System.Windows.Forms.Button();
            this.lb_username = new System.Windows.Forms.Label();
            this.user_list = new System.Windows.Forms.ListView();
            this.chat_status = new System.Windows.Forms.ImageList(this.components);
            this.btn_channel_wow = new System.Windows.Forms.Button();
            this.btn_channel_aion = new System.Windows.Forms.Button();
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
            this.btn_close.Location = new System.Drawing.Point(325, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(28, 28);
            this.btn_close.TabIndex = 10;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
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
            this.btn_min.Location = new System.Drawing.Point(291, 5);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(28, 28);
            this.btn_min.TabIndex = 11;
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_addfriend
            // 
            this.btn_addfriend.BackColor = System.Drawing.Color.Transparent;
            this.btn_addfriend.BackgroundImage = global::VFLauncher.Properties.Resources.AddFriend_Nomal;
            this.btn_addfriend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addfriend.FlatAppearance.BorderSize = 0;
            this.btn_addfriend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_addfriend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_addfriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addfriend.ImageKey = "(none)";
            this.btn_addfriend.Location = new System.Drawing.Point(9, 50);
            this.btn_addfriend.Margin = new System.Windows.Forms.Padding(0);
            this.btn_addfriend.Name = "btn_addfriend";
            this.btn_addfriend.Size = new System.Drawing.Size(120, 26);
            this.btn_addfriend.TabIndex = 12;
            this.btn_addfriend.UseVisualStyleBackColor = false;
            this.btn_addfriend.Click += new System.EventHandler(this.btn_addfriend_Click);
            this.btn_addfriend.MouseLeave += new System.EventHandler(this.btn_addfriend_Leave);
            this.btn_addfriend.MouseHover += new System.EventHandler(this.btn_addfriend_Hover);
            // 
            // lb_username
            // 
            this.lb_username.BackColor = System.Drawing.Color.Transparent;
            this.lb_username.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_username.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lb_username.Location = new System.Drawing.Point(12, 22);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(196, 23);
            this.lb_username.TabIndex = 13;
            this.lb_username.Text = "Loading...";
            this.lb_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // user_list
            // 
            this.user_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.user_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            listViewGroup1.Header = "Game Channel";
            listViewGroup1.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup1.Name = "lv_group_channel";
            listViewGroup1.Tag = "0";
            listViewGroup2.Header = "Friends";
            listViewGroup2.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup2.Name = "lv_group_friends";
            listViewGroup2.Tag = "1";
            this.user_list.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            listViewItem1.Group = listViewGroup2;
            this.user_list.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.user_list.LargeImageList = this.chat_status;
            this.user_list.Location = new System.Drawing.Point(6, 166);
            this.user_list.Name = "user_list";
            this.user_list.Size = new System.Drawing.Size(350, 548);
            this.user_list.SmallImageList = this.chat_status;
            this.user_list.TabIndex = 14;
            this.user_list.UseCompatibleStateImageBehavior = false;
            this.user_list.View = System.Windows.Forms.View.List;
            // 
            // chat_status
            // 
            this.chat_status.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("chat_status.ImageStream")));
            this.chat_status.TransparentColor = System.Drawing.Color.Transparent;
            this.chat_status.Images.SetKeyName(0, "chat_offline.png");
            this.chat_status.Images.SetKeyName(1, "chat_online.png");
            // 
            // btn_channel_wow
            // 
            this.btn_channel_wow.BackColor = System.Drawing.Color.Transparent;
            this.btn_channel_wow.BackgroundImage = global::VFLauncher.Properties.Resources.WoW_Channel_Nomal;
            this.btn_channel_wow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_channel_wow.FlatAppearance.BorderSize = 0;
            this.btn_channel_wow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_channel_wow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_channel_wow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_channel_wow.ImageKey = "(none)";
            this.btn_channel_wow.Location = new System.Drawing.Point(2, 83);
            this.btn_channel_wow.Margin = new System.Windows.Forms.Padding(0);
            this.btn_channel_wow.Name = "btn_channel_wow";
            this.btn_channel_wow.Size = new System.Drawing.Size(178, 80);
            this.btn_channel_wow.TabIndex = 15;
            this.btn_channel_wow.UseVisualStyleBackColor = false;
            this.btn_channel_wow.Click += new System.EventHandler(this.btn_channel_wow_Click);
            this.btn_channel_wow.MouseLeave += new System.EventHandler(this.btn_channel_wow_Leave);
            this.btn_channel_wow.MouseHover += new System.EventHandler(this.btn_channel_wow_Hover);
            // 
            // btn_channel_aion
            // 
            this.btn_channel_aion.BackColor = System.Drawing.Color.Transparent;
            this.btn_channel_aion.BackgroundImage = global::VFLauncher.Properties.Resources.Aion_Channel_Nomal;
            this.btn_channel_aion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_channel_aion.FlatAppearance.BorderSize = 0;
            this.btn_channel_aion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_channel_aion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_channel_aion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_channel_aion.ImageKey = "(none)";
            this.btn_channel_aion.Location = new System.Drawing.Point(182, 83);
            this.btn_channel_aion.Margin = new System.Windows.Forms.Padding(0);
            this.btn_channel_aion.Name = "btn_channel_aion";
            this.btn_channel_aion.Size = new System.Drawing.Size(178, 80);
            this.btn_channel_aion.TabIndex = 16;
            this.btn_channel_aion.UseVisualStyleBackColor = false;
            this.btn_channel_aion.Click += new System.EventHandler(this.btn_channel_aion_Click);
            this.btn_channel_aion.MouseLeave += new System.EventHandler(this.btn_channel_aion_Leave);
            this.btn_channel_aion.MouseHover += new System.EventHandler(this.btn_channel_aion_Hover);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VFLauncher.Properties.Resources.ChatBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(362, 720);
            this.Controls.Add(this.btn_channel_aion);
            this.Controls.Add(this.btn_channel_wow);
            this.Controls.Add(this.user_list);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.btn_addfriend);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_close);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_addfriend;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.ListView user_list;
        private System.Windows.Forms.ImageList chat_status;
        private System.Windows.Forms.Button btn_channel_wow;
        private System.Windows.Forms.Button btn_channel_aion;
    }
}