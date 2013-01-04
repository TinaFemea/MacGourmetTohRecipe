namespace MacGourmetReader
{
    partial class MacGourmetReader
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
            this.label1 = new System.Windows.Forms.Label();
            this.fileNameTB = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.recipeLB = new System.Windows.Forms.ListBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.filterTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.flickrTB = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database:";
            // 
            // fileNameTB
            // 
            this.fileNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameTB.Location = new System.Drawing.Point(11, 34);
            this.fileNameTB.Name = "fileNameTB";
            this.fileNameTB.Size = new System.Drawing.Size(502, 20);
            this.fileNameTB.TabIndex = 1;
            // 
            // browseButton
            // 
            this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButton.Location = new System.Drawing.Point(519, 31);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // recipeLB
            // 
            this.recipeLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.recipeLB.FormattingEnabled = true;
            this.recipeLB.Location = new System.Drawing.Point(17, 158);
            this.recipeLB.Name = "recipeLB";
            this.recipeLB.Size = new System.Drawing.Size(597, 199);
            this.recipeLB.TabIndex = 3;
            // 
            // convertButton
            // 
            this.convertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.convertButton.Location = new System.Drawing.Point(538, 371);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filter Names:";
            // 
            // filterTB
            // 
            this.filterTB.Location = new System.Drawing.Point(11, 74);
            this.filterTB.Name = "filterTB";
            this.filterTB.Size = new System.Drawing.Size(583, 20);
            this.filterTB.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.openButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.filterTB);
            this.groupBox1.Controls.Add(this.browseButton);
            this.groupBox1.Controls.Add(this.fileNameTB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 130);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File";
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(519, 100);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 7;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "flickr URL";
            // 
            // flickrTB
            // 
            this.flickrTB.Location = new System.Drawing.Point(83, 372);
            this.flickrTB.Name = "flickrTB";
            this.flickrTB.Size = new System.Drawing.Size(443, 20);
            this.flickrTB.TabIndex = 9;
            // 
            // MacGourmetReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 417);
            this.Controls.Add(this.flickrTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.recipeLB);
            this.Controls.Add(this.groupBox1);
            this.Name = "MacGourmetReader";
            this.Text = "MacGourmetReader";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileNameTB;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.ListBox recipeLB;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filterTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox flickrTB;
    }
}

