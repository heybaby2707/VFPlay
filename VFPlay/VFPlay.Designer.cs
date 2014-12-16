namespace VFPlay
{
    partial class VFPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VFPlay));
            this.pb_bindupdate = new System.Windows.Forms.ProgressBar();
            this.lb_showinfo = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.lb_download = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pb_bindupdate
            // 
            this.pb_bindupdate.Location = new System.Drawing.Point(23, 61);
            this.pb_bindupdate.Name = "pb_bindupdate";
            this.pb_bindupdate.Size = new System.Drawing.Size(327, 19);
            this.pb_bindupdate.TabIndex = 0;
            // 
            // lb_showinfo
            // 
            this.lb_showinfo.BackColor = System.Drawing.Color.Transparent;
            this.lb_showinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_showinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_showinfo.ForeColor = System.Drawing.Color.Silver;
            this.lb_showinfo.Location = new System.Drawing.Point(23, 34);
            this.lb_showinfo.Name = "lb_showinfo";
            this.lb_showinfo.Size = new System.Drawing.Size(327, 23);
            this.lb_showinfo.TabIndex = 22;
            this.lb_showinfo.Text = "ShowInfo";
            this.lb_showinfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImage = global::VFPlay.Properties.Resources.Btn_Close_;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(331, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(28, 28);
            this.btn_close.TabIndex = 23;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lb_download
            // 
            this.lb_download.BackColor = System.Drawing.Color.Transparent;
            this.lb_download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_download.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_download.ForeColor = System.Drawing.Color.Silver;
            this.lb_download.Location = new System.Drawing.Point(211, 34);
            this.lb_download.Name = "lb_download";
            this.lb_download.Size = new System.Drawing.Size(139, 23);
            this.lb_download.TabIndex = 24;
            this.lb_download.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VFPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VFPlay.Properties.Resources.ConfirmForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(362, 92);
            this.Controls.Add(this.lb_download);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lb_showinfo);
            this.Controls.Add(this.pb_bindupdate);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VFPlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pb_bindupdate;
        private System.Windows.Forms.Label lb_showinfo;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lb_download;
    }
}

