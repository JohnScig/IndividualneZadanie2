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
            this.tStrip_Runners = new System.Windows.Forms.ToolStrip();
            this.tStripLabel_Runners = new System.Windows.Forms.ToolStripLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tStripLabel_StartRace = new System.Windows.Forms.ToolStripLabel();
            this.tStriptBox_RacerLap = new System.Windows.Forms.ToolStripTextBox();
            this.tStripLabel_RunnerLaps = new System.Windows.Forms.ToolStripLabel();
            this.dataGridViewGrouper1 = new Subro.Controls.DataGridViewGrouper(this.components);
            this.tStrip_Runners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tStrip_Runners
            // 
            this.tStrip_Runners.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStripLabel_Runners,
            this.tStripLabel_StartRace,
            this.tStriptBox_RacerLap,
            this.tStripLabel_RunnerLaps});
            this.tStrip_Runners.Location = new System.Drawing.Point(0, 24);
            this.tStrip_Runners.Name = "tStrip_Runners";
            this.tStrip_Runners.Size = new System.Drawing.Size(800, 25);
            this.tStrip_Runners.TabIndex = 0;
            this.tStrip_Runners.Text = "Runners";
            // 
            // tStripLabel_Runners
            // 
            this.tStripLabel_Runners.Name = "tStripLabel_Runners";
            this.tStripLabel_Runners.Size = new System.Drawing.Size(50, 22);
            this.tStripLabel_Runners.Text = "Runners";
            this.tStripLabel_Runners.Click += new System.EventHandler(this.tStripLabel_Runners_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(347, 383);
            this.dataGridView1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Options";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "New Race";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem3.Text = "Load Race";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem4.Text = "Save Race";
            // 
            // tStripLabel_StartRace
            // 
            this.tStripLabel_StartRace.Name = "tStripLabel_StartRace";
            this.tStripLabel_StartRace.Size = new System.Drawing.Size(59, 22);
            this.tStripLabel_StartRace.Text = "Start Race";
            // 
            // tStriptBox_RacerLap
            // 
            this.tStriptBox_RacerLap.Name = "tStriptBox_RacerLap";
            this.tStriptBox_RacerLap.Size = new System.Drawing.Size(100, 25);
            // 
            // tStripLabel_RunnerLaps
            // 
            this.tStripLabel_RunnerLaps.Name = "tStripLabel_RunnerLaps";
            this.tStripLabel_RunnerLaps.Size = new System.Drawing.Size(72, 22);
            this.tStripLabel_RunnerLaps.Text = "Runner Laps";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tStrip_Runners);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.Text = "Form1";
            this.tStrip_Runners.ResumeLayout(false);
            this.tStrip_Runners.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tStrip_Runners;
        private System.Windows.Forms.ToolStripLabel tStripLabel_Runners;
        private System.Windows.Forms.ToolStripLabel tStripLabel_StartRace;
        private System.Windows.Forms.ToolStripTextBox tStriptBox_RacerLap;
        private System.Windows.Forms.ToolStripLabel tStripLabel_RunnerLaps;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private Subro.Controls.DataGridViewGrouper dataGridViewGrouper1;
    }
}

