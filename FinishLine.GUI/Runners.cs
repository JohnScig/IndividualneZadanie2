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
    public partial class Runners : Form
    {
        public Runners()
        {
            InitializeComponent();
        }

        private void btn_Runners_Add_Click(object sender, EventArgs e)
        {
            new AddRunner().ShowDialog();
        }
    }
}
