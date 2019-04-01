namespace FinishLine
{
    partial class StartRaceView
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
            this.label1 = new System.Windows.Forms.Label();
            this.numeric_NoOfLaps = new System.Windows.Forms.NumericUpDown();
            this.numeric_LapLength = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numeric_PointsPositions = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_OverallLength = new System.Windows.Forms.Label();
            this.btn_StartRace_GO = new System.Windows.Forms.Button();
            this.btn_StartRace_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_NoOfLaps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_LapLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_PointsPositions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set Number Of Laps";
            // 
            // numeric_NoOfLaps
            // 
            this.numeric_NoOfLaps.Location = new System.Drawing.Point(131, 7);
            this.numeric_NoOfLaps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_NoOfLaps.Name = "numeric_NoOfLaps";
            this.numeric_NoOfLaps.Size = new System.Drawing.Size(120, 20);
            this.numeric_NoOfLaps.TabIndex = 1;
            this.numeric_NoOfLaps.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numeric_NoOfLaps.ValueChanged += new System.EventHandler(this.numeric_NoOfLaps_ValueChanged);
            // 
            // numeric_LapLength
            // 
            this.numeric_LapLength.DecimalPlaces = 3;
            this.numeric_LapLength.Location = new System.Drawing.Point(131, 41);
            this.numeric_LapLength.Name = "numeric_LapLength";
            this.numeric_LapLength.Size = new System.Drawing.Size(120, 20);
            this.numeric_LapLength.TabIndex = 3;
            this.numeric_LapLength.Value = new decimal(new int[] {
            1500,
            0,
            0,
            196608});
            this.numeric_LapLength.ValueChanged += new System.EventHandler(this.numeric_LapLength_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Set Lap Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "No. of Points Positions";
            // 
            // numeric_PointsPositions
            // 
            this.numeric_PointsPositions.Location = new System.Drawing.Point(131, 76);
            this.numeric_PointsPositions.Name = "numeric_PointsPositions";
            this.numeric_PointsPositions.Size = new System.Drawing.Size(120, 20);
            this.numeric_PointsPositions.TabIndex = 3;
            this.numeric_PointsPositions.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Overall  Race Length";
            // 
            // lbl_OverallLength
            // 
            this.lbl_OverallLength.AutoSize = true;
            this.lbl_OverallLength.Location = new System.Drawing.Point(129, 123);
            this.lbl_OverallLength.Name = "lbl_OverallLength";
            this.lbl_OverallLength.Size = new System.Drawing.Size(83, 13);
            this.lbl_OverallLength.TabIndex = 5;
            this.lbl_OverallLength.Text = "ToBeCalculated";
            // 
            // btn_StartRace_GO
            // 
            this.btn_StartRace_GO.Location = new System.Drawing.Point(131, 186);
            this.btn_StartRace_GO.Name = "btn_StartRace_GO";
            this.btn_StartRace_GO.Size = new System.Drawing.Size(150, 81);
            this.btn_StartRace_GO.TabIndex = 6;
            this.btn_StartRace_GO.Text = "GO!";
            this.btn_StartRace_GO.UseVisualStyleBackColor = true;
            this.btn_StartRace_GO.Click += new System.EventHandler(this.btn_StartRace_GO_Click);
            // 
            // btn_StartRace_Cancel
            // 
            this.btn_StartRace_Cancel.Location = new System.Drawing.Point(15, 244);
            this.btn_StartRace_Cancel.Name = "btn_StartRace_Cancel";
            this.btn_StartRace_Cancel.Size = new System.Drawing.Size(100, 23);
            this.btn_StartRace_Cancel.TabIndex = 7;
            this.btn_StartRace_Cancel.Text = "Cancel";
            this.btn_StartRace_Cancel.UseVisualStyleBackColor = true;
            this.btn_StartRace_Cancel.Click += new System.EventHandler(this.btn_StartRace_Cancel_Click);
            // 
            // StartRaceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 279);
            this.Controls.Add(this.btn_StartRace_Cancel);
            this.Controls.Add(this.btn_StartRace_GO);
            this.Controls.Add(this.lbl_OverallLength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numeric_PointsPositions);
            this.Controls.Add(this.numeric_LapLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numeric_NoOfLaps);
            this.Controls.Add(this.label1);
            this.Name = "StartRaceView";
            this.Text = "Start Race";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_NoOfLaps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_LapLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_PointsPositions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numeric_NoOfLaps;
        private System.Windows.Forms.NumericUpDown numeric_LapLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numeric_PointsPositions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_OverallLength;
        private System.Windows.Forms.Button btn_StartRace_GO;
        private System.Windows.Forms.Button btn_StartRace_Cancel;
    }
}