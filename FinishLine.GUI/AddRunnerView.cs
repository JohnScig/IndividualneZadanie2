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
    public partial class AddRunnerView : Form
    {
        /// <summary>
        /// Default constructor. ComboBox is pre-loaded with a list of countries and the numeric value is set with a unique, randomly-generated ID
        /// </summary>
        public AddRunnerView()
        {
            InitializeComponent();
            LoadComboBox();
            numeric_ID.Value = Race.GetRandomID();
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Loads the ComboBox with list of countries.
        /// </summary>
        public void LoadComboBox()
        {
            cBox_Country.DataSource = DataHandler.LoadCountries(@"C:\Users\transformer10\source\repos\IndividualneZadanie2\Data\countries.csv");
            cBox_Country.DisplayMember = nameof(Country.Name);
            cBox_Country.ValueMember = nameof(Country.Code).ToString();
        }

        /// <summary>
        /// New runner is added to the dictionary as specified by the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OK_Click(object sender, EventArgs e)
        {
            Race.Runners.Add
                (
                key: (int) numeric_ID.Value, 
                value: new Runner() { ID = (int)numeric_ID.Value, Name = tBox_Name.Text, Country = cBox_Country.SelectedValue.ToString(),
                    Age = (int)numeric_Age.Value, Gender = GetGender() }
                );
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private string GetGender()
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
        /// Checks if the numeric value in NumericUpDown is a unique ID. If it is not, the method gets automatically finds a random unique ID to use.
        /// User is warned about the change.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numeric_ID_ValueChanged(object sender, EventArgs e)
        {
            int correctID = (int)numeric_ID.Value;

            while (!Race.CheckID(correctID))
            {
                correctID=Race.GetRandomID();
            }
            if (correctID != (int)numeric_ID.Value)
            {
                MessageBox.Show("ID already in use, assigned next available number.");
            }
            numeric_ID.Value = correctID;
        }
    }
}
