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
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.homePageBtn = new System.Windows.Forms.Button();
            this.nodesPageBtn = new System.Windows.Forms.Button();
            this.mainFormUpperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainFormUpperPanel
            // 
            this.mainFormUpperPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mainFormUpperPanel.Controls.Add(this.nodesPageBtn);
            this.mainFormUpperPanel.Controls.Add(this.homePageBtn);
            this.mainFormUpperPanel.Controls.Add(this.logoPictureBox);
            this.mainFormUpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainFormUpperPanel.Location = new System.Drawing.Point(0, 0);
            this.mainFormUpperPanel.Name = "mainFormUpperPanel";
            this.mainFormUpperPanel.Size = new System.Drawing.Size(1090, 112);
            this.mainFormUpperPanel.TabIndex = 0;
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
            // 
            // homePageBtn
            // 
            this.homePageBtn.FlatAppearance.BorderSize = 0;
            this.homePageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homePageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homePageBtn.ForeColor = System.Drawing.Color.Transparent;
            this.homePageBtn.Location = new System.Drawing.Point(135, 3);
            this.homePageBtn.Name = "homePageBtn";
            this.homePageBtn.Size = new System.Drawing.Size(131, 106);
            this.homePageBtn.TabIndex = 1;
            this.homePageBtn.Text = "HOME";
            this.homePageBtn.UseVisualStyleBackColor = true;
            // 
            // nodesPageBtn
            // 
            this.nodesPageBtn.FlatAppearance.BorderSize = 0;
            this.nodesPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nodesPageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodesPageBtn.ForeColor = System.Drawing.Color.Transparent;
            this.nodesPageBtn.Location = new System.Drawing.Point(272, 3);
            this.nodesPageBtn.Name = "nodesPageBtn";
            this.nodesPageBtn.Size = new System.Drawing.Size(131, 106);
            this.nodesPageBtn.TabIndex = 2;
            this.nodesPageBtn.Text = "NODES";
            this.nodesPageBtn.UseVisualStyleBackColor = true;
            // 
            // NodyMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1090, 525);
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
    }
}