using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace Module_1
{
    public partial class LoginForm : Form
    {
        private Module1Entities db = new Module1Entities();
        private int wrongLoginCount = 0;
        private int loginCountdown = 10;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            lblTimer.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text != "" && txtPassword.Text != "")
            {
                var cekPassword = db.Users.Where(x => x.Email == txtUsername.Text).ToList();
                if (cekPassword.Count > 0)
                {
                    var md5 = new MD5CryptoServiceProvider();
                    var bytes = md5.ComputeHash(new UTF8Encoding().GetBytes(txtPassword.Text));
                    var hashedPassword = "";
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        hashedPassword += bytes[i].ToString("x2");
                    }

                    if (hashedPassword == cekPassword[0].Password)
                    {
                        if (cekPassword[0].Active == true)
                        {
                            var userID = cekPassword[0].ID;
                            var cekLastLogin = db.UserLogins.Where(x => x.UserID == userID).OrderByDescending(x => x.LoginTime).ToList();

                            if(cekLastLogin.Count() > 0)
                            {
                                if (cekLastLogin[0].LogoutTime == null)
                                {
                                    this.Hide();
                                    var crash = new CrashForm();
                                    crash.loginID = cekLastLogin[0].ID;
                                    crash.userID = userID;

                                    crash.Show();
                                }
                                else
                                {
                                    if (cekPassword[0].RoleID == 1)
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
                            }
                            else
                            {
                                if (cekPassword[0].RoleID == 1)
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
                        }
                        else
                        {
                            MessageBox.Show("Sorry, you are disabled to login ...");
                        }
                    }
                    else
                    {
                        wrongLoginCount++;

                        if(wrongLoginCount > 3)
                        {
                            MessageBox.Show("You have entered wrong login credentials for more than 3 times\nWait for the countdown to try logging in again ...");
                            lblTimer.Visible = true;
                            lblTimer.Text = "Login Countdown : " + loginCountdown;
                            timer.Start();
                        }
                        else
                        {
                            MessageBox.Show("Username or password is wrong ...");
                        }
                    }
                }
                else
                {
                    wrongLoginCount++;

                    if (wrongLoginCount > 3)
                    {
                        MessageBox.Show("You have entered wrong login credentials for more than 3 times\nWait for the countdown to try logging in again ...");
                        lblTimer.Visible = true;
                        lblTimer.Text = "Login Countdown : " + loginCountdown;
                        timer.Start();
                    }
                    else
                    {
                        MessageBox.Show("Username or password is wrong ...");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill up all fields ...");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(loginCountdown == 0)
            {
                loginCountdown = 10;
                lblTimer.Visible = false;
                timer.Stop();
            }

            loginCountdown--;
            lblTimer.Text = "Login Countdown : " + loginCountdown;
        }
    }
}
