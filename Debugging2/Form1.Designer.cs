namespace Modularity_InLab
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtHeirs = new System.Windows.Forms.TextBox();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Modularity_InLab.Properties.Resources.Bill;
            this.pictureBox1.Location = new System.Drawing.Point(106, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(152, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(134, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(152, 103);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(134, 20);
            this.txtAmount.TabIndex = 2;
            // 
            // txtHeirs
            // 
            this.txtHeirs.Location = new System.Drawing.Point(153, 129);
            this.txtHeirs.Name = "txtHeirs";
            this.txtHeirs.Size = new System.Drawing.Size(133, 20);
            this.txtHeirs.TabIndex = 3;
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(83, 223);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 23);
            this.btnDivide.TabIndex = 4;
            this.btnDivide.Text = "&Compute";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.BtnDivide_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(176, 223);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(268, 223);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(106, 165);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(237, 45);
            this.txtOutput.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = " Share:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Inheritance ($):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "# of Heirs:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 258);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.txtHeirs);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modularity  By ------";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtHeirs;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

