﻿namespace retrieve_files
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.downloadAllBtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.downloadAll = new System.Windows.Forms.Button();
            this.categoriesListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.downloadSelected = new System.Windows.Forms.Button();
            this.filesListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Remember = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userKey = new System.Windows.Forms.TextBox();
            this.showFilesButton = new System.Windows.Forms.Button();
            this.browseBtn = new System.Windows.Forms.Button();
            this.downloadPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 105);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(716, 571);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.downloadAllBtn);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.downloadAll);
            this.panel1.Controls.Add(this.categoriesListBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 565);
            this.panel1.TabIndex = 0;
            // 
            // downloadAllBtn
            // 
            this.downloadAllBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadAllBtn.Location = new System.Drawing.Point(220, 508);
            this.downloadAllBtn.Name = "downloadAllBtn";
            this.downloadAllBtn.Size = new System.Drawing.Size(129, 23);
            this.downloadAllBtn.TabIndex = 5;
            this.downloadAllBtn.Text = "Download All";
            this.downloadAllBtn.UseVisualStyleBackColor = true;
            this.downloadAllBtn.Click += new System.EventHandler(this.downloadAllBtn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 575);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(164, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Do not create category folder";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // downloadAll
            // 
            this.downloadAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadAll.Location = new System.Drawing.Point(6, 508);
            this.downloadAll.Name = "downloadAll";
            this.downloadAll.Size = new System.Drawing.Size(208, 23);
            this.downloadAll.TabIndex = 2;
            this.downloadAll.Text = "Download all files in selected category";
            this.downloadAll.UseVisualStyleBackColor = true;
            this.downloadAll.Click += new System.EventHandler(this.downloadAll_Click);
            // 
            // categoriesListBox
            // 
            this.categoriesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoriesListBox.FormattingEnabled = true;
            this.categoriesListBox.Location = new System.Drawing.Point(6, 16);
            this.categoriesListBox.Name = "categoriesListBox";
            this.categoriesListBox.Size = new System.Drawing.Size(343, 485);
            this.categoriesListBox.TabIndex = 1;
            this.categoriesListBox.SelectedIndexChanged += new System.EventHandler(this.categoriesListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Categories";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.downloadSelected);
            this.panel2.Controls.Add(this.filesListBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(361, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 565);
            this.panel2.TabIndex = 1;
            // 
            // downloadSelected
            // 
            this.downloadSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadSelected.Location = new System.Drawing.Point(3, 508);
            this.downloadSelected.Name = "downloadSelected";
            this.downloadSelected.Size = new System.Drawing.Size(343, 23);
            this.downloadSelected.TabIndex = 5;
            this.downloadSelected.Text = "Download Selected File(s)";
            this.downloadSelected.UseVisualStyleBackColor = true;
            this.downloadSelected.Click += new System.EventHandler(this.downloadSelected_Click);
            // 
            // filesListBox
            // 
            this.filesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesListBox.FormattingEnabled = true;
            this.filesListBox.Location = new System.Drawing.Point(3, 16);
            this.filesListBox.Name = "filesListBox";
            this.filesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.filesListBox.Size = new System.Drawing.Size(343, 485);
            this.filesListBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Files";
            // 
            // Remember
            // 
            this.Remember.AutoSize = true;
            this.Remember.Location = new System.Drawing.Point(15, 47);
            this.Remember.Name = "Remember";
            this.Remember.Size = new System.Drawing.Size(77, 17);
            this.Remember.TabIndex = 4;
            this.Remember.Text = "Remember";
            this.Remember.UseVisualStyleBackColor = true;
            this.Remember.CheckedChanged += new System.EventHandler(this.Remember_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Account Weak Key:";
            // 
            // userKey
            // 
            this.userKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userKey.Location = new System.Drawing.Point(15, 25);
            this.userKey.Name = "userKey";
            this.userKey.Size = new System.Drawing.Size(632, 20);
            this.userKey.TabIndex = 1;
            this.userKey.TextChanged += new System.EventHandler(this.userKey_TextChanged);
            // 
            // showFilesButton
            // 
            this.showFilesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showFilesButton.Location = new System.Drawing.Point(653, 23);
            this.showFilesButton.Name = "showFilesButton";
            this.showFilesButton.Size = new System.Drawing.Size(75, 23);
            this.showFilesButton.TabIndex = 2;
            this.showFilesButton.Text = "Show Files";
            this.showFilesButton.UseVisualStyleBackColor = true;
            this.showFilesButton.Click += new System.EventHandler(this.showFilesButton_Click);
            // 
            // browseBtn
            // 
            this.browseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseBtn.Location = new System.Drawing.Point(653, 81);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(75, 23);
            this.browseBtn.TabIndex = 7;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // downloadPath
            // 
            this.downloadPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadPath.Location = new System.Drawing.Point(15, 83);
            this.downloadPath.Name = "downloadPath";
            this.downloadPath.Size = new System.Drawing.Size(632, 20);
            this.downloadPath.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Download path:";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(740, 688);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.downloadPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Remember);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.showFilesButton);
            this.Controls.Add(this.userKey);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Distributed Data and Media Processing | Data Retriever";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button downloadAll;
        private System.Windows.Forms.ListBox categoriesListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button downloadSelected;
        private System.Windows.Forms.ListBox filesListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button downloadAllBtn;
        private System.Windows.Forms.CheckBox Remember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userKey;
        private System.Windows.Forms.Button showFilesButton;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.TextBox downloadPath;
        private System.Windows.Forms.Label label4;
    }
}

