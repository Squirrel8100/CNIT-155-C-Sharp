namespace In_Lab03
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSemester1 = new System.Windows.Forms.Label();
            this.lblSemester2 = new System.Windows.Forms.Label();
            this.lblSemester3 = new System.Windows.Forms.Label();
            this.lblSemester4 = new System.Windows.Forms.Label();
            this.lblCollege = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSemester1 = new System.Windows.Forms.TextBox();
            this.txtSemester2 = new System.Windows.Forms.TextBox();
            this.txtSemester3 = new System.Windows.Forms.TextBox();
            this.txtSemester4 = new System.Windows.Forms.TextBox();
            this.cboCollege = new System.Windows.Forms.ComboBox();
            this.btnSummary = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(150, 62);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Full Name:";
            this.lblName.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblSemester1
            // 
            this.lblSemester1.AutoSize = true;
            this.lblSemester1.Location = new System.Drawing.Point(119, 93);
            this.lblSemester1.Name = "lblSemester1";
            this.lblSemester1.Size = new System.Drawing.Size(88, 13);
            this.lblSemester1.TabIndex = 1;
            this.lblSemester1.Text = "Semester 1 GPA:";
            // 
            // lblSemester2
            // 
            this.lblSemester2.AutoSize = true;
            this.lblSemester2.Location = new System.Drawing.Point(119, 121);
            this.lblSemester2.Name = "lblSemester2";
            this.lblSemester2.Size = new System.Drawing.Size(88, 13);
            this.lblSemester2.TabIndex = 2;
            this.lblSemester2.Text = "Semester 2 GPA:";
            // 
            // lblSemester3
            // 
            this.lblSemester3.AutoSize = true;
            this.lblSemester3.Location = new System.Drawing.Point(119, 149);
            this.lblSemester3.Name = "lblSemester3";
            this.lblSemester3.Size = new System.Drawing.Size(88, 13);
            this.lblSemester3.TabIndex = 3;
            this.lblSemester3.Text = "Semester 3 GPA:";
            // 
            // lblSemester4
            // 
            this.lblSemester4.AutoSize = true;
            this.lblSemester4.Location = new System.Drawing.Point(119, 179);
            this.lblSemester4.Name = "lblSemester4";
            this.lblSemester4.Size = new System.Drawing.Size(88, 13);
            this.lblSemester4.TabIndex = 4;
            this.lblSemester4.Text = "Semester 4 GPA:";
            // 
            // lblCollege
            // 
            this.lblCollege.AutoSize = true;
            this.lblCollege.Location = new System.Drawing.Point(119, 209);
            this.lblCollege.Name = "lblCollege";
            this.lblCollege.Size = new System.Drawing.Size(45, 13);
            this.lblCollege.TabIndex = 5;
            this.lblCollege.Text = "College:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(213, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtSemester1
            // 
            this.txtSemester1.Location = new System.Drawing.Point(213, 93);
            this.txtSemester1.Name = "txtSemester1";
            this.txtSemester1.Size = new System.Drawing.Size(100, 20);
            this.txtSemester1.TabIndex = 7;
            // 
            // txtSemester2
            // 
            this.txtSemester2.Location = new System.Drawing.Point(213, 121);
            this.txtSemester2.Name = "txtSemester2";
            this.txtSemester2.Size = new System.Drawing.Size(100, 20);
            this.txtSemester2.TabIndex = 8;
            // 
            // txtSemester3
            // 
            this.txtSemester3.Location = new System.Drawing.Point(213, 146);
            this.txtSemester3.Name = "txtSemester3";
            this.txtSemester3.Size = new System.Drawing.Size(100, 20);
            this.txtSemester3.TabIndex = 9;
            // 
            // txtSemester4
            // 
            this.txtSemester4.Location = new System.Drawing.Point(213, 179);
            this.txtSemester4.Name = "txtSemester4";
            this.txtSemester4.Size = new System.Drawing.Size(100, 20);
            this.txtSemester4.TabIndex = 10;
            // 
            // cboCollege
            // 
            this.cboCollege.AutoCompleteCustomSource.AddRange(new string[] {
            "College Of Pharmacy",
            "College Of Poly Tech",
            "College of Agriculture",
            "College Of Engineering"});
            this.cboCollege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCollege.FormattingEnabled = true;
            this.cboCollege.Items.AddRange(new object[] {
            "College Of Pharmacy",
            "College Of Engineering",
            "College Of Poly Tech",
            "College Of Agriculture"});
            this.cboCollege.Location = new System.Drawing.Point(213, 209);
            this.cboCollege.Name = "cboCollege";
            this.cboCollege.Size = new System.Drawing.Size(121, 21);
            this.cboCollege.TabIndex = 11;
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(122, 250);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(75, 23);
            this.btnSummary.TabIndex = 12;
            this.btnSummary.Text = "&Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.BtnSummary_Click);
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(203, 250);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(75, 23);
            this.btnAverage.TabIndex = 13;
            this.btnAverage.Text = "&Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.BtnAverage_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(284, 250);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(365, 250);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.Button3_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(122, 308);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(318, 130);
            this.txtOutput.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.cboCollege);
            this.Controls.Add(this.txtSemester4);
            this.Controls.Add(this.txtSemester3);
            this.Controls.Add(this.txtSemester2);
            this.Controls.Add(this.txtSemester1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCollege);
            this.Controls.Add(this.lblSemester4);
            this.Controls.Add(this.lblSemester3);
            this.Controls.Add(this.lblSemester2);
            this.Controls.Add(this.lblSemester1);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "InLab03 By Logan Fish";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSemester1;
        private System.Windows.Forms.Label lblSemester2;
        private System.Windows.Forms.Label lblSemester3;
        private System.Windows.Forms.Label lblSemester4;
        private System.Windows.Forms.Label lblCollege;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSemester1;
        private System.Windows.Forms.TextBox txtSemester2;
        private System.Windows.Forms.TextBox txtSemester3;
        private System.Windows.Forms.TextBox txtSemester4;
        private System.Windows.Forms.ComboBox cboCollege;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

