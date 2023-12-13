namespace cafe_system
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.slidebar = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mname = new System.Windows.Forms.Label();
            this.main_p = new System.Windows.Forms.Panel();
            this.slidetime = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_user_log = new System.Windows.Forms.Button();
            this.btn_acc = new System.Windows.Forms.Button();
            this.btn_inve = new System.Windows.Forms.Button();
            this.btn_pro = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.iconm = new System.Windows.Forms.PictureBox();
            this.btnMini = new System.Windows.Forms.Button();
            this.btnCLose = new System.Windows.Forms.Button();
            this.btnToCashier = new System.Windows.Forms.Button();
            this.dashboard1 = new cafe_system.dashboard();
            this.slidebar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.main_p.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconm)).BeginInit();
            this.SuspendLayout();
            // 
            // slidebar
            // 
            this.slidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.slidebar.Controls.Add(this.btnDashboard);
            this.slidebar.Controls.Add(this.btn_Logout);
            this.slidebar.Controls.Add(this.btn_user_log);
            this.slidebar.Controls.Add(this.btn_acc);
            this.slidebar.Controls.Add(this.btn_inve);
            this.slidebar.Controls.Add(this.btn_pro);
            this.slidebar.Controls.Add(this.btn_menu);
            this.slidebar.Controls.Add(this.panel3);
            this.slidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidebar.Location = new System.Drawing.Point(0, 44);
            this.slidebar.MaximumSize = new System.Drawing.Size(140, 800);
            this.slidebar.MinimumSize = new System.Drawing.Size(64, 800);
            this.slidebar.Name = "slidebar";
            this.slidebar.Size = new System.Drawing.Size(64, 800);
            this.slidebar.TabIndex = 0;
            this.slidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.iconm);
            this.panel3.Controls.Add(this.mname);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(64, 100);
            this.panel3.TabIndex = 0;
            // 
            // mname
            // 
            this.mname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mname.AutoSize = true;
            this.mname.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mname.ForeColor = System.Drawing.Color.White;
            this.mname.Location = new System.Drawing.Point(50, 80);
            this.mname.Name = "mname";
            this.mname.Size = new System.Drawing.Size(41, 16);
            this.mname.TabIndex = 0;
            this.mname.Text = "label1";
            // 
            // main_p
            // 
            this.main_p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.main_p.Controls.Add(this.dashboard1);
            this.main_p.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_p.Location = new System.Drawing.Point(64, 44);
            this.main_p.Name = "main_p";
            this.main_p.Size = new System.Drawing.Size(1058, 607);
            this.main_p.TabIndex = 1;
            this.main_p.Paint += new System.Windows.Forms.PaintEventHandler(this.main_p_Paint);
            // 
            // slidetime
            // 
            this.slidetime.Interval = 10;
            this.slidetime.Tick += new System.EventHandler(this.slidetime_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.btnToCashier);
            this.panel1.Controls.Add(this.btnMini);
            this.panel1.Controls.Add(this.btnCLose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 44);
            this.panel1.TabIndex = 2;
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::cafe_system.Properties.Resources.dashboard;
            this.btnDashboard.Location = new System.Drawing.Point(0, 150);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(140, 44);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "         Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.White;
            this.btn_Logout.Image = global::cafe_system.Properties.Resources.Logout__3_;
            this.btn_Logout.Location = new System.Drawing.Point(6, 530);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(134, 44);
            this.btn_Logout.TabIndex = 1;
            this.btn_Logout.Text = "       Log Out";
            this.btn_Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_user_log
            // 
            this.btn_user_log.FlatAppearance.BorderSize = 0;
            this.btn_user_log.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_user_log.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_user_log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user_log.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_user_log.ForeColor = System.Drawing.Color.White;
            this.btn_user_log.Image = global::cafe_system.Properties.Resources.log__2_;
            this.btn_user_log.Location = new System.Drawing.Point(0, 326);
            this.btn_user_log.Name = "btn_user_log";
            this.btn_user_log.Size = new System.Drawing.Size(140, 44);
            this.btn_user_log.TabIndex = 1;
            this.btn_user_log.Text = "           User Log";
            this.btn_user_log.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_user_log.UseVisualStyleBackColor = true;
            this.btn_user_log.Click += new System.EventHandler(this.btn_user_log_Click);
            // 
            // btn_acc
            // 
            this.btn_acc.FlatAppearance.BorderSize = 0;
            this.btn_acc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_acc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_acc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_acc.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_acc.ForeColor = System.Drawing.Color.White;
            this.btn_acc.Image = global::cafe_system.Properties.Resources.acc;
            this.btn_acc.Location = new System.Drawing.Point(0, 282);
            this.btn_acc.Name = "btn_acc";
            this.btn_acc.Size = new System.Drawing.Size(140, 44);
            this.btn_acc.TabIndex = 1;
            this.btn_acc.Text = "           Account";
            this.btn_acc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_acc.UseVisualStyleBackColor = true;
            this.btn_acc.Click += new System.EventHandler(this.btn_acc_Click);
            // 
            // btn_inve
            // 
            this.btn_inve.FlatAppearance.BorderSize = 0;
            this.btn_inve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_inve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_inve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inve.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inve.ForeColor = System.Drawing.Color.White;
            this.btn_inve.Image = global::cafe_system.Properties.Resources.store;
            this.btn_inve.Location = new System.Drawing.Point(0, 238);
            this.btn_inve.Name = "btn_inve";
            this.btn_inve.Size = new System.Drawing.Size(140, 44);
            this.btn_inve.TabIndex = 1;
            this.btn_inve.Text = "           Inventroy";
            this.btn_inve.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_inve.UseVisualStyleBackColor = true;
            this.btn_inve.Click += new System.EventHandler(this.btn_inve_Click);
            // 
            // btn_pro
            // 
            this.btn_pro.FlatAppearance.BorderSize = 0;
            this.btn_pro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_pro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_pro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pro.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pro.ForeColor = System.Drawing.Color.White;
            this.btn_pro.Image = global::cafe_system.Properties.Resources.product_;
            this.btn_pro.Location = new System.Drawing.Point(0, 194);
            this.btn_pro.Name = "btn_pro";
            this.btn_pro.Size = new System.Drawing.Size(140, 44);
            this.btn_pro.TabIndex = 1;
            this.btn_pro.Text = "           Product";
            this.btn_pro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_pro.UseVisualStyleBackColor = true;
            this.btn_pro.Click += new System.EventHandler(this.btn_pro_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.ForeColor = System.Drawing.Color.White;
            this.btn_menu.Image = global::cafe_system.Properties.Resources.menu_;
            this.btn_menu.Location = new System.Drawing.Point(0, 106);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(140, 44);
            this.btn_menu.TabIndex = 1;
            this.btn_menu.Text = "            Menu";
            this.btn_menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // iconm
            // 
            this.iconm.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconm.Image = global::cafe_system.Properties.Resources.software_engineer__1_;
            this.iconm.Location = new System.Drawing.Point(0, 0);
            this.iconm.Name = "iconm";
            this.iconm.Size = new System.Drawing.Size(64, 74);
            this.iconm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconm.TabIndex = 1;
            this.iconm.TabStop = false;
            // 
            // btnMini
            // 
            this.btnMini.BackColor = System.Drawing.Color.Transparent;
            this.btnMini.BackgroundImage = global::cafe_system.Properties.Resources.Group_121;
            this.btnMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMini.FlatAppearance.BorderSize = 0;
            this.btnMini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMini.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMini.Location = new System.Drawing.Point(1045, 8);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(28, 28);
            this.btnMini.TabIndex = 7;
            this.btnMini.UseVisualStyleBackColor = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnCLose
            // 
            this.btnCLose.BackColor = System.Drawing.Color.Transparent;
            this.btnCLose.BackgroundImage = global::cafe_system.Properties.Resources.Group_120;
            this.btnCLose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCLose.FlatAppearance.BorderSize = 0;
            this.btnCLose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCLose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCLose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLose.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLose.Location = new System.Drawing.Point(1078, 8);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(28, 28);
            this.btnCLose.TabIndex = 6;
            this.btnCLose.UseVisualStyleBackColor = false;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // btnToCashier
            // 
            this.btnToCashier.BackgroundImage = global::cafe_system.Properties.Resources.Rectangle_22__1_;
            this.btnToCashier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnToCashier.FlatAppearance.BorderSize = 0;
            this.btnToCashier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnToCashier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnToCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToCashier.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToCashier.ForeColor = System.Drawing.Color.Black;
            this.btnToCashier.Location = new System.Drawing.Point(911, 7);
            this.btnToCashier.Name = "btnToCashier";
            this.btnToCashier.Size = new System.Drawing.Size(109, 30);
            this.btnToCashier.TabIndex = 8;
            this.btnToCashier.Text = "Go to Cashier";
            this.btnToCashier.UseVisualStyleBackColor = true;
            this.btnToCashier.Click += new System.EventHandler(this.btnToCashier_Click);
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.dashboard1.Location = new System.Drawing.Point(0, 6);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1055, 598);
            this.dashboard1.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 651);
            this.Controls.Add(this.main_p);
            this.Controls.Add(this.slidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.slidebar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.main_p.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel slidebar;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_user_log;
        private System.Windows.Forms.Button btn_acc;
        private System.Windows.Forms.Button btn_inve;
        private System.Windows.Forms.Button btn_pro;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel main_p;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label mname;
        private System.Windows.Forms.Timer slidetime;
        private System.Windows.Forms.PictureBox iconm;
        private dashboard dashboard1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCLose;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.Button btnToCashier;
    }
}