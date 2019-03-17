namespace Nody
{
    partial class RequestDatasetUserControl
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
            this.requesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // requesLabel
            // 
            this.requesLabel.AutoSize = true;
            this.requesLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.requesLabel.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requesLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.requesLabel.Location = new System.Drawing.Point(53, 127);
            this.requesLabel.Name = "requesLabel";
            this.requesLabel.Size = new System.Drawing.Size(981, 126);
            this.requesLabel.TabIndex = 1;
            this.requesLabel.Text = "To request a dataset, you must send us an email with\r\nthe data you need and the n" +
    "ame of the node you want\r\nto receive it from.";
            // 
            // RequestDatasetUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.requesLabel);
            this.Name = "RequestDatasetUserControl";
            this.Size = new System.Drawing.Size(1090, 413);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label requesLabel;
    }
}
