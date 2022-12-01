namespace cafe_system
{
    partial class drinkbtn
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
            this.btntea = new System.Windows.Forms.Button();
            this.btncofee = new System.Windows.Forms.Button();
            this.btnshakes = new System.Windows.Forms.Button();
            this.btnsoftdrink = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.shakes1 = new cafe_system.shakes();
            this.tea1 = new cafe_system.tea();
            this.SuspendLayout();
            // 
            // btntea
            // 
            this.btntea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btntea.Location = new System.Drawing.Point(28, 80);
            this.btntea.Name = "btntea";
            this.btntea.Size = new System.Drawing.Size(71, 53);
            this.btntea.TabIndex = 9;
            this.btntea.Text = "tea";
            this.btntea.UseVisualStyleBackColor = true;
            this.btntea.Click += new System.EventHandler(this.button32_Click);
            // 
            // btncofee
            // 
            this.btncofee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btncofee.Location = new System.Drawing.Point(28, 155);
            this.btncofee.Name = "btncofee";
            this.btncofee.Size = new System.Drawing.Size(71, 53);
            this.btncofee.TabIndex = 8;
            this.btncofee.Text = "cofee";
            this.btncofee.UseVisualStyleBackColor = true;
            // 
            // btnshakes
            // 
            this.btnshakes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnshakes.Location = new System.Drawing.Point(28, 230);
            this.btnshakes.Name = "btnshakes";
            this.btnshakes.Size = new System.Drawing.Size(71, 53);
            this.btnshakes.TabIndex = 7;
            this.btnshakes.Text = "shakes";
            this.btnshakes.UseVisualStyleBackColor = true;
            this.btnshakes.Click += new System.EventHandler(this.button34_Click);
            // 
            // btnsoftdrink
            // 
            this.btnsoftdrink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnsoftdrink.Location = new System.Drawing.Point(28, 313);
            this.btnsoftdrink.Name = "btnsoftdrink";
            this.btnsoftdrink.Size = new System.Drawing.Size(71, 53);
            this.btnsoftdrink.TabIndex = 6;
            this.btnsoftdrink.Text = "softdrinks";
            this.btnsoftdrink.UseVisualStyleBackColor = true;
            this.btnsoftdrink.Click += new System.EventHandler(this.button35_Click);
            // 
            // shakes1
            // 
            this.shakes1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.shakes1.Location = new System.Drawing.Point(134, 3);
            this.shakes1.Name = "shakes1";
            this.shakes1.Size = new System.Drawing.Size(820, 443);
            this.shakes1.TabIndex = 11;
            // 
            // tea1
            // 
            this.tea1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tea1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tea1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tea1.Location = new System.Drawing.Point(112, 3);
            this.tea1.Name = "tea1";
            this.tea1.Size = new System.Drawing.Size(790, 434);
            this.tea1.TabIndex = 10;
            // 
            // drinkbtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.shakes1);
            this.Controls.Add(this.tea1);
            this.Controls.Add(this.btnsoftdrink);
            this.Controls.Add(this.btnshakes);
            this.Controls.Add(this.btncofee);
            this.Controls.Add(this.btntea);
            this.Name = "drinkbtn";
            this.Size = new System.Drawing.Size(732, 437);
            this.Load += new System.EventHandler(this.drinkbtn_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btntea;
        private System.Windows.Forms.Button btncofee;
        private System.Windows.Forms.Button btnshakes;
        private System.Windows.Forms.Button btnsoftdrink;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private tea tea1;
        private shakes shakes1;


    }
}
