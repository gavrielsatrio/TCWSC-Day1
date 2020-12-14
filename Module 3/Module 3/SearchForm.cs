using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_3
{
    public partial class SearchForm : Form
    {
        private Module3Entities db = new Module3Entities();

        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            LoadComboFrom();
            LoadComboTo();
            LoadCabinType();

            radioReturn.Checked = true;
        }

        private void LoadComboFrom()
        {
            var query = db.Airports.ToList();
            comboFrom.ValueMember = "ID";
            comboFrom.DisplayMember = "IATACode";
            comboFrom.DataSource = query;
        }

        private void LoadComboTo()
        {
            var query = db.Airports.ToList();
            comboTo.ValueMember = "ID";
            comboTo.DisplayMember = "IATACode";
            comboTo.DataSource = query;
        }

        private void LoadCabinType()
        {
            var query = db.CabinTypes.ToList();
            comboCabinType.ValueMember = "ID";
            comboCabinType.DisplayMember = "Name";
            comboCabinType.DataSource = query;
        }

        private void SearchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
