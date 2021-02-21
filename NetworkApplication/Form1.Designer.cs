namespace NetworkApplication
{
    partial class NetworkApp
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
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.BtnDownload = new System.Windows.Forms.Button();
            this.BtnChooseDir = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDownloadDir = new System.Windows.Forms.Label();
            this.displayFormat = new System.Windows.Forms.DomainUpDown();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUrl.Location = new System.Drawing.Point(0, 0);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(480, 20);
            this.txtUrl.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblHost);
            this.groupBox1.Controls.Add(this.lblSize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Info";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(54, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 5;
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(35, 67);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(0, 13);
            this.lblHost.TabIndex = 4;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(85, 43);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(0, 13);
            this.lblSize.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Host: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "File Size (Bytes):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filename:";
            // 
            // BtnCheck
            // 
            this.BtnCheck.Location = new System.Drawing.Point(275, 35);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(193, 23);
            this.BtnCheck.TabIndex = 2;
            this.BtnCheck.Text = "Check File";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // BtnDownload
            // 
            this.BtnDownload.Location = new System.Drawing.Point(275, 64);
            this.BtnDownload.Name = "BtnDownload";
            this.BtnDownload.Size = new System.Drawing.Size(193, 23);
            this.BtnDownload.TabIndex = 3;
            this.BtnDownload.Text = "Download File";
            this.BtnDownload.UseVisualStyleBackColor = true;
            this.BtnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // BtnChooseDir
            // 
            this.BtnChooseDir.Location = new System.Drawing.Point(275, 93);
            this.BtnChooseDir.Name = "BtnChooseDir";
            this.BtnChooseDir.Size = new System.Drawing.Size(193, 23);
            this.BtnChooseDir.TabIndex = 4;
            this.BtnChooseDir.Text = "Choose Download Directory";
            this.BtnChooseDir.UseVisualStyleBackColor = true;
            this.BtnChooseDir.Click += new System.EventHandler(this.BtnChooseDir_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Download Directory: ";
            // 
            // lblDownloadDir
            // 
            this.lblDownloadDir.AutoSize = true;
            this.lblDownloadDir.Location = new System.Drawing.Point(110, 129);
            this.lblDownloadDir.Name = "lblDownloadDir";
            this.lblDownloadDir.Size = new System.Drawing.Size(0, 13);
            this.lblDownloadDir.TabIndex = 6;
            // 
            // displayFormat
            // 
            this.displayFormat.Items.Add("KB");
            this.displayFormat.Items.Add("MB");
            this.displayFormat.Items.Add("GB");
            this.displayFormat.Location = new System.Drawing.Point(348, 122);
            this.displayFormat.Name = "displayFormat";
            this.displayFormat.ReadOnly = true;
            this.displayFormat.Size = new System.Drawing.Size(120, 20);
            this.displayFormat.TabIndex = 7;
            this.displayFormat.Text = "domainUpDown1";
            // 
            // NetworkApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 151);
            this.Controls.Add(this.displayFormat);
            this.Controls.Add(this.lblDownloadDir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnChooseDir);
            this.Controls.Add(this.BtnDownload);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NetworkApp";
            this.Text = "Network App";
            this.Load += new System.EventHandler(this.NetworkApp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.Button BtnDownload;
        private System.Windows.Forms.Button BtnChooseDir;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDownloadDir;
        private System.Windows.Forms.DomainUpDown displayFormat;
    }
}

