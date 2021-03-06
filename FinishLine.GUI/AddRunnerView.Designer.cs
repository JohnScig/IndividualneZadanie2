﻿namespace FinishLine
{
    partial class AddRunnerView
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
            this.tBox_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Country = new System.Windows.Forms.Label();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.cBox_Country = new System.Windows.Forms.ComboBox();
            this.gBox_Gender = new System.Windows.Forms.GroupBox();
            this.rBtn_Other = new System.Windows.Forms.RadioButton();
            this.rBtn_Female = new System.Windows.Forms.RadioButton();
            this.rBtn_Male = new System.Windows.Forms.RadioButton();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.numeric_Age = new System.Windows.Forms.NumericUpDown();
            this.numeric_ID = new System.Windows.Forms.NumericUpDown();
            this.gBox_Gender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_ID)).BeginInit();
            this.SuspendLayout();
            // 
            // tBox_Name
            // 
            this.tBox_Name.Location = new System.Drawing.Point(106, 12);
            this.tBox_Name.Name = "tBox_Name";
            this.tBox_Name.Size = new System.Drawing.Size(267, 20);
            this.tBox_Name.TabIndex = 0;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Location = new System.Drawing.Point(12, 12);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(88, 20);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Country
            // 
            this.lbl_Country.Location = new System.Drawing.Point(12, 38);
            this.lbl_Country.Name = "lbl_Country";
            this.lbl_Country.Size = new System.Drawing.Size(88, 20);
            this.lbl_Country.TabIndex = 3;
            this.lbl_Country.Text = "Country";
            this.lbl_Country.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Age
            // 
            this.lbl_Age.Location = new System.Drawing.Point(12, 64);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(88, 20);
            this.lbl_Age.TabIndex = 5;
            this.lbl_Age.Text = "Age";
            this.lbl_Age.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cBox_Country
            // 
            this.cBox_Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Country.FormattingEnabled = true;
            this.cBox_Country.Location = new System.Drawing.Point(106, 39);
            this.cBox_Country.Name = "cBox_Country";
            this.cBox_Country.Size = new System.Drawing.Size(267, 21);
            this.cBox_Country.TabIndex = 6;
            // 
            // gBox_Gender
            // 
            this.gBox_Gender.BackColor = System.Drawing.SystemColors.Control;
            this.gBox_Gender.Controls.Add(this.rBtn_Other);
            this.gBox_Gender.Controls.Add(this.rBtn_Female);
            this.gBox_Gender.Controls.Add(this.rBtn_Male);
            this.gBox_Gender.Location = new System.Drawing.Point(106, 90);
            this.gBox_Gender.Name = "gBox_Gender";
            this.gBox_Gender.Size = new System.Drawing.Size(267, 51);
            this.gBox_Gender.TabIndex = 9;
            this.gBox_Gender.TabStop = false;
            this.gBox_Gender.Text = "Gender";
            // 
            // rBtn_Other
            // 
            this.rBtn_Other.AutoSize = true;
            this.rBtn_Other.Location = new System.Drawing.Point(210, 19);
            this.rBtn_Other.Name = "rBtn_Other";
            this.rBtn_Other.Size = new System.Drawing.Size(51, 17);
            this.rBtn_Other.TabIndex = 2;
            this.rBtn_Other.Text = "Other";
            this.rBtn_Other.UseVisualStyleBackColor = true;
            // 
            // rBtn_Female
            // 
            this.rBtn_Female.AutoSize = true;
            this.rBtn_Female.Location = new System.Drawing.Point(100, 20);
            this.rBtn_Female.Name = "rBtn_Female";
            this.rBtn_Female.Size = new System.Drawing.Size(59, 17);
            this.rBtn_Female.TabIndex = 1;
            this.rBtn_Female.Text = "Female";
            this.rBtn_Female.UseVisualStyleBackColor = true;
            // 
            // rBtn_Male
            // 
            this.rBtn_Male.AutoSize = true;
            this.rBtn_Male.Checked = true;
            this.rBtn_Male.Location = new System.Drawing.Point(7, 20);
            this.rBtn_Male.Name = "rBtn_Male";
            this.rBtn_Male.Size = new System.Drawing.Size(48, 17);
            this.rBtn_Male.TabIndex = 0;
            this.rBtn_Male.TabStop = true;
            this.rBtn_Male.Text = "Male";
            this.rBtn_Male.UseVisualStyleBackColor = true;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(292, 218);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 10;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(211, 218);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_ID
            // 
            this.lbl_ID.Location = new System.Drawing.Point(12, 147);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(88, 20);
            this.lbl_ID.TabIndex = 13;
            this.lbl_ID.Text = "ID";
            this.lbl_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numeric_Age
            // 
            this.numeric_Age.Location = new System.Drawing.Point(106, 66);
            this.numeric_Age.Maximum = new decimal(new int[] {
            117,
            0,
            0,
            0});
            this.numeric_Age.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numeric_Age.Name = "numeric_Age";
            this.numeric_Age.Size = new System.Drawing.Size(267, 20);
            this.numeric_Age.TabIndex = 14;
            this.numeric_Age.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // numeric_ID
            // 
            this.numeric_ID.Location = new System.Drawing.Point(106, 149);
            this.numeric_ID.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numeric_ID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_ID.Name = "numeric_ID";
            this.numeric_ID.Size = new System.Drawing.Size(267, 20);
            this.numeric_ID.TabIndex = 15;
            this.numeric_ID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_ID.ValueChanged += new System.EventHandler(this.numeric_ID_ValueChanged);
            // 
            // AddRunnerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.numeric_ID);
            this.Controls.Add(this.numeric_Age);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.gBox_Gender);
            this.Controls.Add(this.cBox_Country);
            this.Controls.Add(this.lbl_Age);
            this.Controls.Add(this.lbl_Country);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.tBox_Name);
            this.Name = "AddRunnerView";
            this.Text = "Add a Runner";
            this.gBox_Gender.ResumeLayout(false);
            this.gBox_Gender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_ID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBox_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Country;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.ComboBox cBox_Country;
        private System.Windows.Forms.GroupBox gBox_Gender;
        private System.Windows.Forms.RadioButton rBtn_Other;
        private System.Windows.Forms.RadioButton rBtn_Female;
        private System.Windows.Forms.RadioButton rBtn_Male;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.NumericUpDown numeric_Age;
        private System.Windows.Forms.NumericUpDown numeric_ID;
    }
}