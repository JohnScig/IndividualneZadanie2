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
        /// <summary>
        /// Basic constructor.
        /// Sets the maximum value for Points Position numBox as the number of racers in the race (for obvious reasons).
        /// Also calculated the default length of the race.
        /// </summary>
        public StartRaceView()
        {
            InitializeComponent();
            numeric_PointsPositions.Maximum = Race.Runners.Count();
            CalculateLength();
        }

        /// <summary>
        /// Calculates the length of the race based on number of laps and length of laps.
        /// </summary>
        private void CalculateLength()
        {
            lbl_OverallLength.Text = (numeric_LapLength.Value * numeric_NoOfLaps.Value).ToString() + " km";
        }

        /// <summary>
        /// Calls the race length calculation method on changing the value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numeric_NoOfLaps_ValueChanged(object sender, EventArgs e)
        {
            CalculateLength();
        }

        /// <summary>
        /// Calls the race length calculation method on changing the value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numeric_LapLength_ValueChanged(object sender, EventArgs e)
        {
            CalculateLength();
        }

        /// <summary>
        /// On clicking the Go button, this dialog sends its data to the general Race method with parameters necessary for the race to run.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_StartRace_GO_Click(object sender, EventArgs e)
        {
            Race.NumOfLaps = (int)numeric_NoOfLaps.Value;
            Race.LengthOfLap = (double)numeric_LapLength.Value;
            Race.PointsPositions = (int)numeric_PointsPositions.Value;
            Race.StartOfRace = DateTime.Now;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Closes the dialog with "Abort" result.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_StartRace_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            this.Close();
        }
    }
}
