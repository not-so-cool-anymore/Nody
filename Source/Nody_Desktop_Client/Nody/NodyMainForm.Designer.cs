namespace Nody
{
    partial class NodyMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NodyMainForm));
            this.mainFormUpperPanel = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.requestDatasetBtn = new System.Windows.Forms.Button();
            this.nodesPageBtn = new System.Windows.Forms.Button();
            this.homePageBtn = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.nodesPageUserControl = new Nody.NodesPageUserControl();
            this.homePageUserControl = new Nody.HomePageUserControl();
            this.requestDatasetUserControl = new Nody.RequestDatasetUserControl();
            this.mainFormUpperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainFormUpperPanel
            // 
            this.mainFormUpperPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mainFormUpperPanel.Controls.Add(this.exitBtn);
            this.mainFormUpperPanel.Controls.Add(this.requestDatasetBtn);
            this.mainFormUpperPanel.Controls.Add(this.nodesPageBtn);
            this.mainFormUpperPanel.Controls.Add(this.homePageBtn);
            this.mainFormUpperPanel.Controls.Add(this.logoPictureBox);
            this.mainFormUpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainFormUpperPanel.Location = new System.Drawing.Point(0, 0);
            this.mainFormUpperPanel.Name = "mainFormUpperPanel";
            this.mainFormUpperPanel.Size = new System.Drawing.Size(1090, 112);
            this.mainFormUpperPanel.TabIndex = 0;
            this.mainFormUpperPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainFormUpperPanel_MouseDown);
            this.mainFormUpperPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainFormUpperPanel_MouseMove);
            // 
            // exitBtn
            // 
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.Transparent;
            this.exitBtn.Location = new System.Drawing.Point(939, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(139, 106);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // requestDatasetBtn
            // 
            this.requestDatasetBtn.FlatAppearance.BorderSize = 0;
            this.requestDatasetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.requestDatasetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestDatasetBtn.ForeColor = System.Drawing.Color.Transparent;
            this.requestDatasetBtn.Location = new System.Drawing.Point(423, 4);
            this.requestDatasetBtn.Name = "requestDatasetBtn";
            this.requestDatasetBtn.Size = new System.Drawing.Size(139, 106);
            this.requestDatasetBtn.TabIndex = 3;
            this.requestDatasetBtn.Text = "REQUEST\r\nDATASET";
            this.requestDatasetBtn.UseVisualStyleBackColor = true;
            this.requestDatasetBtn.Click += new System.EventHandler(this.RequestDatasetBtn_Click);
            // 
            // nodesPageBtn
            // 
            this.nodesPageBtn.FlatAppearance.BorderSize = 0;
            this.nodesPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nodesPageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodesPageBtn.ForeColor = System.Drawing.Color.Transparent;
            this.nodesPageBtn.Location = new System.Drawing.Point(280, 3);
            this.nodesPageBtn.Name = "nodesPageBtn";
            this.nodesPageBtn.Size = new System.Drawing.Size(139, 106);
            this.nodesPageBtn.TabIndex = 2;
            this.nodesPageBtn.Text = "NODES";
            this.nodesPageBtn.UseVisualStyleBackColor = true;
            this.nodesPageBtn.Click += new System.EventHandler(this.NodesPageBtn_Click);
            // 
            // homePageBtn
            // 
            this.homePageBtn.FlatAppearance.BorderSize = 0;
            this.homePageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homePageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homePageBtn.ForeColor = System.Drawing.Color.Transparent;
            this.homePageBtn.Location = new System.Drawing.Point(135, 3);
            this.homePageBtn.Name = "homePageBtn";
            this.homePageBtn.Size = new System.Drawing.Size(139, 106);
            this.homePageBtn.TabIndex = 1;
            this.homePageBtn.Text = "HOME";
            this.homePageBtn.UseVisualStyleBackColor = true;
            this.homePageBtn.Click += new System.EventHandler(this.HomePageBtn_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(112, 112);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            this.logoPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LogoPictureBox_MouseDown);
            this.logoPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LogoPictureBox_MouseMove);
            // 
            // nodesPageUserControl
            // 
            this.nodesPageUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nodesPageUserControl.Location = new System.Drawing.Point(0, 112);
            this.nodesPageUserControl.Name = "nodesPageUserControl";
            this.nodesPageUserControl.Size = new System.Drawing.Size(1090, 413);
            this.nodesPageUserControl.TabIndex = 2;
            // 
            // homePageUserControl
            // 
            this.homePageUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.homePageUserControl.Location = new System.Drawing.Point(0, 112);
            this.homePageUserControl.Name = "homePageUserControl";
            this.homePageUserControl.Size = new System.Drawing.Size(1090, 413);
            this.homePageUserControl.TabIndex = 1;
            // 
            // requestDatasetUserControl
            // 
            this.requestDatasetUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.requestDatasetUserControl.Location = new System.Drawing.Point(0, 112);
            this.requestDatasetUserControl.Name = "requestDatasetUserControl";
            this.requestDatasetUserControl.Size = new System.Drawing.Size(1090, 413);
            this.requestDatasetUserControl.TabIndex = 3;
            // 
            // NodyMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1090, 525);
            this.Controls.Add(this.requestDatasetUserControl);
            this.Controls.Add(this.nodesPageUserControl);
            this.Controls.Add(this.homePageUserControl);
            this.Controls.Add(this.mainFormUpperPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NodyMainForm";
            this.Text = "Nody";
            this.mainFormUpperPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainFormUpperPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button homePageBtn;
        private System.Windows.Forms.Button nodesPageBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button requestDatasetBtn;
        private HomePageUserControl homePageUserControl;
        private NodesPageUserControl nodesPageUserControl;
        private RequestDatasetUserControl requestDatasetUserControl;
    }
}