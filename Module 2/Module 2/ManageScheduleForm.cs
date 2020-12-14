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
    public partial class ManageScheduleForm : Form
    {
        private Module2Entities db = new Module2Entities();
        private int selectedScheduleID = 0;

        public ManageScheduleForm()
        {
            InitializeComponent();
        }

        private void ManageScheduleForm_Load(object sender, EventArgs e)
        {
            LoadComboFrom();
            LoadComboTo();

            comboSort.Items.Add("Date-Time");
            comboSort.Items.Add("Economy Price");
            comboSort.Items.Add("Confirmed");

            comboSort.Text = comboSort.Items[0].ToString();

            btnApply.PerformClick();
        }

        private void LoadComboFrom()
        {
            var query = db.Airports.ToList();
            query.Insert(0, new Airport
            {
                ID = 0,
                IATACode = "All Airports"
            });
            comboFrom.ValueMember = "ID";
            comboFrom.DisplayMember = "IATACode";
            comboFrom.DataSource = query;
        }

        private void LoadComboTo()
        {
            var query = db.Airports.ToList();
            query.Insert(0, new Airport
            {
                ID = 0,
                IATACode = "All Airports"
            });
            comboTo.ValueMember = "ID";
            comboTo.DisplayMember = "IATACode";
            comboTo.DataSource = query;
        }

        private void LoadData()
        {
            db = new Module2Entities();
            var query = db.Schedules.ToList();

            if(comboFrom.SelectedValue.ToString() != "0")
            {
                query = query.Where(x => x.Route.Airport.IATACode == comboFrom.Text).ToList();
            }

            if(comboTo.SelectedValue.ToString() != "0")
            {
                query = query.Where(x => x.Route.Airport1.IATACode == comboTo.Text).ToList();
            }

            if(dtpOutbound.Checked == true)
            {
                query = query.Where(x => x.Date == dtpOutbound.Value.Date).ToList();
            }

            if(txtFlightNumber.Text != "")
            {
                query = query.Where(x => x.FlightNumber == txtFlightNumber.Text).ToList();
            }

            if(comboSort.Text == "Date-Time")
            {
                query = query.OrderByDescending(x => x.Date).ToList();
            }
            else if(comboSort.Text == "Economy Price")
            {
                query = query.OrderByDescending(x => x.EconomyPrice).ToList();
            }
            else
            {
                query = query.OrderByDescending(x => x.Confirmed).ToList();
            }

            dgv.DataSource = query.ToList().Select(x => new
            {
                x.ID,
                x.Date,
                Time = x.Time.ToString(@"hh\:mm"),
                From = x.Route.Airport.IATACode,
                To = x.Route.Airport1.IATACode,
                x.FlightNumber,
                Aircraft = x.Aircraft.Name,
                EconomyPrice = "$" + Math.Round(x.EconomyPrice, 0),
                BusinessPrice = "$" + (Math.Round(x.EconomyPrice, 0) + Math.Round(x.EconomyPrice * 0.35m, 0)),
                FirstClassPrice = "$" + (Math.Round(x.EconomyPrice, 0) + Math.Round(x.EconomyPrice * 0.35m, 0) + Math.Round((x.EconomyPrice + Math.Round(x.EconomyPrice * 0.35m)) * 0.3m, 0)),
                Color = x.Confirmed == true ? "White" : "Red"
            }).ToList();

            dgv.Columns["ID"].Visible = false;
            dgv.Columns["Color"].Visible = false;

            for (int i = 0; i < dgv.RowCount; i++)
            {
                if(dgv["Color", i].Value.ToString() == "Red")
                {
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dgv.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        private void ManageScheduleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(selectedScheduleID != 0)
            {
                var query = db.Schedules.Find(selectedScheduleID);
                if(query.Confirmed == false)
                {
                    query.Confirmed = true;
                }
                else
                {
                    query.Confirmed = false;
                }
                db.SaveChanges();

                LoadData();
                selectedScheduleID = 0;
                btnCancel.Text = "Confirm/Cancel Flight";
            }
            else
            {
                MessageBox.Show("Select a schedule first ...");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(selectedScheduleID != 0)
            {
                var edit = new ScheduleEditForm();
                edit.scheduleID = selectedScheduleID;
                edit.ShowDialog();

                LoadData();
            }
            else
            {
                MessageBox.Show("Select a schedule first ...");
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            new ApplyScheduleForm().ShowDialog();
            LoadData();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgv.CurrentRow.Cells;
            selectedScheduleID = int.Parse(row["ID"].Value.ToString());

            if(row["Color"].Value.ToString() == "Red")
            {
                btnCancel.Text = "Confirm Flight";
            }
            else
            {
                btnCancel.Text = "Cancel Flight";
            }
        }
    }
}
