namespace Fernandez_RobynKristoffer_2F1
{
    partial class mainForm
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
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.employeeType = new System.Windows.Forms.ComboBox();
            this.numberTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.isTandC = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.requiredName = new System.Windows.Forms.Label();
            this.requiredPosition = new System.Windows.Forms.Label();
            this.requiredAbsent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTxt
            // 
            this.nameTxt.BackColor = System.Drawing.SystemColors.Window;
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.nameTxt.Location = new System.Drawing.Point(32, 71);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(221, 24);
            this.nameTxt.TabIndex = 0;
            this.nameTxt.Click += new System.EventHandler(this.nameTxt_Click);
            // 
            // employeeType
            // 
            this.employeeType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.employeeType.FormattingEnabled = true;
            this.employeeType.Items.AddRange(new object[] {
            "Job Order (JO)",
            "Contract of Service (COS)",
            "Permanent"});
            this.employeeType.Location = new System.Drawing.Point(32, 142);
            this.employeeType.Name = "employeeType";
            this.employeeType.Size = new System.Drawing.Size(221, 26);
            this.employeeType.TabIndex = 1;
            this.employeeType.Click += new System.EventHandler(this.employeeType_Click);
            // 
            // numberTxt
            // 
            this.numberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.numberTxt.Location = new System.Drawing.Point(32, 212);
            this.numberTxt.Name = "numberTxt";
            this.numberTxt.Size = new System.Drawing.Size(221, 24);
            this.numberTxt.TabIndex = 0;
            this.numberTxt.Click += new System.EventHandler(this.numberTxt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = " Number of Absences";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Activity: Salary Computation of Government Employees";
            // 
            // isTandC
            // 
            this.isTandC.AutoSize = true;
            this.isTandC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.isTandC.Location = new System.Drawing.Point(50, 291);
            this.isTandC.Name = "isTandC";
            this.isTandC.Size = new System.Drawing.Size(15, 14);
            this.isTandC.TabIndex = 4;
            this.isTandC.UseVisualStyleBackColor = true;
            this.isTandC.Click += new System.EventHandler(this.isTandC_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Accept the";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Location = new System.Drawing.Point(125, 291);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(104, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "terms and conditions";
            // 
            // calculateBtn
            // 
            this.calculateBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.calculateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculateBtn.FlatAppearance.BorderSize = 0;
            this.calculateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.calculateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.calculateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.calculateBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calculateBtn.Location = new System.Drawing.Point(32, 317);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.calculateBtn.Size = new System.Drawing.Size(221, 41);
            this.calculateBtn.TabIndex = 6;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = false;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);

            // requiredName
            // 
            this.requiredName.AutoSize = true;
            this.requiredName.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Bold);
            this.requiredName.ForeColor = System.Drawing.Color.Red;
            this.requiredName.Location = new System.Drawing.Point(30, 98);
            this.requiredName.Name = "requiredName";
            this.requiredName.Size = new System.Drawing.Size(101, 12);
            this.requiredName.TabIndex = 7;
            this.requiredName.Text = "                                ";
            this.requiredName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // requiredPosition
            // 
            this.requiredPosition.AutoSize = true;
            this.requiredPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Bold);
            this.requiredPosition.ForeColor = System.Drawing.Color.Red;
            this.requiredPosition.Location = new System.Drawing.Point(30, 171);
            this.requiredPosition.Name = "requiredPosition";
            this.requiredPosition.Size = new System.Drawing.Size(101, 12);
            this.requiredPosition.TabIndex = 7;
            this.requiredPosition.Text = "                                ";
            this.requiredPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // requiredAbsent
            // 
            this.requiredAbsent.AutoSize = true;
            this.requiredAbsent.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Bold);
            this.requiredAbsent.ForeColor = System.Drawing.Color.Red;
            this.requiredAbsent.Location = new System.Drawing.Point(30, 239);
            this.requiredAbsent.Name = "requiredAbsent";
            this.requiredAbsent.Size = new System.Drawing.Size(101, 12);
            this.requiredAbsent.TabIndex = 7;
            this.requiredAbsent.Text = "                                ";
            this.requiredAbsent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 382);
            this.Controls.Add(this.requiredAbsent);
            this.Controls.Add(this.requiredPosition);
            this.Controls.Add(this.requiredName);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.isTandC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeeType);
            this.Controls.Add(this.numberTxt);
            this.Controls.Add(this.nameTxt);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.ComboBox employeeType;
        private System.Windows.Forms.TextBox numberTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox isTandC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label requiredName;
        private System.Windows.Forms.Label requiredPosition;
        private System.Windows.Forms.Label requiredAbsent;
    }
}

