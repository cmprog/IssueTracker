namespace IssueTracker.App
{
    partial class NewIssueControlHost
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
            this.mTextPreviewViewBody = new IssueTracker.App.TextPreviewView();
            this.mTextBoxTitle = new System.Windows.Forms.TextBox();
            this.mButtonSubmit = new System.Windows.Forms.Button();
            this.mLabelAssigned = new System.Windows.Forms.Label();
            this.mComboBoxAssigned = new System.Windows.Forms.ComboBox();
            this.mComboBoxMilestone = new System.Windows.Forms.ComboBox();
            this.mLabelMilestone = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mListBoxLabels = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // mTextPreviewViewBody
            // 
            this.mTextPreviewViewBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mTextPreviewViewBody.Location = new System.Drawing.Point(4, 66);
            this.mTextPreviewViewBody.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.mTextPreviewViewBody.Name = "mTextPreviewViewBody";
            this.mTextPreviewViewBody.Size = new System.Drawing.Size(277, 114);
            this.mTextPreviewViewBody.TabIndex = 1;
            // 
            // mTextBoxTitle
            // 
            this.mTextBoxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mTextBoxTitle.Location = new System.Drawing.Point(4, 4);
            this.mTextBoxTitle.Margin = new System.Windows.Forms.Padding(4);
            this.mTextBoxTitle.Name = "mTextBoxTitle";
            this.mTextBoxTitle.Size = new System.Drawing.Size(278, 22);
            this.mTextBoxTitle.TabIndex = 2;
            // 
            // mButtonSubmit
            // 
            this.mButtonSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mButtonSubmit.Location = new System.Drawing.Point(68, 193);
            this.mButtonSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.mButtonSubmit.Name = "mButtonSubmit";
            this.mButtonSubmit.Size = new System.Drawing.Size(219, 28);
            this.mButtonSubmit.TabIndex = 3;
            this.mButtonSubmit.Text = "Submit new issue";
            this.mButtonSubmit.UseVisualStyleBackColor = true;
            this.mButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // mLabelAssigned
            // 
            this.mLabelAssigned.AutoSize = true;
            this.mLabelAssigned.Location = new System.Drawing.Point(3, 36);
            this.mLabelAssigned.Name = "mLabelAssigned";
            this.mLabelAssigned.Size = new System.Drawing.Size(124, 16);
            this.mLabelAssigned.TabIndex = 5;
            this.mLabelAssigned.Text = "No one is assigned";
            // 
            // mComboBoxAssigned
            // 
            this.mComboBoxAssigned.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mComboBoxAssigned.DropDownWidth = 100;
            this.mComboBoxAssigned.FormattingEnabled = true;
            this.mComboBoxAssigned.Location = new System.Drawing.Point(133, 33);
            this.mComboBoxAssigned.Name = "mComboBoxAssigned";
            this.mComboBoxAssigned.Size = new System.Drawing.Size(16, 24);
            this.mComboBoxAssigned.TabIndex = 6;
            // 
            // mComboBoxMilestone
            // 
            this.mComboBoxMilestone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mComboBoxMilestone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mComboBoxMilestone.DropDownWidth = 100;
            this.mComboBoxMilestone.FormattingEnabled = true;
            this.mComboBoxMilestone.Location = new System.Drawing.Point(266, 33);
            this.mComboBoxMilestone.Name = "mComboBoxMilestone";
            this.mComboBoxMilestone.Size = new System.Drawing.Size(16, 24);
            this.mComboBoxMilestone.TabIndex = 8;
            // 
            // mLabelMilestone
            // 
            this.mLabelMilestone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mLabelMilestone.AutoSize = true;
            this.mLabelMilestone.Location = new System.Drawing.Point(173, 36);
            this.mLabelMilestone.Name = "mLabelMilestone";
            this.mLabelMilestone.Size = new System.Drawing.Size(87, 16);
            this.mLabelMilestone.TabIndex = 7;
            this.mLabelMilestone.Text = "No milestone";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(291, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Add Labels";
            // 
            // mListBoxLabels
            // 
            this.mListBoxLabels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mListBoxLabels.BackColor = System.Drawing.SystemColors.Control;
            this.mListBoxLabels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mListBoxLabels.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mListBoxLabels.FormattingEnabled = true;
            this.mListBoxLabels.IntegralHeight = false;
            this.mListBoxLabels.ItemHeight = 25;
            this.mListBoxLabels.Location = new System.Drawing.Point(312, 36);
            this.mListBoxLabels.Name = "mListBoxLabels";
            this.mListBoxLabels.Size = new System.Drawing.Size(260, 185);
            this.mListBoxLabels.TabIndex = 10;
            this.mListBoxLabels.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxLabels_MouseClick);
            this.mListBoxLabels.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBoxLabels_DrawItem);
            // 
            // NewIssueControlHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mListBoxLabels);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mComboBoxMilestone);
            this.Controls.Add(this.mLabelMilestone);
            this.Controls.Add(this.mComboBoxAssigned);
            this.Controls.Add(this.mLabelAssigned);
            this.Controls.Add(this.mButtonSubmit);
            this.Controls.Add(this.mTextBoxTitle);
            this.Controls.Add(this.mTextPreviewViewBody);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(575, 225);
            this.Name = "NewIssueControlHost";
            this.Size = new System.Drawing.Size(575, 225);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextPreviewView mTextPreviewViewBody;
        private System.Windows.Forms.TextBox mTextBoxTitle;
        private System.Windows.Forms.Button mButtonSubmit;
        private System.Windows.Forms.Label mLabelAssigned;
        private System.Windows.Forms.ComboBox mComboBoxAssigned;
        private System.Windows.Forms.ComboBox mComboBoxMilestone;
        private System.Windows.Forms.Label mLabelMilestone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox mListBoxLabels;
    }
}
