namespace cafe_system
{
    partial class frmFood
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
            this.btnrice = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button35
            // 
            this.button35.Location = new System.Drawing.Point(12, 280);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(71, 53);
            this.button35.TabIndex = 5;
            this.button35.Text = "bagels";
            this.button35.UseVisualStyleBackColor = true;
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(12, 197);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(71, 53);
            this.button34.TabIndex = 6;
            this.button34.Text = "sandwiches";
            this.button34.UseVisualStyleBackColor = true;
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(12, 118);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(71, 53);
            this.button33.TabIndex = 7;
            this.button33.Text = "pasta";
            this.button33.UseVisualStyleBackColor = true;
            // 
            // btnrice
            // 
            this.btnrice.Location = new System.Drawing.Point(12, 47);
            this.btnrice.Name = "btnrice";
            this.btnrice.Size = new System.Drawing.Size(71, 53);
            this.btnrice.TabIndex = 8;
            this.btnrice.Text = "Rice";
            this.btnrice.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(180, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 548);
            this.panel1.TabIndex = 9;
            // 
            // frmFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.btnrice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFood";
            this.Text = "frmFood";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button btnrice;
        private System.Windows.Forms.Panel panel1;
    }
}