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
        public ModifyRunnerView()
        {
            InitializeComponent();
        }

        public ModifyRunnerView(Runner r)
        {
            InitializeComponent();
            LoadComboBox();
            runnerToChange = r;
            LoadRunnerData(r);

        }

        private Runner runnerToChange = new Runner();

        private void LoadRunnerData(Runner r)
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

        public void LoadComboBox()
        {
            cBox_Country.DataSource = DataHandler.LoadCountries(@"C:\Users\transformer10\source\repos\IndividualneZadanie2\Data\countries.csv");
            cBox_Country.DisplayMember = nameof(Country.Name);
            cBox_Country.ValueMember = nameof(Country.Code).ToString();
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
            this.Close();
        }

        private void GetSomeID()
        {
            int someID = 1;
            while (!Race.CheckID(someID))
            {
                //MessageBox.Show("ID already in use, checking next number");
                Race.CheckID(++someID);
            }
            numeric_ID.Value = someID;
        }

        private void numeric_ID_ValueChanged(object sender, EventArgs e)
        {

            int correctID = (int)numeric_ID.Value;

            while (!Race.CheckID(correctID))
            {
                if (correctID == runnerToChange.ID)
                { break; }
                else
                {
                    correctID++;
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
