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
        
        /// <summary>
        /// Opens the adding window. Afterwards, the new list is saved into a textfile.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btn_Runners_Add_Click(object sender, EventArgs e)
        {
            new AddRunnerView().ShowDialog();

            DataHandler.SaveRunners("runners.txt");
            DisplayRunners();
        }

        /// <summary>
        /// Loads the current Dictionary of runners into the grid. Is called every time a runner is added, edited or deleted.
        /// </summary>
        public void DisplayRunners()
        {
            dataGridView_Runners.Rows.Clear();
            foreach (Runner person in Race.Runners.Values)
            {
                dataGridView_Runners.Rows.Add(person.ID, person.Name, person.Country, person.Age, person.Gender);
            }
            dataGridView_Runners.Sort(dataGridView_Runners.Columns[0], ListSortDirection.Ascending);
        }

        /// <summary>
        /// Deletes a runner from the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Runners_Delete_Click(object sender, EventArgs e)
        {
            Race.Runners.Remove((int)dataGridView_Runners.SelectedRows[0].Cells[0].Value);
            DisplayRunners();
        }

        /// <summary>
        /// Saves the runners into a textfile and closes dialog window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Runners_Close_Click(object sender, EventArgs e)
        {
            DataHandler.SaveRunners("runners.txt");
            this.Close();
        }

        /// <summary>
        /// Opens the modify dialog, sending the selected runner as parameter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Runners_Modify_Click(object sender, EventArgs e)
        {
            ModifyRunnerView modifyRunnerView = new ModifyRunnerView(Race.Runners[(int)dataGridView_Runners.SelectedRows[0].Cells[0].Value]);
            modifyRunnerView.ShowDialog();

            DataHandler.SaveRunners("runners.txt");
            DisplayRunners();
        }

        /// <summary>
        /// Loads runners from a textfile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Runners_Load_Click(object sender, EventArgs e)
        {
            Race.Runners.Clear();
            Race.Runners = DataHandler.LoadRunners("runners.txt");

            DisplayRunners();
        }

        /// <summary>
        /// Saves runners from Dictionary into a textfile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Runners_Save_Click(object sender, EventArgs e)
        {
            DataHandler.SaveRunners("runners.txt");
        }
    }
}
