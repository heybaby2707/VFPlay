namespace VFLauncher
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TopBar = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_max = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_wow = new System.Windows.Forms.Button();
            this.btn_aion = new System.Windows.Forms.Button();
            this.lb_username = new System.Windows.Forms.Label();
            this.btn_status = new System.Windows.Forms.Button();
            this.lb_ip = new System.Windows.Forms.Label();
            this.lb_ip_info = new System.Windows.Forms.Label();
            this.lb_gold = new System.Windows.Forms.Label();
            this.lb_gold_info = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_chat = new System.Windows.Forms.Button();
            this.lb_activegame_ = new System.Windows.Forms.Label();
            this.lb_serverstatus_ = new System.Windows.Forms.Label();
            this.lb_managerank_ = new System.Windows.Forms.Label();
            this.lb_activegame = new System.Windows.Forms.Label();
            this.lb_managerank = new System.Windows.Forms.Label();
            this.lb_serverstatus = new System.Windows.Forms.Label();
            this.lb_emailaddress_ = new System.Windows.Forms.Label();
            this.lb_emailaddress = new System.Windows.Forms.Label();
            this.btn_activatenow = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.pb_update = new System.Windows.Forms.ProgressBar();
            this.lb_update = new System.Windows.Forms.Label();
            this.lb_supporttools_ = new System.Windows.Forms.Label();
            this.lb_supporttools = new System.Windows.Forms.Label();
            this.lb_download = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TopBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.Transparent;
            this.TopBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TopBar.BackgroundImage")));
            this.TopBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(1024, 83);
            this.TopBar.TabIndex = 4;
            this.TopBar.TabStop = false;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            this.TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseMove);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close.BackgroundImage")));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(999, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(25, 25);
            this.btn_close.TabIndex = 5;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_max
            // 
            this.btn_max.BackColor = System.Drawing.Color.Transparent;
            this.btn_max.BackgroundImage = global::VFLauncher.Properties.Resources.Btn_Max;
            this.btn_max.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_max.FlatAppearance.BorderSize = 0;
            this.btn_max.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_max.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_max.Location = new System.Drawing.Point(965, 0);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(28, 28);
            this.btn_max.TabIndex = 6;
            this.btn_max.UseVisualStyleBackColor = false;
            // 
            // btn_min
            // 
            this.btn_min.BackColor = System.Drawing.Color.Transparent;
            this.btn_min.BackgroundImage = global::VFLauncher.Properties.Resources.Btn_Min;
            this.btn_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_min.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Location = new System.Drawing.Point(931, 0);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(28, 28);
            this.btn_min.TabIndex = 7;
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 575);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btn_wow
            // 
            this.btn_wow.BackColor = System.Drawing.Color.Transparent;
            this.btn_wow.BackgroundImage = global::VFLauncher.Properties.Resources.WoWIcon_01_Nomal;
            this.btn_wow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_wow.FlatAppearance.BorderSize = 0;
            this.btn_wow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_wow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_wow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_wow.ImageKey = "(none)";
            this.btn_wow.Location = new System.Drawing.Point(5, 87);
            this.btn_wow.Margin = new System.Windows.Forms.Padding(0);
            this.btn_wow.Name = "btn_wow";
            this.btn_wow.Size = new System.Drawing.Size(80, 80);
            this.btn_wow.TabIndex = 9;
            this.btn_wow.UseVisualStyleBackColor = false;
            this.btn_wow.Click += new System.EventHandler(this.btn_wow_Click);
            this.btn_wow.MouseLeave += new System.EventHandler(this.btn_wow_HoverEnd);
            this.btn_wow.MouseHover += new System.EventHandler(this.btn_wow_HoverStart);
            // 
            // btn_aion
            // 
            this.btn_aion.BackColor = System.Drawing.Color.Transparent;
            this.btn_aion.BackgroundImage = global::VFLauncher.Properties.Resources.AionIcon_01_Nomal;
            this.btn_aion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_aion.FlatAppearance.BorderSize = 0;
            this.btn_aion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_aion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_aion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aion.ImageKey = "(none)";
            this.btn_aion.Location = new System.Drawing.Point(5, 172);
            this.btn_aion.Margin = new System.Windows.Forms.Padding(0);
            this.btn_aion.Name = "btn_aion";
            this.btn_aion.Size = new System.Drawing.Size(80, 80);
            this.btn_aion.TabIndex = 10;
            this.btn_aion.UseVisualStyleBackColor = false;
            this.btn_aion.Click += new System.EventHandler(this.btn_aion_Click);
            this.btn_aion.MouseLeave += new System.EventHandler(this.btn_aion_HoverEnd);
            this.btn_aion.MouseHover += new System.EventHandler(this.btn_aion_HoverStart);
            // 
            // lb_username
            // 
            this.lb_username.BackColor = System.Drawing.Color.Transparent;
            this.lb_username.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_username.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lb_username.Image = global::VFLauncher.Properties.Resources.TopBar;
            this.lb_username.Location = new System.Drawing.Point(616, 18);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(189, 23);
            this.lb_username.TabIndex = 11;
            this.lb_username.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_status
            // 
            this.btn_status.BackColor = System.Drawing.Color.Transparent;
            this.btn_status.BackgroundImage = global::VFLauncher.Properties.Resources.TopBar;
            this.btn_status.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_status.FlatAppearance.BorderSize = 0;
            this.btn_status.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_status.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_status.Image = ((System.Drawing.Image)(resources.GetObject("btn_status.Image")));
            this.btn_status.Location = new System.Drawing.Point(802, 21);
            this.btn_status.Name = "btn_status";
            this.btn_status.Size = new System.Drawing.Size(20, 20);
            this.btn_status.TabIndex = 12;
            this.btn_status.UseVisualStyleBackColor = false;
            // 
            // lb_ip
            // 
            this.lb_ip.BackColor = System.Drawing.Color.Transparent;
            this.lb_ip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_ip.ForeColor = System.Drawing.Color.Silver;
            this.lb_ip.Image = global::VFLauncher.Properties.Resources.TopBar;
            this.lb_ip.Location = new System.Drawing.Point(617, 51);
            this.lb_ip.Name = "lb_ip";
            this.lb_ip.Size = new System.Drawing.Size(28, 23);
            this.lb_ip.TabIndex = 13;
            this.lb_ip.Text = "IP :";
            this.lb_ip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_ip_info
            // 
            this.lb_ip_info.BackColor = System.Drawing.Color.Transparent;
            this.lb_ip_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_ip_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_ip_info.ForeColor = System.Drawing.Color.Silver;
            this.lb_ip_info.Image = global::VFLauncher.Properties.Resources.TopBar;
            this.lb_ip_info.Location = new System.Drawing.Point(641, 51);
            this.lb_ip_info.Name = "lb_ip_info";
            this.lb_ip_info.Size = new System.Drawing.Size(163, 23);
            this.lb_ip_info.TabIndex = 14;
            this.lb_ip_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_gold
            // 
            this.lb_gold.BackColor = System.Drawing.Color.Transparent;
            this.lb_gold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_gold.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_gold.ForeColor = System.Drawing.Color.Gold;
            this.lb_gold.Image = global::VFLauncher.Properties.Resources.TopBar;
            this.lb_gold.Location = new System.Drawing.Point(800, 50);
            this.lb_gold.Name = "lb_gold";
            this.lb_gold.Size = new System.Drawing.Size(69, 23);
            this.lb_gold.TabIndex = 15;
            this.lb_gold.Text = "Bank :";
            this.lb_gold.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_gold_info
            // 
            this.lb_gold_info.BackColor = System.Drawing.Color.Transparent;
            this.lb_gold_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_gold_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_gold_info.ForeColor = System.Drawing.Color.Gold;
            this.lb_gold_info.Image = global::VFLauncher.Properties.Resources.TopBar;
            this.lb_gold_info.Location = new System.Drawing.Point(863, 50);
            this.lb_gold_info.Name = "lb_gold_info";
            this.lb_gold_info.Size = new System.Drawing.Size(149, 23);
            this.lb_gold_info.TabIndex = 16;
            this.lb_gold_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::VFLauncher.Properties.Resources.VFireNetwork;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(133, 98);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(207, 34);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // btn_chat
            // 
            this.btn_chat.BackColor = System.Drawing.Color.Transparent;
            this.btn_chat.BackgroundImage = global::VFLauncher.Properties.Resources.Btn_Chat_Nomal;
            this.btn_chat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_chat.FlatAppearance.BorderSize = 0;
            this.btn_chat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_chat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_chat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chat.ImageKey = "(none)";
            this.btn_chat.Location = new System.Drawing.Point(825, 9);
            this.btn_chat.Margin = new System.Windows.Forms.Padding(0);
            this.btn_chat.Name = "btn_chat";
            this.btn_chat.Size = new System.Drawing.Size(32, 32);
            this.btn_chat.TabIndex = 19;
            this.btn_chat.UseVisualStyleBackColor = false;
            this.btn_chat.Click += new System.EventHandler(this.btn_chat_Click);
            this.btn_chat.MouseLeave += new System.EventHandler(this.btn_chat_HoverEnd);
            this.btn_chat.MouseHover += new System.EventHandler(this.btn_chat_HoverStart);
            // 
            // lb_activegame_
            // 
            this.lb_activegame_.BackColor = System.Drawing.Color.Transparent;
            this.lb_activegame_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_activegame_.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_activegame_.ForeColor = System.Drawing.Color.Silver;
            this.lb_activegame_.Location = new System.Drawing.Point(110, 144);
            this.lb_activegame_.Name = "lb_activegame_";
            this.lb_activegame_.Size = new System.Drawing.Size(127, 23);
            this.lb_activegame_.TabIndex = 20;
            this.lb_activegame_.Text = "Active Game :";
            this.lb_activegame_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_serverstatus_
            // 
            this.lb_serverstatus_.BackColor = System.Drawing.Color.Transparent;
            this.lb_serverstatus_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_serverstatus_.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_serverstatus_.ForeColor = System.Drawing.Color.Silver;
            this.lb_serverstatus_.Location = new System.Drawing.Point(110, 172);
            this.lb_serverstatus_.Name = "lb_serverstatus_";
            this.lb_serverstatus_.Size = new System.Drawing.Size(127, 23);
            this.lb_serverstatus_.TabIndex = 21;
            this.lb_serverstatus_.Text = "Server Status :";
            this.lb_serverstatus_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_managerank_
            // 
            this.lb_managerank_.BackColor = System.Drawing.Color.Transparent;
            this.lb_managerank_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_managerank_.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_managerank_.ForeColor = System.Drawing.Color.Silver;
            this.lb_managerank_.Location = new System.Drawing.Point(110, 200);
            this.lb_managerank_.Name = "lb_managerank_";
            this.lb_managerank_.Size = new System.Drawing.Size(127, 23);
            this.lb_managerank_.TabIndex = 22;
            this.lb_managerank_.Text = "Manage Rank :";
            this.lb_managerank_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_activegame
            // 
            this.lb_activegame.BackColor = System.Drawing.Color.Transparent;
            this.lb_activegame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_activegame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_activegame.ForeColor = System.Drawing.Color.LawnGreen;
            this.lb_activegame.Location = new System.Drawing.Point(243, 144);
            this.lb_activegame.Name = "lb_activegame";
            this.lb_activegame.Size = new System.Drawing.Size(127, 23);
            this.lb_activegame.TabIndex = 23;
            this.lb_activegame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_managerank
            // 
            this.lb_managerank.BackColor = System.Drawing.Color.Transparent;
            this.lb_managerank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_managerank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_managerank.ForeColor = System.Drawing.Color.Red;
            this.lb_managerank.Location = new System.Drawing.Point(243, 200);
            this.lb_managerank.Name = "lb_managerank";
            this.lb_managerank.Size = new System.Drawing.Size(127, 23);
            this.lb_managerank.TabIndex = 24;
            this.lb_managerank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_serverstatus
            // 
            this.lb_serverstatus.BackColor = System.Drawing.Color.Transparent;
            this.lb_serverstatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_serverstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_serverstatus.ForeColor = System.Drawing.Color.LawnGreen;
            this.lb_serverstatus.Location = new System.Drawing.Point(243, 172);
            this.lb_serverstatus.Name = "lb_serverstatus";
            this.lb_serverstatus.Size = new System.Drawing.Size(127, 23);
            this.lb_serverstatus.TabIndex = 25;
            this.lb_serverstatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_emailaddress_
            // 
            this.lb_emailaddress_.BackColor = System.Drawing.Color.Transparent;
            this.lb_emailaddress_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_emailaddress_.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_emailaddress_.ForeColor = System.Drawing.Color.Silver;
            this.lb_emailaddress_.Location = new System.Drawing.Point(110, 228);
            this.lb_emailaddress_.Name = "lb_emailaddress_";
            this.lb_emailaddress_.Size = new System.Drawing.Size(127, 23);
            this.lb_emailaddress_.TabIndex = 26;
            this.lb_emailaddress_.Text = "Email Address :";
            this.lb_emailaddress_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_emailaddress
            // 
            this.lb_emailaddress.BackColor = System.Drawing.Color.Transparent;
            this.lb_emailaddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_emailaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_emailaddress.ForeColor = System.Drawing.Color.White;
            this.lb_emailaddress.Location = new System.Drawing.Point(243, 229);
            this.lb_emailaddress.Name = "lb_emailaddress";
            this.lb_emailaddress.Size = new System.Drawing.Size(249, 23);
            this.lb_emailaddress.TabIndex = 27;
            this.lb_emailaddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_activatenow
            // 
            this.btn_activatenow.BackColor = System.Drawing.Color.Transparent;
            this.btn_activatenow.BackgroundImage = global::VFLauncher.Properties.Resources.Btn_Active_Nomal;
            this.btn_activatenow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_activatenow.FlatAppearance.BorderSize = 0;
            this.btn_activatenow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_activatenow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_activatenow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_activatenow.ImageKey = "(none)";
            this.btn_activatenow.Location = new System.Drawing.Point(246, 144);
            this.btn_activatenow.Margin = new System.Windows.Forms.Padding(0);
            this.btn_activatenow.Name = "btn_activatenow";
            this.btn_activatenow.Size = new System.Drawing.Size(124, 28);
            this.btn_activatenow.TabIndex = 28;
            this.btn_activatenow.UseVisualStyleBackColor = false;
            this.btn_activatenow.Click += new System.EventHandler(this.btn_activatenow_Click);
            this.btn_activatenow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_activatenow_MouseDown);
            this.btn_activatenow.MouseLeave += new System.EventHandler(this.btn_activatenow_Leave);
            this.btn_activatenow.MouseHover += new System.EventHandler(this.btn_activatenow_Hover);
            this.btn_activatenow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_activatenow_MouseUp);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Transparent;
            this.btn_start.BackgroundImage = global::VFLauncher.Properties.Resources.Btn_Update_Normal;
            this.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_start.FlatAppearance.BorderSize = 0;
            this.btn_start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.ImageKey = "(none)";
            this.btn_start.Location = new System.Drawing.Point(113, 564);
            this.btn_start.Margin = new System.Windows.Forms.Padding(0);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(124, 54);
            this.btn_start.TabIndex = 29;
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            this.btn_start.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_start_MouseDown);
            this.btn_start.MouseLeave += new System.EventHandler(this.btn_start_Leave);
            this.btn_start.MouseHover += new System.EventHandler(this.btn_start_Hover);
            this.btn_start.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_start_MouseUp);
            // 
            // pb_update
            // 
            this.pb_update.BackColor = System.Drawing.Color.Olive;
            this.pb_update.ForeColor = System.Drawing.Color.Olive;
            this.pb_update.Location = new System.Drawing.Point(246, 594);
            this.pb_update.Name = "pb_update";
            this.pb_update.Size = new System.Drawing.Size(339, 15);
            this.pb_update.TabIndex = 30;
            this.pb_update.Value = 50;
            // 
            // lb_update
            // 
            this.lb_update.BackColor = System.Drawing.Color.Transparent;
            this.lb_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_update.ForeColor = System.Drawing.Color.Silver;
            this.lb_update.Location = new System.Drawing.Point(243, 568);
            this.lb_update.Name = "lb_update";
            this.lb_update.Size = new System.Drawing.Size(769, 23);
            this.lb_update.TabIndex = 31;
            this.lb_update.Text = "Step :";
            this.lb_update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_supporttools_
            // 
            this.lb_supporttools_.BackColor = System.Drawing.Color.Transparent;
            this.lb_supporttools_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_supporttools_.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_supporttools_.ForeColor = System.Drawing.Color.Silver;
            this.lb_supporttools_.Location = new System.Drawing.Point(110, 256);
            this.lb_supporttools_.Name = "lb_supporttools_";
            this.lb_supporttools_.Size = new System.Drawing.Size(127, 23);
            this.lb_supporttools_.TabIndex = 32;
            this.lb_supporttools_.Text = "Support Tools :";
            this.lb_supporttools_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_supporttools
            // 
            this.lb_supporttools.BackColor = System.Drawing.Color.Transparent;
            this.lb_supporttools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_supporttools.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_supporttools.ForeColor = System.Drawing.Color.YellowGreen;
            this.lb_supporttools.Location = new System.Drawing.Point(243, 256);
            this.lb_supporttools.Name = "lb_supporttools";
            this.lb_supporttools.Size = new System.Drawing.Size(127, 23);
            this.lb_supporttools.TabIndex = 33;
            this.lb_supporttools.Text = "In Development";
            this.lb_supporttools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_download
            // 
            this.lb_download.BackColor = System.Drawing.Color.Transparent;
            this.lb_download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_download.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_download.ForeColor = System.Drawing.Color.Lime;
            this.lb_download.Location = new System.Drawing.Point(591, 591);
            this.lb_download.Name = "lb_download";
            this.lb_download.Size = new System.Drawing.Size(156, 23);
            this.lb_download.TabIndex = 34;
            this.lb_download.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.ControlBox = false;
            this.Controls.Add(this.lb_download);
            this.Controls.Add(this.lb_supporttools);
            this.Controls.Add(this.lb_supporttools_);
            this.Controls.Add(this.lb_update);
            this.Controls.Add(this.pb_update);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_activatenow);
            this.Controls.Add(this.lb_emailaddress);
            this.Controls.Add(this.lb_emailaddress_);
            this.Controls.Add(this.lb_serverstatus);
            this.Controls.Add(this.lb_managerank);
            this.Controls.Add(this.lb_activegame);
            this.Controls.Add(this.lb_managerank_);
            this.Controls.Add(this.lb_serverstatus_);
            this.Controls.Add(this.lb_activegame_);
            this.Controls.Add(this.btn_chat);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lb_gold_info);
            this.Controls.Add(this.lb_gold);
            this.Controls.Add(this.lb_ip_info);
            this.Controls.Add(this.lb_ip);
            this.Controls.Add(this.btn_status);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.btn_aion);
            this.Controls.Add(this.btn_wow);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_max);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.TopBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VFLauncher";
            ((System.ComponentModel.ISupportInitialize)(this.TopBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox TopBar;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_max;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_wow;
        private System.Windows.Forms.Button btn_aion;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Button btn_status;
        private System.Windows.Forms.Label lb_ip;
        private System.Windows.Forms.Label lb_ip_info;
        private System.Windows.Forms.Label lb_gold;
        private System.Windows.Forms.Label lb_gold_info;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_chat;
        private System.Windows.Forms.Label lb_activegame_;
        private System.Windows.Forms.Label lb_serverstatus_;
        private System.Windows.Forms.Label lb_managerank_;
        private System.Windows.Forms.Label lb_activegame;
        private System.Windows.Forms.Label lb_managerank;
        private System.Windows.Forms.Label lb_serverstatus;
        private System.Windows.Forms.Label lb_emailaddress_;
        private System.Windows.Forms.Label lb_emailaddress;
        private System.Windows.Forms.Button btn_activatenow;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.ProgressBar pb_update;
        private System.Windows.Forms.Label lb_update;
        private System.Windows.Forms.Label lb_supporttools_;
        private System.Windows.Forms.Label lb_supporttools;
        private System.Windows.Forms.Label lb_download;
    }
}

