﻿namespace FinishLine
{
    partial class ModifyRunnerView
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
            this.gBox_Gender = new System.Windows.Forms.GroupBox();
            this.rBtn_Other = new System.Windows.Forms.RadioButton();
            this.rBtn_Female = new System.Windows.Forms.RadioButton();
            this.rBtn_Male = new System.Windows.Forms.RadioButton();
            this.cBox_Country = new System.Windows.Forms.ComboBox();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.tBox_Age = new System.Windows.Forms.TextBox();
            this.lbl_Country = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tBox_Name = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.tBox_ID = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.gBox_Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBox_Gender
            // 
            this.gBox_Gender.BackColor = System.Drawing.SystemColors.Control;
            this.gBox_Gender.Controls.Add(this.rBtn_Other);
            this.gBox_Gender.Controls.Add(this.rBtn_Female);
            this.gBox_Gender.Controls.Add(this.rBtn_Male);
            this.gBox_Gender.Location = new System.Drawing.Point(106, 87);
            this.gBox_Gender.Name = "gBox_Gender";
            this.gBox_Gender.Size = new System.Drawing.Size(267, 51);
            this.gBox_Gender.TabIndex = 20;
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
            // cBox_Country
            // 
            this.cBox_Country.FormattingEnabled = true;
            this.cBox_Country.Location = new System.Drawing.Point(106, 36);
            this.cBox_Country.Name = "cBox_Country";
            this.cBox_Country.Size = new System.Drawing.Size(267, 21);
            this.cBox_Country.TabIndex = 19;
            // 
            // lbl_Age
            // 
            this.lbl_Age.Location = new System.Drawing.Point(12, 61);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(88, 20);
            this.lbl_Age.TabIndex = 18;
            this.lbl_Age.Text = "Age";
            this.lbl_Age.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tBox_Age
            // 
            this.tBox_Age.Location = new System.Drawing.Point(106, 61);
            this.tBox_Age.Name = "tBox_Age";
            this.tBox_Age.Size = new System.Drawing.Size(267, 20);
            this.tBox_Age.TabIndex = 17;
            this.tBox_Age.Text = "35";
            this.tBox_Age.Leave += new System.EventHandler(this.tBox_Age_Leave_1);
            // 
            // lbl_Country
            // 
            this.lbl_Country.Location = new System.Drawing.Point(12, 35);
            this.lbl_Country.Name = "lbl_Country";
            this.lbl_Country.Size = new System.Drawing.Size(88, 20);
            this.lbl_Country.TabIndex = 16;
            this.lbl_Country.Text = "Country";
            this.lbl_Country.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Location = new System.Drawing.Point(12, 9);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(88, 20);
            this.lbl_Name.TabIndex = 15;
            this.lbl_Name.Text = "Name";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tBox_Name
            // 
            this.tBox_Name.Location = new System.Drawing.Point(106, 9);
            this.tBox_Name.Name = "tBox_Name";
            this.tBox_Name.Size = new System.Drawing.Size(267, 20);
            this.tBox_Name.TabIndex = 14;
            // 
            // lbl_ID
            // 
            this.lbl_ID.Location = new System.Drawing.Point(12, 144);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(88, 20);
            this.lbl_ID.TabIndex = 24;
            this.lbl_ID.Text = "ID";
            this.lbl_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tBox_ID
            // 
            this.tBox_ID.Location = new System.Drawing.Point(106, 144);
            this.tBox_ID.Name = "tBox_ID";
            this.tBox_ID.Size = new System.Drawing.Size(267, 20);
            this.tBox_ID.TabIndex = 23;
            this.tBox_ID.Leave += new System.EventHandler(this.tBox_ID_Leave_1);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(211, 215);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 22;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(292, 215);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 21;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // ModifyRunnerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.gBox_Gender);
            this.Controls.Add(this.cBox_Country);
            this.Controls.Add(this.lbl_Age);
            this.Controls.Add(this.tBox_Age);
            this.Controls.Add(this.lbl_Country);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.tBox_Name);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.tBox_ID);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Name = "ModifyRunnerView";
            this.Text = "Modify a Runner";
            this.gBox_Gender.ResumeLayout(false);
            this.gBox_Gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBox_Gender;
        private System.Windows.Forms.RadioButton rBtn_Other;
        private System.Windows.Forms.RadioButton rBtn_Female;
        private System.Windows.Forms.RadioButton rBtn_Male;
        private System.Windows.Forms.ComboBox cBox_Country;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.TextBox tBox_Age;
        private System.Windows.Forms.Label lbl_Country;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tBox_Name;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox tBox_ID;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
    }
}