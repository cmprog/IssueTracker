namespace IssueTracker.App.Views
{
    partial class ProjectHomeView
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
            this.mTabControlMain = new System.Windows.Forms.TabControl();
            this.mTabPageIssues = new System.Windows.Forms.TabPage();
            this.mTabControlIssues = new System.Windows.Forms.TabControl();
            this.mTabPageOpenIssues = new System.Windows.Forms.TabPage();
            this.mTabPageClosedIssues = new System.Windows.Forms.TabPage();
            this.mButtonIssuesCreated = new System.Windows.Forms.Button();
            this.mButtonIssuesAssigned = new System.Windows.Forms.Button();
            this.mButtonIssuesEveryone = new System.Windows.Forms.Button();
            this.mTabPageMilestones = new System.Windows.Forms.TabPage();
            this.mButtonAdd = new System.Windows.Forms.Button();
            this.mLabelSearch = new System.Windows.Forms.Label();
            this.mTextBoxSearch = new System.Windows.Forms.TextBox();
            this.mListBoxOpenIssues = new System.Windows.Forms.ListBox();
            this.mTabControlMain.SuspendLayout();
            this.mTabPageIssues.SuspendLayout();
            this.mTabControlIssues.SuspendLayout();
            this.mTabPageOpenIssues.SuspendLayout();
            this.SuspendLayout();
            // 
            // mTabControlMain
            // 
            this.mTabControlMain.Controls.Add(this.mTabPageIssues);
            this.mTabControlMain.Controls.Add(this.mTabPageMilestones);
            this.mTabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTabControlMain.ItemSize = new System.Drawing.Size(400, 30);
            this.mTabControlMain.Location = new System.Drawing.Point(0, 0);
            this.mTabControlMain.Margin = new System.Windows.Forms.Padding(4);
            this.mTabControlMain.Name = "mTabControlMain";
            this.mTabControlMain.SelectedIndex = 0;
            this.mTabControlMain.Size = new System.Drawing.Size(550, 220);
            this.mTabControlMain.TabIndex = 0;
            // 
            // mTabPageIssues
            // 
            this.mTabPageIssues.Controls.Add(this.mTabControlIssues);
            this.mTabPageIssues.Controls.Add(this.mButtonIssuesCreated);
            this.mTabPageIssues.Controls.Add(this.mButtonIssuesAssigned);
            this.mTabPageIssues.Controls.Add(this.mButtonIssuesEveryone);
            this.mTabPageIssues.Location = new System.Drawing.Point(4, 34);
            this.mTabPageIssues.Margin = new System.Windows.Forms.Padding(4);
            this.mTabPageIssues.Name = "mTabPageIssues";
            this.mTabPageIssues.Padding = new System.Windows.Forms.Padding(4);
            this.mTabPageIssues.Size = new System.Drawing.Size(542, 182);
            this.mTabPageIssues.TabIndex = 0;
            this.mTabPageIssues.Text = "Browse Issues";
            this.mTabPageIssues.UseVisualStyleBackColor = true;
            // 
            // mTabControlIssues
            // 
            this.mTabControlIssues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTabControlIssues.Controls.Add(this.mTabPageOpenIssues);
            this.mTabControlIssues.Controls.Add(this.mTabPageClosedIssues);
            this.mTabControlIssues.Location = new System.Drawing.Point(183, 7);
            this.mTabControlIssues.Name = "mTabControlIssues";
            this.mTabControlIssues.SelectedIndex = 0;
            this.mTabControlIssues.Size = new System.Drawing.Size(352, 168);
            this.mTabControlIssues.TabIndex = 3;
            // 
            // mTabPageOpenIssues
            // 
            this.mTabPageOpenIssues.Controls.Add(this.mListBoxOpenIssues);
            this.mTabPageOpenIssues.Location = new System.Drawing.Point(4, 25);
            this.mTabPageOpenIssues.Name = "mTabPageOpenIssues";
            this.mTabPageOpenIssues.Padding = new System.Windows.Forms.Padding(3);
            this.mTabPageOpenIssues.Size = new System.Drawing.Size(344, 139);
            this.mTabPageOpenIssues.TabIndex = 0;
            this.mTabPageOpenIssues.Text = "# open issue";
            this.mTabPageOpenIssues.UseVisualStyleBackColor = true;
            // 
            // mTabPageClosedIssues
            // 
            this.mTabPageClosedIssues.Location = new System.Drawing.Point(4, 25);
            this.mTabPageClosedIssues.Name = "mTabPageClosedIssues";
            this.mTabPageClosedIssues.Padding = new System.Windows.Forms.Padding(3);
            this.mTabPageClosedIssues.Size = new System.Drawing.Size(344, 139);
            this.mTabPageClosedIssues.TabIndex = 1;
            this.mTabPageClosedIssues.Text = "# closed issues";
            this.mTabPageClosedIssues.UseVisualStyleBackColor = true;
            // 
            // mButtonIssuesCreated
            // 
            this.mButtonIssuesCreated.Location = new System.Drawing.Point(7, 93);
            this.mButtonIssuesCreated.Name = "mButtonIssuesCreated";
            this.mButtonIssuesCreated.Size = new System.Drawing.Size(170, 37);
            this.mButtonIssuesCreated.TabIndex = 2;
            this.mButtonIssuesCreated.Text = "Created by you";
            this.mButtonIssuesCreated.UseVisualStyleBackColor = true;
            // 
            // mButtonIssuesAssigned
            // 
            this.mButtonIssuesAssigned.Location = new System.Drawing.Point(7, 50);
            this.mButtonIssuesAssigned.Name = "mButtonIssuesAssigned";
            this.mButtonIssuesAssigned.Size = new System.Drawing.Size(170, 37);
            this.mButtonIssuesAssigned.TabIndex = 1;
            this.mButtonIssuesAssigned.Text = "Assigned to you";
            this.mButtonIssuesAssigned.UseVisualStyleBackColor = true;
            // 
            // mButtonIssuesEveryone
            // 
            this.mButtonIssuesEveryone.Location = new System.Drawing.Point(7, 7);
            this.mButtonIssuesEveryone.Name = "mButtonIssuesEveryone";
            this.mButtonIssuesEveryone.Size = new System.Drawing.Size(170, 37);
            this.mButtonIssuesEveryone.TabIndex = 0;
            this.mButtonIssuesEveryone.Text = "Everyone\'s Issues";
            this.mButtonIssuesEveryone.UseVisualStyleBackColor = true;
            // 
            // mTabPageMilestones
            // 
            this.mTabPageMilestones.Location = new System.Drawing.Point(4, 34);
            this.mTabPageMilestones.Margin = new System.Windows.Forms.Padding(4);
            this.mTabPageMilestones.Name = "mTabPageMilestones";
            this.mTabPageMilestones.Padding = new System.Windows.Forms.Padding(4);
            this.mTabPageMilestones.Size = new System.Drawing.Size(542, 182);
            this.mTabPageMilestones.TabIndex = 1;
            this.mTabPageMilestones.Text = "Milestones";
            this.mTabPageMilestones.UseVisualStyleBackColor = true;
            // 
            // mButtonAdd
            // 
            this.mButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mButtonAdd.Location = new System.Drawing.Point(438, 3);
            this.mButtonAdd.Name = "mButtonAdd";
            this.mButtonAdd.Size = new System.Drawing.Size(109, 23);
            this.mButtonAdd.TabIndex = 4;
            this.mButtonAdd.Text = "New Milestone";
            this.mButtonAdd.UseVisualStyleBackColor = true;
            // 
            // mLabelSearch
            // 
            this.mLabelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mLabelSearch.AutoSize = true;
            this.mLabelSearch.Location = new System.Drawing.Point(220, 6);
            this.mLabelSearch.Name = "mLabelSearch";
            this.mLabelSearch.Size = new System.Drawing.Size(51, 16);
            this.mLabelSearch.TabIndex = 5;
            this.mLabelSearch.Text = "Search";
            // 
            // mTextBoxSearch
            // 
            this.mTextBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mTextBoxSearch.Location = new System.Drawing.Point(277, 3);
            this.mTextBoxSearch.Name = "mTextBoxSearch";
            this.mTextBoxSearch.Size = new System.Drawing.Size(155, 22);
            this.mTextBoxSearch.TabIndex = 6;
            // 
            // mListBoxOpenIssues
            // 
            this.mListBoxOpenIssues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mListBoxOpenIssues.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mListBoxOpenIssues.FormattingEnabled = true;
            this.mListBoxOpenIssues.Location = new System.Drawing.Point(3, 3);
            this.mListBoxOpenIssues.Name = "mListBoxOpenIssues";
            this.mListBoxOpenIssues.Size = new System.Drawing.Size(338, 133);
            this.mListBoxOpenIssues.TabIndex = 0;
            this.mListBoxOpenIssues.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBoxIssues_DrawItem);
            // 
            // ProjectHomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mTextBoxSearch);
            this.Controls.Add(this.mLabelSearch);
            this.Controls.Add(this.mButtonAdd);
            this.Controls.Add(this.mTabControlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(550, 220);
            this.Name = "ProjectHomeView";
            this.Size = new System.Drawing.Size(550, 220);
            this.mTabControlMain.ResumeLayout(false);
            this.mTabPageIssues.ResumeLayout(false);
            this.mTabControlIssues.ResumeLayout(false);
            this.mTabPageOpenIssues.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mTabControlMain;
        private System.Windows.Forms.TabPage mTabPageIssues;
        private System.Windows.Forms.TabPage mTabPageMilestones;
        private System.Windows.Forms.Button mButtonIssuesCreated;
        private System.Windows.Forms.Button mButtonIssuesAssigned;
        private System.Windows.Forms.Button mButtonIssuesEveryone;
        private System.Windows.Forms.TabControl mTabControlIssues;
        private System.Windows.Forms.TabPage mTabPageOpenIssues;
        private System.Windows.Forms.TabPage mTabPageClosedIssues;
        private System.Windows.Forms.Button mButtonAdd;
        private System.Windows.Forms.Label mLabelSearch;
        private System.Windows.Forms.TextBox mTextBoxSearch;
        private System.Windows.Forms.ListBox mListBoxOpenIssues;
    }
}
