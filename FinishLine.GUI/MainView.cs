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


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void tStripLabel_Runners_Click(object sender, EventArgs e)
        {
            runnersView.ShowDialog();
        }
    }
}
