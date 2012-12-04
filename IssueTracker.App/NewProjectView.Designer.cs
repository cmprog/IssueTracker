namespace IssueTracker.App
{
    partial class NewProjectView
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
            this.mButtonCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mTextPreviewViewBody
            // 
            this.mTextPreviewViewBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTextPreviewViewBody.Location = new System.Drawing.Point(5, 33);
            this.mTextPreviewViewBody.Margin = new System.Windows.Forms.Padding(5);
            this.mTextPreviewViewBody.Name = "mTextPreviewViewBody";
            this.mTextPreviewViewBody.Size = new System.Drawing.Size(319, 150);
            this.mTextPreviewViewBody.TabIndex = 0;
            // 
            // mTextBoxTitle
            // 
            this.mTextBoxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTextBoxTitle.Location = new System.Drawing.Point(3, 3);
            this.mTextBoxTitle.Name = "mTextBoxTitle";
            this.mTextBoxTitle.Size = new System.Drawing.Size(321, 22);
            this.mTextBoxTitle.TabIndex = 1;
            // 
            // mButtonCreate
            // 
            this.mButtonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mButtonCreate.Location = new System.Drawing.Point(149, 191);
            this.mButtonCreate.Name = "mButtonCreate";
            this.mButtonCreate.Size = new System.Drawing.Size(175, 23);
            this.mButtonCreate.TabIndex = 2;
            this.mButtonCreate.Text = "Create New Project";
            this.mButtonCreate.UseVisualStyleBackColor = true;
            this.mButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // NewProjectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mButtonCreate);
            this.Controls.Add(this.mTextBoxTitle);
            this.Controls.Add(this.mTextPreviewViewBody);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewProjectView";
            this.Size = new System.Drawing.Size(329, 217);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextPreviewView mTextPreviewViewBody;
        private System.Windows.Forms.TextBox mTextBoxTitle;
        private System.Windows.Forms.Button mButtonCreate;
    }
}
