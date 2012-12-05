namespace IssueTracker.App
{
    partial class IssueDetailsControlHost
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
            this.mLabelAuthor = new System.Windows.Forms.Label();
            this.mButtonEdit = new System.Windows.Forms.Button();
            this.mLabelTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mLabelAssignedUserFooter = new System.Windows.Forms.Label();
            this.mProgressBarMilestone = new System.Windows.Forms.ProgressBar();
            this.mLabelMilestone = new System.Windows.Forms.Label();
            this.mLabelMilestoneHeader = new System.Windows.Forms.Label();
            this.mLabelAssignedUser = new System.Windows.Forms.Label();
            this.mHtmlPanel = new System.Windows.Forms.HtmlPanel();
            this.mLabelAuthorFooter = new System.Windows.Forms.Label();
            this.mPanelOpenStatus = new System.Windows.Forms.Panel();
            this.mListBoxLabels = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mTextPreviewViewBody = new IssueTracker.App.TextPreviewView();
            this.mTextBoxTitle = new System.Windows.Forms.TextBox();
            this.mButtonUpdate = new System.Windows.Forms.Button();
            this.mButtonCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mLabelAuthor
            // 
            this.mLabelAuthor.AutoSize = true;
            this.mLabelAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLabelAuthor.ForeColor = System.Drawing.SystemColors.GrayText;
            this.mLabelAuthor.Location = new System.Drawing.Point(4, 0);
            this.mLabelAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelAuthor.Name = "mLabelAuthor";
            this.mLabelAuthor.Size = new System.Drawing.Size(63, 16);
            this.mLabelAuthor.TabIndex = 0;
            this.mLabelAuthor.Text = "{author}";
            this.mLabelAuthor.SizeChanged += new System.EventHandler(this.LabelAuthor_SizeChanged);
            // 
            // mButtonEdit
            // 
            this.mButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mButtonEdit.Location = new System.Drawing.Point(484, 3);
            this.mButtonEdit.Name = "mButtonEdit";
            this.mButtonEdit.Size = new System.Drawing.Size(48, 23);
            this.mButtonEdit.TabIndex = 1;
            this.mButtonEdit.Text = "Edit";
            this.mButtonEdit.UseVisualStyleBackColor = true;
            this.mButtonEdit.Click += new System.EventHandler(this.mButtonEdit_Click);
            // 
            // mLabelTitle
            // 
            this.mLabelTitle.AutoSize = true;
            this.mLabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLabelTitle.Location = new System.Drawing.Point(4, 16);
            this.mLabelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelTitle.Name = "mLabelTitle";
            this.mLabelTitle.Size = new System.Drawing.Size(137, 25);
            this.mLabelTitle.TabIndex = 2;
            this.mLabelTitle.Text = "{Issue Title}";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.mLabelAssignedUserFooter);
            this.panel1.Controls.Add(this.mProgressBarMilestone);
            this.panel1.Controls.Add(this.mLabelMilestone);
            this.panel1.Controls.Add(this.mLabelMilestoneHeader);
            this.panel1.Controls.Add(this.mLabelAssignedUser);
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(532, 25);
            this.panel1.TabIndex = 3;
            // 
            // mLabelAssignedUserFooter
            // 
            this.mLabelAssignedUserFooter.AutoSize = true;
            this.mLabelAssignedUserFooter.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.mLabelAssignedUserFooter.Location = new System.Drawing.Point(62, 3);
            this.mLabelAssignedUserFooter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelAssignedUserFooter.Name = "mLabelAssignedUserFooter";
            this.mLabelAssignedUserFooter.Size = new System.Drawing.Size(77, 16);
            this.mLabelAssignedUserFooter.TabIndex = 5;
            this.mLabelAssignedUserFooter.Text = "is assigned";
            // 
            // mProgressBarMilestone
            // 
            this.mProgressBarMilestone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mProgressBarMilestone.Location = new System.Drawing.Point(309, 3);
            this.mProgressBarMilestone.Name = "mProgressBarMilestone";
            this.mProgressBarMilestone.Size = new System.Drawing.Size(217, 16);
            this.mProgressBarMilestone.TabIndex = 4;
            // 
            // mLabelMilestone
            // 
            this.mLabelMilestone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mLabelMilestone.AutoSize = true;
            this.mLabelMilestone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLabelMilestone.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.mLabelMilestone.Location = new System.Drawing.Point(215, 3);
            this.mLabelMilestone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelMilestone.Name = "mLabelMilestone";
            this.mLabelMilestone.Size = new System.Drawing.Size(87, 16);
            this.mLabelMilestone.TabIndex = 3;
            this.mLabelMilestone.Text = "{Milestone}";
            this.mLabelMilestone.TextChanged += new System.EventHandler(this.LabelMilestone_SizeChanged);
            // 
            // mLabelMilestoneHeader
            // 
            this.mLabelMilestoneHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mLabelMilestoneHeader.AutoSize = true;
            this.mLabelMilestoneHeader.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.mLabelMilestoneHeader.Location = new System.Drawing.Point(138, 3);
            this.mLabelMilestoneHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelMilestoneHeader.Name = "mLabelMilestoneHeader";
            this.mLabelMilestoneHeader.Size = new System.Drawing.Size(69, 16);
            this.mLabelMilestoneHeader.TabIndex = 2;
            this.mLabelMilestoneHeader.Text = "Milestone:";
            // 
            // mLabelAssignedUser
            // 
            this.mLabelAssignedUser.AutoSize = true;
            this.mLabelAssignedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLabelAssignedUser.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.mLabelAssignedUser.Location = new System.Drawing.Point(4, 3);
            this.mLabelAssignedUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelAssignedUser.Name = "mLabelAssignedUser";
            this.mLabelAssignedUser.Size = new System.Drawing.Size(50, 16);
            this.mLabelAssignedUser.TabIndex = 1;
            this.mLabelAssignedUser.Text = "{user}";
            this.mLabelAssignedUser.SizeChanged += new System.EventHandler(this.LabelAssignedUser_SizeChanged);
            // 
            // mHtmlPanel
            // 
            this.mHtmlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mHtmlPanel.AutoScroll = true;
            this.mHtmlPanel.AutoScrollMinSize = new System.Drawing.Size(529, 18);
            this.mHtmlPanel.BackColor = System.Drawing.SystemColors.Window;
            this.mHtmlPanel.Location = new System.Drawing.Point(3, 75);
            this.mHtmlPanel.Name = "mHtmlPanel";
            this.mHtmlPanel.Size = new System.Drawing.Size(529, 229);
            this.mHtmlPanel.TabIndex = 4;
            this.mHtmlPanel.Text = "htmlPanel1";
            // 
            // mLabelAuthorFooter
            // 
            this.mLabelAuthorFooter.AutoSize = true;
            this.mLabelAuthorFooter.ForeColor = System.Drawing.SystemColors.GrayText;
            this.mLabelAuthorFooter.Location = new System.Drawing.Point(75, 0);
            this.mLabelAuthorFooter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelAuthorFooter.Name = "mLabelAuthorFooter";
            this.mLabelAuthorFooter.Size = new System.Drawing.Size(190, 16);
            this.mLabelAuthorFooter.TabIndex = 5;
            this.mLabelAuthorFooter.Text = "opened this issue 15 days ago";
            // 
            // mPanelOpenStatus
            // 
            this.mPanelOpenStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mPanelOpenStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mPanelOpenStatus.Location = new System.Drawing.Point(538, 3);
            this.mPanelOpenStatus.Name = "mPanelOpenStatus";
            this.mPanelOpenStatus.Size = new System.Drawing.Size(202, 59);
            this.mPanelOpenStatus.TabIndex = 6;
            this.mPanelOpenStatus.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelOpenStatus_Paint);
            // 
            // mListBoxLabels
            // 
            this.mListBoxLabels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mListBoxLabels.BackColor = System.Drawing.SystemColors.Control;
            this.mListBoxLabels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mListBoxLabels.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mListBoxLabels.Enabled = false;
            this.mListBoxLabels.FormattingEnabled = true;
            this.mListBoxLabels.IntegralHeight = false;
            this.mListBoxLabels.ItemHeight = 25;
            this.mListBoxLabels.Location = new System.Drawing.Point(538, 102);
            this.mListBoxLabels.Name = "mListBoxLabels";
            this.mListBoxLabels.Size = new System.Drawing.Size(202, 202);
            this.mListBoxLabels.TabIndex = 7;
            this.mListBoxLabels.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBoxLabels_DrawItem);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(538, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Labels";
            // 
            // mTextPreviewViewBody
            // 
            this.mTextPreviewViewBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mTextPreviewViewBody.Location = new System.Drawing.Point(3, 104);
            this.mTextPreviewViewBody.Margin = new System.Windows.Forms.Padding(4);
            this.mTextPreviewViewBody.Name = "mTextPreviewViewBody";
            this.mTextPreviewViewBody.Size = new System.Drawing.Size(529, 162);
            this.mTextPreviewViewBody.TabIndex = 9;
            // 
            // mTextBoxTitle
            // 
            this.mTextBoxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mTextBoxTitle.Location = new System.Drawing.Point(3, 75);
            this.mTextBoxTitle.Name = "mTextBoxTitle";
            this.mTextBoxTitle.Size = new System.Drawing.Size(529, 22);
            this.mTextBoxTitle.TabIndex = 10;
            // 
            // mButtonUpdate
            // 
            this.mButtonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mButtonUpdate.Location = new System.Drawing.Point(419, 281);
            this.mButtonUpdate.Name = "mButtonUpdate";
            this.mButtonUpdate.Size = new System.Drawing.Size(113, 23);
            this.mButtonUpdate.TabIndex = 11;
            this.mButtonUpdate.Text = "Update Issue";
            this.mButtonUpdate.UseVisualStyleBackColor = true;
            this.mButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // mButtonCancel
            // 
            this.mButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mButtonCancel.ForeColor = System.Drawing.Color.Maroon;
            this.mButtonCancel.Location = new System.Drawing.Point(3, 281);
            this.mButtonCancel.Name = "mButtonCancel";
            this.mButtonCancel.Size = new System.Drawing.Size(113, 23);
            this.mButtonCancel.TabIndex = 12;
            this.mButtonCancel.Text = "Cancel";
            this.mButtonCancel.UseVisualStyleBackColor = true;
            this.mButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // IssueDetailsControlHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mLabelTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mListBoxLabels);
            this.Controls.Add(this.mPanelOpenStatus);
            this.Controls.Add(this.mLabelAuthorFooter);
            this.Controls.Add(this.mHtmlPanel);
            this.Controls.Add(this.mButtonEdit);
            this.Controls.Add(this.mLabelAuthor);
            this.Controls.Add(this.mTextPreviewViewBody);
            this.Controls.Add(this.mTextBoxTitle);
            this.Controls.Add(this.mButtonCancel);
            this.Controls.Add(this.mButtonUpdate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IssueDetailsControlHost";
            this.Size = new System.Drawing.Size(743, 307);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mLabelAuthor;
        private System.Windows.Forms.Button mButtonEdit;
        private System.Windows.Forms.Label mLabelTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar mProgressBarMilestone;
        private System.Windows.Forms.Label mLabelMilestone;
        private System.Windows.Forms.Label mLabelMilestoneHeader;
        private System.Windows.Forms.Label mLabelAssignedUser;
        private System.Windows.Forms.HtmlPanel mHtmlPanel;
        private System.Windows.Forms.Label mLabelAuthorFooter;
        private System.Windows.Forms.Label mLabelAssignedUserFooter;
        private System.Windows.Forms.Panel mPanelOpenStatus;
        private System.Windows.Forms.ListBox mListBoxLabels;
        private System.Windows.Forms.Label label1;
        private TextPreviewView mTextPreviewViewBody;
        private System.Windows.Forms.TextBox mTextBoxTitle;
        private System.Windows.Forms.Button mButtonUpdate;
        private System.Windows.Forms.Button mButtonCancel;
    }
}
