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
    public partial class EditRoleForm : Form
    {
        private Module1Entities db = new Module1Entities();
        public int userID = 0;

        public EditRoleForm()
        {
            InitializeComponent();
        }

        private void EditRoleForm_Load(object sender, EventArgs e)
        {
            var query = db.Users.Where(x => x.ID == userID).ToList();
            txtEmail.Text = query[0].Email;
            txtFirstName.Text = query[0].FirstName;
            txtLastName.Text = query[0].LastName;
            comboOffice.Items.Add(query[0].Office.Title);
            comboOffice.Text = comboOffice.Items[0].ToString();

            radioUser.Checked = true;
            if(query[0].RoleID == 1)
            {
                radioAdmin.Checked = true;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            var role = 1;
            if(radioUser.Checked == true)
            {
                role = 2;
            }

            var query = db.Users.Find(userID);
            query.RoleID = role;
            db.SaveChanges();

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
