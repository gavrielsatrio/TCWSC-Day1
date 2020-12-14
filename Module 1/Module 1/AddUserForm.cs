using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace Module_1
{
    public partial class AddUserForm : Form
    {
        private Module1Entities db = new Module1Entities();
        
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var adaYangKosong = false;
            foreach (var control in Controls)
            {
                if(control is TextBox txt)
                {
                    if(txt.Text == "")
                    {
                        adaYangKosong = true;
                    }
                }
            }

            if(adaYangKosong == false)
            {
                if(new EmailAddressAttribute().IsValid(txtEmail.Text))
                {
                    var md5 = new MD5CryptoServiceProvider();
                    var bytes = md5.ComputeHash(new UTF8Encoding().GetBytes(txtPassword.Text));
                    var hashedPassword = "";
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        hashedPassword += bytes[i].ToString("x2");
                    }

                    db.Users.Add(new User
                    {
                        ID = db.Users.Max(x => x.ID) + 1,
                        RoleID = 2,
                        Email = txtEmail.Text,
                        Password = hashedPassword,
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        OfficeID = int.Parse(comboOffice.SelectedValue.ToString()),
                        Birthdate = dtpDate.Value.Date,
                        Active = true
                    });

                    db.SaveChanges();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Email is invalid ...");
                }
            }
            else
            {
                MessageBox.Show("Please fill up all fields ...");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            var query = db.Offices.ToList();
            comboOffice.ValueMember = "ID";
            comboOffice.DisplayMember = "Title";
            comboOffice.DataSource = query;
        }
    }
}
