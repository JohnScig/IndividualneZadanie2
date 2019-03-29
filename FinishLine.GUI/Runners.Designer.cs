namespace FinishLine
{
    partial class Runners
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Runners_Add = new System.Windows.Forms.Button();
            this.btn_Runners_Delete = new System.Windows.Forms.Button();
            this.btn_Runners_Modify = new System.Windows.Forms.Button();
            this.btn_Runners_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(425, 514);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_Runners_Add
            // 
            this.btn_Runners_Add.Location = new System.Drawing.Point(443, 12);
            this.btn_Runners_Add.Name = "btn_Runners_Add";
            this.btn_Runners_Add.Size = new System.Drawing.Size(134, 23);
            this.btn_Runners_Add.TabIndex = 1;
            this.btn_Runners_Add.Text = "Add Runner";
            this.btn_Runners_Add.UseVisualStyleBackColor = true;
            this.btn_Runners_Add.Click += new System.EventHandler(this.btn_Runners_Add_Click);
            // 
            // btn_Runners_Delete
            // 
            this.btn_Runners_Delete.Location = new System.Drawing.Point(443, 41);
            this.btn_Runners_Delete.Name = "btn_Runners_Delete";
            this.btn_Runners_Delete.Size = new System.Drawing.Size(134, 23);
            this.btn_Runners_Delete.TabIndex = 2;
            this.btn_Runners_Delete.Text = "Delete Runner";
            this.btn_Runners_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Runners_Modify
            // 
            this.btn_Runners_Modify.Location = new System.Drawing.Point(443, 70);
            this.btn_Runners_Modify.Name = "btn_Runners_Modify";
            this.btn_Runners_Modify.Size = new System.Drawing.Size(134, 23);
            this.btn_Runners_Modify.TabIndex = 3;
            this.btn_Runners_Modify.Text = "Modify Runner";
            this.btn_Runners_Modify.UseVisualStyleBackColor = true;
            // 
            // btn_Runners_Close
            // 
            this.btn_Runners_Close.Location = new System.Drawing.Point(502, 503);
            this.btn_Runners_Close.Name = "btn_Runners_Close";
            this.btn_Runners_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Runners_Close.TabIndex = 4;
            this.btn_Runners_Close.Text = "Close";
            this.btn_Runners_Close.UseVisualStyleBackColor = true;
            // 
            // Runners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 538);
            this.Controls.Add(this.btn_Runners_Close);
            this.Controls.Add(this.btn_Runners_Modify);
            this.Controls.Add(this.btn_Runners_Delete);
            this.Controls.Add(this.btn_Runners_Add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Runners";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Runners_Add;
        private System.Windows.Forms.Button btn_Runners_Delete;
        private System.Windows.Forms.Button btn_Runners_Modify;
        private System.Windows.Forms.Button btn_Runners_Close;
    }
}