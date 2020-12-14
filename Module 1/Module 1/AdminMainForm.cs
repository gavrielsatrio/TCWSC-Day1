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
    public partial class AdminMainForm : Form
    {
        private Module1Entities db = new Module1Entities();
        public int userID = 0;
        private int selectedUserID = 0;
        private DateTime loginTime = DateTime.Now;
        private int loginID = 0;
        
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            var query = db.Offices.ToList();
            comboOffice.ValueMember = "ID";
            comboOffice.DisplayMember = "Title";
            query.Insert(0, new Office
            {
                ID = 0,
                Title = "All offices"
            });
            comboOffice.DataSource = query;

            db.UserLogins.Add(new UserLogin
            {
                UserID = userID,
                LoginTime = loginTime
            });
            db.SaveChanges();

            loginID = db.UserLogins.Max(x => x.ID);
        }

        private void LoadData()
        {
            db = new Module1Entities();
            var query = db.Users.ToList();
            if(comboOffice.Text != "All offices")
            {
                var officeID = int.Parse(comboOffice.SelectedValue.ToString());
                query = query.Where(x => x.OfficeID == officeID).ToList();
            }

            dgv.DataSource = query.Select(x => new
            {
                x.ID,
                Name = x.FirstName,
                x.LastName,
                Age = DateTime.Now.Year - x.Birthdate.Value.Year,
                UserRole = x.Role.Title,
                EmailAddress = x.Email,
                Office = x.Office.Title,
                Color = x.Active == true ? (x.RoleID == 1 ? "Green" : "White")  : "Red"
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
                else if(dgv["Color", i].Value.ToString() == "Green")
                {
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }

        private void comboOffice_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnChangeRole_Click(object sender, EventArgs e)
        {
            if(selectedUserID != 0)
            {
                var edit = new EditRoleForm();
                edit.userID = selectedUserID;
                edit.ShowDialog();

                LoadData();
                selectedUserID = 0;
                dgv.CurrentCell.Selected = false;
                btnEnableDisableLogin.Text = "Enable/Disable Login";
            }
            else
            {
                MessageBox.Show("Please select a user first ...");
            }
        }

        private void btnEnableDisableLogin_Click(object sender, EventArgs e)
        {
            if(selectedUserID != 0)
            {
                var query = db.Users.Find(selectedUserID);
                if (query.Active == true)
                {
                    query.Active = false;
                }
                else
                {
                    query.Active = true;
                }

                db.SaveChanges();
                LoadData();
                selectedUserID = 0;
                dgv.CurrentCell.Selected = false;
                btnEnableDisableLogin.Text = "Enable/Disable Login";
            }
            else
            {
                MessageBox.Show("Please select a user first ...");
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgv.CurrentRow.Cells;
            selectedUserID = int.Parse(row["ID"].Value.ToString());

            var query = db.Users.Find(selectedUserID);
            if(query.Active == true)
            {
                btnEnableDisableLogin.Text = "Suspend Account";
            }
            else
            {
                btnEnableDisableLogin.Text = "Unsuspend Account";
            }
        }

        private void AdminMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var query = db.UserLogins.Find(loginID);
            query.LogoutTime = DateTime.Now;
            db.SaveChanges();

            Application.Exit();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var add = new AddUserForm();
            add.ShowDialog();

            LoadData();
        }
    }
}
