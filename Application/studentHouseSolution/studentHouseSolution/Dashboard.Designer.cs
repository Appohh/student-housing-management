namespace studentHouseSolution
{
    partial class Dashboard
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.daycontainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Lbl_Date = new System.Windows.Forms.Label();
            this.txt_selected = new System.Windows.Forms.TextBox();
            this.lblLoggedInUser = new System.Windows.Forms.Label();
            this.btnGetAllTasks = new System.Windows.Forms.Button();
            this.btnGetMyTasks = new System.Windows.Forms.Button();
            this.btnAddComplaint = new System.Windows.Forms.Button();
            this.btnSeeComplaints = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(689, 92);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(660, 453);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // daycontainer
            // 
            this.daycontainer.BackColor = System.Drawing.Color.Gainsboro;
            this.daycontainer.Location = new System.Drawing.Point(25, 128);
            this.daycontainer.Margin = new System.Windows.Forms.Padding(1);
            this.daycontainer.Name = "daycontainer";
            this.daycontainer.Size = new System.Drawing.Size(514, 391);
            this.daycontainer.TabIndex = 6;
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_next.Location = new System.Drawing.Point(351, 536);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(188, 58);
            this.btn_next.TabIndex = 7;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_previous.Location = new System.Drawing.Point(25, 536);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(188, 58);
            this.btn_previous.TabIndex = 8;
            this.btn_previous.Text = "Previous";
            this.btn_previous.UseVisualStyleBackColor = false;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(25, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Monday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(94, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tuesday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(254, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Thursday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(163, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Wednesday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(383, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Saturday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(328, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Friday";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(456, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Sunday";
            // 
            // Lbl_Date
            // 
            this.Lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Lbl_Date.ForeColor = System.Drawing.Color.White;
            this.Lbl_Date.Location = new System.Drawing.Point(12, 26);
            this.Lbl_Date.Name = "Lbl_Date";
            this.Lbl_Date.Size = new System.Drawing.Size(545, 57);
            this.Lbl_Date.TabIndex = 16;
            this.Lbl_Date.Text = "Month YEAR";
            this.Lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_selected
            // 
            this.txt_selected.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_selected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txt_selected.Location = new System.Drawing.Point(219, 552);
            this.txt_selected.Name = "txt_selected";
            this.txt_selected.ReadOnly = true;
            this.txt_selected.Size = new System.Drawing.Size(126, 30);
            this.txt_selected.TabIndex = 17;
            this.txt_selected.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_selected.TextChanged += new System.EventHandler(this.txt_selected_TextChanged);
            // 
            // lblLoggedInUser
            // 
            this.lblLoggedInUser.AutoSize = true;
            this.lblLoggedInUser.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblLoggedInUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoggedInUser.ForeColor = System.Drawing.Color.White;
            this.lblLoggedInUser.Location = new System.Drawing.Point(1207, 26);
            this.lblLoggedInUser.Name = "lblLoggedInUser";
            this.lblLoggedInUser.Size = new System.Drawing.Size(48, 22);
            this.lblLoggedInUser.TabIndex = 18;
            this.lblLoggedInUser.Text = "User";
            // 
            // btnGetAllTasks
            // 
            this.btnGetAllTasks.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGetAllTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnGetAllTasks.Location = new System.Drawing.Point(697, 44);
            this.btnGetAllTasks.Name = "btnGetAllTasks";
            this.btnGetAllTasks.Size = new System.Drawing.Size(219, 44);
            this.btnGetAllTasks.TabIndex = 19;
            this.btnGetAllTasks.Text = "Get all tasks";
            this.btnGetAllTasks.UseVisualStyleBackColor = false;
            this.btnGetAllTasks.Click += new System.EventHandler(this.btnGetAllTasks_Click);
            // 
            // btnGetMyTasks
            // 
            this.btnGetMyTasks.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGetMyTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnGetMyTasks.Location = new System.Drawing.Point(922, 44);
            this.btnGetMyTasks.Name = "btnGetMyTasks";
            this.btnGetMyTasks.Size = new System.Drawing.Size(250, 44);
            this.btnGetMyTasks.TabIndex = 20;
            this.btnGetMyTasks.Text = "Get all my tasks";
            this.btnGetMyTasks.UseVisualStyleBackColor = false;
            this.btnGetMyTasks.Click += new System.EventHandler(this.btnGetMyTasks_Click);
            // 
            // btnAddComplaint
            // 
            this.btnAddComplaint.Location = new System.Drawing.Point(785, 552);
            this.btnAddComplaint.Name = "btnAddComplaint";
            this.btnAddComplaint.Size = new System.Drawing.Size(171, 48);
            this.btnAddComplaint.TabIndex = 21;
            this.btnAddComplaint.Text = "Add complaint";
            this.btnAddComplaint.UseVisualStyleBackColor = true;
            this.btnAddComplaint.Click += new System.EventHandler(this.btnAddComplaint_Click);
            // 
            // btnSeeComplaints
            // 
            this.btnSeeComplaints.Location = new System.Drawing.Point(1109, 555);
            this.btnSeeComplaints.Name = "btnSeeComplaints";
            this.btnSeeComplaints.Size = new System.Drawing.Size(173, 45);
            this.btnSeeComplaints.TabIndex = 22;
            this.btnSeeComplaints.Text = "See complaints";
            this.btnSeeComplaints.UseVisualStyleBackColor = true;
            this.btnSeeComplaints.Click += new System.EventHandler(this.btnSeeComplaints_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::studentHouseSolution.Properties.Resources._70Z_1409_B_Blur_P2_HTp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1378, 612);
            this.Controls.Add(this.btnSeeComplaints);
            this.Controls.Add(this.btnAddComplaint);
            this.Controls.Add(this.btnGetMyTasks);
            this.Controls.Add(this.btnGetAllTasks);
            this.Controls.Add(this.lblLoggedInUser);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txt_selected);
            this.Controls.Add(this.Lbl_Date);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.daycontainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel daycontainer;
        private Button btn_next;
        private Button btn_previous;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label Lbl_Date;
        public TextBox txt_selected;
        private Label lblLoggedInUser;
        private Button btnGetAllTasks;
        private Button btnGetMyTasks;
        private Button btnAddComplaint;
        private Button btnSeeComplaints;
    }
}
