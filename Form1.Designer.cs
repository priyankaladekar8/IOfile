namespace IOfile
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
            this.btnwrite = new System.Windows.Forms.Button();
            this.btnread = new System.Windows.Forms.Button();
            this.labelname = new System.Windows.Forms.Label();
            this.labelmarks = new System.Windows.Forms.Label();
            this.labelpercentage = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtMarks = new System.Windows.Forms.TextBox();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.btnsreamwrite = new System.Windows.Forms.Button();
            this.btnstreamread = new System.Windows.Forms.Button();
            this.btnbinarywrite = new System.Windows.Forms.Button();
            this.btnbinaryread = new System.Windows.Forms.Button();
            this.btnxmlread = new System.Windows.Forms.Button();
            this.btnxmlwrite = new System.Windows.Forms.Button();
            this.btnsoapread = new System.Windows.Forms.Button();
            this.btnsoapwrite = new System.Windows.Forms.Button();
            this.btnjsonwrite = new System.Windows.Forms.Button();
            this.btnjsonread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnwrite
            // 
            this.btnwrite.Location = new System.Drawing.Point(207, 252);
            this.btnwrite.Name = "btnwrite";
            this.btnwrite.Size = new System.Drawing.Size(95, 42);
            this.btnwrite.TabIndex = 0;
            this.btnwrite.Text = "Write";
            this.btnwrite.UseVisualStyleBackColor = true;
            this.btnwrite.Click += new System.EventHandler(this.btnwrite_Click);
            // 
            // btnread
            // 
            this.btnread.Location = new System.Drawing.Point(349, 252);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(90, 42);
            this.btnread.TabIndex = 1;
            this.btnread.Text = "Read";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Location = new System.Drawing.Point(238, 47);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(44, 16);
            this.labelname.TabIndex = 2;
            this.labelname.Text = "Name";
            // 
            // labelmarks
            // 
            this.labelmarks.AutoSize = true;
            this.labelmarks.Location = new System.Drawing.Point(238, 105);
            this.labelmarks.Name = "labelmarks";
            this.labelmarks.Size = new System.Drawing.Size(44, 16);
            this.labelmarks.TabIndex = 3;
            this.labelmarks.Text = "Marks";
            // 
            // labelpercentage
            // 
            this.labelpercentage.AutoSize = true;
            this.labelpercentage.Location = new System.Drawing.Point(238, 157);
            this.labelpercentage.Name = "labelpercentage";
            this.labelpercentage.Size = new System.Drawing.Size(77, 16);
            this.labelpercentage.TabIndex = 4;
            this.labelpercentage.Text = "Percentage";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(364, 41);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 22);
            this.txtname.TabIndex = 5;
            // 
            // txtMarks
            // 
            this.txtMarks.Location = new System.Drawing.Point(364, 99);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(100, 22);
            this.txtMarks.TabIndex = 6;
            // 
            // txtPercentage
            // 
            this.txtPercentage.Location = new System.Drawing.Point(364, 151);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(100, 22);
            this.txtPercentage.TabIndex = 7;
            // 
            // btnsreamwrite
            // 
            this.btnsreamwrite.Location = new System.Drawing.Point(487, 252);
            this.btnsreamwrite.Name = "btnsreamwrite";
            this.btnsreamwrite.Size = new System.Drawing.Size(88, 42);
            this.btnsreamwrite.TabIndex = 8;
            this.btnsreamwrite.Text = "SreamWrite";
            this.btnsreamwrite.UseVisualStyleBackColor = true;
            this.btnsreamwrite.Click += new System.EventHandler(this.btnsreamwrite_Click);
            // 
            // btnstreamread
            // 
            this.btnstreamread.Location = new System.Drawing.Point(607, 252);
            this.btnstreamread.Name = "btnstreamread";
            this.btnstreamread.Size = new System.Drawing.Size(100, 42);
            this.btnstreamread.TabIndex = 9;
            this.btnstreamread.Text = "SreamRead";
            this.btnstreamread.UseVisualStyleBackColor = true;
            this.btnstreamread.Click += new System.EventHandler(this.btnstreamread_Click);
            // 
            // btnbinarywrite
            // 
            this.btnbinarywrite.Location = new System.Drawing.Point(241, 398);
            this.btnbinarywrite.Name = "btnbinarywrite";
            this.btnbinarywrite.Size = new System.Drawing.Size(115, 44);
            this.btnbinarywrite.TabIndex = 10;
            this.btnbinarywrite.Text = "BinaryWrite";
            this.btnbinarywrite.UseVisualStyleBackColor = true;
            this.btnbinarywrite.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnbinaryread
            // 
            this.btnbinaryread.Location = new System.Drawing.Point(389, 398);
            this.btnbinaryread.Name = "btnbinaryread";
            this.btnbinaryread.Size = new System.Drawing.Size(115, 44);
            this.btnbinaryread.TabIndex = 11;
            this.btnbinaryread.Text = "Binary Read";
            this.btnbinaryread.UseVisualStyleBackColor = true;
            this.btnbinaryread.Click += new System.EventHandler(this.btnbinaryread_Click);
            // 
            // btnxmlread
            // 
            this.btnxmlread.Location = new System.Drawing.Point(389, 470);
            this.btnxmlread.Name = "btnxmlread";
            this.btnxmlread.Size = new System.Drawing.Size(115, 40);
            this.btnxmlread.TabIndex = 12;
            this.btnxmlread.Text = "XML Read";
            this.btnxmlread.UseVisualStyleBackColor = true;
            this.btnxmlread.Click += new System.EventHandler(this.btnxmlread_Click);
            // 
            // btnxmlwrite
            // 
            this.btnxmlwrite.Location = new System.Drawing.Point(247, 470);
            this.btnxmlwrite.Name = "btnxmlwrite";
            this.btnxmlwrite.Size = new System.Drawing.Size(109, 40);
            this.btnxmlwrite.TabIndex = 13;
            this.btnxmlwrite.Text = "XMl Write";
            this.btnxmlwrite.UseVisualStyleBackColor = true;
            this.btnxmlwrite.Click += new System.EventHandler(this.btnxmlwrite_Click);
            // 
            // btnsoapread
            // 
            this.btnsoapread.Location = new System.Drawing.Point(389, 538);
            this.btnsoapread.Name = "btnsoapread";
            this.btnsoapread.Size = new System.Drawing.Size(115, 46);
            this.btnsoapread.TabIndex = 14;
            this.btnsoapread.Text = "SOAP Read";
            this.btnsoapread.UseVisualStyleBackColor = true;
            this.btnsoapread.Click += new System.EventHandler(this.btnsoapread_Click);
            // 
            // btnsoapwrite
            // 
            this.btnsoapwrite.Location = new System.Drawing.Point(247, 538);
            this.btnsoapwrite.Name = "btnsoapwrite";
            this.btnsoapwrite.Size = new System.Drawing.Size(109, 46);
            this.btnsoapwrite.TabIndex = 15;
            this.btnsoapwrite.Text = "SOAP Write";
            this.btnsoapwrite.UseVisualStyleBackColor = true;
            this.btnsoapwrite.Click += new System.EventHandler(this.btnsoapwrite_Click);
            // 
            // btnjsonwrite
            // 
            this.btnjsonwrite.Location = new System.Drawing.Point(247, 607);
            this.btnjsonwrite.Name = "btnjsonwrite";
            this.btnjsonwrite.Size = new System.Drawing.Size(92, 45);
            this.btnjsonwrite.TabIndex = 16;
            this.btnjsonwrite.Text = "JSON Write";
            this.btnjsonwrite.UseVisualStyleBackColor = true;
            this.btnjsonwrite.Click += new System.EventHandler(this.btnjsonwrite_Click);
            // 
            // btnjsonread
            // 
            this.btnjsonread.Location = new System.Drawing.Point(389, 607);
            this.btnjsonread.Name = "btnjsonread";
            this.btnjsonread.Size = new System.Drawing.Size(102, 45);
            this.btnjsonread.TabIndex = 17;
            this.btnjsonread.Text = "JSON Read";
            this.btnjsonread.UseVisualStyleBackColor = true;
            this.btnjsonread.Click += new System.EventHandler(this.btnjsonread_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 727);
            this.Controls.Add(this.btnjsonread);
            this.Controls.Add(this.btnjsonwrite);
            this.Controls.Add(this.btnsoapwrite);
            this.Controls.Add(this.btnsoapread);
            this.Controls.Add(this.btnxmlwrite);
            this.Controls.Add(this.btnxmlread);
            this.Controls.Add(this.btnbinaryread);
            this.Controls.Add(this.btnbinarywrite);
            this.Controls.Add(this.btnstreamread);
            this.Controls.Add(this.btnsreamwrite);
            this.Controls.Add(this.txtPercentage);
            this.Controls.Add(this.txtMarks);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.labelpercentage);
            this.Controls.Add(this.labelmarks);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.btnwrite);
            this.Name = "Form1";
            this.Text = "Student IOForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnwrite;
        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelmarks;
        private System.Windows.Forms.Label labelpercentage;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtMarks;
        private System.Windows.Forms.TextBox txtPercentage;
        private System.Windows.Forms.Button btnsreamwrite;
        private System.Windows.Forms.Button btnstreamread;
        private System.Windows.Forms.Button btnbinarywrite;
        private System.Windows.Forms.Button btnbinaryread;
        private System.Windows.Forms.Button btnxmlread;
        private System.Windows.Forms.Button btnxmlwrite;
        private System.Windows.Forms.Button btnsoapread;
        private System.Windows.Forms.Button btnsoapwrite;
        private System.Windows.Forms.Button btnjsonwrite;
        private System.Windows.Forms.Button btnjsonread;
    }
}