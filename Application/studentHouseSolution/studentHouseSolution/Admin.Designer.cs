namespace studentHouseSolution
{
    partial class Admin
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnShowRegister = new System.Windows.Forms.Button();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.btnShowTaskCreate = new System.Windows.Forms.Button();
            this.btnCreateTask = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.nudCycle = new System.Windows.Forms.NumericUpDown();
            this.lblCycle = new System.Windows.Forms.Label();
            this.cbPerson = new System.Windows.Forms.ComboBox();
            this.lblPerson = new System.Windows.Forms.Label();
            this.cbTasks = new System.Windows.Forms.ComboBox();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnDeletePerson = new System.Windows.Forms.Button();
            this.cbPersonPerson = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCycle)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(12, 59);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderText = "Firstname";
            this.txtFirstName.Size = new System.Drawing.Size(125, 27);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.Visible = false;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(143, 59);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceholderText = "Lastname";
            this.txtLastName.Size = new System.Drawing.Size(125, 27);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(431, 59);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(125, 27);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(274, 59);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.Size = new System.Drawing.Size(151, 27);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Visible = false;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(160, 24);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(108, 29);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Submit";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Visible = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnShowRegister
            // 
            this.btnShowRegister.Location = new System.Drawing.Point(12, 24);
            this.btnShowRegister.Name = "btnShowRegister";
            this.btnShowRegister.Size = new System.Drawing.Size(142, 29);
            this.btnShowRegister.TabIndex = 6;
            this.btnShowRegister.Text = "Person tools";
            this.btnShowRegister.UseVisualStyleBackColor = true;
            this.btnShowRegister.Click += new System.EventHandler(this.btnShowRegister_Click);
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Location = new System.Drawing.Point(562, 62);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(75, 24);
            this.cbAdmin.TabIndex = 8;
            this.cbAdmin.Text = "Admin";
            this.cbAdmin.UseVisualStyleBackColor = true;
            this.cbAdmin.Visible = false;
            // 
            // btnShowTaskCreate
            // 
            this.btnShowTaskCreate.Location = new System.Drawing.Point(12, 92);
            this.btnShowTaskCreate.Name = "btnShowTaskCreate";
            this.btnShowTaskCreate.Size = new System.Drawing.Size(142, 29);
            this.btnShowTaskCreate.TabIndex = 14;
            this.btnShowTaskCreate.Text = "Task tools";
            this.btnShowTaskCreate.UseVisualStyleBackColor = true;
            this.btnShowTaskCreate.Click += new System.EventHandler(this.btnShowTaskCreate_Click);
            // 
            // btnCreateTask
            // 
            this.btnCreateTask.Location = new System.Drawing.Point(160, 92);
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.Size = new System.Drawing.Size(108, 29);
            this.btnCreateTask.TabIndex = 13;
            this.btnCreateTask.Text = "Submit";
            this.btnCreateTask.UseVisualStyleBackColor = true;
            this.btnCreateTask.Visible = false;
            this.btnCreateTask.Click += new System.EventHandler(this.btnCreateTask_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 160);
            this.txtDescription.MaxLength = 100;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceholderText = "Description";
            this.txtDescription.Size = new System.Drawing.Size(213, 112);
            this.txtDescription.TabIndex = 10;
            this.txtDescription.Visible = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 127);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Name";
            this.txtName.Size = new System.Drawing.Size(213, 27);
            this.txtName.TabIndex = 9;
            this.txtName.Visible = false;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(231, 159);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(250, 27);
            this.dtpStartDate.TabIndex = 15;
            this.dtpStartDate.Visible = false;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Location = new System.Drawing.Point(231, 221);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(250, 27);
            this.dtpDueDate.TabIndex = 16;
            this.dtpDueDate.Visible = false;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(231, 133);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(70, 20);
            this.lblStartDate.TabIndex = 17;
            this.lblStartDate.Text = "Startdate";
            this.lblStartDate.Visible = false;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(231, 198);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(66, 20);
            this.lblDueDate.TabIndex = 18;
            this.lblDueDate.Text = "Duedate";
            this.lblDueDate.Visible = false;
            // 
            // nudCycle
            // 
            this.nudCycle.Location = new System.Drawing.Point(487, 160);
            this.nudCycle.Name = "nudCycle";
            this.nudCycle.Size = new System.Drawing.Size(150, 27);
            this.nudCycle.TabIndex = 19;
            this.nudCycle.Visible = false;
            // 
            // lblCycle
            // 
            this.lblCycle.AutoSize = true;
            this.lblCycle.Location = new System.Drawing.Point(487, 137);
            this.lblCycle.Name = "lblCycle";
            this.lblCycle.Size = new System.Drawing.Size(44, 20);
            this.lblCycle.TabIndex = 20;
            this.lblCycle.Text = "Cycle";
            this.lblCycle.Visible = false;
            // 
            // cbPerson
            // 
            this.cbPerson.FormattingEnabled = true;
            this.cbPerson.Location = new System.Drawing.Point(487, 221);
            this.cbPerson.Name = "cbPerson";
            this.cbPerson.Size = new System.Drawing.Size(151, 28);
            this.cbPerson.TabIndex = 21;
            this.cbPerson.Visible = false;
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Location = new System.Drawing.Point(487, 198);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(52, 20);
            this.lblPerson.TabIndex = 22;
            this.lblPerson.Text = "Person";
            this.lblPerson.Visible = false;
            // 
            // cbTasks
            // 
            this.cbTasks.FormattingEnabled = true;
            this.cbTasks.Location = new System.Drawing.Point(274, 93);
            this.cbTasks.Name = "cbTasks";
            this.cbTasks.Size = new System.Drawing.Size(99, 28);
            this.cbTasks.TabIndex = 23;
            this.cbTasks.Visible = false;
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Location = new System.Drawing.Point(379, 93);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(108, 29);
            this.btnDeleteTask.TabIndex = 24;
            this.btnDeleteTask.Text = "Delete";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Visible = false;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnDeletePerson
            // 
            this.btnDeletePerson.Location = new System.Drawing.Point(379, 25);
            this.btnDeletePerson.Name = "btnDeletePerson";
            this.btnDeletePerson.Size = new System.Drawing.Size(108, 29);
            this.btnDeletePerson.TabIndex = 26;
            this.btnDeletePerson.Text = "Delete";
            this.btnDeletePerson.UseVisualStyleBackColor = true;
            this.btnDeletePerson.Visible = false;
            this.btnDeletePerson.Click += new System.EventHandler(this.btnDeletePerson_Click);
            // 
            // cbPersonPerson
            // 
            this.cbPersonPerson.FormattingEnabled = true;
            this.cbPersonPerson.Location = new System.Drawing.Point(274, 25);
            this.cbPersonPerson.Name = "cbPersonPerson";
            this.cbPersonPerson.Size = new System.Drawing.Size(99, 28);
            this.cbPersonPerson.TabIndex = 25;
            this.cbPersonPerson.Visible = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeletePerson);
            this.Controls.Add(this.cbPersonPerson);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.cbTasks);
            this.Controls.Add(this.lblPerson);
            this.Controls.Add(this.cbPerson);
            this.Controls.Add(this.lblCycle);
            this.Controls.Add(this.nudCycle);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.btnShowTaskCreate);
            this.Controls.Add(this.btnCreateTask);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cbAdmin);
            this.Controls.Add(this.btnShowRegister);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.nudCycle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Button btnRegister;
        private Button btnShowRegister;
        private CheckBox cbAdmin;
        private Button btnShowTaskCreate;
        private Button btnCreateTask;
        private TextBox txtDescription;
        private TextBox txtName;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpDueDate;
        private Label lblStartDate;
        private Label lblDueDate;
        private NumericUpDown nudCycle;
        private Label lblCycle;
        private ComboBox cbPerson;
        private Label lblPerson;
        private ComboBox cbTasks;
        private Button btnDeleteTask;
        private Button btnDeletePerson;
        private ComboBox cbPersonPerson;
    }
}