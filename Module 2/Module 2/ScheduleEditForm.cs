using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_2
{
    public partial class ScheduleEditForm : Form
    {
        private Module2Entities db = new Module2Entities();
        public int scheduleID = 0;

        public ScheduleEditForm()
        {
            InitializeComponent();
        }

        private void ScheduleEditForm_Load(object sender, EventArgs e)
        {
            var query = db.Schedules.Find(scheduleID);
            txtFrom.Text = query.Route.Airport.IATACode;
            txtTo.Text = query.Route.Airport1.IATACode;
            txtAircraft.Text = query.Aircraft.Name;

            dtpDate.Value = query.Date.Date;
            txtTime.Text = query.Time.ToString(@"hh\:mm");
            txtEconomyPrice.Text = Math.Round(query.EconomyPrice, 0).ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var query = db.Schedules.Find(scheduleID);
                query.Date = dtpDate.Value.Date;
                query.Time = TimeSpan.Parse(txtTime.Text + ":00");
                query.EconomyPrice = int.Parse(txtEconomyPrice.Text);
                db.SaveChanges();

                this.Close();
            }
            catch
            {
                MessageBox.Show("Wrong format ...");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ScheduleEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
