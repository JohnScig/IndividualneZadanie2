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
    public partial class AddRunner : Form
    {
        public AddRunner()
        {
            InitializeComponent();
            LoadComboBox();
        }

        public void LoadComboBox()
        {
            cBox_Country.DataSource = DataHandler.LoadCountries(@"C:\Users\transformer10\source\repos\IndividualneZadanie2\Data\countries.csv");
            cBox_Country.DisplayMember = nameof(Country.Name);
            cBox_Country.ValueMember = nameof(Country.Code);
        }
    }
}
