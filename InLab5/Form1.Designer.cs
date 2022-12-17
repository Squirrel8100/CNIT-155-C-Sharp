namespace InLab05FishLogan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStemsNum = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStems = new System.Windows.Forms.Label();
            this.lblValentineRose = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.chkWrap = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(206, 144);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(149, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtStemsNum
            // 
            this.txtStemsNum.Location = new System.Drawing.Point(206, 188);
            this.txtStemsNum.Name = "txtStemsNum";
            this.txtStemsNum.Size = new System.Drawing.Size(149, 20);
            this.txtStemsNum.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(108, 147);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // lblStems
            // 
            this.lblStems.AutoSize = true;
            this.lblStems.Location = new System.Drawing.Point(108, 195);
            this.lblStems.Name = "lblStems";
            this.lblStems.Size = new System.Drawing.Size(58, 13);
            this.lblStems.TabIndex = 4;
            this.lblStems.Text = "# of Stems";
            // 
            // lblValentineRose
            // 
            this.lblValentineRose.AutoSize = true;
            this.lblValentineRose.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValentineRose.Location = new System.Drawing.Point(201, 36);
            this.lblValentineRose.Name = "lblValentineRose";
            this.lblValentineRose.Size = new System.Drawing.Size(148, 28);
            this.lblValentineRose.TabIndex = 5;
            this.lblValentineRose.Text = "Valentine Roses";
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(91, 412);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(75, 23);
            this.btnCompute.TabIndex = 6;
            this.btnCompute.Text = "&Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.BtnCompute_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(186, 412);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(280, 412);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(91, 259);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(264, 135);
            this.txtOutput.TabIndex = 9;
            // 
            // chkWrap
            // 
            this.chkWrap.AutoSize = true;
            this.chkWrap.Location = new System.Drawing.Point(206, 224);
            this.chkWrap.Name = "chkWrap";
            this.chkWrap.Size = new System.Drawing.Size(77, 17);
            this.chkWrap.TabIndex = 10;
            this.chkWrap.Text = "Gift Wrap?";
            this.chkWrap.UseVisualStyleBackColor = true;
            this.chkWrap.CheckedChanged += new System.EventHandler(this.ChkWrap_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 564);
            this.Controls.Add(this.chkWrap);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.lblValentineRose);
            this.Controls.Add(this.lblStems);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtStemsNum);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "InLab05 Data Visualization By Logan Fish";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtStemsNum;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStems;
        private System.Windows.Forms.Label lblValentineRose;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.CheckBox chkWrap;
    }
}

