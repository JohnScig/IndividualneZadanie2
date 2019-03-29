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

        Runners runners = new Runners();


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            runners.ShowDialog();
        }
    }
}
