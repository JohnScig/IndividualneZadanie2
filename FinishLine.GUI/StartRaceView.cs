using FinishLine.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinishLine
{
    public partial class StartRaceView : Form
    {
        public StartRaceView()
        {
            InitializeComponent();
            numeric_PointsPositions.Maximum = Race.Runners.Count();
        }

        private void CalculateLength()
        {
            lbl_OverallLength.Text = (numeric_LapLength.Value * numeric_NoOfLaps.Value).ToString() + " km";
        }

        private void numeric_NoOfLaps_ValueChanged(object sender, EventArgs e)
        {
            CalculateLength();
        }

        private void numeric_LapLength_ValueChanged(object sender, EventArgs e)
        {
            CalculateLength();
        }

        private void btn_StartRace_GO_Click(object sender, EventArgs e)
        {
            Race.NumOfLaps = (int)numeric_NoOfLaps.Value;
            Race.LengthOfLap = (double)numeric_LapLength.Value;
            Race.PointsPositions = (int)numeric_PointsPositions.Value;
            Race.StartOfRace = DateTime.Now;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_StartRace_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            this.Close();
        }
    }
}
