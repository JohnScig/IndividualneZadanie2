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

        private void runnersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunnersView runnersView = new RunnersView();
            runnersView.ShowDialog();
            if (Race.Runners.Count != 0)
            {
                DisplayLaps();
            }
        }

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
                    DisplayLaps();
                    DisplayLeaderboards();
                }
            }

        }

        private void btn_Main_EndRace_Click(object sender, EventArgs e)
        {
            EndOfRace();

        }

        private void tBox_FinishLap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //int lappingRunnerID = int.Parse(tBox_FinishLap.Text);

                RunnerEndsLap(int.Parse(tBox_FinishLap.Text));
                tBox_FinishLap.Text = string.Empty;
            }

        }

        private void dataGridView_Laps_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //int lappingRunnerID = (int)dataGridView_Laps[0, e.RowIndex].Value;
                RunnerEndsLap((int)dataGridView_Laps[0, e.RowIndex].Value);
            }
            catch (ArgumentOutOfRangeException)
            { }
        }

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

                    DisplayLaps();
                    DisplayLeaderboards();

                    if (Race.CheckIsDone(Race.Runners[id]))
                    {
                        MessageBox.Show($"Racer {Race.Runners[id].Name} has finished the race on position no. {Race.WinningRunners.Count}");
                    }

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

        public void EndOfRace()
        {
            Race.EndOfRace = DateTime.Now;
            btn_Main_EndRace.Enabled = false;
            tBox_FinishLap.Enabled = false;
            dataGridView_Laps.Enabled = false;
            btn_Main_StartRace.Enabled = true;
            tStrip_SaveResults.Enabled = true;
        }

        public void DisplayLaps()
        {
            dataGridView_Laps.Rows.Clear();
            foreach (Runner person in Race.Runners.Values)
            {
                dataGridView_Laps.Rows.Add(person.ID, person.Name, Race.GetCurrentLap(person.ID),
                    person.Country, person.Age, person.Gender);
            }


        }

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
            //dataGridView_Leaderboards.Sort(dataGridView_Leaderboards.Columns[2], ListSortDirection.Descending);


        }

        private void tStrip_SaveResults_Click(object sender, EventArgs e)
        {
            DataHandler.SaveResults();
        }
    }
}
