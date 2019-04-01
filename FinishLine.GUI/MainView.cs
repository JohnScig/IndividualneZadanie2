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
            
        }
        
        private void runnersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunnersView runnersView = new RunnersView();
            runnersView.ShowDialog();
        }

        private void btn_Main_StartRace_Click(object sender, EventArgs e)
        {
            StartRaceView startRaceView = new StartRaceView();
            startRaceView.ShowDialog();
            if (startRaceView.DialogResult == DialogResult.OK)
            {
                btn_Main_StartRace.Enabled = false;
                btn_Main_EndRace.Enabled = true;
            }
            Race.StartRace();
            DisplayLaps();
            DisplayLeaderboards();
        }

        private void btn_Main_EndRace_Click(object sender, EventArgs e)
        {
            Race.EndOfRace = DateTime.Now;
            btn_Main_EndRace.Enabled = false;
            btn_Main_StartRace.Enabled = true;
        }

        public void DisplayLaps()
        {
            dataGridView_Laps.Rows.Clear();
            foreach (Runner person in Race.Runners.Values)
            {
                dataGridView_Laps.Rows.Add(person.ID, person.Name, Race.GetCurrentLap(person.ID),
                    person.Country, person.Age, person.Gender);
            }
            //dataGridViewGrouper1.SetGroupOn(dataGridView_Laps.Columns[2]);
        }

        public void DisplayLeaderboards()
        {
            dataGridView_Leaderboards.Rows.Clear();
            foreach (Runner person in Race.Runners.Values)
            {
                dataGridView_Leaderboards.Rows.Add(person.ID, person.Name, 
                    Race.GetCurrentLap(person.ID), Race.GetLapDeltaToLeader(person.ID).ToString(), Race.GetOverallTime(person.ID));
            }
            dataGridView_Leaderboards.Sort(dataGridView_Leaderboards.Columns[4], ListSortDirection.Ascending);
            //dataGridView_Leaderboards.Sort(dataGridView_Leaderboards.Columns[2], ListSortDirection.Descending);
            
            
        }

        private void tBox_FinishLap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int lappingRunnerID = int.Parse(tBox_FinishLap.Text);

                Race.RunnerLaps[lappingRunnerID].Add(DateTime.Now);
                Race.CheckRaceLeader(Race.Runners[lappingRunnerID]);
                //MessageBox.Show(tBox_FinishLap.Text);
            }
            DisplayLaps();
            DisplayLeaderboards();

        }

        

    }
}
