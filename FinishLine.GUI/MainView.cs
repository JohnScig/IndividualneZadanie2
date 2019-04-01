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
        RunnersView runnersView = new RunnersView();


        private void tStripLabel_Runners_Click(object sender, EventArgs e)
        {
            
        }

        private void runnersToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
        }

        private void btn_Main_EndRace_Click(object sender, EventArgs e)
        {
            Race.EndOfRace = DateTime.Now;
            btn_Main_EndRace.Enabled = false;
            btn_Main_StartRace.Enabled = true;
        }
    }
}
