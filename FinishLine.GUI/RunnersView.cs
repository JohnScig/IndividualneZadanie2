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
    public partial class RunnersView : Form
    {
        public RunnersView()
        {
            InitializeComponent();
            DisplayRunners();
        }
        

        public void btn_Runners_Add_Click(object sender, EventArgs e)
        {
            new AddRunnerView().ShowDialog();
            DisplayRunners();
        }

        public void DisplayRunners()
        {
            dataGridView_Runners.Rows.Clear();
            foreach (Runner person in Race.Runners)
            {
                dataGridView_Runners.Rows.Add(person.ID, person.Name, person.Country, person.Age, person.Gender);
            }
        }
    }
}
