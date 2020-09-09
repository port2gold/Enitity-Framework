namespace Employee
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxProduct = new System.Windows.Forms.ListBox();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.buttonAddDept = new System.Windows.Forms.Button();
            this.buttonUpdateDept = new System.Windows.Forms.Button();
            this.buttonDeleteDept = new System.Windows.Forms.Button();
            this.buttonUpdateEmp = new System.Windows.Forms.Button();
            this.buttonDeleteEmp = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.buttonAbove = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonGroup = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxProduct
            // 
            this.listBoxProduct.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxProduct.FormattingEnabled = true;
            this.listBoxProduct.ItemHeight = 23;
            this.listBoxProduct.Location = new System.Drawing.Point(48, 38);
            this.listBoxProduct.Name = "listBoxProduct";
            this.listBoxProduct.Size = new System.Drawing.Size(321, 280);
            this.listBoxProduct.TabIndex = 1;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonAddProduct.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddProduct.Location = new System.Drawing.Point(48, 683);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(139, 42);
            this.buttonAddProduct.TabIndex = 2;
            this.buttonAddProduct.Text = "Add Employee";
            this.buttonAddProduct.UseVisualStyleBackColor = false;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(394, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(325, 280);
            this.listBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 344);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 4;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(66, 344);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(80, 20);
            this.labelProductName.TabIndex = 5;
            this.labelProductName.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Last Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(171, 387);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(171, 436);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(171, 487);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 27);
            this.textBox4.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 535);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Salary";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(171, 532);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(125, 27);
            this.textBox5.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Department Name";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(565, 365);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(154, 27);
            this.textBox6.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 578);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Department";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(171, 571);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(125, 27);
            this.textBox7.TabIndex = 4;
            // 
            // buttonAddDept
            // 
            this.buttonAddDept.BackColor = System.Drawing.Color.Lime;
            this.buttonAddDept.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddDept.Location = new System.Drawing.Point(403, 446);
            this.buttonAddDept.Name = "buttonAddDept";
            this.buttonAddDept.Size = new System.Drawing.Size(152, 54);
            this.buttonAddDept.TabIndex = 2;
            this.buttonAddDept.Text = "Add Department";
            this.buttonAddDept.UseVisualStyleBackColor = false;
            this.buttonAddDept.Click += new System.EventHandler(this.buttonAddDept_Click);
            // 
            // buttonUpdateDept
            // 
            this.buttonUpdateDept.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonUpdateDept.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonUpdateDept.Location = new System.Drawing.Point(583, 446);
            this.buttonUpdateDept.Name = "buttonUpdateDept";
            this.buttonUpdateDept.Size = new System.Drawing.Size(152, 54);
            this.buttonUpdateDept.TabIndex = 2;
            this.buttonUpdateDept.Text = "Update Department";
            this.buttonUpdateDept.UseVisualStyleBackColor = false;
            this.buttonUpdateDept.Click += new System.EventHandler(this.buttonUpdateDept_Click);
            // 
            // buttonDeleteDept
            // 
            this.buttonDeleteDept.BackColor = System.Drawing.Color.Crimson;
            this.buttonDeleteDept.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteDept.Location = new System.Drawing.Point(484, 532);
            this.buttonDeleteDept.Name = "buttonDeleteDept";
            this.buttonDeleteDept.Size = new System.Drawing.Size(202, 54);
            this.buttonDeleteDept.TabIndex = 2;
            this.buttonDeleteDept.Text = "Delete Department";
            this.buttonDeleteDept.UseVisualStyleBackColor = false;
            this.buttonDeleteDept.Click += new System.EventHandler(this.buttonDeleteDept_Click);
            // 
            // buttonUpdateEmp
            // 
            this.buttonUpdateEmp.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonUpdateEmp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonUpdateEmp.Location = new System.Drawing.Point(230, 683);
            this.buttonUpdateEmp.Name = "buttonUpdateEmp";
            this.buttonUpdateEmp.Size = new System.Drawing.Size(160, 42);
            this.buttonUpdateEmp.TabIndex = 2;
            this.buttonUpdateEmp.Text = "Update Employee";
            this.buttonUpdateEmp.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteEmp
            // 
            this.buttonDeleteEmp.BackColor = System.Drawing.Color.Crimson;
            this.buttonDeleteEmp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteEmp.Location = new System.Drawing.Point(136, 731);
            this.buttonDeleteEmp.Name = "buttonDeleteEmp";
            this.buttonDeleteEmp.Size = new System.Drawing.Size(183, 42);
            this.buttonDeleteEmp.TabIndex = 2;
            this.buttonDeleteEmp.Text = "Delete Employee";
            this.buttonDeleteEmp.UseVisualStyleBackColor = false;
            this.buttonDeleteEmp.Click += new System.EventHandler(this.buttonDeleteEmp_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 621);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Hire Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(171, 616);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(125, 27);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(448, 650);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Get Department ID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(670, 646);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(75, 27);
            this.textBox8.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Department ID";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(565, 406);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(154, 27);
            this.textBox9.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(448, 707);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "Get Employee ID";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(670, 707);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(75, 27);
            this.textBox10.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 660);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Employee ID";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(171, 653);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(125, 27);
            this.textBox11.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(916, 474);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(286, 52);
            this.button3.TabIndex = 9;
            this.button3.Text = "Get Employee And Department";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 23;
            this.listBox2.Location = new System.Drawing.Point(819, 23);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(468, 418);
            this.listBox2.TabIndex = 10;
            // 
            // buttonAbove
            // 
            this.buttonAbove.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAbove.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAbove.Location = new System.Drawing.Point(916, 535);
            this.buttonAbove.Name = "buttonAbove";
            this.buttonAbove.Size = new System.Drawing.Size(286, 52);
            this.buttonAbove.TabIndex = 11;
            this.buttonAbove.Text = "Get Employee with Salary Above 150000";
            this.buttonAbove.UseVisualStyleBackColor = false;
            this.buttonAbove.Click += new System.EventHandler(this.buttonAbove_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(146, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 25);
            this.label10.TabIndex = 5;
            this.label10.Text = "Employee";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(517, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 25);
            this.label11.TabIndex = 5;
            this.label11.Text = "Department";
            // 
            // buttonGroup
            // 
            this.buttonGroup.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGroup.Location = new System.Drawing.Point(916, 605);
            this.buttonGroup.Name = "buttonGroup";
            this.buttonGroup.Size = new System.Drawing.Size(286, 52);
            this.buttonGroup.TabIndex = 12;
            this.buttonGroup.Text = "Group Employee By Department";
            this.buttonGroup.UseVisualStyleBackColor = false;
            this.buttonGroup.Click += new System.EventHandler(this.buttonGroup_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(916, 663);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(286, 52);
            this.button4.TabIndex = 13;
            this.button4.Text = "Department Not Assigned Employee";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(916, 731);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(286, 52);
            this.button5.TabIndex = 13;
            this.button5.Text = "Employee And DepartmentAssigned And Not Assigned";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button4_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(980, -5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 25);
            this.label12.TabIndex = 5;
            this.label12.Text = "Fetch Result View";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1333, 785);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonGroup);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonAbove);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonDeleteEmp);
            this.Controls.Add(this.buttonUpdateEmp);
            this.Controls.Add(this.buttonDeleteDept);
            this.Controls.Add(this.buttonUpdateDept);
            this.Controls.Add(this.buttonAddDept);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.listBoxProduct);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ListBox listBoxProduct;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button buttonAddDept;
        private System.Windows.Forms.Button buttonUpdateDept;
        private System.Windows.Forms.Button buttonDeleteDept;
        private System.Windows.Forms.Button buttonUpdateEmp;
        private System.Windows.Forms.Button buttonDeleteEmp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button buttonAbove;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonGroup;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label12;
    }
}

