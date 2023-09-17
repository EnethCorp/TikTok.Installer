
using System.Drawing;

namespace CricBlast_GUI.UI.User_Controls
{
    partial class Welcome
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.login = new Guna.UI2.WinForms.Guna2Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.forgotPassword = new System.Windows.Forms.Label();
            this.createAccountLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.usernameRequired = new System.Windows.Forms.Label();
            this.passwordRequired = new System.Windows.Forms.Label();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.loginAsPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginAsPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.BorderRadius = 4;
            this.login.CheckedState.Parent = this.login;
            this.login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login.CustomImages.Parent = this.login;
            this.login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.login.DisabledState.Parent = this.login;
            this.login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(161)))), ((int)(((byte)(47)))));
            this.login.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.HoverState.Parent = this.login;
            this.login.Location = new System.Drawing.Point(736, 476);
            this.login.Name = "login";
            this.login.ShadowDecoration.Parent = this.login;
            this.login.Size = new System.Drawing.Size(409, 45);
            this.login.TabIndex = 3;
            this.login.Text = "Login";
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold);
            this.welcomeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.welcomeLabel.Location = new System.Drawing.Point(730, 158);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(420, 65);
            this.welcomeLabel.TabIndex = 19;
            this.welcomeLabel.Text = "Welcome!";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.usernameLabel.Location = new System.Drawing.Point(731, 248);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(87, 25);
            this.usernameLabel.TabIndex = 18;
            this.usernameLabel.Text = "User Key";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Enabled = true;
            this.usernameTextBox.Animated = true;
            this.usernameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.usernameTextBox.BorderRadius = 3;
            this.usernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTextBox.DisabledState.Parent = this.usernameTextBox;
            this.usernameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTextBox.FocusedState.Parent = this.usernameTextBox;
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.usernameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.usernameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTextBox.HoverState.Parent = this.usernameTextBox;
            this.usernameTextBox.Location = new System.Drawing.Point(736, 278);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PlaceholderText = "Please enter your key...";
            this.usernameTextBox.SelectedText = "";
            this.usernameTextBox.SelectionStart = 6;
            this.usernameTextBox.ShadowDecoration.Parent = this.usernameTextBox;
            this.usernameTextBox.Size = new System.Drawing.Size(409, 47);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            this.usernameTextBox.Load += new System.EventHandler(this.usernameTextBox_Load);
            this.usernameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usernameTextBox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(731, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "TikTok Username";
            // 
            // forgotPassword
            // 
            this.forgotPassword.Location = new System.Drawing.Point(0, 0);
            this.forgotPassword.Name = "forgotPassword";
            this.forgotPassword.Size = new System.Drawing.Size(100, 23);
            this.forgotPassword.TabIndex = 33;
            // 
            // createAccountLabel
            // 
            this.createAccountLabel.Location = new System.Drawing.Point(0, 0);
            this.createAccountLabel.Name = "createAccountLabel";
            this.createAccountLabel.Size = new System.Drawing.Size(100, 23);
            this.createAccountLabel.TabIndex = 32;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.White;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.passwordTextBox.Location = new System.Drawing.Point(736, 379);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(409, 47);
            this.passwordTextBox.TabIndex = 31;
            this.passwordTextBox.Text = "Enter your username...";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 29;
            // 
            // usernameRequired
            // 
            this.usernameRequired.AutoSize = true;
            this.usernameRequired.BackColor = System.Drawing.Color.Transparent;
            this.usernameRequired.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameRequired.ForeColor = System.Drawing.Color.Red;
            this.usernameRequired.Location = new System.Drawing.Point(810, 248);
            this.usernameRequired.Name = "usernameRequired";
            this.usernameRequired.Size = new System.Drawing.Size(97, 25);
            this.usernameRequired.TabIndex = 28;
            this.usernameRequired.Text = "- required";
            this.usernameRequired.Visible = false;
            // 
            // passwordRequired
            // 
            this.passwordRequired.Location = new System.Drawing.Point(0, 0);
            this.passwordRequired.Name = "passwordRequired";
            this.passwordRequired.Size = new System.Drawing.Size(100, 23);
            this.passwordRequired.TabIndex = 0;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.FillColor = System.Drawing.Color.Black;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(639, 85);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.ShadowDecoration.Parent = this.guna2PictureBox3;
            this.guna2PictureBox3.Size = new System.Drawing.Size(2, 551);
            this.guna2PictureBox3.TabIndex = 23;
            this.guna2PictureBox3.TabStop = false;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = global::CricBlast_GUI.Properties.Resources.Logo;
            this.logo.Location = new System.Drawing.Point(118, 159);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(446, 402);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 12;
            this.logo.TabStop = false;
            // 
            // DragControl
            // 
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.TargetControl = this;
            this.DragControl.TransparentWhileDrag = false;
            // 
            // loginAsPicture
            // 
            this.loginAsPicture.BackColor = System.Drawing.Color.Transparent;
            this.loginAsPicture.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.loginAsPicture.Image = global::CricBlast_GUI.Properties.Resources.discord;
            this.loginAsPicture.ImageRotate = 0F;
            this.loginAsPicture.Location = new System.Drawing.Point(1105, 226);
            this.loginAsPicture.Name = "loginAsPicture";
            this.loginAsPicture.ShadowDecoration.Parent = this.loginAsPicture;
            this.loginAsPicture.Size = new System.Drawing.Size(40, 48);
            this.loginAsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginAsPicture.TabIndex = 25;
            this.loginAsPicture.TabStop = false;
            this.loginAsPicture.Click += new System.EventHandler(this.loginAsPicture_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.BackgroundImage = global::CricBlast_GUI.Properties.Resources.Background;
            this.Controls.Add(this.passwordRequired);
            this.Controls.Add(this.usernameRequired);
            this.Controls.Add(this.loginAsPicture);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2PictureBox3);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.createAccountLabel);
            this.Controls.Add(this.forgotPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.login);
            this.Controls.Add(this.logo);
            this.DoubleBuffered = true;
            this.Name = "Welcome";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.Welcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginAsPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button login;
        private System.Windows.Forms.Label usernameLabel;
        private Guna.UI2.WinForms.Guna2TextBox usernameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label forgotPassword;
        private System.Windows.Forms.Label createAccountLabel;
        private System.Windows.Forms.Label passwordTextBox;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label usernameRequired;
        private System.Windows.Forms.Label passwordRequired;
        public System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.PictureBox logo;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2PictureBox loginAsPicture;
    }
}
