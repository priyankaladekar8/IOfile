namespace IOfile
{
    partial class Form2
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
            this.btncreatefile = new System.Windows.Forms.Button();
            this.btndirectory = new System.Windows.Forms.Button();
            this.btnstreamwrite = new System.Windows.Forms.Button();
            this.btnstreamread = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.labelsalary = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.textread = new System.Windows.Forms.TextBox();
            this.btnbinary = new System.Windows.Forms.Button();
            this.btnbinaryread = new System.Windows.Forms.Button();
            this.btnxmlwrite = new System.Windows.Forms.Button();
            this.btnxmlread = new System.Windows.Forms.Button();
            this.btnsoapwrite = new System.Windows.Forms.Button();
            this.btnsoapread = new System.Windows.Forms.Button();
            this.btnjsonwrite = new System.Windows.Forms.Button();
            this.btnjsonread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnwrite
            // 
            this.btnwrite.Location = new System.Drawing.Point(84, 280);
            this.btnwrite.Name = "btnwrite";
            this.btnwrite.Size = new System.Drawing.Size(120, 71);
            this.btnwrite.TabIndex = 0;
            this.btnwrite.Text = "Write";
            this.btnwrite.UseVisualStyleBackColor = true;
            this.btnwrite.Click += new System.EventHandler(this.btnwrite_Click);
            // 
            // btnread
            // 
            this.btnread.Location = new System.Drawing.Point(250, 280);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(114, 71);
            this.btnread.TabIndex = 1;
            this.btnread.Text = "Read";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // btncreatefile
            // 
            this.btncreatefile.Location = new System.Drawing.Point(397, 167);
            this.btncreatefile.Name = "btncreatefile";
            this.btncreatefile.Size = new System.Drawing.Size(112, 50);
            this.btncreatefile.TabIndex = 2;
            this.btncreatefile.Text = "Create File";
            this.btncreatefile.UseVisualStyleBackColor = true;
            this.btncreatefile.Click += new System.EventHandler(this.button3_Click);
            // 
            // btndirectory
            // 
            this.btndirectory.Location = new System.Drawing.Point(397, 49);
            this.btndirectory.Name = "btndirectory";
            this.btndirectory.Size = new System.Drawing.Size(112, 56);
            this.btndirectory.TabIndex = 3;
            this.btndirectory.Text = "Create Directory";
            this.btndirectory.UseVisualStyleBackColor = true;
            this.btndirectory.Click += new System.EventHandler(this.btndirectory_Click);
            // 
            // btnstreamwrite
            // 
            this.btnstreamwrite.Location = new System.Drawing.Point(467, 280);
            this.btnstreamwrite.Name = "btnstreamwrite";
            this.btnstreamwrite.Size = new System.Drawing.Size(114, 75);
            this.btnstreamwrite.TabIndex = 4;
            this.btnstreamwrite.Text = "StreamWrite";
            this.btnstreamwrite.UseVisualStyleBackColor = true;
            this.btnstreamwrite.Click += new System.EventHandler(this.btnstreamwrite_Click);
            // 
            // btnstreamread
            // 
            this.btnstreamread.Location = new System.Drawing.Point(641, 280);
            this.btnstreamread.Name = "btnstreamread";
            this.btnstreamread.Size = new System.Drawing.Size(105, 75);
            this.btnstreamread.TabIndex = 5;
            this.btnstreamread.Text = "StreamRead";
            this.btnstreamread.UseVisualStyleBackColor = true;
            this.btnstreamread.Click += new System.EventHandler(this.btnstreamread_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Id";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Location = new System.Drawing.Point(115, 122);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(78, 16);
            this.labelname.TabIndex = 7;
            this.labelname.Text = "Enter Name";
            // 
            // labelsalary
            // 
            this.labelsalary.AutoSize = true;
            this.labelsalary.Location = new System.Drawing.Point(115, 195);
            this.labelsalary.Name = "labelsalary";
            this.labelsalary.Size = new System.Drawing.Size(46, 16);
            this.labelsalary.TabIndex = 8;
            this.labelsalary.Text = "Salary";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(212, 56);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(135, 22);
            this.txtid.TabIndex = 10;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(212, 122);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(135, 22);
            this.txtname.TabIndex = 11;
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(212, 195);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(135, 22);
            this.txtsalary.TabIndex = 12;
            // 
            // textread
            // 
            this.textread.Location = new System.Drawing.Point(577, 74);
            this.textread.Name = "textread";
            this.textread.Size = new System.Drawing.Size(169, 22);
            this.textread.TabIndex = 14;
            // 
            // btnbinary
            // 
            this.btnbinary.Location = new System.Drawing.Point(200, 421);
            this.btnbinary.Name = "btnbinary";
            this.btnbinary.Size = new System.Drawing.Size(104, 39);
            this.btnbinary.TabIndex = 15;
            this.btnbinary.Text = "Binary Write";
            this.btnbinary.UseVisualStyleBackColor = true;
            this.btnbinary.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnbinaryread
            // 
            this.btnbinaryread.Location = new System.Drawing.Point(456, 421);
            this.btnbinaryread.Name = "btnbinaryread";
            this.btnbinaryread.Size = new System.Drawing.Size(125, 39);
            this.btnbinaryread.TabIndex = 16;
            this.btnbinaryread.Text = "Binary Read";
            this.btnbinaryread.UseVisualStyleBackColor = true;
            this.btnbinaryread.Click += new System.EventHandler(this.btnbinaryread_Click);
            // 
            // btnxmlwrite
            // 
            this.btnxmlwrite.Location = new System.Drawing.Point(200, 491);
            this.btnxmlwrite.Name = "btnxmlwrite";
            this.btnxmlwrite.Size = new System.Drawing.Size(104, 37);
            this.btnxmlwrite.TabIndex = 17;
            this.btnxmlwrite.Text = "XML Write";
            this.btnxmlwrite.UseVisualStyleBackColor = true;
            this.btnxmlwrite.Click += new System.EventHandler(this.btnxmlwrite_Click);
            // 
            // btnxmlread
            // 
            this.btnxmlread.Location = new System.Drawing.Point(456, 491);
            this.btnxmlread.Name = "btnxmlread";
            this.btnxmlread.Size = new System.Drawing.Size(90, 41);
            this.btnxmlread.TabIndex = 18;
            this.btnxmlread.Text = "XML Read";
            this.btnxmlread.UseVisualStyleBackColor = true;
            this.btnxmlread.Click += new System.EventHandler(this.btnxmlread_Click);
            // 
            // btnsoapwrite
            // 
            this.btnsoapwrite.Location = new System.Drawing.Point(200, 572);
            this.btnsoapwrite.Name = "btnsoapwrite";
            this.btnsoapwrite.Size = new System.Drawing.Size(104, 42);
            this.btnsoapwrite.TabIndex = 19;
            this.btnsoapwrite.Text = "SOAP Write";
            this.btnsoapwrite.UseVisualStyleBackColor = true;
            this.btnsoapwrite.Click += new System.EventHandler(this.btnsoapwrite_Click);
            // 
            // btnsoapread
            // 
            this.btnsoapread.Location = new System.Drawing.Point(456, 572);
            this.btnsoapread.Name = "btnsoapread";
            this.btnsoapread.Size = new System.Drawing.Size(108, 42);
            this.btnsoapread.TabIndex = 20;
            this.btnsoapread.Text = "SOAP Read";
            this.btnsoapread.UseVisualStyleBackColor = true;
            this.btnsoapread.Click += new System.EventHandler(this.btnsoapread_Click);
            // 
            // btnjsonwrite
            // 
            this.btnjsonwrite.Location = new System.Drawing.Point(200, 654);
            this.btnjsonwrite.Name = "btnjsonwrite";
            this.btnjsonwrite.Size = new System.Drawing.Size(104, 40);
            this.btnjsonwrite.TabIndex = 21;
            this.btnjsonwrite.Text = "JSON Write";
            this.btnjsonwrite.UseVisualStyleBackColor = true;
            this.btnjsonwrite.Click += new System.EventHandler(this.btnjsonwrite_Click);
            // 
            // btnjsonread
            // 
            this.btnjsonread.Location = new System.Drawing.Point(456, 654);
            this.btnjsonread.Name = "btnjsonread";
            this.btnjsonread.Size = new System.Drawing.Size(108, 50);
            this.btnjsonread.TabIndex = 22;
            this.btnjsonread.Text = "JSON Read";
            this.btnjsonread.UseVisualStyleBackColor = true;
            this.btnjsonread.Click += new System.EventHandler(this.btnjsonread_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 738);
            this.Controls.Add(this.btnjsonread);
            this.Controls.Add(this.btnjsonwrite);
            this.Controls.Add(this.btnsoapread);
            this.Controls.Add(this.btnsoapwrite);
            this.Controls.Add(this.btnxmlread);
            this.Controls.Add(this.btnxmlwrite);
            this.Controls.Add(this.btnbinaryread);
            this.Controls.Add(this.btnbinary);
            this.Controls.Add(this.textread);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.labelsalary);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnstreamread);
            this.Controls.Add(this.btnstreamwrite);
            this.Controls.Add(this.btndirectory);
            this.Controls.Add(this.btncreatefile);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.btnwrite);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnwrite;
        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.Button btncreatefile;
        private System.Windows.Forms.Button btndirectory;
        private System.Windows.Forms.Button btnstreamwrite;
        private System.Windows.Forms.Button btnstreamread;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelsalary;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.TextBox textread;
        private System.Windows.Forms.Button btnbinary;
        private System.Windows.Forms.Button btnbinaryread;
        private System.Windows.Forms.Button btnxmlwrite;
        private System.Windows.Forms.Button btnxmlread;
        private System.Windows.Forms.Button btnsoapwrite;
        private System.Windows.Forms.Button btnsoapread;
        private System.Windows.Forms.Button btnjsonwrite;
        private System.Windows.Forms.Button btnjsonread;
    }
}