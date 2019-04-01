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
            foreach (Runner person in Race.Runners.Values)
            {
                dataGridView_Runners.Rows.Add(person.ID, person.Name, person.Country, person.Age, person.Gender);
            }
            dataGridView_Runners.Sort(dataGridView_Runners.Columns[0], ListSortDirection.Ascending);
            //runnersDataGridGrouper.SetGroupOn(dataGridView_Runners.Columns[3]);

            //dataGridViewGrouper1.SetGroupOn(dataGridView_Laps.Columns[2]);
        }

        private void btn_Runners_Delete_Click(object sender, EventArgs e)
        {
            Race.Runners.Remove(int.Parse(dataGridView_Runners.SelectedRows[0].Cells[0].Value.ToString()));
            DisplayRunners();
        }

        private void btn_Runners_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Runners_Modify_Click(object sender, EventArgs e)
        {
            Runner runnerToChange;
            Race.Runners.TryGetValue((int) dataGridView_Runners.SelectedRows[0].Cells[0].Value, out runnerToChange);

            ModifyRunnerView modifyRunnerView = new ModifyRunnerView(runnerToChange);
            modifyRunnerView.ShowDialog();

            DisplayRunners();
        }

        private void btn_Runners_Load_Click(object sender, EventArgs e)
        {
            Race.Runners.Clear();
            Race.Runners = DataHandler.LoadRunners("runners.txt");

            DisplayRunners();
        }

        private void btn_Runners_Save_Click(object sender, EventArgs e)
        {
            DataHandler.SaveRunners("runners.txt");
        }
    }
}
