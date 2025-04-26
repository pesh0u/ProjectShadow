namespace ProjectShadow.Forms
{
    partial class LoginForm
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
            this.dataPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.exitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.loginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.powerExitBtn = new System.Windows.Forms.PictureBox();
            this.clockLine = new System.Windows.Forms.Label();
            this.welcomePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.powerExitBtn)).BeginInit();
            this.welcomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataPanel
            // 
            this.dataPanel.BackColor = System.Drawing.Color.Transparent;
            this.dataPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataPanel.BorderRadius = 10;
            this.dataPanel.BorderThickness = 3;
            this.dataPanel.Controls.Add(this.label1);
            this.dataPanel.Controls.Add(this.passwordBox);
            this.dataPanel.Controls.Add(this.usernameBox);
            this.dataPanel.Controls.Add(this.guna2PictureBox1);
            this.dataPanel.Controls.Add(this.guna2Panel1);
            this.dataPanel.FillColor = System.Drawing.Color.DimGray;
            this.dataPanel.Location = new System.Drawing.Point(60, 87);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(383, 191);
            this.dataPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "LOGIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordBox
            // 
            this.passwordBox.BorderColor = System.Drawing.Color.Black;
            this.passwordBox.BorderRadius = 10;
            this.passwordBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordBox.DefaultText = "";
            this.passwordBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordBox.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.passwordBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.ForeColor = System.Drawing.Color.White;
            this.passwordBox.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.passwordBox.Location = new System.Drawing.Point(115, 94);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.passwordBox.PlaceholderText = "Password";
            this.passwordBox.SelectedText = "";
            this.passwordBox.Size = new System.Drawing.Size(252, 36);
            this.passwordBox.TabIndex = 2;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // usernameBox
            // 
            this.usernameBox.BorderColor = System.Drawing.Color.Black;
            this.usernameBox.BorderRadius = 10;
            this.usernameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameBox.DefaultText = "";
            this.usernameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernameBox.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.usernameBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.ForeColor = System.Drawing.Color.White;
            this.usernameBox.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.usernameBox.Location = new System.Drawing.Point(115, 52);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.usernameBox.PlaceholderText = "Username";
            this.usernameBox.SelectedText = "";
            this.usernameBox.Size = new System.Drawing.Size(252, 36);
            this.usernameBox.TabIndex = 1;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::ProjectShadow.Properties.Resources.outline_account_circle_white_48dp;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(10, 42);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(96, 96);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.Controls.Add(this.statusLabel);
            this.guna2Panel1.Controls.Add(this.exitBtn);
            this.guna2Panel1.Controls.Add(this.loginBtn);
            this.guna2Panel1.CustomizableEdges.TopLeft = false;
            this.guna2Panel1.CustomizableEdges.TopRight = false;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 146);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(383, 52);
            this.guna2Panel1.TabIndex = 0;
            // 
            // exitBtn
            // 
            this.exitBtn.BorderRadius = 5;
            this.exitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitBtn.FillColor = System.Drawing.Color.Gray;
            this.exitBtn.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(21, 15);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(85, 27);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "Exit";
            // 
            // loginBtn
            // 
            this.loginBtn.BorderRadius = 5;
            this.loginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginBtn.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(282, 15);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(85, 27);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Log In";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.powerExitBtn);
            this.guna2Panel2.Controls.Add(this.clockLine);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1920, 28);
            this.guna2Panel2.TabIndex = 1;
            // 
            // powerExitBtn
            // 
            this.powerExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.powerExitBtn.Image = global::ProjectShadow.Properties.Resources.outline_power_settings_new_white_48dp;
            this.powerExitBtn.Location = new System.Drawing.Point(1888, 3);
            this.powerExitBtn.Name = "powerExitBtn";
            this.powerExitBtn.Size = new System.Drawing.Size(25, 25);
            this.powerExitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.powerExitBtn.TabIndex = 4;
            this.powerExitBtn.TabStop = false;
            // 
            // clockLine
            // 
            this.clockLine.BackColor = System.Drawing.Color.Transparent;
            this.clockLine.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockLine.ForeColor = System.Drawing.Color.White;
            this.clockLine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clockLine.Location = new System.Drawing.Point(14, 0);
            this.clockLine.Name = "clockLine";
            this.clockLine.Size = new System.Drawing.Size(1906, 28);
            this.clockLine.TabIndex = 0;
            this.clockLine.Text = "YYYY-MM-DD HH:MM:SS FF";
            this.clockLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // welcomePanel
            // 
            this.welcomePanel.BackColor = System.Drawing.Color.Transparent;
            this.welcomePanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.welcomePanel.BorderRadius = 10;
            this.welcomePanel.BorderThickness = 3;
            this.welcomePanel.Controls.Add(this.pictureBox1);
            this.welcomePanel.Controls.Add(this.label3);
            this.welcomePanel.FillColor = System.Drawing.Color.DimGray;
            this.welcomePanel.Location = new System.Drawing.Point(535, 87);
            this.welcomePanel.Name = "welcomePanel";
            this.welcomePanel.Size = new System.Drawing.Size(412, 191);
            this.welcomePanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectShadow.Properties.Resources.logoheader;
            this.pictureBox1.Location = new System.Drawing.Point(135, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(2, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(406, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "WELCOME TO BOTNET NETWORK";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.statusLabel.Location = new System.Drawing.Point(112, 15);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(164, 23);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectShadow.Properties.Resources.ChatGPT_Image_Apr_25__2025__11_52_42_PM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.welcomePanel);
            this.Controls.Add(this.dataPanel);
            this.DoubleBuffered = true;
            this.Name = "LoginForm";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.dataPanel.ResumeLayout(false);
            this.dataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.powerExitBtn)).EndInit();
            this.welcomePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel dataPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox usernameBox;
        private Guna.UI2.WinForms.Guna2TextBox passwordBox;
        private Guna.UI2.WinForms.Guna2Button loginBtn;
        private Guna.UI2.WinForms.Guna2Button exitBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label clockLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox powerExitBtn;
        private Guna.UI2.WinForms.Guna2Panel welcomePanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label statusLabel;
    }
}
