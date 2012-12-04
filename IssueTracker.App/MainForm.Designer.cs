namespace IssueTracker.App
{
    partial class MainForm
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
            this.mListBoxProjects = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // mListBoxProjects
            // 
            this.mListBoxProjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.mListBoxProjects.FormattingEnabled = true;
            this.mListBoxProjects.IntegralHeight = false;
            this.mListBoxProjects.Location = new System.Drawing.Point(15, 15);
            this.mListBoxProjects.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.mListBoxProjects.Name = "mListBoxProjects";
            this.mListBoxProjects.Size = new System.Drawing.Size(168, 323);
            this.mListBoxProjects.TabIndex = 0;
            this.mListBoxProjects.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxProjects_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 353);
            this.Controls.Add(this.mListBoxProjects);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox mListBoxProjects;
    }
}

