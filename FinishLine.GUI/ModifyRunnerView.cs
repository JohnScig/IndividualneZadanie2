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
    public partial class ModifyRunnerView : Form
    {
        /// <summary>
        /// Default form constructor. Is not used by this program.
        /// </summary>
        public ModifyRunnerView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Modified form constructor. Takes Runner as parameter and loads its data into the various form elements.
        /// </summary>
        public ModifyRunnerView(Runner r)
        {
            InitializeComponent();
            LoadComboBox();
            runnerToChange = r;
            LoadRunnerData(r);
            DialogResult = DialogResult.Cancel;
        }

        private Runner runnerToChange = new Runner();

        /// <summary>
        /// Loads Runner's data into various elements of the form.
        /// </summary>
        /// <param name="r"></param>
        public void LoadRunnerData(Runner r)
        {
            tBox_Name.Text = r.Name;
            numeric_Age.Value = r.Age;
            numeric_ID.Value = r.ID;

            if (r.Gender == "Female")
            {
                rBtn_Female.Checked = true;
            }
            if (r.Gender == "Other")
            {
                rBtn_Other.Checked = true;
            }
            cBox_Country.SelectedValue = r.Country;
        }

        /// <summary>
        /// Loads the ComboBox with list of countries.
        /// </summary>
        public void LoadComboBox()
        {
            cBox_Country.DataSource = DataHandler.LoadCountries(@"..\..\..\Data\countries.csv");
            cBox_Country.DisplayMember = nameof(Country.Name);
            cBox_Country.ValueMember = nameof(Country.Code).ToString();
        }

        /// <summary>
        /// Sets the correct radio button based on the runner's gender.
        /// </summary>
        /// <returns></returns>
        public string GetGender()
        {
            if (rBtn_Female.Checked)
            {
                return "Female";
            }
            if (rBtn_Male.Checked)
            {
                return "Male";
            }

            return "Other";
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// On OK click on the Edit window, the specified runner is deleted and the edited version is added into the dictionary.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OK_Click(object sender, EventArgs e)
        {
            Race.Runners.Remove(runnerToChange.ID);
            Race.Runners.Add(
            key: (int)numeric_ID.Value,
            value: new Runner()
            {
                ID = (int)numeric_ID.Value,
                Name = tBox_Name.Text,
                Country = cBox_Country.SelectedValue.ToString(),
                Age = (int)numeric_Age.Value,
                Gender = GetGender()
            });
            DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// If the user changes the value of ID in the numericUpDown element, function is called to check that ID against the list of Runners' IDs.
        /// If that ID is found, a random ID is generated until a unique one is found. That unique ID is then set as the new ID of the edited Racer.
        /// The function warns user that the ID was changed automatically
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numeric_ID_ValueChanged(object sender, EventArgs e)
        {
            int correctID = (int)numeric_ID.Value;

            while (!Race.CheckID(correctID))
            {
                if (correctID == runnerToChange.ID)
                { break; }
                else
                {
                    correctID = Race.GetRandomID();
                }
            }
            if (correctID != (int)numeric_ID.Value)
            {
                MessageBox.Show("ID already in use, assigned next available number.");
            }
            numeric_ID.Value = correctID;
        }

    }
}
