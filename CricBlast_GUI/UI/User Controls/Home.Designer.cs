
using CricBlast_GUI.Database;
using System;

namespace CricBlast_GUI.UI.User_Controls
{
    partial class Home
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
            this.homeSubPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.OnlineIcon = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.logout = new System.Windows.Forms.Label();
            this.StateLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.menuPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.updateButton = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.ConnectButton = new Guna.UI2.WinForms.Guna2Button();
            this.StartGameButton = new Guna.UI2.WinForms.Guna2Button();
            this.GoLiveButton = new Guna.UI2.WinForms.Guna2Button();
            this.cricBlastLabel = new System.Windows.Forms.Label();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.homeSubPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OnlineIcon)).BeginInit();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // homeSubPanel
            // 
            this.homeSubPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.homeSubPanel.BackgroundImage = global::CricBlast_GUI.Properties.Resources.BackgroundHome;
            this.homeSubPanel.Controls.Add(this.OnlineIcon);
            this.homeSubPanel.Controls.Add(this.logout);
            this.homeSubPanel.Controls.Add(this.StateLabel);
            this.homeSubPanel.Controls.Add(this.usernameLabel);
            this.homeSubPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeSubPanel.Location = new System.Drawing.Point(308, 0);
            this.homeSubPanel.Name = "homeSubPanel";
            this.homeSubPanel.ShadowDecoration.Parent = this.homeSubPanel;
            this.homeSubPanel.Size = new System.Drawing.Size(972, 720);
            this.homeSubPanel.TabIndex = 12;
            // 
            // OnlineIcon
            // 
            this.OnlineIcon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OnlineIcon.ImageRotate = 0F;
            this.OnlineIcon.Location = new System.Drawing.Point(45, 100);
            this.OnlineIcon.Name = "OnlineIcon";
            this.OnlineIcon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.OnlineIcon.ShadowDecoration.Parent = this.OnlineIcon;
            this.OnlineIcon.Size = new System.Drawing.Size(14, 14);
            this.OnlineIcon.TabIndex = 7;
            this.OnlineIcon.TabStop = false;
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.logout.Location = new System.Drawing.Point(819, 634);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(86, 30);
            this.logout.TabIndex = 4;
            this.logout.Text = "Logout";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.BackColor = System.Drawing.Color.Transparent;
            this.StateLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.StateLabel.Location = new System.Drawing.Point(59, 94);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(71, 25);
            this.StateLabel.TabIndex = 6;
            this.StateLabel.Text = "Offline";
            // 
            // usernameLabel
            // 
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.usernameLabel.Location = new System.Drawing.Point(39, 60);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(216, 34);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "Username";
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.Transparent;
            this.menuPanel.BackgroundImage = global::CricBlast_GUI.Properties.Resources.Home_Menu;
            this.menuPanel.Controls.Add(this.updateButton);
            this.menuPanel.Controls.Add(this.guna2Button1);
            this.menuPanel.Controls.Add(this.ConnectButton);
            this.menuPanel.Controls.Add(this.StartGameButton);
            this.menuPanel.Controls.Add(this.GoLiveButton);
            this.menuPanel.Controls.Add(this.cricBlastLabel);
            this.menuPanel.Controls.Add(this.logoPicture);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.ShadowDecoration.Parent = this.menuPanel;
            this.menuPanel.Size = new System.Drawing.Size(308, 720);
            this.menuPanel.TabIndex = 11;
            // 
            // updateButton
            // 
            this.updateButton.AutoSize = true;
            this.updateButton.BackColor = System.Drawing.Color.Transparent;
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.updateButton.Location = new System.Drawing.Point(71, 634);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(156, 30);
            this.updateButton.TabIndex = 8;
            this.updateButton.Text = "Update Game";
            this.updateButton.Click += new System.EventHandler(this.uninstallButton_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.DimGray;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageOffset = new System.Drawing.Point(3, 1);
            this.guna2Button1.Location = new System.Drawing.Point(45, 587);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(161)))), ((int)(((byte)(47)))));
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(215, 44);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "Change Game";
            this.guna2Button1.TextOffset = new System.Drawing.Point(2, 0);
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.BackColor = System.Drawing.Color.Transparent;
            this.ConnectButton.BorderRadius = 10;
            this.ConnectButton.CheckedState.Parent = this.ConnectButton;
            this.ConnectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConnectButton.CustomImages.Parent = this.ConnectButton;
            this.ConnectButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ConnectButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ConnectButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ConnectButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ConnectButton.DisabledState.Parent = this.ConnectButton;
            this.ConnectButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(161)))), ((int)(((byte)(47)))));
            this.ConnectButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.ConnectButton.ForeColor = System.Drawing.Color.White;
            this.ConnectButton.HoverState.Parent = this.ConnectButton;
            this.ConnectButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ConnectButton.ImageOffset = new System.Drawing.Point(3, 0);
            this.ConnectButton.Location = new System.Drawing.Point(45, 177);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(161)))), ((int)(((byte)(47)))));
            this.ConnectButton.ShadowDecoration.Parent = this.ConnectButton;
            this.ConnectButton.Size = new System.Drawing.Size(215, 44);
            this.ConnectButton.TabIndex = 1;
            this.ConnectButton.Text = "Connect to Live";
            this.ConnectButton.TextOffset = new System.Drawing.Point(2, 0);
            this.ConnectButton.Click += new System.EventHandler(this.Connect_Click);
            // 
            // StartGameButton
            // 
            this.StartGameButton.BackColor = System.Drawing.Color.Transparent;
            this.StartGameButton.BorderRadius = 10;
            this.StartGameButton.CheckedState.Parent = this.StartGameButton;
            this.StartGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartGameButton.CustomImages.Parent = this.StartGameButton;
            this.StartGameButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StartGameButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StartGameButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StartGameButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StartGameButton.DisabledState.Parent = this.StartGameButton;
            this.StartGameButton.FillColor = System.Drawing.Color.Green;
            this.StartGameButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.StartGameButton.ForeColor = System.Drawing.Color.White;
            this.StartGameButton.HoverState.Parent = this.StartGameButton;
            this.StartGameButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.StartGameButton.ImageOffset = new System.Drawing.Point(3, 1);
            this.StartGameButton.Location = new System.Drawing.Point(45, 227);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(161)))), ((int)(((byte)(47)))));
            this.StartGameButton.ShadowDecoration.Parent = this.StartGameButton;
            this.StartGameButton.Size = new System.Drawing.Size(215, 44);
            this.StartGameButton.TabIndex = 1;
            this.StartGameButton.Text = "Start Game";
            this.StartGameButton.TextOffset = new System.Drawing.Point(2, 0);
            this.StartGameButton.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // GoLiveButton
            // 
            this.GoLiveButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GoLiveButton.BackColor = System.Drawing.Color.Transparent;
            this.GoLiveButton.BorderRadius = 10;
            this.GoLiveButton.CheckedState.Parent = this.GoLiveButton;
            this.GoLiveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoLiveButton.CustomImages.Parent = this.GoLiveButton;
            this.GoLiveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GoLiveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GoLiveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GoLiveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GoLiveButton.DisabledState.Parent = this.GoLiveButton;
            this.GoLiveButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(161)))), ((int)(((byte)(47)))));
            this.GoLiveButton.FocusedColor = System.Drawing.Color.Transparent;
            this.GoLiveButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.GoLiveButton.ForeColor = System.Drawing.Color.White;
            this.GoLiveButton.HoverState.Parent = this.GoLiveButton;
            this.GoLiveButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GoLiveButton.ImageOffset = new System.Drawing.Point(3, 1);
            this.GoLiveButton.Location = new System.Drawing.Point(45, 126);
            this.GoLiveButton.Name = "GoLiveButton";
            this.GoLiveButton.PressedColor = System.Drawing.Color.Transparent;
            this.GoLiveButton.PressedDepth = 0;
            this.GoLiveButton.ShadowDecoration.Parent = this.GoLiveButton;
            this.GoLiveButton.Size = new System.Drawing.Size(215, 45);
            this.GoLiveButton.TabIndex = 1;
            this.GoLiveButton.Text = "Go Live on TikTok";
            this.GoLiveButton.TextOffset = new System.Drawing.Point(2, 0);
            this.GoLiveButton.Click += new System.EventHandler(this.GoLive_Click);
            // 
            // cricBlastLabel
            // 
            this.cricBlastLabel.AutoSize = true;
            this.cricBlastLabel.BackColor = System.Drawing.Color.Transparent;
            this.cricBlastLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cricBlastLabel.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Bold);
            this.cricBlastLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cricBlastLabel.Location = new System.Drawing.Point(103, 50);
            this.cricBlastLabel.Name = "cricBlastLabel";
            this.cricBlastLabel.Size = new System.Drawing.Size(165, 46);
            this.cricBlastLabel.TabIndex = 4;
            this.cricBlastLabel.Text = "InterTok";
            // 
            // logoPicture
            // 
            this.logoPicture.BackColor = System.Drawing.Color.Transparent;
            this.logoPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoPicture.Image = global::CricBlast_GUI.Properties.Resources.Logo;
            this.logoPicture.Location = new System.Drawing.Point(45, 41);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(57, 64);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicture.TabIndex = 0;
            this.logoPicture.TabStop = false;
            // 
            // DragControl
            // 
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.TargetControl = this.menuPanel;
            this.DragControl.TransparentWhileDrag = false;
            // 
            // DragControl2
            // 
            this.DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl2.TargetControl = this.homeSubPanel;
            this.DragControl2.TransparentWhileDrag = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.BackgroundImage = global::CricBlast_GUI.Properties.Resources.Background;
            this.Controls.Add(this.homeSubPanel);
            this.Controls.Add(this.menuPanel);
            this.DoubleBuffered = true;
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1280, 720);
            this.homeSubPanel.ResumeLayout(false);
            this.homeSubPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OnlineIcon)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel menuPanel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox OnlineIcon;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Label usernameLabel;
        private Guna.UI2.WinForms.Guna2Button StartGameButton;
        private Guna.UI2.WinForms.Guna2Button GoLiveButton;
        private System.Windows.Forms.Label cricBlastLabel;
        private System.Windows.Forms.PictureBox logoPicture;
        private Guna.UI2.WinForms.Guna2Panel homeSubPanel;
        private System.Windows.Forms.Label logout;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2DragControl DragControl2;
        private Guna.UI2.WinForms.Guna2Button ConnectButton;
        private Guna.UI2.WinForms.Guna2CirclePictureBox userPhoto;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label updateButton;
    }
}
