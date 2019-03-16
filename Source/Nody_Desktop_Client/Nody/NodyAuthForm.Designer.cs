namespace Nody
{
    partial class Nody_Auth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nody_Auth));
            this.welcomePanel = new System.Windows.Forms.Panel();
            this.upperPanel = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.registerLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.loginUserControl = new Nody.LoginUserControl();
            this.registerUserControl = new Nody.RegisterUserControl();
            this.welcomePanel.SuspendLayout();
            this.upperPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomePanel
            // 
            this.welcomePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.welcomePanel.Controls.Add(this.upperPanel);
            this.welcomePanel.Controls.Add(this.loginLabel);
            this.welcomePanel.Controls.Add(this.registerLabel);
            this.welcomePanel.Controls.Add(this.welcomeLabel);
            this.welcomePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.welcomePanel.Location = new System.Drawing.Point(0, 0);
            this.welcomePanel.Name = "welcomePanel";
            this.welcomePanel.Size = new System.Drawing.Size(511, 140);
            this.welcomePanel.TabIndex = 0;
            this.welcomePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WelcomePanelMouseDown);
            this.welcomePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WelcomePaneMouseMove);
            // 
            // upperPanel
            // 
            this.upperPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.upperPanel.Controls.Add(this.nameLabel);
            this.upperPanel.Controls.Add(this.exitLabel);
            this.upperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperPanel.Location = new System.Drawing.Point(0, 0);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(511, 23);
            this.upperPanel.TabIndex = 3;
            this.upperPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpperPanelMouseDown);
            this.upperPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpperPanelMouseMove);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nameLabel.Location = new System.Drawing.Point(8, 1);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 20);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Nody";
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exitLabel.Location = new System.Drawing.Point(490, 1);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(20, 20);
            this.exitLabel.TabIndex = 4;
            this.exitLabel.Text = "X";
            this.exitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginLabel.Location = new System.Drawing.Point(451, 111);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(48, 20);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Login";
            this.loginLabel.Click += new System.EventHandler(this.LoginLabel_Click);
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.registerLabel.Location = new System.Drawing.Point(376, 111);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(69, 20);
            this.registerLabel.TabIndex = 1;
            this.registerLabel.Text = "Register";
            this.registerLabel.Click += new System.EventHandler(this.RegisterLabel_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.welcomeLabel.Location = new System.Drawing.Point(95, 26);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(321, 78);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome";
            this.welcomeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WelcomeLabelMouseDown);
            this.welcomeLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WelcomeLabelMouseMove);
            // 
            // loginUserControl
            // 
            this.loginUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.loginUserControl.Location = new System.Drawing.Point(0, 142);
            this.loginUserControl.Name = "loginUserControl";
            this.loginUserControl.Size = new System.Drawing.Size(511, 420);
            this.loginUserControl.TabIndex = 1;
            // 
            // registerUserControl
            // 
            this.registerUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.registerUserControl.Location = new System.Drawing.Point(0, 142);
            this.registerUserControl.Name = "registerUserControl";
            this.registerUserControl.Size = new System.Drawing.Size(511, 420);
            this.registerUserControl.TabIndex = 2;
            // 
            // Nody_Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(511, 560);
            this.Controls.Add(this.registerUserControl);
            this.Controls.Add(this.loginUserControl);
            this.Controls.Add(this.welcomePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Nody_Auth";
            this.Text = "Nody Login";
            this.welcomePanel.ResumeLayout(false);
            this.welcomePanel.PerformLayout();
            this.upperPanel.ResumeLayout(false);
            this.upperPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel welcomePanel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private LoginUserControl loginUserControl;
        private System.Windows.Forms.Panel upperPanel;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label nameLabel;
        private RegisterUserControl registerUserControl;
    }
}

