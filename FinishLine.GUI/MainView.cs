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
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
            //dataGridView_Laps.Columns[0].FillWeight = 35;

        }

        /// <summary>
        /// Handles the tool strip option "Runners" by opening a dialog where the user can add, edit, load or save runners.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void runnersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunnersView runnersView = new RunnersView();
            runnersView.ShowDialog();
            if (Race.Runners.Count != 0)
            {
                DisplayLaps();
            }
        }

        /// <summary>
        /// Creates a Start Race dialog window. The user specifies the parameters of the race.
        /// If the dialog exits successfully, race is started and both grids are populated.
        /// Creates a dictionary of laptimes based on runners' IDs (and shows an error message if none are added).
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Main_StartRace_Click(object sender, EventArgs e)
        {
            StartRaceView startRaceView = new StartRaceView();
            if (Race.Runners.Count == 0)
            {
                MessageBox.Show("There are no runners. Please add some in the Runners dialogue.");
            }
            else
            {
                startRaceView.ShowDialog();
                if (startRaceView.DialogResult == DialogResult.OK)
                {
                    btn_Main_StartRace.Enabled = false;
                    btn_Main_EndRace.Enabled = true;
                    tBox_FinishLap.Enabled = true;
                    dataGridView_Laps.Enabled = true;
                    Race.StartRace();
                    PopulateRaceParameters();
                    DisplayLaps();
                    DisplayLeaderboards();
                }
            }

        }

        /// <summary>
        /// Handles manually ending the race by the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Main_EndRace_Click(object sender, EventArgs e)
        {
            EndOfRace();

        }

        /// <summary>
        /// Calls the RunnerEndsLap function based on pressing Enter after writing in a correct ID of a runner.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tBox_FinishLap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RunnerEndsLap(int.Parse(tBox_FinishLap.Text));
                tBox_FinishLap.Text = string.Empty;
            }

        }

        /// <summary>
        /// Calls the RunnerEndsLap function based on clicking the runners' grid. The runner on that row is send as parameter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_Laps_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                RunnerEndsLap((int)dataGridView_Laps[0, e.RowIndex].Value);
            }
            catch (ArgumentOutOfRangeException)
            { }
        }

        /// <summary>
        /// Function called when the runner ends a lap. Several checks are called to see if the race is over or if the racer is the leader
        /// or if the racer has finished his race.
        /// If neither of these checks pass, the laptime is added to the racers list of laptimes.
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void RunnerEndsLap(int id)
        {

            if (Race.RunnerLaps.Keys.Contains(id))
            {
                if (Race.CheckFinishedRace(Race.Runners[id]))
                {
                    MessageBox.Show("This racer already finished the race");
                }
                else
                {
                    Race.RunnerLaps[id].Add(DateTime.Now);
                    Race.CheckRaceLeader(Race.Runners[id]);

                    if (Race.CheckIsDone(Race.Runners[id]))
                    {
                        MessageBox.Show($"Racer {Race.Runners[id].Name} has finished the race on position no. {Race.WinningRunners.Count}");
                    }

                    DisplayLaps();
                    DisplayLeaderboards();

                    if (Race.CheckEndOfRace())
                    {
                        MessageBox.Show("The race is over!");
                        EndOfRace();
                    }

                }
            }
            else
            {
                MessageBox.Show("Wrong ID");
            }
        }

        /// <summary>
        /// Called at the end of race. Disables certain elements (race start, clicking on runners' grid) and enables others (saving results to text file)
        /// </summary>
        public void EndOfRace()
        {
            Race.EndOfRace = DateTime.Now;
            btn_Main_EndRace.Enabled = false;
            tBox_FinishLap.Enabled = false;
            dataGridView_Laps.Enabled = false;
            btn_Main_StartRace.Enabled = false;
            tStrip_SaveResults.Enabled = true;
        }

        /// <summary>
        /// This function loads a list of runners into the runners' grid.
        /// </summary>
        public void DisplayLaps()
        {
            dataGridView_Laps.Rows.Clear();
            foreach (Runner person in Race.Runners.Values)
            {
                dataGridView_Laps.Rows.Add(person.ID, person.Name, Race.GetCurrentLap(person.ID),
                    person.Country, person.Age, person.Gender);
            }
            dataGridView_Laps.Sort(dataGridView_Laps.Columns[0], ListSortDirection.Ascending);
        }

        /// <summary>
        /// This function populates the grid of runners and sorts them based on their performance in the race.
        /// </summary>
        public void DisplayLeaderboards()
        {
            dataGridView_Leaderboards.Rows.Clear();
            foreach (Runner person in Race.Runners.Values)
            {
                dataGridView_Leaderboards.Rows.Add(person.ID, person.Name,
                    Race.GetCurrentLap(person.ID), Race.GetLapDeltaToLeader(person.ID).ToString(),
                    Race.GetOverallTime(person.ID), Race.GetOverallHiddenTime(person.ID));
            }
            dataGridView_Leaderboards.Sort(dataGridView_Leaderboards.Columns[5], ListSortDirection.Descending);
        }

        /// <summary>
        /// Populates labels regarding the race parameters.
        /// </summary>
        public void PopulateRaceParameters()
        {
            lbl_Main_NumOfLaps.Text = Race.NumOfLaps.ToString();
            lbl_Main_LapLength.Text = Race.LengthOfLap.ToString() + " km";
            lbl_Main_PointsPositions.Text = Race.PointsPositions.ToString();
            lbl_Main_NumberOfRunners.Text = Race.Runners.Count.ToString();
        }

        /// <summary>
        /// Handles click on the Save Results option in the tool strip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tStrip_SaveResults_Click(object sender, EventArgs e)
        {
            DataHandler.SaveResults();
            MessageBox.Show("Data saved successfully");
        }
    }
}
