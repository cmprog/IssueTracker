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
            this.mLinkLabelBack = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // mListBoxProjects
            // 
            this.mListBoxProjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.mListBoxProjects.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mListBoxProjects.FormattingEnabled = true;
            this.mListBoxProjects.IntegralHeight = false;
            this.mListBoxProjects.ItemHeight = 25;
            this.mListBoxProjects.Location = new System.Drawing.Point(20, 18);
            this.mListBoxProjects.Margin = new System.Windows.Forms.Padding(0, 0, 13, 0);
            this.mListBoxProjects.Name = "mListBoxProjects";
            this.mListBoxProjects.Size = new System.Drawing.Size(223, 397);
            this.mListBoxProjects.TabIndex = 0;
            this.mListBoxProjects.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBoxProjects_DrawItem);
            this.mListBoxProjects.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxProjects_MouseDoubleClick);
            // 
            // mLinkLabelBack
            // 
            this.mLinkLabelBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mLinkLabelBack.Location = new System.Drawing.Point(259, 18);
            this.mLinkLabelBack.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.mLinkLabelBack.Name = "mLinkLabelBack";
            this.mLinkLabelBack.Size = new System.Drawing.Size(799, 13);
            this.mLinkLabelBack.TabIndex = 1;
            this.mLinkLabelBack.TabStop = true;
            this.mLinkLabelBack.Text = "Back";
            this.mLinkLabelBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelBack_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 434);
            this.Controls.Add(this.mLinkLabelBack);
            this.Controls.Add(this.mListBoxProjects);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox mListBoxProjects;
        private System.Windows.Forms.LinkLabel mLinkLabelBack;
    }
}

