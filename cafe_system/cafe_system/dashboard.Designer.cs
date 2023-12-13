namespace cafe_system
{
    partial class dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.data_acc = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.date_end = new System.Windows.Forms.DateTimePicker();
            this.btn_get = new System.Windows.Forms.Button();
            this.date_start = new System.Windows.Forms.DateTimePicker();
            this.btday = new System.Windows.Forms.Button();
            this.btnmonth = new System.Windows.Forms.Button();
            this.btn7day = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblcus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.user_log = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_acc)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_log)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.label9.Location = new System.Drawing.Point(86, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 28);
            this.label9.TabIndex = 13;
            this.label9.Text = "ACCOUNTS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.label8.Location = new System.Drawing.Point(475, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 28);
            this.label8.TabIndex = 12;
            this.label8.Text = "USER LOG STATS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.label7.Location = new System.Drawing.Point(362, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 41);
            this.label7.TabIndex = 11;
            this.label7.Text = "DASHBOARD";
            // 
            // data_acc
            // 
            this.data_acc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.data_acc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_acc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_acc.Location = new System.Drawing.Point(91, 405);
            this.data_acc.Name = "data_acc";
            this.data_acc.Size = new System.Drawing.Size(333, 150);
            this.data_acc.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btday);
            this.panel2.Controls.Add(this.btnmonth);
            this.panel2.Controls.Add(this.btn7day);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblcus);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(91, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 147);
            this.panel2.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.date_end);
            this.groupBox1.Controls.Add(this.btn_get);
            this.groupBox1.Controls.Add(this.date_start);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.groupBox1.Location = new System.Drawing.Point(195, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 87);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search from Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.label6.Location = new System.Drawing.Point(21, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "To";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.label5.Location = new System.Drawing.Point(21, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "From";
            // 
            // date_end
            // 
            this.date_end.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.date_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_end.Location = new System.Drawing.Point(91, 54);
            this.date_end.Name = "date_end";
            this.date_end.Size = new System.Drawing.Size(96, 21);
            this.date_end.TabIndex = 7;
            this.date_end.Value = new System.DateTime(2022, 12, 17, 0, 0, 0, 0);
            // 
            // btn_get
            // 
            this.btn_get.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_get.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_get.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.btn_get.Location = new System.Drawing.Point(213, 30);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(79, 36);
            this.btn_get.TabIndex = 6;
            this.btn_get.Text = "Get";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // date_start
            // 
            this.date_start.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.date_start.Checked = false;
            this.date_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_start.Location = new System.Drawing.Point(91, 25);
            this.date_start.Name = "date_start";
            this.date_start.Size = new System.Drawing.Size(96, 21);
            this.date_start.TabIndex = 7;
            // 
            // btday
            // 
            this.btday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btday.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.btday.Location = new System.Drawing.Point(511, 52);
            this.btday.Name = "btday";
            this.btday.Size = new System.Drawing.Size(75, 39);
            this.btday.TabIndex = 6;
            this.btday.Text = "Last Day";
            this.btday.UseVisualStyleBackColor = true;
            this.btday.Click += new System.EventHandler(this.btday_Click);
            // 
            // btnmonth
            // 
            this.btnmonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmonth.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.btnmonth.Location = new System.Drawing.Point(691, 52);
            this.btnmonth.Name = "btnmonth";
            this.btnmonth.Size = new System.Drawing.Size(75, 39);
            this.btnmonth.TabIndex = 6;
            this.btnmonth.Text = "Last Moth";
            this.btnmonth.UseVisualStyleBackColor = true;
            this.btnmonth.Click += new System.EventHandler(this.btnmonth_Click);
            // 
            // btn7day
            // 
            this.btn7day.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7day.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7day.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.btn7day.Location = new System.Drawing.Point(593, 52);
            this.btn7day.Name = "btn7day";
            this.btn7day.Size = new System.Drawing.Size(92, 39);
            this.btn7day.TabIndex = 6;
            this.btn7day.Text = "Last 7 Days";
            this.btn7day.UseVisualStyleBackColor = true;
            this.btn7day.Click += new System.EventHandler(this.btn7day_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.label4.Location = new System.Drawing.Point(21, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rs :";
            // 
            // lblcus
            // 
            this.lblcus.AutoSize = true;
            this.lblcus.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.lblcus.Location = new System.Drawing.Point(72, 74);
            this.lblcus.Name = "lblcus";
            this.lblcus.Size = new System.Drawing.Size(0, 24);
            this.lblcus.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = " Profit";
            // 
            // user_log
            // 
            this.user_log.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.user_log.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.user_log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user_log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_log.Location = new System.Drawing.Point(475, 277);
            this.user_log.Name = "user_log";
            this.user_log.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.user_log.Size = new System.Drawing.Size(388, 294);
            this.user_log.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_total);
            this.panel1.Location = new System.Drawing.Point(91, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 115);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.label2.Location = new System.Drawing.Point(91, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rs :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.label1.Location = new System.Drawing.Point(70, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Profit";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.lbl_total.Location = new System.Drawing.Point(142, 72);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(74, 24);
            this.lbl_total.TabIndex = 1;
            this.lbl_total.Text = "label1";
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.data_acc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.user_log);
            this.Controls.Add(this.panel1);
            this.Name = "dashboard";
            this.Size = new System.Drawing.Size(1029, 635);
            this.Load += new System.EventHandler(this.dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_acc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_log)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView data_acc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker date_end;
        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.DateTimePicker date_start;
        private System.Windows.Forms.Button btday;
        private System.Windows.Forms.Button btnmonth;
        private System.Windows.Forms.Button btn7day;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblcus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView user_log;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_total;
    }
}
