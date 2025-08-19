namespace KN_MAX_3
{
    partial class View_Data
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
            this.bt_modify = new System.Windows.Forms.Button();
            this.bt_remove = new System.Windows.Forms.Button();
            this.lv_Data = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.la_name = new System.Windows.Forms.Label();
            this.la_phone = new System.Windows.Forms.Label();
            this.la_gender = new System.Windows.Forms.Label();
            this.tx_name = new System.Windows.Forms.TextBox();
            this.tx_phone = new System.Windows.Forms.TextBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.lacender = new System.Windows.Forms.Label();
            this.BACK_BT = new System.Windows.Forms.Button();
            this.comb_class = new System.Windows.Forms.ComboBox();
            this.comb_gender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bt_modify
            // 
            this.bt_modify.BackColor = System.Drawing.Color.Transparent;
            this.bt_modify.BackgroundImage = global::KN_MAX_3.Properties.Resources.Picsart_25_05_17_21_27_00_045___Copy;
            this.bt_modify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_modify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_modify.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_modify.FlatAppearance.BorderSize = 0;
            this.bt_modify.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_modify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_modify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_modify.Location = new System.Drawing.Point(98, 232);
            this.bt_modify.Margin = new System.Windows.Forms.Padding(4);
            this.bt_modify.Name = "bt_modify";
            this.bt_modify.Size = new System.Drawing.Size(180, 52);
            this.bt_modify.TabIndex = 13;
            this.bt_modify.Text = "Modify";
            this.bt_modify.UseVisualStyleBackColor = false;
            this.bt_modify.Click += new System.EventHandler(this.bt_modify_Click);
            // 
            // bt_remove
            // 
            this.bt_remove.BackColor = System.Drawing.Color.Transparent;
            this.bt_remove.BackgroundImage = global::KN_MAX_3.Properties.Resources.Picsart_25_05_17_22_21_03_418;
            this.bt_remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_remove.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_remove.FlatAppearance.BorderSize = 0;
            this.bt_remove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_remove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_remove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_remove.Location = new System.Drawing.Point(414, 232);
            this.bt_remove.Margin = new System.Windows.Forms.Padding(4);
            this.bt_remove.Name = "bt_remove";
            this.bt_remove.Size = new System.Drawing.Size(182, 52);
            this.bt_remove.TabIndex = 12;
            this.bt_remove.Text = "Remove";
            this.bt_remove.UseVisualStyleBackColor = false;
            this.bt_remove.Click += new System.EventHandler(this.bt_remove_Click);
            // 
            // lv_Data
            // 
            this.lv_Data.BackColor = System.Drawing.Color.White;
            this.lv_Data.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lv_Data.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Data.FullRowSelect = true;
            this.lv_Data.GridLines = true;
            this.lv_Data.HideSelection = false;
            this.lv_Data.Location = new System.Drawing.Point(14, 297);
            this.lv_Data.Margin = new System.Windows.Forms.Padding(5);
            this.lv_Data.MultiSelect = false;
            this.lv_Data.Name = "lv_Data";
            this.lv_Data.Size = new System.Drawing.Size(710, 247);
            this.lv_Data.TabIndex = 11;
            this.lv_Data.UseCompatibleStateImageBehavior = false;
            this.lv_Data.View = System.Windows.Forms.View.Details;
            this.lv_Data.SelectedIndexChanged += new System.EventHandler(this.lv_Data_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Phone";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name Class";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Gender";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 140;
            // 
            // la_name
            // 
            this.la_name.AutoSize = true;
            this.la_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_name.Location = new System.Drawing.Point(110, 35);
            this.la_name.Name = "la_name";
            this.la_name.Size = new System.Drawing.Size(96, 29);
            this.la_name.TabIndex = 14;
            this.la_name.Text = "Name :";
            // 
            // la_phone
            // 
            this.la_phone.AutoSize = true;
            this.la_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_phone.Location = new System.Drawing.Point(110, 82);
            this.la_phone.Name = "la_phone";
            this.la_phone.Size = new System.Drawing.Size(102, 29);
            this.la_phone.TabIndex = 15;
            this.la_phone.Text = "Phone :";
            // 
            // la_gender
            // 
            this.la_gender.AutoSize = true;
            this.la_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_gender.Location = new System.Drawing.Point(110, 132);
            this.la_gender.Name = "la_gender";
            this.la_gender.Size = new System.Drawing.Size(168, 29);
            this.la_gender.TabIndex = 16;
            this.la_gender.Text = "Name Class :";
            // 
            // tx_name
            // 
            this.tx_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_name.Location = new System.Drawing.Point(290, 31);
            this.tx_name.Name = "tx_name";
            this.tx_name.Size = new System.Drawing.Size(311, 34);
            this.tx_name.TabIndex = 17;
            // 
            // tx_phone
            // 
            this.tx_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_phone.Location = new System.Drawing.Point(290, 81);
            this.tx_phone.Name = "tx_phone";
            this.tx_phone.Size = new System.Drawing.Size(311, 34);
            this.tx_phone.TabIndex = 18;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.BackColor = System.Drawing.Color.White;
            this.checkBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox.Location = new System.Drawing.Point(578, 552);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(146, 25);
            this.checkBox.TabIndex = 20;
            this.checkBox.Text = "show all data";
            this.checkBox.UseVisualStyleBackColor = false;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // lacender
            // 
            this.lacender.AutoSize = true;
            this.lacender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lacender.Location = new System.Drawing.Point(110, 184);
            this.lacender.Name = "lacender";
            this.lacender.Size = new System.Drawing.Size(114, 29);
            this.lacender.TabIndex = 21;
            this.lacender.Text = "Gender :";
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
            this.BACK_BT.Location = new System.Drawing.Point(20, 552);
            this.BACK_BT.Margin = new System.Windows.Forms.Padding(4);
            this.BACK_BT.Name = "BACK_BT";
            this.BACK_BT.Size = new System.Drawing.Size(192, 53);
            this.BACK_BT.TabIndex = 23;
            this.BACK_BT.Text = "BACK";
            this.BACK_BT.UseVisualStyleBackColor = false;
            this.BACK_BT.Click += new System.EventHandler(this.BACK_BT_Click);
            // 
            // comb_class
            // 
            this.comb_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.comb_class.FormattingEnabled = true;
            this.comb_class.Location = new System.Drawing.Point(290, 132);
            this.comb_class.Margin = new System.Windows.Forms.Padding(4);
            this.comb_class.Name = "comb_class";
            this.comb_class.Size = new System.Drawing.Size(311, 37);
            this.comb_class.TabIndex = 24;
            // 
            // comb_gender
            // 
            this.comb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.comb_gender.FormattingEnabled = true;
            this.comb_gender.Location = new System.Drawing.Point(290, 187);
            this.comb_gender.Margin = new System.Windows.Forms.Padding(4);
            this.comb_gender.Name = "comb_gender";
            this.comb_gender.Size = new System.Drawing.Size(311, 37);
            this.comb_gender.TabIndex = 25;
            // 
            // View_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KN_MAX_3.Properties.Resources.dark_purple_oppo_r15_stock;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(725, 611);
            this.Controls.Add(this.comb_gender);
            this.Controls.Add(this.comb_class);
            this.Controls.Add(this.BACK_BT);
            this.Controls.Add(this.lacender);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.tx_phone);
            this.Controls.Add(this.tx_name);
            this.Controls.Add(this.la_gender);
            this.Controls.Add(this.la_phone);
            this.Controls.Add(this.la_name);
            this.Controls.Add(this.bt_modify);
            this.Controls.Add(this.bt_remove);
            this.Controls.Add(this.lv_Data);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "View_Data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_modify;
        private System.Windows.Forms.Button bt_remove;
        private System.Windows.Forms.ListView lv_Data;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label la_name;
        private System.Windows.Forms.Label la_phone;
        private System.Windows.Forms.Label la_gender;
        private System.Windows.Forms.TextBox tx_name;
        private System.Windows.Forms.TextBox tx_phone;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label lacender;
        private System.Windows.Forms.Button BACK_BT;
        private System.Windows.Forms.ComboBox comb_class;
        private System.Windows.Forms.ComboBox comb_gender;
    }
}