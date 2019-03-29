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

        Runner runnerToChange = new Runner();

        private void LoadRunnerData(Runner r)
        {
            tBox_Name.Text = r.Name;
            tBox_Age.Text = r.Age.ToString();
            tBox_ID.Text = r.ID.ToString();

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


        private void tBox_ID_Leave(object sender, EventArgs e)
        {
            int correctID;
            if (int.TryParse(tBox_ID.Text, out correctID))
            {
                while (!Race.CheckID(correctID))
                {
                    MessageBox.Show("ID already in use, checking next number");
                    Race.CheckID(++correctID);
                }
                tBox_ID.Text = correctID.ToString();
            }
            else
            {
                MessageBox.Show("Wrong input. Set to empty");
                tBox_ID.Text = string.Empty;
            }

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

        private void tBox_Age_Leave(object sender, EventArgs e)
        {
            int correctAge;
            if (int.TryParse(tBox_Age.Text, out correctAge))
            {
                if (correctAge < 120 && correctAge > 12)
                {
                    tBox_Age.Text = correctAge.ToString();
                }
                else
                {
                    MessageBox.Show("Wrong input. Set to 35");
                    tBox_Age.Text = "35";
                }
            }
            else
            {
                MessageBox.Show("Wrong input. Set to 35");
                tBox_Age.Text = "35";
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {

            Race.Runners.Remove(runnerToChange.ID);
            Race.Runners.Add(
            key: int.Parse(tBox_ID.Text),
            value: new Runner()
                    {
                    ID = int.Parse(tBox_ID.Text),
                    Name = tBox_Name.Text,
                    Country = cBox_Country.SelectedValue.ToString(),
                    Age = int.Parse(tBox_Age.Text),
                    Gender = GetGender()
                     });
            this.Close();
        }
    }
}
