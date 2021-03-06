﻿namespace FinishLine
{
    partial class RunnersView
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
            this.dataGridView_Runners = new System.Windows.Forms.DataGridView();
            this.Column_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Runners_Add = new System.Windows.Forms.Button();
            this.btn_Runners_Delete = new System.Windows.Forms.Button();
            this.btn_Runners_Modify = new System.Windows.Forms.Button();
            this.btn_Runners_Close = new System.Windows.Forms.Button();
            this.btn_Runners_Load = new System.Windows.Forms.Button();
            this.btn_Runners_Save = new System.Windows.Forms.Button();
            this.runnersDataGridGrouper = new Subro.Controls.DataGridViewGrouper(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Runners)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Runners
            // 
            this.dataGridView_Runners.AllowUserToAddRows = false;
            this.dataGridView_Runners.AllowUserToDeleteRows = false;
            this.dataGridView_Runners.AllowUserToResizeColumns = false;
            this.dataGridView_Runners.AllowUserToResizeRows = false;
            this.dataGridView_Runners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Runners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Runners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_ID,
            this.Column_Name,
            this.Column_Country,
            this.Column_Age,
            this.Column_Gender});
            this.dataGridView_Runners.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Runners.MultiSelect = false;
            this.dataGridView_Runners.Name = "dataGridView_Runners";
            this.dataGridView_Runners.RowHeadersVisible = false;
            this.dataGridView_Runners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Runners.Size = new System.Drawing.Size(472, 514);
            this.dataGridView_Runners.TabIndex = 0;
            // 
            // Column_ID
            // 
            this.Column_ID.FillWeight = 35F;
            this.Column_ID.HeaderText = "ID";
            this.Column_ID.Name = "Column_ID";
            this.Column_ID.ReadOnly = true;
            // 
            // Column_Name
            // 
            this.Column_Name.HeaderText = "Name";
            this.Column_Name.Name = "Column_Name";
            this.Column_Name.ReadOnly = true;
            // 
            // Column_Country
            // 
            this.Column_Country.FillWeight = 35F;
            this.Column_Country.HeaderText = "Country";
            this.Column_Country.Name = "Column_Country";
            this.Column_Country.ReadOnly = true;
            // 
            // Column_Age
            // 
            this.Column_Age.FillWeight = 35F;
            this.Column_Age.HeaderText = "Age";
            this.Column_Age.Name = "Column_Age";
            this.Column_Age.ReadOnly = true;
            // 
            // Column_Gender
            // 
            this.Column_Gender.FillWeight = 35F;
            this.Column_Gender.HeaderText = "Gender";
            this.Column_Gender.Name = "Column_Gender";
            this.Column_Gender.ReadOnly = true;
            // 
            // btn_Runners_Add
            // 
            this.btn_Runners_Add.Location = new System.Drawing.Point(490, 12);
            this.btn_Runners_Add.Name = "btn_Runners_Add";
            this.btn_Runners_Add.Size = new System.Drawing.Size(134, 23);
            this.btn_Runners_Add.TabIndex = 1;
            this.btn_Runners_Add.Text = "Add Runner";
            this.btn_Runners_Add.UseVisualStyleBackColor = true;
            this.btn_Runners_Add.Click += new System.EventHandler(this.btn_Runners_Add_Click);
            // 
            // btn_Runners_Delete
            // 
            this.btn_Runners_Delete.Location = new System.Drawing.Point(490, 41);
            this.btn_Runners_Delete.Name = "btn_Runners_Delete";
            this.btn_Runners_Delete.Size = new System.Drawing.Size(134, 23);
            this.btn_Runners_Delete.TabIndex = 2;
            this.btn_Runners_Delete.Text = "Delete Runner";
            this.btn_Runners_Delete.UseVisualStyleBackColor = true;
            this.btn_Runners_Delete.Click += new System.EventHandler(this.btn_Runners_Delete_Click);
            // 
            // btn_Runners_Modify
            // 
            this.btn_Runners_Modify.Location = new System.Drawing.Point(490, 70);
            this.btn_Runners_Modify.Name = "btn_Runners_Modify";
            this.btn_Runners_Modify.Size = new System.Drawing.Size(134, 23);
            this.btn_Runners_Modify.TabIndex = 3;
            this.btn_Runners_Modify.Text = "Edit Runner";
            this.btn_Runners_Modify.UseVisualStyleBackColor = true;
            this.btn_Runners_Modify.Click += new System.EventHandler(this.btn_Runners_Modify_Click);
            // 
            // btn_Runners_Close
            // 
            this.btn_Runners_Close.Location = new System.Drawing.Point(490, 503);
            this.btn_Runners_Close.Name = "btn_Runners_Close";
            this.btn_Runners_Close.Size = new System.Drawing.Size(134, 23);
            this.btn_Runners_Close.TabIndex = 4;
            this.btn_Runners_Close.Text = "Close";
            this.btn_Runners_Close.UseVisualStyleBackColor = true;
            this.btn_Runners_Close.Click += new System.EventHandler(this.btn_Runners_Close_Click);
            // 
            // btn_Runners_Load
            // 
            this.btn_Runners_Load.Location = new System.Drawing.Point(490, 380);
            this.btn_Runners_Load.Name = "btn_Runners_Load";
            this.btn_Runners_Load.Size = new System.Drawing.Size(134, 23);
            this.btn_Runners_Load.TabIndex = 5;
            this.btn_Runners_Load.Text = "Load Runners";
            this.btn_Runners_Load.UseVisualStyleBackColor = true;
            this.btn_Runners_Load.Click += new System.EventHandler(this.btn_Runners_Load_Click);
            // 
            // btn_Runners_Save
            // 
            this.btn_Runners_Save.Location = new System.Drawing.Point(490, 409);
            this.btn_Runners_Save.Name = "btn_Runners_Save";
            this.btn_Runners_Save.Size = new System.Drawing.Size(134, 23);
            this.btn_Runners_Save.TabIndex = 6;
            this.btn_Runners_Save.Text = "Save Runners";
            this.btn_Runners_Save.UseVisualStyleBackColor = true;
            this.btn_Runners_Save.Click += new System.EventHandler(this.btn_Runners_Save_Click);
            // 
            // runnersDataGridGrouper
            // 
            this.runnersDataGridGrouper.DataGridView = this.dataGridView_Runners;
            // 
            // RunnersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 538);
            this.Controls.Add(this.btn_Runners_Save);
            this.Controls.Add(this.btn_Runners_Load);
            this.Controls.Add(this.btn_Runners_Close);
            this.Controls.Add(this.btn_Runners_Modify);
            this.Controls.Add(this.btn_Runners_Delete);
            this.Controls.Add(this.btn_Runners_Add);
            this.Controls.Add(this.dataGridView_Runners);
            this.Name = "RunnersView";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Runners)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Runners;
        private System.Windows.Forms.Button btn_Runners_Add;
        private System.Windows.Forms.Button btn_Runners_Delete;
        private System.Windows.Forms.Button btn_Runners_Modify;
        private System.Windows.Forms.Button btn_Runners_Close;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Gender;
        private System.Windows.Forms.Button btn_Runners_Load;
        private System.Windows.Forms.Button btn_Runners_Save;
        private Subro.Controls.DataGridViewGrouper runnersDataGridGrouper;
    }
}