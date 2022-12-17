namespace InLab04_Fish
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
            this.lblCount = new System.Windows.Forms.Label();
            this.txtOrderCount = new System.Windows.Forms.TextBox();
            this.cboToppings = new System.Windows.Forms.ComboBox();
            this.lblToppings = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtOrderOutput = new System.Windows.Forms.TextBox();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(27, 44);
            this.lblCount.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(38, 13);
            this.lblCount.TabIndex = 0;
            this.lblCount.Text = "Count:";
            this.lblCount.Click += new System.EventHandler(this.lblCount_Click);
            // 
            // txtOrderCount
            // 
            this.txtOrderCount.Location = new System.Drawing.Point(78, 44);
            this.txtOrderCount.Margin = new System.Windows.Forms.Padding(1);
            this.txtOrderCount.Name = "txtOrderCount";
            this.txtOrderCount.Size = new System.Drawing.Size(75, 20);
            this.txtOrderCount.TabIndex = 1;
            this.txtOrderCount.TextChanged += new System.EventHandler(this.txtOrder_TextChanged);
            // 
            // cboToppings
            // 
            this.cboToppings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboToppings.FormattingEnabled = true;
            this.cboToppings.Items.AddRange(new object[] {
            "Meat Lovers",
            "Veggie",
            "Pepperoni",
            "Sausage",
            "Mushroom",
            "Plain"});
            this.cboToppings.Location = new System.Drawing.Point(78, 76);
            this.cboToppings.Margin = new System.Windows.Forms.Padding(1);
            this.cboToppings.Name = "cboToppings";
            this.cboToppings.Size = new System.Drawing.Size(75, 21);
            this.cboToppings.TabIndex = 2;
            this.cboToppings.SelectedIndexChanged += new System.EventHandler(this.cboToppings_SelectedIndexChanged);
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Location = new System.Drawing.Point(13, 78);
            this.lblToppings.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(54, 13);
            this.lblToppings.TabIndex = 3;
            this.lblToppings.Text = "Toppings:";
            this.lblToppings.Click += new System.EventHandler(this.lblToppings_Click);
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(219, 115);
            this.btnCompute.Margin = new System.Windows.Forms.Padding(1);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(51, 22);
            this.btnCompute.TabIndex = 4;
            this.btnCompute.Text = "&Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(219, 150);
            this.btnClear.Margin = new System.Windows.Forms.Padding(1);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(51, 22);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(219, 187);
            this.btnExit.Margin = new System.Windows.Forms.Padding(1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(51, 22);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtOrderOutput
            // 
            this.txtOrderOutput.Location = new System.Drawing.Point(198, 232);
            this.txtOrderOutput.Margin = new System.Windows.Forms.Padding(1);
            this.txtOrderOutput.Name = "txtOrderOutput";
            this.txtOrderOutput.ReadOnly = true;
            this.txtOrderOutput.Size = new System.Drawing.Size(75, 20);
            this.txtOrderOutput.TabIndex = 7;
            this.txtOrderOutput.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Location = new System.Drawing.Point(129, 233);
            this.lblOrderNum.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(63, 13);
            this.lblOrderNum.TabIndex = 8;
            this.lblOrderNum.Text = "# of Orders:";
            this.lblOrderNum.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(30, 115);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(1);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(180, 102);
            this.txtOutput.TabIndex = 9;
            this.txtOutput.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(182, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 285);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblOrderNum);
            this.Controls.Add(this.txtOrderOutput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.cboToppings);
            this.Controls.Add(this.txtOrderCount);
            this.Controls.Add(this.lblCount);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "In Lab 4 By Logan Fish";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox txtOrderCount;
        private System.Windows.Forms.ComboBox cboToppings;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtOrderOutput;
        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

