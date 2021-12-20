﻿
namespace CricBlast_GUI.Forms.Controls
{
    partial class GameSelectPanel
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
            this.gamePlayPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.teamSelectError = new System.Windows.Forms.Label();
            this.pitchComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.stadiumComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.formatComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.opponentComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.playButton = new Guna.UI2.WinForms.Guna2Button();
            this.gamePlayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamePlayPanel
            // 
            this.gamePlayPanel.BackColor = System.Drawing.Color.Transparent;
            this.gamePlayPanel.Controls.Add(this.teamSelectError);
            this.gamePlayPanel.Controls.Add(this.pitchComboBox);
            this.gamePlayPanel.Controls.Add(this.stadiumComboBox);
            this.gamePlayPanel.Controls.Add(this.formatComboBox);
            this.gamePlayPanel.Controls.Add(this.opponentComboBox);
            this.gamePlayPanel.Controls.Add(this.label8);
            this.gamePlayPanel.Controls.Add(this.label7);
            this.gamePlayPanel.Controls.Add(this.label6);
            this.gamePlayPanel.Controls.Add(this.label9);
            this.gamePlayPanel.Controls.Add(this.playButton);
            this.gamePlayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamePlayPanel.Location = new System.Drawing.Point(0, 0);
            this.gamePlayPanel.Name = "gamePlayPanel";
            this.gamePlayPanel.ShadowDecoration.Parent = this.gamePlayPanel;
            this.gamePlayPanel.Size = new System.Drawing.Size(838, 259);
            this.gamePlayPanel.TabIndex = 38;
            // 
            // teamSelectError
            // 
            this.teamSelectError.AutoSize = true;
            this.teamSelectError.BackColor = System.Drawing.Color.Transparent;
            this.teamSelectError.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamSelectError.ForeColor = System.Drawing.Color.Red;
            this.teamSelectError.Location = new System.Drawing.Point(395, 52);
            this.teamSelectError.Name = "teamSelectError";
            this.teamSelectError.Size = new System.Drawing.Size(22, 32);
            this.teamSelectError.TabIndex = 36;
            this.teamSelectError.Text = "!";
            this.teamSelectError.Visible = false;
            // 
            // pitchComboBox
            // 
            this.pitchComboBox.BackColor = System.Drawing.Color.Transparent;
            this.pitchComboBox.BorderRadius = 4;
            this.pitchComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.pitchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pitchComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pitchComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pitchComboBox.FocusedState.Parent = this.pitchComboBox;
            this.pitchComboBox.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.pitchComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.pitchComboBox.HoverState.Parent = this.pitchComboBox;
            this.pitchComboBox.ItemHeight = 30;
            this.pitchComboBox.Items.AddRange(new object[] {
            "Green Pitch",
            "Dusty Pitch",
            "Dead Pitch"});
            this.pitchComboBox.ItemsAppearance.Parent = this.pitchComboBox;
            this.pitchComboBox.Location = new System.Drawing.Point(25, 123);
            this.pitchComboBox.Name = "pitchComboBox";
            this.pitchComboBox.ShadowDecoration.Parent = this.pitchComboBox;
            this.pitchComboBox.Size = new System.Drawing.Size(364, 36);
            this.pitchComboBox.StartIndex = 0;
            this.pitchComboBox.TabIndex = 26;
            // 
            // stadiumComboBox
            // 
            this.stadiumComboBox.BackColor = System.Drawing.Color.Transparent;
            this.stadiumComboBox.BorderRadius = 4;
            this.stadiumComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.stadiumComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stadiumComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stadiumComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stadiumComboBox.FocusedState.Parent = this.stadiumComboBox;
            this.stadiumComboBox.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.stadiumComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.stadiumComboBox.HoverState.Parent = this.stadiumComboBox;
            this.stadiumComboBox.ItemHeight = 30;
            this.stadiumComboBox.Items.AddRange(new object[] {
            "Sher-E-Bangla Cricket Stadium",
            "Narendra Modi Stadium",
            "Melbourne Cricket Ground",
            "Eden Gardens",
            "Shaheed Veer Narayan Singh International Cricket Stadium",
            "Perth Stadium",
            "Rajiv Gandhi International Cricket Stadium",
            "Greenfield International Stadium",
            "Adelaide Oval",
            "M. A. Chidambaram Stadium",
            "JSCA International Cricket Stadium",
            "Bharat Ratna Shri Atal Bihari Vajpayee Ekana Cricket Stadium",
            "Docklands Stadium",
            "Sydney Cricket Ground",
            "Vidarbha Cricket Association Stadium",
            "Barabati Stadium",
            "Saifai International Cricket Stadium",
            "Eden Park"});
            this.stadiumComboBox.ItemsAppearance.Parent = this.stadiumComboBox;
            this.stadiumComboBox.Location = new System.Drawing.Point(449, 123);
            this.stadiumComboBox.Name = "stadiumComboBox";
            this.stadiumComboBox.ShadowDecoration.Parent = this.stadiumComboBox;
            this.stadiumComboBox.Size = new System.Drawing.Size(364, 36);
            this.stadiumComboBox.StartIndex = 0;
            this.stadiumComboBox.TabIndex = 27;
            // 
            // formatComboBox
            // 
            this.formatComboBox.BackColor = System.Drawing.Color.Transparent;
            this.formatComboBox.BorderRadius = 4;
            this.formatComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.formatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formatComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.formatComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.formatComboBox.FocusedState.Parent = this.formatComboBox;
            this.formatComboBox.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.formatComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.formatComboBox.HoverState.Parent = this.formatComboBox;
            this.formatComboBox.ItemHeight = 30;
            this.formatComboBox.Items.AddRange(new object[] {
            "Test",
            "ODI",
            "T20I"});
            this.formatComboBox.ItemsAppearance.Parent = this.formatComboBox;
            this.formatComboBox.Location = new System.Drawing.Point(449, 48);
            this.formatComboBox.Name = "formatComboBox";
            this.formatComboBox.ShadowDecoration.Parent = this.formatComboBox;
            this.formatComboBox.Size = new System.Drawing.Size(364, 36);
            this.formatComboBox.StartIndex = 1;
            this.formatComboBox.TabIndex = 28;
            // 
            // opponentComboBox
            // 
            this.opponentComboBox.BackColor = System.Drawing.Color.Transparent;
            this.opponentComboBox.BorderRadius = 4;
            this.opponentComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.opponentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.opponentComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.opponentComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.opponentComboBox.FocusedState.Parent = this.opponentComboBox;
            this.opponentComboBox.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.opponentComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.opponentComboBox.HoverState.Parent = this.opponentComboBox;
            this.opponentComboBox.ItemHeight = 30;
            this.opponentComboBox.Items.AddRange(new object[] {
            "Select...",
            "Australia",
            "Bangladesh",
            "India",
            "New Zealand",
            "Pakistan",
            "South Africa",
            "Sri Lanka",
            "West Indies"});
            this.opponentComboBox.ItemsAppearance.Parent = this.opponentComboBox;
            this.opponentComboBox.Location = new System.Drawing.Point(25, 48);
            this.opponentComboBox.Name = "opponentComboBox";
            this.opponentComboBox.ShadowDecoration.Parent = this.opponentComboBox;
            this.opponentComboBox.Size = new System.Drawing.Size(364, 36);
            this.opponentComboBox.StartIndex = 0;
            this.opponentComboBox.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(20, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "PITCH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(444, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "STADIUM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(444, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "FORMAT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(20, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "OPPONENT";
            // 
            // playButton
            // 
            this.playButton.Animated = true;
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.BorderRadius = 4;
            this.playButton.CheckedState.Parent = this.playButton;
            this.playButton.CustomImages.Parent = this.playButton;
            this.playButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.playButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.playButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.playButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.playButton.DisabledState.Parent = this.playButton;
            this.playButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.playButton.ForeColor = System.Drawing.Color.White;
            this.playButton.HoverState.Parent = this.playButton;
            this.playButton.Location = new System.Drawing.Point(326, 195);
            this.playButton.Name = "playButton";
            this.playButton.ShadowDecoration.Parent = this.playButton;
            this.playButton.Size = new System.Drawing.Size(180, 45);
            this.playButton.TabIndex = 15;
            this.playButton.Text = "Play";
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // GameSelectPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gamePlayPanel);
            this.Name = "GameSelectPanel";
            this.Size = new System.Drawing.Size(838, 259);
            this.gamePlayPanel.ResumeLayout(false);
            this.gamePlayPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Panel gamePlayPanel;
        private System.Windows.Forms.Label teamSelectError;
        private Guna.UI2.WinForms.Guna2ComboBox pitchComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox stadiumComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox formatComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox opponentComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button playButton;
    }
}
