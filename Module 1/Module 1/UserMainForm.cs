using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_1
{
    public partial class UserMainForm : Form
    {
        private Module1Entities db = new Module1Entities();
        public int userID = 0;
        private TimeSpan timeSpentShow = new TimeSpan(0, 0, 0);
        private DateTime loginTime = DateTime.Now;
        private int loginID = 0;

        public UserMainForm()
        {
            InitializeComponent();
        }

        private void UserMainForm_Load(object sender, EventArgs e)
        {
            var name = db.Users.Where(x => x.ID == userID).Select(x => x.FirstName).ToList()[0];
            lblHi.Text = "Hi " + name + ", Welcome to AMONIC Airlines.";

            var query = db.UserLogins.ToList().Where(x => x.UserID == userID).Select(x => new
            {
                Date = x.LoginTime.Date.ToString("MM/dd/yyyy"),
                LoginTime = x.LoginTime.ToString("HH:mm"),
                LogoutTime = x.LogoutTime.HasValue ? x.LogoutTime.Value.ToString("HH:mm") : "**",
                TimeSpent = x.LogoutTime.HasValue ? (x.LogoutTime.Value - x.LoginTime).Hours.ToString().PadLeft(2, '0') + ":" + (x.LogoutTime.Value - x.LoginTime).Minutes.ToString().PadLeft(2, '0') : "**",
                TimeSpentFull = x.LogoutTime.HasValue ? TimeSpan.FromSeconds(Math.Round((x.LogoutTime.Value- x.LoginTime).TotalSeconds)).ToString() : "**",
                Reason = x.Reason,
                Color = x.LogoutTime.HasValue ? "White" : "Red"
            }).ToList();

            dgv.DataSource = query;

            dgv.Columns["Color"].Visible = false;
            dgv.Columns["TimeSpent"].HeaderText = "Time spent on system";
            dgv.Columns["TimeSpentFull"].Visible = false;
            dgv.Columns["Reason"].HeaderText = "Unsuccessful logout reason";
            dgv.Columns["Reason"].Width = 300;

            var numberCrash = 0;
            for (int i = 0; i < dgv.RowCount; i++)
            {
                if (dgv["Color", i].Value.ToString() == "Red")
                {
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dgv.Rows[i].DefaultCellStyle.ForeColor = Color.White;

                    numberCrash++;
                }

                if (dgv["TimeSpent", i].Value.ToString() != "**")
                {
                    var timeSpent = TimeSpan.Parse(dgv["TimeSpentFull", i].Value.ToString());
                    timeSpentShow = timeSpentShow.Add(timeSpent);
                }
            }

            lblTime.Text = "Time spent on system : " + timeSpentShow.ToString();
            lblCrash.Text = "Number of crashes : " + numberCrash;

            db.UserLogins.Add(new UserLogin
            {
                UserID = userID,
                LoginTime = loginTime
            });
            db.SaveChanges();

            loginID = db.UserLogins.Max(x => x.ID);

            timer.Start();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var query = db.UserLogins.Find(loginID);
            query.LogoutTime = DateTime.Now;
            db.SaveChanges();

            Application.Exit();
        }

        private void UserMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeSpentShow = timeSpentShow.Add(new TimeSpan(0, 0, 1));
            lblTime.Text = "Time spent on system : " + timeSpentShow.ToString();
        }
    }
}
