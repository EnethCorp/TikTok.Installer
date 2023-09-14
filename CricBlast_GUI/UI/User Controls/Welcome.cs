using CricBlast_GUI.Database;
using CricBlast_GUI.UI.Admin_Controls;
using System;
using System.Threading;
using System.Windows.Forms;

namespace CricBlast_GUI.UI.User_Controls
{
    public partial class Welcome : UserControl
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private bool _admin;

        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, System.EventArgs e)
        {
            usernameTextBox.Text = Selected.UserDetails[2];
            passwordTextBox.Text = Selected.UserDetails[3];
        }

        private void refreshPicture_Click(object sender, System.EventArgs e)
        {
            switch (_admin)
            {
                case true:
                    loginAsPicture.Image = Properties.Resources.Unknown_User;
                    _admin = false;
                    logo.Image = Properties.Resources.Logo;
                    usernameLabel.Text = "USERNAME OR EMAIL";
                    usernameTextBox.Text = "";
                    passwordTextBox.Text = "";
                    createAccountLabel.Visible = true;
                    label5.Visible = true;
                    usernameTextBox.Focus();
                    return;
                case false:
                    loginAsPicture.Image = Properties.Resources.Admin_Colored;
                    _admin = true;
                    logo.Image = Properties.Resources.Admin_Logo;
                    usernameLabel.Text = "ADMIN NAME OR EMAIL";
                    usernameTextBox.Text = "";
                    passwordTextBox.Text = "";
                    createAccountLabel.Visible = false;
                    label5.Visible = false;
                    usernameTextBox.Focus();
                    break;
            }
        }

        private void login_Click(object sender, System.EventArgs e)
        {
            usernameRequired.Visible = string.IsNullOrWhiteSpace(usernameTextBox.Text);
            passwordRequired.Visible = string.IsNullOrWhiteSpace(passwordTextBox.Text);

            if (!usernameRequired.Visible && !passwordRequired.Visible)
                switch (_admin)
                {
                    case true when usernameTextBox.Text.ToLower() == "admin" && passwordTextBox.Text.ToLower() == "admin":
                        Controls.Clear();

                        var threadParameters = new ThreadStart(() =>
                        {
                            Invoke((Action)(() =>
                            {
                                new MessageBoxOk(Selected.CheckMark, "You have successfully logged in.").Show();
                                Controls.Add(new AdminPanel());
                            }));
                        });

                        var thread = new Thread(threadParameters);
                        thread.Start();
                        return;
                    case false when Login.Verify(usernameTextBox.Text, passwordTextBox.Text):
                        Controls.Clear();

                        var threadParameters1 = new ThreadStart(() =>
                        {
                            Invoke((Action)(() =>
                            {
                                new MessageBoxOk(Selected.CheckMark, "You have successfully logged in.").ShowDialog();
                                Controls.Add(new Home());
                            }));
                        });

                        var thread1 = new Thread(threadParameters1);
                        thread1.Start();
                        return;
                    default:
                        new MessageBoxOk(Selected.ErrorMark, "Bad credentials. Please login again.").ShowDialog();
                        break;
                }
            else
                new MessageBoxOk(Selected.WarningMark, "Please fill out all the fields properly.").ShowDialog();
        }

        private void forgotPassword_Click(object sender, System.EventArgs e)
        {
            switch (_admin)
            {
                case true:
                    usernameTextBox.Text = "admin";
                    passwordTextBox.Text = "admin";
                    return;
                default:
                    new Recover().ShowDialog();
                    usernameTextBox.Text = Selected.UserDetails[2];
                    passwordTextBox.Text = Selected.UserDetails[3];
                    break;
            }
        }

        private void createAccountLabel_Click(object sender, System.EventArgs e)
        {
            Controls.Clear();
            Controls.Add(value: new CreateAccount());
        }

        private void usernameTextBox_TextChanged(object sender, System.EventArgs e)
        {
            usernameRequired.Visible = false;
        }

        private void passwordTextBox_TextChanged(object sender, System.EventArgs e)
        {
            passwordRequired.Visible = false;
        }

        private void usernameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) login.PerformClick();
            else if (e.KeyCode == Keys.Delete) passwordTextBox.Text.Remove(passwordTextBox.Text[passwordTextBox.Text.Length-1]);
            else passwordTextBox.Text = usernameTextBox.Text;
        }

        private void usernameTextBox_Load(object sender, EventArgs e)
        {
            usernameTextBox.Focus();
        }
    }
}