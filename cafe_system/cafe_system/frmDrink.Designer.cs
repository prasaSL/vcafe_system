namespace cafe_system
{
    partial class frmDrink
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
            this.button35 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.pnlDrink = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button35
            // 
            this.button35.Location = new System.Drawing.Point(12, 284);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(71, 53);
            this.button35.TabIndex = 1;
            this.button35.Text = "softdrinks";
            this.button35.UseVisualStyleBackColor = true;
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(12, 201);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(71, 53);
            this.button34.TabIndex = 2;
            this.button34.Text = "shakes";
            this.button34.UseVisualStyleBackColor = true;
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(12, 122);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(71, 53);
            this.button33.TabIndex = 3;
            this.button33.Text = "cofee";
            this.button33.UseVisualStyleBackColor = true;
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(12, 51);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(71, 53);
            this.button32.TabIndex = 4;
            this.button32.Text = "tea";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // pnlDrink
            // 
            this.pnlDrink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDrink.Location = new System.Drawing.Point(108, 51);
            this.pnlDrink.Name = "pnlDrink";
            this.pnlDrink.Size = new System.Drawing.Size(817, 441);
            this.pnlDrink.TabIndex = 5;
            // 
            // frmDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(948, 504);
            this.Controls.Add(this.pnlDrink);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button32);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDrink";
            this.Text = "frmDrink";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Panel pnlDrink;
    }
}