
namespace CricBlast_GUI.UI
{
    partial class MessageBoxDownload
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.message = new System.Windows.Forms.Label();
            this.yes = new Guna.UI2.WinForms.Guna2Button();
            this.messageMark = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cricBlastPicture = new System.Windows.Forms.PictureBox();
            this.cricBlastLabel = new System.Windows.Forms.Label();
            this.downloadBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.downloadPercentage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.messageMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cricBlastPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // BorderlessForm
            // 
            this.BorderlessForm.ContainerControl = this;
            this.BorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessForm.TransparentWhileDrag = true;
            // 
            // message
            // 
            this.message.BackColor = System.Drawing.Color.Transparent;
            this.message.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.message.ForeColor = System.Drawing.Color.White;
            this.message.Location = new System.Drawing.Point(146, 33);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(322, 105);
            this.message.TabIndex = 32;
            this.message.Text = "Message";
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yes
            // 
            this.yes.BackColor = System.Drawing.Color.Transparent;
            this.yes.BorderRadius = 4;
            this.yes.CheckedState.Parent = this.yes;
            this.yes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yes.CustomImages.Parent = this.yes;
            this.yes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.yes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.yes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.yes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.yes.DisabledState.Parent = this.yes;
            this.yes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.yes.ForeColor = System.Drawing.Color.White;
            this.yes.HoverState.Parent = this.yes;
            this.yes.Location = new System.Drawing.Point(38, 141);
            this.yes.Name = "yes";
            this.yes.ShadowDecoration.Parent = this.yes;
            this.yes.Size = new System.Drawing.Size(223, 45);
            this.yes.TabIndex = 1;
            this.yes.Text = "Install Game";
            this.yes.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // messageMark
            // 
            this.messageMark.Image = global::CricBlast_GUI.Properties.Resources.Warning_Mark;
            this.messageMark.ImageRotate = 0F;
            this.messageMark.Location = new System.Drawing.Point(38, 44);
            this.messageMark.Name = "messageMark";
            this.messageMark.ShadowDecoration.Parent = this.messageMark;
            this.messageMark.Size = new System.Drawing.Size(80, 80);
            this.messageMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.messageMark.TabIndex = 30;
            this.messageMark.TabStop = false;
            // 
            // cricBlastPicture
            // 
            this.cricBlastPicture.BackColor = System.Drawing.Color.Transparent;
            this.cricBlastPicture.Image = global::CricBlast_GUI.Properties.Resources.Logo;
            this.cricBlastPicture.Location = new System.Drawing.Point(8, 8);
            this.cricBlastPicture.Name = "cricBlastPicture";
            this.cricBlastPicture.Size = new System.Drawing.Size(25, 25);
            this.cricBlastPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cricBlastPicture.TabIndex = 41;
            this.cricBlastPicture.TabStop = false;
            // 
            // cricBlastLabel
            // 
            this.cricBlastLabel.AutoSize = true;
            this.cricBlastLabel.BackColor = System.Drawing.Color.Transparent;
            this.cricBlastLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cricBlastLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cricBlastLabel.Location = new System.Drawing.Point(34, 10);
            this.cricBlastLabel.Name = "cricBlastLabel";
            this.cricBlastLabel.Size = new System.Drawing.Size(73, 21);
            this.cricBlastLabel.TabIndex = 44;
            this.cricBlastLabel.Text = "InterTok";
            this.cricBlastLabel.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // downloadBar
            // 
            this.downloadBar.Location = new System.Drawing.Point(38, 192);
            this.downloadBar.Name = "downloadBar";
            this.downloadBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.downloadBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.downloadBar.ShadowDecoration.Parent = this.downloadBar;
            this.downloadBar.Size = new System.Drawing.Size(430, 39);
            this.downloadBar.TabIndex = 46;
            this.downloadBar.Text = "guna2ProgressBar1";
            this.downloadBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // downloadPercentage
            // 
            this.downloadPercentage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.downloadPercentage.AutoSize = true;
            this.downloadPercentage.BackColor = System.Drawing.Color.Transparent;
            this.downloadPercentage.Cursor = System.Windows.Forms.Cursors.Default;
            this.downloadPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.downloadPercentage.Location = new System.Drawing.Point(404, 160);
            this.downloadPercentage.Name = "downloadPercentage";
            this.downloadPercentage.Size = new System.Drawing.Size(48, 29);
            this.downloadPercentage.TabIndex = 47;
            this.downloadPercentage.Text = "0%";
            this.downloadPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MessageBoxDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.BackgroundImage = global::CricBlast_GUI.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(518, 265);
            this.ControlBox = false;
            this.Controls.Add(this.downloadPercentage);
            this.Controls.Add(this.downloadBar);
            this.Controls.Add(this.cricBlastLabel);
            this.Controls.Add(this.cricBlastPicture);
            this.Controls.Add(this.message);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.messageMark);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageBoxDownload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CricBlast";
            ((System.ComponentModel.ISupportInitialize)(this.messageMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cricBlastPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private System.Windows.Forms.Label message;
        private Guna.UI2.WinForms.Guna2Button yes;
        private Guna.UI2.WinForms.Guna2PictureBox messageMark;
        private System.Windows.Forms.PictureBox cricBlastPicture;
        private System.Windows.Forms.Label cricBlastLabel;
        private Guna.UI2.WinForms.Guna2ProgressBar downloadBar;
        private System.Windows.Forms.Label downloadPercentage;
    }
}