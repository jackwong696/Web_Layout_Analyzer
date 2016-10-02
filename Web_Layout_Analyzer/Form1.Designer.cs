namespace Web_Layout_Analyzer
{
    partial class Form1
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.listBoxElements = new System.Windows.Forms.ListBox();
            this.listBoxIndex = new System.Windows.Forms.ListBox();
            this.listBoxAttribute = new System.Windows.Forms.ListBox();
            this.lblElements = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.Label();
            this.lblAttribute = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txtText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(11, 304);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Start Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // listBoxElements
            // 
            this.listBoxElements.FormattingEnabled = true;
            this.listBoxElements.Location = new System.Drawing.Point(12, 49);
            this.listBoxElements.Name = "listBoxElements";
            this.listBoxElements.Size = new System.Drawing.Size(120, 251);
            this.listBoxElements.TabIndex = 1;
            this.listBoxElements.SelectedIndexChanged += new System.EventHandler(this.listBoxElements_SelectedIndexChanged);
            // 
            // listBoxIndex
            // 
            this.listBoxIndex.FormattingEnabled = true;
            this.listBoxIndex.Location = new System.Drawing.Point(138, 49);
            this.listBoxIndex.Name = "listBoxIndex";
            this.listBoxIndex.Size = new System.Drawing.Size(68, 251);
            this.listBoxIndex.TabIndex = 2;
            this.listBoxIndex.SelectedIndexChanged += new System.EventHandler(this.listBoxIndex_SelectedIndexChanged);
            // 
            // listBoxAttribute
            // 
            this.listBoxAttribute.FormattingEnabled = true;
            this.listBoxAttribute.Location = new System.Drawing.Point(212, 48);
            this.listBoxAttribute.Name = "listBoxAttribute";
            this.listBoxAttribute.Size = new System.Drawing.Size(236, 251);
            this.listBoxAttribute.TabIndex = 3;
            // 
            // lblElements
            // 
            this.lblElements.AutoSize = true;
            this.lblElements.Location = new System.Drawing.Point(12, 9);
            this.lblElements.Name = "lblElements";
            this.lblElements.Size = new System.Drawing.Size(59, 13);
            this.lblElements.TabIndex = 4;
            this.lblElements.Text = "Elements : ";
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(138, 9);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(42, 13);
            this.lblIndex.TabIndex = 5;
            this.lblIndex.Text = "Index : ";
            // 
            // lblAttribute
            // 
            this.lblAttribute.AutoSize = true;
            this.lblAttribute.Location = new System.Drawing.Point(212, 9);
            this.lblAttribute.Name = "lblAttribute";
            this.lblAttribute.Size = new System.Drawing.Size(60, 13);
            this.lblAttribute.TabIndex = 6;
            this.lblAttribute.Text = "Attributes : ";
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(127, 306);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(700, 20);
            this.txtUrl.TabIndex = 7;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(92, 309);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(29, 13);
            this.lblUrl.TabIndex = 8;
            this.lblUrl.Text = "Url : ";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(454, 49);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(373, 250);
            this.webBrowser1.TabIndex = 9;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // txtText
            // 
            this.txtText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtText.Location = new System.Drawing.Point(11, 333);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtText.Size = new System.Drawing.Size(816, 184);
            this.txtText.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 529);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lblAttribute);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.lblElements);
            this.Controls.Add(this.listBoxAttribute);
            this.Controls.Add(this.listBoxIndex);
            this.Controls.Add(this.listBoxElements);
            this.Controls.Add(this.btnSearch);
            this.Name = "Form1";
            this.Text = "Elements Finder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox listBoxElements;
        private System.Windows.Forms.ListBox listBoxIndex;
        private System.Windows.Forms.ListBox listBoxAttribute;
        private System.Windows.Forms.Label lblElements;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Label lblAttribute;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox txtText;
    }
}

