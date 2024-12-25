namespace Chapter8
{
    partial class frmSalaryTaxCalculator
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
            this.textSalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBonus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textSpouse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NumofChild = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblLastSalary = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textSalary
            // 
            this.textSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textSalary.Location = new System.Drawing.Point(258, 71);
            this.textSalary.Name = "textSalary";
            this.textSalary.Size = new System.Drawing.Size(329, 36);
            this.textSalary.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(106, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salary:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(106, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bonus:";
            // 
            // textBonus
            // 
            this.textBonus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBonus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBonus.Location = new System.Drawing.Point(258, 115);
            this.textBonus.Name = "textBonus";
            this.textBonus.Size = new System.Drawing.Size(329, 36);
            this.textBonus.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(106, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Spouse:";
            // 
            // textSpouse
            // 
            this.textSpouse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSpouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSpouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textSpouse.Location = new System.Drawing.Point(258, 160);
            this.textSpouse.Name = "textSpouse";
            this.textSpouse.Size = new System.Drawing.Size(329, 36);
            this.textSpouse.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(106, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Num.of Childs:";
            // 
            // NumofChild
            // 
            this.NumofChild.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumofChild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumofChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.NumofChild.Location = new System.Drawing.Point(258, 206);
            this.NumofChild.Name = "NumofChild";
            this.NumofChild.Size = new System.Drawing.Size(329, 36);
            this.NumofChild.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(109, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tax";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.BackColor = System.Drawing.Color.Transparent;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTax.ForeColor = System.Drawing.Color.Red;
            this.lblTax.Location = new System.Drawing.Point(258, 276);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(52, 25);
            this.lblTax.TabIndex = 9;
            this.lblTax.Text = "Tax:";
            this.lblTax.Click += new System.EventHandler(this.lblTax_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(109, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Last Salary";
            // 
            // lblLastSalary
            // 
            this.lblLastSalary.AutoSize = true;
            this.lblLastSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLastSalary.ForeColor = System.Drawing.Color.Red;
            this.lblLastSalary.Location = new System.Drawing.Point(258, 329);
            this.lblLastSalary.Name = "lblLastSalary";
            this.lblLastSalary.Size = new System.Drawing.Size(110, 25);
            this.lblLastSalary.TabIndex = 11;
            this.lblLastSalary.Text = "Last Salary";
            this.lblLastSalary.Click += new System.EventHandler(this.lblLastSalary_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnCalculate.Location = new System.Drawing.Point(632, 115);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(133, 77);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmSalaryTaxCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 413);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblLastSalary);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumofChild);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textSpouse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBonus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSalary);
            this.Name = "frmSalaryTaxCalculator";
            this.Text = "frmSalaryTaxCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBonus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSpouse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NumofChild;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblLastSalary;
        private System.Windows.Forms.Button btnCalculate;
    }
}