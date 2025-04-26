using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectShadow.Core;

namespace ProjectShadow.Forms
{
    public partial class LoginForm : UserControl
    {
        private Timer clockTimer;

        public LoginForm()
        {
            InitializeComponent();
            InitializeClock();
            Design.InitializeAnimations(this, welcomePanel, dataPanel, 2500);
        }

        private void InitializeClock()
        {
            clockTimer = new Timer();
            clockTimer.Interval = 1000;
            clockTimer.Tick += ClockTimer_Tick;
            clockTimer.Start();

            clockLine.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            clockLine.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text == string.Empty && passwordBox.Text == string.Empty)
            {
                statusLabel.ForeColor = Color.Orange;
                statusLabel.Text = "Insert Credentials";
            }
            else
            {
                usernameBox.ReadOnly = true;
                passwordBox.ReadOnly = true;
                loginBtn.Enabled = false;
                exitBtn.Enabled = false;
                statusLabel.ForeColor = Color.White;
                statusLabel.Text = "Logging in...";
                UserData userData = new UserData
                {
                    Username = usernameBox.Text,
                    Password = passwordBox.Text
                };
                Task.Delay(2000).ContinueWith(t =>
                {
                    // Simulate login process
                    if (usernameBox.Text == "admin" && passwordBox.Text == "password")
                    {
                        statusLabel.ForeColor = Color.Green;
                        statusLabel.Text = "Login Successful";
                        Task.Delay(2000).ContinueWith(t2 =>
                        {
                            // Proceed to the next form or action
                            this.Invoke(new Action(() =>
                            {
                                Design.AnimatePopout(dataPanel, 10, 15);
                            }));
                        });
                    }
                    else
                    {
                        statusLabel.ForeColor = Color.Red;
                        statusLabel.Text = "Invalid Credentials";
                        usernameBox.ReadOnly = false;
                        passwordBox.ReadOnly = false;
                        loginBtn.Enabled = true;
                        exitBtn.Enabled = true;
                    }
                });
            }
        }
    }
}
