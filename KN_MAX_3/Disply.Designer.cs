namespace KN_MAX_3
{
    partial class Disply
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
            this.di_tech = new System.Windows.Forms.Button();
            this.di_stu = new System.Windows.Forms.Button();
            this.BACK_BT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // di_tech
            // 
            this.di_tech.BackColor = System.Drawing.Color.Transparent;
            this.di_tech.BackgroundImage = global::KN_MAX_3.Properties.Resources.Picsart_25_05_17_22_21_03_418;
            this.di_tech.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.di_tech.Cursor = System.Windows.Forms.Cursors.Hand;
            this.di_tech.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.di_tech.FlatAppearance.BorderSize = 0;
            this.di_tech.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.di_tech.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.di_tech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.di_tech.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.di_tech.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.di_tech.Location = new System.Drawing.Point(348, 46);
            this.di_tech.Margin = new System.Windows.Forms.Padding(4);
            this.di_tech.Name = "di_tech";
            this.di_tech.Size = new System.Drawing.Size(223, 96);
            this.di_tech.TabIndex = 7;
            this.di_tech.Text = "View Teacher";
            this.di_tech.UseVisualStyleBackColor = false;
            this.di_tech.Click += new System.EventHandler(this.di_tech_Click);
            // 
            // di_stu
            // 
            this.di_stu.BackColor = System.Drawing.Color.Transparent;
            this.di_stu.BackgroundImage = global::KN_MAX_3.Properties.Resources.Picsart_25_05_17_21_25_24_132;
            this.di_stu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.di_stu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.di_stu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.di_stu.FlatAppearance.BorderSize = 0;
            this.di_stu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.di_stu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.di_stu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.di_stu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.di_stu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.di_stu.Location = new System.Drawing.Point(66, 46);
            this.di_stu.Margin = new System.Windows.Forms.Padding(4);
            this.di_stu.Name = "di_stu";
            this.di_stu.Size = new System.Drawing.Size(223, 96);
            this.di_stu.TabIndex = 4;
            this.di_stu.Text = "View Student";
            this.di_stu.UseVisualStyleBackColor = false;
            this.di_stu.Click += new System.EventHandler(this.di_stu_Click);
            // 
            // BACK_BT
            // 
            this.BACK_BT.BackColor = System.Drawing.Color.Transparent;
            this.BACK_BT.BackgroundImage = global::KN_MAX_3.Properties.Resources.Picsart_25_05_17_21_26_18_371___Copy;
            this.BACK_BT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BACK_BT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BACK_BT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BACK_BT.FlatAppearance.BorderSize = 0;
            this.BACK_BT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BACK_BT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BACK_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BACK_BT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.BACK_BT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BACK_BT.Location = new System.Drawing.Point(228, 201);
            this.BACK_BT.Margin = new System.Windows.Forms.Padding(4);
            this.BACK_BT.Name = "BACK_BT";
            this.BACK_BT.Size = new System.Drawing.Size(181, 62);
            this.BACK_BT.TabIndex = 8;
            this.BACK_BT.Text = "BACK";
            this.BACK_BT.UseVisualStyleBackColor = false;
            this.BACK_BT.Click += new System.EventHandler(this.BACK_BT_Click);
            // 
            // Disply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KN_MAX_3.Properties.Resources.dark_purple_oppo_r15_stock;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(652, 293);
            this.Controls.Add(this.BACK_BT);
            this.Controls.Add(this.di_tech);
            this.Controls.Add(this.di_stu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Disply";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main UI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button di_tech;
        private System.Windows.Forms.Button di_stu;
        private System.Windows.Forms.Button BACK_BT;
    }
}