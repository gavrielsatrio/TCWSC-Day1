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
    public partial class CrashForm : Form
    {
        private Module1Entities db = new Module1Entities();
        public int loginID = 0;
        public int userID = 0;

        public CrashForm()
        {
            InitializeComponent();
        }

        private void CrashForm_Load(object sender, EventArgs e)
        {
            var query = db.UserLogins.Find(loginID);
            lblHeader.Text = "No logout detected for your last login on " + query.LoginTime.Date.ToString("MM/dd/yyyy") + " at " + query.LoginTime.Hour.ToString().PadLeft(2, '0') + ":" + query.LoginTime.Minute.ToString().PadLeft(2, '0');
            radioSoftware.Checked = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(txtReason.Text != "")
            {
                var crashType = "Software";
                if (radioSystem.Checked == true)
                {
                    crashType = "System";
                }

                var query = db.UserLogins.Find(loginID);
                query.Reason = txtReason.Text;
                query.CrashType = crashType;

                db.SaveChanges();

                if (db.Users.Where(x => x.ID == userID).Select(x => x.RoleID).ToArray()[0] == 1)
                {
                    this.Hide();
                    var mainForm = new AdminMainForm();
                    mainForm.userID = userID;
                    mainForm.Show();
                }
                else
                {
                    this.Hide();
                    var mainForm = new UserMainForm();
                    mainForm.userID = userID;
                    mainForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Please fill up all fields ...");
            }
        }

        private void CrashForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
