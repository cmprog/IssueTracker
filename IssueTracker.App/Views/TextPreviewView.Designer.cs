namespace IssueTracker.App.Views
{
    partial class TextPreviewView
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
            this.mTabControl = new System.Windows.Forms.TabControl();
            this.mTabPageWrite = new System.Windows.Forms.TabPage();
            this.mTabPagePreview = new System.Windows.Forms.TabPage();
            this.mWebBrowserPreview = new System.Windows.Forms.WebBrowser();
            this.mTextBoxUserInput = new System.Windows.Forms.TextBox();
            this.mTabControl.SuspendLayout();
            this.mTabPageWrite.SuspendLayout();
            this.mTabPagePreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // mTabControl
            // 
            this.mTabControl.Controls.Add(this.mTabPageWrite);
            this.mTabControl.Controls.Add(this.mTabPagePreview);
            this.mTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTabControl.Location = new System.Drawing.Point(0, 0);
            this.mTabControl.Name = "mTabControl";
            this.mTabControl.SelectedIndex = 0;
            this.mTabControl.Size = new System.Drawing.Size(400, 208);
            this.mTabControl.TabIndex = 0;
            this.mTabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TabControl_Selecting);
            // 
            // mTabPageWrite
            // 
            this.mTabPageWrite.Controls.Add(this.mTextBoxUserInput);
            this.mTabPageWrite.Location = new System.Drawing.Point(4, 25);
            this.mTabPageWrite.Name = "mTabPageWrite";
            this.mTabPageWrite.Padding = new System.Windows.Forms.Padding(3);
            this.mTabPageWrite.Size = new System.Drawing.Size(392, 179);
            this.mTabPageWrite.TabIndex = 0;
            this.mTabPageWrite.Text = "Write";
            this.mTabPageWrite.UseVisualStyleBackColor = true;
            // 
            // mTabPagePreview
            // 
            this.mTabPagePreview.Controls.Add(this.mWebBrowserPreview);
            this.mTabPagePreview.Location = new System.Drawing.Point(4, 25);
            this.mTabPagePreview.Name = "mTabPagePreview";
            this.mTabPagePreview.Padding = new System.Windows.Forms.Padding(3);
            this.mTabPagePreview.Size = new System.Drawing.Size(392, 179);
            this.mTabPagePreview.TabIndex = 1;
            this.mTabPagePreview.Text = "Preview";
            this.mTabPagePreview.UseVisualStyleBackColor = true;
            // 
            // mWebBrowserPreview
            // 
            this.mWebBrowserPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mWebBrowserPreview.Location = new System.Drawing.Point(3, 3);
            this.mWebBrowserPreview.MinimumSize = new System.Drawing.Size(20, 20);
            this.mWebBrowserPreview.Name = "mWebBrowserPreview";
            this.mWebBrowserPreview.Size = new System.Drawing.Size(386, 173);
            this.mWebBrowserPreview.TabIndex = 0;
            // 
            // mTextBoxUserInput
            // 
            this.mTextBoxUserInput.AcceptsReturn = true;
            this.mTextBoxUserInput.AcceptsTab = true;
            this.mTextBoxUserInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTextBoxUserInput.Location = new System.Drawing.Point(3, 3);
            this.mTextBoxUserInput.Multiline = true;
            this.mTextBoxUserInput.Name = "mTextBoxUserInput";
            this.mTextBoxUserInput.Size = new System.Drawing.Size(386, 173);
            this.mTextBoxUserInput.TabIndex = 0;
            // 
            // TextPreviewView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mTabControl);
            this.Name = "TextPreviewView";
            this.Size = new System.Drawing.Size(400, 208);
            this.mTabControl.ResumeLayout(false);
            this.mTabPageWrite.ResumeLayout(false);
            this.mTabPageWrite.PerformLayout();
            this.mTabPagePreview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mTabControl;
        private System.Windows.Forms.TabPage mTabPageWrite;
        private System.Windows.Forms.TabPage mTabPagePreview;
        private System.Windows.Forms.TextBox mTextBoxUserInput;
        private System.Windows.Forms.WebBrowser mWebBrowserPreview;
    }
}
