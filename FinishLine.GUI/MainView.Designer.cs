namespace FinishLine
{
    partial class MainView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_Laps = new System.Windows.Forms.DataGridView();
            this.Column_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Laps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tStrip_SaveResults = new System.Windows.Forms.ToolStripMenuItem();
            this.runnersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tBox_FinishLap = new System.Windows.Forms.TextBox();
            this.dataGridView_Leaderboards = new System.Windows.Forms.DataGridView();
            this.btn_Main_StartRace = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Main_NumOfLaps = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Main_LapLength = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Main_PointsPositions = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_Main_NumberOfRunners = new System.Windows.Forms.Label();
            this.btn_Main_EndRace = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewGrouper1 = new Subro.Controls.DataGridViewGrouper(this.components);
            this.Column_Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_DeltaTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_OverallTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OverallHiddenTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Laps)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Leaderboards)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Laps
            // 
            this.dataGridView_Laps.AllowUserToAddRows = false;
            this.dataGridView_Laps.AllowUserToDeleteRows = false;
            this.dataGridView_Laps.AllowUserToResizeColumns = false;
            this.dataGridView_Laps.AllowUserToResizeRows = false;
            this.dataGridView_Laps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Laps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Laps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_ID,
            this.Column_Name,
            this.Column_Laps,
            this.Column_Country,
            this.Column_Age,
            this.Column_Gender});
            this.dataGridView_Laps.Location = new System.Drawing.Point(12, 27);
            this.dataGridView_Laps.MultiSelect = false;
            this.dataGridView_Laps.Name = "dataGridView_Laps";
            this.dataGridView_Laps.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView_Laps.RowHeadersVisible = false;
            this.dataGridView_Laps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Laps.Size = new System.Drawing.Size(384, 411);
            this.dataGridView_Laps.TabIndex = 1;
            this.dataGridView_Laps.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Laps_CellContentClick);
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
            // Column_Laps
            // 
            this.Column_Laps.FillWeight = 35F;
            this.Column_Laps.HeaderText = "Laps";
            this.Column_Laps.Name = "Column_Laps";
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.runnersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1060, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStrip_SaveResults});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Options";
            // 
            // tStrip_SaveResults
            // 
            this.tStrip_SaveResults.Enabled = false;
            this.tStrip_SaveResults.Name = "tStrip_SaveResults";
            this.tStrip_SaveResults.Size = new System.Drawing.Size(138, 22);
            this.tStrip_SaveResults.Text = "Save Results";
            this.tStrip_SaveResults.Click += new System.EventHandler(this.tStrip_SaveResults_Click);
            // 
            // runnersToolStripMenuItem
            // 
            this.runnersToolStripMenuItem.Name = "runnersToolStripMenuItem";
            this.runnersToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.runnersToolStripMenuItem.Text = "Runners";
            this.runnersToolStripMenuItem.Click += new System.EventHandler(this.runnersToolStripMenuItem_Click);
            // 
            // tBox_FinishLap
            // 
            this.tBox_FinishLap.Location = new System.Drawing.Point(402, 76);
            this.tBox_FinishLap.Name = "tBox_FinishLap";
            this.tBox_FinishLap.Size = new System.Drawing.Size(100, 20);
            this.tBox_FinishLap.TabIndex = 3;
            this.tBox_FinishLap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBox_FinishLap_KeyDown);
            // 
            // dataGridView_Leaderboards
            // 
            this.dataGridView_Leaderboards.AllowUserToAddRows = false;
            this.dataGridView_Leaderboards.AllowUserToDeleteRows = false;
            this.dataGridView_Leaderboards.AllowUserToResizeColumns = false;
            this.dataGridView_Leaderboards.AllowUserToResizeRows = false;
            this.dataGridView_Leaderboards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Leaderboards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Leaderboards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Position,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column_DeltaTime,
            this.Column_OverallTime,
            this.OverallHiddenTime});
            this.dataGridView_Leaderboards.Enabled = false;
            this.dataGridView_Leaderboards.Location = new System.Drawing.Point(508, 26);
            this.dataGridView_Leaderboards.Name = "dataGridView_Leaderboards";
            this.dataGridView_Leaderboards.RowHeadersVisible = false;
            this.dataGridView_Leaderboards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Leaderboards.Size = new System.Drawing.Size(540, 411);
            this.dataGridView_Leaderboards.TabIndex = 4;
            // 
            // btn_Main_StartRace
            // 
            this.btn_Main_StartRace.Location = new System.Drawing.Point(403, 27);
            this.btn_Main_StartRace.Name = "btn_Main_StartRace";
            this.btn_Main_StartRace.Size = new System.Drawing.Size(99, 43);
            this.btn_Main_StartRace.TabIndex = 5;
            this.btn_Main_StartRace.Text = "Start Race";
            this.btn_Main_StartRace.UseVisualStyleBackColor = true;
            this.btn_Main_StartRace.Click += new System.EventHandler(this.btn_Main_StartRace_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Number of Laps";
            // 
            // lbl_Main_NumOfLaps
            // 
            this.lbl_Main_NumOfLaps.AutoSize = true;
            this.lbl_Main_NumOfLaps.Location = new System.Drawing.Point(467, 157);
            this.lbl_Main_NumOfLaps.Name = "lbl_Main_NumOfLaps";
            this.lbl_Main_NumOfLaps.Size = new System.Drawing.Size(13, 13);
            this.lbl_Main_NumOfLaps.TabIndex = 7;
            this.lbl_Main_NumOfLaps.Text = "0";
            this.lbl_Main_NumOfLaps.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lap Length";
            // 
            // lbl_Main_LapLength
            // 
            this.lbl_Main_LapLength.AutoSize = true;
            this.lbl_Main_LapLength.Location = new System.Drawing.Point(467, 203);
            this.lbl_Main_LapLength.Name = "lbl_Main_LapLength";
            this.lbl_Main_LapLength.Size = new System.Drawing.Size(13, 13);
            this.lbl_Main_LapLength.TabIndex = 9;
            this.lbl_Main_LapLength.Text = "0";
            this.lbl_Main_LapLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Points Positions";
            // 
            // lbl_Main_PointsPositions
            // 
            this.lbl_Main_PointsPositions.AutoSize = true;
            this.lbl_Main_PointsPositions.Location = new System.Drawing.Point(467, 244);
            this.lbl_Main_PointsPositions.Name = "lbl_Main_PointsPositions";
            this.lbl_Main_PointsPositions.Size = new System.Drawing.Size(13, 13);
            this.lbl_Main_PointsPositions.TabIndex = 11;
            this.lbl_Main_PointsPositions.Text = "0";
            this.lbl_Main_PointsPositions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Number of Runners";
            // 
            // lbl_Main_NumberOfRunners
            // 
            this.lbl_Main_NumberOfRunners.AutoSize = true;
            this.lbl_Main_NumberOfRunners.Location = new System.Drawing.Point(467, 305);
            this.lbl_Main_NumberOfRunners.Name = "lbl_Main_NumberOfRunners";
            this.lbl_Main_NumberOfRunners.Size = new System.Drawing.Size(13, 13);
            this.lbl_Main_NumberOfRunners.TabIndex = 13;
            this.lbl_Main_NumberOfRunners.Text = "0";
            this.lbl_Main_NumberOfRunners.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Main_EndRace
            // 
            this.btn_Main_EndRace.Enabled = false;
            this.btn_Main_EndRace.Location = new System.Drawing.Point(405, 413);
            this.btn_Main_EndRace.Name = "btn_Main_EndRace";
            this.btn_Main_EndRace.Size = new System.Drawing.Size(96, 23);
            this.btn_Main_EndRace.TabIndex = 14;
            this.btn_Main_EndRace.Text = "End Race";
            this.btn_Main_EndRace.UseVisualStyleBackColor = true;
            this.btn_Main_EndRace.Click += new System.EventHandler(this.btn_Main_EndRace_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(403, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Runner finished lap";
            // 
            // dataGridViewGrouper1
            // 
            this.dataGridViewGrouper1.DataGridView = this.dataGridView_Laps;
            // 
            // Column_Position
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column_Position.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column_Position.FillWeight = 25F;
            this.Column_Position.HeaderText = "Pos";
            this.Column_Position.Name = "Column_Position";
            this.Column_Position.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 35F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 35F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Laps";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Column_DeltaTime
            // 
            this.Column_DeltaTime.FillWeight = 80F;
            this.Column_DeltaTime.HeaderText = "Delta Time";
            this.Column_DeltaTime.Name = "Column_DeltaTime";
            this.Column_DeltaTime.ReadOnly = true;
            // 
            // Column_OverallTime
            // 
            this.Column_OverallTime.FillWeight = 80F;
            this.Column_OverallTime.HeaderText = "Overall Time";
            this.Column_OverallTime.Name = "Column_OverallTime";
            // 
            // OverallHiddenTime
            // 
            this.OverallHiddenTime.HeaderText = "HiddenTime";
            this.OverallHiddenTime.Name = "OverallHiddenTime";
            this.OverallHiddenTime.ReadOnly = true;
            this.OverallHiddenTime.Visible = false;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_Main_EndRace);
            this.Controls.Add(this.lbl_Main_NumberOfRunners);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_Main_PointsPositions);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_Main_LapLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Main_NumOfLaps);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Main_StartRace);
            this.Controls.Add(this.dataGridView_Leaderboards);
            this.Controls.Add(this.tBox_FinishLap);
            this.Controls.Add(this.dataGridView_Laps);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Laps)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Leaderboards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_Laps;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tStrip_SaveResults;
        private Subro.Controls.DataGridViewGrouper dataGridViewGrouper1;
        private System.Windows.Forms.ToolStripMenuItem runnersToolStripMenuItem;
        private System.Windows.Forms.TextBox tBox_FinishLap;
        private System.Windows.Forms.DataGridView dataGridView_Leaderboards;
        private System.Windows.Forms.Button btn_Main_StartRace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Main_NumOfLaps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Main_LapLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Main_PointsPositions;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_Main_NumberOfRunners;
        private System.Windows.Forms.Button btn_Main_EndRace;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Laps;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DeltaTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_OverallTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn OverallHiddenTime;
    }
}

