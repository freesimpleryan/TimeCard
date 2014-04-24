namespace TimeCard
{
    partial class UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.textBox_entry = new System.Windows.Forms.TextBox();
            this.label_success = new System.Windows.Forms.Label();
            this.button_submit = new System.Windows.Forms.Button();
            this.button_fileOpen = new System.Windows.Forms.Button();
            this.label_filePath = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.checkBox_24Hour = new System.Windows.Forms.CheckBox();
            this.checkBox_seconds = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textBox_entry
            // 
            this.textBox_entry.Location = new System.Drawing.Point(12, 12);
            this.textBox_entry.Name = "textBox_entry";
            this.textBox_entry.Size = new System.Drawing.Size(260, 20);
            this.textBox_entry.TabIndex = 0;
            // 
            // label_success
            // 
            this.label_success.AutoSize = true;
            this.label_success.Location = new System.Drawing.Point(12, 39);
            this.label_success.Name = "label_success";
            this.label_success.Size = new System.Drawing.Size(0, 13);
            this.label_success.TabIndex = 1;
            // 
            // button_submit
            // 
            this.button_submit.Enabled = false;
            this.button_submit.Location = new System.Drawing.Point(12, 56);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(75, 23);
            this.button_submit.TabIndex = 2;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // button_fileOpen
            // 
            this.button_fileOpen.Location = new System.Drawing.Point(196, 55);
            this.button_fileOpen.Name = "button_fileOpen";
            this.button_fileOpen.Size = new System.Drawing.Size(75, 23);
            this.button_fileOpen.TabIndex = 3;
            this.button_fileOpen.Text = "Open";
            this.button_fileOpen.UseVisualStyleBackColor = true;
            this.button_fileOpen.Click += new System.EventHandler(this.button_fileOpen_Click);
            // 
            // label_filePath
            // 
            this.label_filePath.AutoSize = true;
            this.label_filePath.Location = new System.Drawing.Point(9, 82);
            this.label_filePath.Name = "label_filePath";
            this.label_filePath.Size = new System.Drawing.Size(32, 13);
            this.label_filePath.TabIndex = 4;
            this.label_filePath.Text = "Path:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.CheckFileExists = false;
            this.openFileDialog1.DefaultExt = "csv";
            this.openFileDialog1.Filter = "CSV files|*.csv";
            // 
            // checkBox_24Hour
            // 
            this.checkBox_24Hour.AutoSize = true;
            this.checkBox_24Hour.Location = new System.Drawing.Point(12, 101);
            this.checkBox_24Hour.Name = "checkBox_24Hour";
            this.checkBox_24Hour.Size = new System.Drawing.Size(126, 17);
            this.checkBox_24Hour.TabIndex = 5;
            this.checkBox_24Hour.Text = "Enable 24 Hour Time";
            this.checkBox_24Hour.UseVisualStyleBackColor = true;
            this.checkBox_24Hour.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox_seconds
            // 
            this.checkBox_seconds.AutoSize = true;
            this.checkBox_seconds.Location = new System.Drawing.Point(167, 101);
            this.checkBox_seconds.Name = "checkBox_seconds";
            this.checkBox_seconds.Size = new System.Drawing.Size(104, 17);
            this.checkBox_seconds.TabIndex = 6;
            this.checkBox_seconds.Text = "Enable Seconds";
            this.checkBox_seconds.UseVisualStyleBackColor = true;
            this.checkBox_seconds.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(9, 121);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(82, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "About Timecard";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // UI
            // 
            this.AcceptButton = this.button_submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 140);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBox_seconds);
            this.Controls.Add(this.checkBox_24Hour);
            this.Controls.Add(this.label_filePath);
            this.Controls.Add(this.button_fileOpen);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.label_success);
            this.Controls.Add(this.textBox_entry);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UI";
            this.Text = "Timecard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UI_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_entry;
        private System.Windows.Forms.Label label_success;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.Button button_fileOpen;
        private System.Windows.Forms.Label label_filePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox checkBox_24Hour;
        private System.Windows.Forms.CheckBox checkBox_seconds;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

