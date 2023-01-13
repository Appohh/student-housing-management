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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
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
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtFirstName.Location = new System.Drawing.Point(26, 121);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(6);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderText = "Firstname";
            this.txtFirstName.Size = new System.Drawing.Size(261, 47);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.Visible = false;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.ForeColor = System.Drawing.Color.Black;
            this.txtLastName.Location = new System.Drawing.Point(26, 183);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(6);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceholderText = "Lastname";
            this.txtLastName.Size = new System.Drawing.Size(261, 47);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(328, 183);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(261, 47);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(328, 124);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.Size = new System.Drawing.Size(316, 47);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Visible = false;
            // 
            // btnRegister
            // 
            this.btnRegister.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnRegister.Location = new System.Drawing.Point(262, 252);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(6);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(230, 59);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Submit";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Visible = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnShowRegister
            // 
            this.btnShowRegister.Location = new System.Drawing.Point(26, 49);
            this.btnShowRegister.Margin = new System.Windows.Forms.Padding(6);
            this.btnShowRegister.Name = "btnShowRegister";
            this.btnShowRegister.Size = new System.Drawing.Size(302, 59);
            this.btnShowRegister.TabIndex = 6;
            this.btnShowRegister.Text = "Create new Person";
            this.btnShowRegister.UseVisualStyleBackColor = true;
            this.btnShowRegister.Click += new System.EventHandler(this.btnShowRegister_Click);
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Location = new System.Drawing.Point(107, 260);
            this.cbAdmin.Margin = new System.Windows.Forms.Padding(6);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(143, 45);
            this.cbAdmin.TabIndex = 8;
            this.cbAdmin.Text = "Admin";
            this.cbAdmin.UseVisualStyleBackColor = true;
            this.cbAdmin.Visible = false;
            // 
            // btnShowTaskCreate
            // 
            this.btnShowTaskCreate.Location = new System.Drawing.Point(26, 359);
            this.btnShowTaskCreate.Margin = new System.Windows.Forms.Padding(6);
            this.btnShowTaskCreate.Name = "btnShowTaskCreate";
            this.btnShowTaskCreate.Size = new System.Drawing.Size(302, 59);
            this.btnShowTaskCreate.TabIndex = 14;
            this.btnShowTaskCreate.Text = "Create tasks";
            this.btnShowTaskCreate.UseVisualStyleBackColor = true;
            this.btnShowTaskCreate.Click += new System.EventHandler(this.btnShowTaskCreate_Click);
            // 
            // btnCreateTask
            // 
            this.btnCreateTask.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCreateTask.Location = new System.Drawing.Point(1124, 684);
            this.btnCreateTask.Margin = new System.Windows.Forms.Padding(6);
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.Size = new System.Drawing.Size(230, 59);
            this.btnCreateTask.TabIndex = 13;
            this.btnCreateTask.Text = "Submit";
            this.btnCreateTask.UseVisualStyleBackColor = true;
            this.btnCreateTask.Visible = false;
            this.btnCreateTask.Click += new System.EventHandler(this.btnCreateTask_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(26, 498);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(6);
            this.txtDescription.MaxLength = 100;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceholderText = "Description";
            this.txtDescription.Size = new System.Drawing.Size(448, 225);
            this.txtDescription.TabIndex = 10;
            this.txtDescription.Visible = false;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(26, 430);
            this.txtName.Margin = new System.Windows.Forms.Padding(6);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "TaskName";
            this.txtName.Size = new System.Drawing.Size(448, 47);
            this.txtName.TabIndex = 9;
            this.txtName.Visible = false;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(491, 495);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(6);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(527, 47);
            this.dtpStartDate.TabIndex = 15;
            this.dtpStartDate.Visible = false;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Location = new System.Drawing.Point(491, 623);
            this.dtpDueDate.Margin = new System.Windows.Forms.Padding(6);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(527, 47);
            this.dtpDueDate.TabIndex = 16;
            this.dtpDueDate.Visible = false;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblStartDate.ForeColor = System.Drawing.SystemColors.Window;
            this.lblStartDate.Location = new System.Drawing.Point(491, 433);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(137, 41);
            this.lblStartDate.TabIndex = 17;
            this.lblStartDate.Text = "Startdate";
            this.lblStartDate.Visible = false;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDueDate.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDueDate.Location = new System.Drawing.Point(491, 576);
            this.lblDueDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(131, 41);
            this.lblDueDate.TabIndex = 18;
            this.lblDueDate.Text = "Duedate";
            this.lblDueDate.Visible = false;
            // 
            // nudCycle
            // 
            this.nudCycle.BackColor = System.Drawing.SystemColors.Window;
            this.nudCycle.Location = new System.Drawing.Point(1035, 498);
            this.nudCycle.Margin = new System.Windows.Forms.Padding(6);
            this.nudCycle.Name = "nudCycle";
            this.nudCycle.Size = new System.Drawing.Size(319, 47);
            this.nudCycle.TabIndex = 19;
            this.nudCycle.Visible = false;
            // 
            // lblCycle
            // 
            this.lblCycle.AutoSize = true;
            this.lblCycle.BackColor = System.Drawing.Color.Transparent;
            this.lblCycle.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCycle.Location = new System.Drawing.Point(1035, 451);
            this.lblCycle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCycle.Name = "lblCycle";
            this.lblCycle.Size = new System.Drawing.Size(89, 41);
            this.lblCycle.TabIndex = 20;
            this.lblCycle.Text = "Cycle";
            this.lblCycle.Visible = false;
            // 
            // cbPerson
            // 
            this.cbPerson.FormattingEnabled = true;
            this.cbPerson.Location = new System.Drawing.Point(1035, 623);
            this.cbPerson.Margin = new System.Windows.Forms.Padding(6);
            this.cbPerson.Name = "cbPerson";
            this.cbPerson.Size = new System.Drawing.Size(316, 49);
            this.cbPerson.TabIndex = 21;
            this.cbPerson.Visible = false;
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.BackColor = System.Drawing.Color.Transparent;
            this.lblPerson.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPerson.Location = new System.Drawing.Point(1035, 576);
            this.lblPerson.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(257, 41);
            this.lblPerson.TabIndex = 22;
            this.lblPerson.Text = "Assign to (Person)";
            this.lblPerson.Visible = false;
            // 
            // cbTasks
            // 
            this.cbTasks.BackColor = System.Drawing.Color.White;
            this.cbTasks.ForeColor = System.Drawing.Color.Black;
            this.cbTasks.FormattingEnabled = true;
            this.cbTasks.Location = new System.Drawing.Point(26, 786);
            this.cbTasks.Margin = new System.Windows.Forms.Padding(6);
            this.cbTasks.Name = "cbTasks";
            this.cbTasks.Size = new System.Drawing.Size(206, 49);
            this.cbTasks.TabIndex = 23;
            this.cbTasks.Visible = false;
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteTask.Location = new System.Drawing.Point(244, 780);
            this.btnDeleteTask.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(230, 59);
            this.btnDeleteTask.TabIndex = 24;
            this.btnDeleteTask.Text = "Delete";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Visible = false;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnDeletePerson
            // 
            this.btnDeletePerson.BackColor = System.Drawing.SystemColors.Window;
            this.btnDeletePerson.ForeColor = System.Drawing.Color.Red;
            this.btnDeletePerson.Location = new System.Drawing.Point(752, 183);
            this.btnDeletePerson.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeletePerson.Name = "btnDeletePerson";
            this.btnDeletePerson.Size = new System.Drawing.Size(230, 59);
            this.btnDeletePerson.TabIndex = 26;
            this.btnDeletePerson.Text = "Delete";
            this.btnDeletePerson.UseVisualStyleBackColor = false;
            this.btnDeletePerson.Visible = false;
            this.btnDeletePerson.Click += new System.EventHandler(this.btnDeletePerson_Click);
            // 
            // cbPersonPerson
            // 
            this.cbPersonPerson.BackColor = System.Drawing.Color.White;
            this.cbPersonPerson.ForeColor = System.Drawing.Color.Black;
            this.cbPersonPerson.FormattingEnabled = true;
            this.cbPersonPerson.Location = new System.Drawing.Point(761, 124);
            this.cbPersonPerson.Margin = new System.Windows.Forms.Padding(6);
            this.cbPersonPerson.Name = "cbPersonPerson";
            this.cbPersonPerson.Size = new System.Drawing.Size(206, 49);
            this.cbPersonPerson.TabIndex = 25;
            this.cbPersonPerson.Visible = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1574, 922);
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
            this.Margin = new System.Windows.Forms.Padding(6);
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