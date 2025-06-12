namespace EmployeeManagementSystem
{
    partial class addEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.filter_emps = new System.Windows.Forms.Button();
            this.filter_emp = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.addEmployee_salary = new System.Windows.Forms.TextBox();
            this.addEmployee_position = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addEmployee_gender = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addEmployee_clearBtn = new System.Windows.Forms.Button();
            this.addEmployee_deleteBtn = new System.Windows.Forms.Button();
            this.addEmployee_updateBtn = new System.Windows.Forms.Button();
            this.addEmployee_addBtn = new System.Windows.Forms.Button();
            this.addEmployee_importBtn = new System.Windows.Forms.Button();
            this.addEmployee_picture = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addEmployee_phoneNumber = new System.Windows.Forms.TextBox();
            this.addEmployee_status = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addEmployee_fullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addEmployee_id = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addEmployee_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.filter_emps);
            this.panel1.Controls.Add(this.filter_emp);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(14, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1294, 448);
            this.panel1.TabIndex = 0;
            // 
            // filter_emps
            // 
            this.filter_emps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.filter_emps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filter_emps.FlatAppearance.BorderSize = 0;
            this.filter_emps.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.filter_emps.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.filter_emps.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.filter_emps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filter_emps.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter_emps.ForeColor = System.Drawing.Color.White;
            this.filter_emps.Location = new System.Drawing.Point(1153, -1);
            this.filter_emps.Name = "filter_emps";
            this.filter_emps.Size = new System.Drawing.Size(136, 45);
            this.filter_emps.TabIndex = 27;
            this.filter_emps.Text = "Filter";
            this.filter_emps.UseVisualStyleBackColor = false;
            this.filter_emps.Click += new System.EventHandler(this.filter_emps_Click);
            // 
            // filter_emp
            // 
            this.filter_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter_emp.FormattingEnabled = true;
            this.filter_emp.Items.AddRange(new object[] {
            "UI/UX Design.",
            "Front-End Dev.",
            "Back-End Dev.",
            "Full-Stack Dev.",
            "Android-App dev.",
            "Data Admin.",
            "Network Admin.",
            "Business Management",
            "Male",
            "Female",
            "Other\'s",
            "Active",
            "Inactive"});
            this.filter_emp.Location = new System.Drawing.Point(837, 3);
            this.filter_emp.Name = "filter_emp";
            this.filter_emp.Size = new System.Drawing.Size(310, 30);
            this.filter_emp.TabIndex = 27;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(39, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1214, 303);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(34, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 34);
            this.label5.TabIndex = 5;
            this.label5.Text = "Employee\'s Data";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.addEmployee_salary);
            this.panel2.Controls.Add(this.addEmployee_position);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.addEmployee_gender);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.addEmployee_clearBtn);
            this.panel2.Controls.Add(this.addEmployee_deleteBtn);
            this.panel2.Controls.Add(this.addEmployee_updateBtn);
            this.panel2.Controls.Add(this.addEmployee_addBtn);
            this.panel2.Controls.Add(this.addEmployee_importBtn);
            this.panel2.Controls.Add(this.addEmployee_picture);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.addEmployee_phoneNumber);
            this.panel2.Controls.Add(this.addEmployee_status);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.addEmployee_fullName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.addEmployee_id);
            this.panel2.Location = new System.Drawing.Point(14, 522);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1294, 274);
            this.panel2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 22);
            this.label8.TabIndex = 25;
            this.label8.Text = "Salary:";
            // 
            // addEmployee_salary
            // 
            this.addEmployee_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_salary.Location = new System.Drawing.Point(154, 158);
            this.addEmployee_salary.Name = "addEmployee_salary";
            this.addEmployee_salary.Size = new System.Drawing.Size(360, 28);
            this.addEmployee_salary.TabIndex = 26;
            // 
            // addEmployee_position
            // 
            this.addEmployee_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_position.FormattingEnabled = true;
            this.addEmployee_position.Items.AddRange(new object[] {
            "UI/UX Design.",
            "Front-End Dev.",
            "Back-End Dev.",
            "Full-Stack Dev.",
            "Android-App dev.",
            "Data Admin.",
            "Network Admin.",
            "Business Management"});
            this.addEmployee_position.Location = new System.Drawing.Point(652, 72);
            this.addEmployee_position.Name = "addEmployee_position";
            this.addEmployee_position.Size = new System.Drawing.Size(310, 30);
            this.addEmployee_position.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(562, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 22);
            this.label7.TabIndex = 23;
            this.label7.Text = "Position:";
            // 
            // addEmployee_gender
            // 
            this.addEmployee_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_gender.FormattingEnabled = true;
            this.addEmployee_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other\'s"});
            this.addEmployee_gender.Location = new System.Drawing.Point(652, 29);
            this.addEmployee_gender.Name = "addEmployee_gender";
            this.addEmployee_gender.Size = new System.Drawing.Size(310, 30);
            this.addEmployee_gender.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(562, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 22);
            this.label6.TabIndex = 21;
            this.label6.Text = "Gender:";
            // 
            // addEmployee_clearBtn
            // 
            this.addEmployee_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addEmployee_clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_clearBtn.FlatAppearance.BorderSize = 0;
            this.addEmployee_clearBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_clearBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_clearBtn.ForeColor = System.Drawing.Color.White;
            this.addEmployee_clearBtn.Location = new System.Drawing.Point(933, 208);
            this.addEmployee_clearBtn.Name = "addEmployee_clearBtn";
            this.addEmployee_clearBtn.Size = new System.Drawing.Size(136, 45);
            this.addEmployee_clearBtn.TabIndex = 20;
            this.addEmployee_clearBtn.Text = "Clear";
            this.addEmployee_clearBtn.UseVisualStyleBackColor = false;
            this.addEmployee_clearBtn.Click += new System.EventHandler(this.addEmployee_clearBtn_Click);
            // 
            // addEmployee_deleteBtn
            // 
            this.addEmployee_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addEmployee_deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_deleteBtn.FlatAppearance.BorderSize = 0;
            this.addEmployee_deleteBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_deleteBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.addEmployee_deleteBtn.Location = new System.Drawing.Point(752, 208);
            this.addEmployee_deleteBtn.Name = "addEmployee_deleteBtn";
            this.addEmployee_deleteBtn.Size = new System.Drawing.Size(136, 45);
            this.addEmployee_deleteBtn.TabIndex = 19;
            this.addEmployee_deleteBtn.Text = "Delete";
            this.addEmployee_deleteBtn.UseVisualStyleBackColor = false;
            this.addEmployee_deleteBtn.Click += new System.EventHandler(this.addEmployee_deleteBtn_Click);
            // 
            // addEmployee_updateBtn
            // 
            this.addEmployee_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addEmployee_updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_updateBtn.FlatAppearance.BorderSize = 0;
            this.addEmployee_updateBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_updateBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_updateBtn.ForeColor = System.Drawing.Color.White;
            this.addEmployee_updateBtn.Location = new System.Drawing.Point(582, 208);
            this.addEmployee_updateBtn.Name = "addEmployee_updateBtn";
            this.addEmployee_updateBtn.Size = new System.Drawing.Size(136, 45);
            this.addEmployee_updateBtn.TabIndex = 18;
            this.addEmployee_updateBtn.Text = "Update";
            this.addEmployee_updateBtn.UseVisualStyleBackColor = false;
            this.addEmployee_updateBtn.Click += new System.EventHandler(this.addEmployee_updateBtn_Click);
            // 
            // addEmployee_addBtn
            // 
            this.addEmployee_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addEmployee_addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_addBtn.FlatAppearance.BorderSize = 0;
            this.addEmployee_addBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_addBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_addBtn.ForeColor = System.Drawing.Color.White;
            this.addEmployee_addBtn.Location = new System.Drawing.Point(400, 208);
            this.addEmployee_addBtn.Name = "addEmployee_addBtn";
            this.addEmployee_addBtn.Size = new System.Drawing.Size(136, 45);
            this.addEmployee_addBtn.TabIndex = 17;
            this.addEmployee_addBtn.Text = "Add";
            this.addEmployee_addBtn.UseVisualStyleBackColor = false;
            this.addEmployee_addBtn.Click += new System.EventHandler(this.addEmployee_addBtn_Click);
            // 
            // addEmployee_importBtn
            // 
            this.addEmployee_importBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addEmployee_importBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_importBtn.FlatAppearance.BorderSize = 0;
            this.addEmployee_importBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_importBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_importBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_importBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_importBtn.ForeColor = System.Drawing.Color.White;
            this.addEmployee_importBtn.Location = new System.Drawing.Point(1038, 117);
            this.addEmployee_importBtn.Name = "addEmployee_importBtn";
            this.addEmployee_importBtn.Size = new System.Drawing.Size(154, 34);
            this.addEmployee_importBtn.TabIndex = 16;
            this.addEmployee_importBtn.Text = "Import";
            this.addEmployee_importBtn.UseVisualStyleBackColor = false;
            this.addEmployee_importBtn.Click += new System.EventHandler(this.addEmployee_importBtn_Click);
            // 
            // addEmployee_picture
            // 
            this.addEmployee_picture.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.addEmployee_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addEmployee_picture.Location = new System.Drawing.Point(1038, 15);
            this.addEmployee_picture.Name = "addEmployee_picture";
            this.addEmployee_picture.Size = new System.Drawing.Size(155, 108);
            this.addEmployee_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addEmployee_picture.TabIndex = 15;
            this.addEmployee_picture.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Phone Num:";
            // 
            // addEmployee_phoneNumber
            // 
            this.addEmployee_phoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_phoneNumber.Location = new System.Drawing.Point(154, 120);
            this.addEmployee_phoneNumber.Name = "addEmployee_phoneNumber";
            this.addEmployee_phoneNumber.Size = new System.Drawing.Size(360, 28);
            this.addEmployee_phoneNumber.TabIndex = 14;
            // 
            // addEmployee_status
            // 
            this.addEmployee_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_status.FormattingEnabled = true;
            this.addEmployee_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.addEmployee_status.Location = new System.Drawing.Point(652, 114);
            this.addEmployee_status.Name = "addEmployee_status";
            this.addEmployee_status.Size = new System.Drawing.Size(310, 30);
            this.addEmployee_status.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(562, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Full Name:";
            // 
            // addEmployee_fullName
            // 
            this.addEmployee_fullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_fullName.Location = new System.Drawing.Point(154, 78);
            this.addEmployee_fullName.Name = "addEmployee_fullName";
            this.addEmployee_fullName.Size = new System.Drawing.Size(360, 28);
            this.addEmployee_fullName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Emp ID:";
            // 
            // addEmployee_id
            // 
            this.addEmployee_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_id.Location = new System.Drawing.Point(154, 34);
            this.addEmployee_id.Name = "addEmployee_id";
            this.addEmployee_id.Size = new System.Drawing.Size(360, 28);
            this.addEmployee_id.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // addEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "addEmployee";
            this.Size = new System.Drawing.Size(1328, 882);
            this.Load += new System.EventHandler(this.addEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addEmployee_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addEmployee_id;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addEmployee_phoneNumber;
        private System.Windows.Forms.ComboBox addEmployee_status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addEmployee_fullName;
        private System.Windows.Forms.Button addEmployee_clearBtn;
        private System.Windows.Forms.Button addEmployee_deleteBtn;
        private System.Windows.Forms.Button addEmployee_updateBtn;
        private System.Windows.Forms.Button addEmployee_addBtn;
        private System.Windows.Forms.Button addEmployee_importBtn;
        private System.Windows.Forms.PictureBox addEmployee_picture;
        private System.Windows.Forms.ComboBox addEmployee_gender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox addEmployee_position;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox addEmployee_salary;
        private System.Windows.Forms.Button filter_emps;
        private System.Windows.Forms.ComboBox filter_emp;
    }
}
