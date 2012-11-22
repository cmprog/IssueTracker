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
            this.mSplitContainer = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.mSplitContainer)).BeginInit();
            this.mSplitContainer.Panel1.SuspendLayout();
            this.mSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mListBoxProjects
            // 
            this.mListBoxProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mListBoxProjects.FormattingEnabled = true;
            this.mListBoxProjects.IntegralHeight = false;
            this.mListBoxProjects.Location = new System.Drawing.Point(0, 0);
            this.mListBoxProjects.Name = "mListBoxProjects";
            this.mListBoxProjects.Size = new System.Drawing.Size(100, 323);
            this.mListBoxProjects.TabIndex = 0;
            this.mListBoxProjects.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxProjects_MouseDoubleClick);
            // 
            // mSplitContainer
            // 
            this.mSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mSplitContainer.Location = new System.Drawing.Point(15, 15);
            this.mSplitContainer.Name = "mSplitContainer";
            // 
            // mSplitContainer.Panel1
            // 
            this.mSplitContainer.Panel1.Controls.Add(this.mListBoxProjects);
            this.mSplitContainer.Panel1MinSize = 100;
            this.mSplitContainer.Panel2MinSize = 200;
            this.mSplitContainer.Size = new System.Drawing.Size(602, 323);
            this.mSplitContainer.SplitterDistance = 100;
            this.mSplitContainer.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 353);
            this.Controls.Add(this.mSplitContainer);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Text = "Form1";
            this.mSplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mSplitContainer)).EndInit();
            this.mSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox mListBoxProjects;
        private System.Windows.Forms.SplitContainer mSplitContainer;
    }
}

