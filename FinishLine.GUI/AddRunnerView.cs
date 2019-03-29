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
        public AddRunnerView()
        {
            InitializeComponent();
            LoadComboBox();
            GetSomeID();

        }

        public void LoadComboBox()
        {
            cBox_Country.DataSource = DataHandler.LoadCountries(@"C:\Users\transformer10\source\repos\IndividualneZadanie2\Data\countries.csv");
            cBox_Country.DisplayMember = nameof(Country.Name);
            cBox_Country.ValueMember = nameof(Country.Code).ToString();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            //Race.Runners.Add(new Runner() {ID= int.Parse(tBox_ID.Text),Name = tBox_Name.Text,Country = cBox_Country.SelectedValue.ToString(),Age = int.Parse(tBox_Age.Text),Gender = GetGender() });
            Race.Runners.Add
                (
                key: int.Parse(tBox_ID.Text), 
                value: new Runner() { ID = int.Parse(tBox_ID.Text), Name = tBox_Name.Text, Country = cBox_Country.SelectedValue.ToString(),
                    Age = int.Parse(tBox_Age.Text), Gender = GetGender() }
                );
            this.Close();
        }

        private void GetSomeID()
        {
            int someID=1;
            while (!Race.CheckID(someID))
            {
                //MessageBox.Show("ID already in use, checking next number");
                Race.CheckID(++someID);
            }
            tBox_ID.Text = someID.ToString();
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
                GetSomeID();
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
    }
}
