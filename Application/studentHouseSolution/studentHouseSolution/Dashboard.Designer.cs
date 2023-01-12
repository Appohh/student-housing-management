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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
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
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1262, 192);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1318, 873);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // daycontainer
            // 
            this.daycontainer.BackColor = System.Drawing.Color.Black;
            this.daycontainer.Location = new System.Drawing.Point(53, 262);
            this.daycontainer.Margin = new System.Windows.Forms.Padding(2);
            this.daycontainer.Name = "daycontainer";
            this.daycontainer.Size = new System.Drawing.Size(1092, 800);
            this.daycontainer.TabIndex = 6;
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Black;
            this.btn_next.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_next.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_next.Location = new System.Drawing.Point(745, 1099);
            this.btn_next.Margin = new System.Windows.Forms.Padding(6);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(400, 119);
            this.btn_next.TabIndex = 7;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.BackColor = System.Drawing.Color.Black;
            this.btn_previous.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_previous.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_previous.Location = new System.Drawing.Point(52, 1099);
            this.btn_previous.Margin = new System.Windows.Forms.Padding(6);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(400, 119);
            this.btn_previous.TabIndex = 8;
            this.btn_previous.Text = "Previous";
            this.btn_previous.UseVisualStyleBackColor = false;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(53, 189);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 41);
            this.label2.TabIndex = 9;
            this.label2.Text = "Monday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(200, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 41);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tuesday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(540, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 41);
            this.label4.TabIndex = 12;
            this.label4.Text = "Thursday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(346, 189);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 41);
            this.label5.TabIndex = 11;
            this.label5.Text = "Wednesday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(814, 189);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 41);
            this.label6.TabIndex = 14;
            this.label6.Text = "Saturday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(697, 189);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 41);
            this.label7.TabIndex = 13;
            this.label7.Text = "Friday";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(969, 189);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 41);
            this.label8.TabIndex = 15;
            this.label8.Text = "Sunday";
            // 
            // Lbl_Date
            // 
            this.Lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Lbl_Date.ForeColor = System.Drawing.Color.White;
            this.Lbl_Date.Location = new System.Drawing.Point(26, 53);
            this.Lbl_Date.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_Date.Name = "Lbl_Date";
            this.Lbl_Date.Size = new System.Drawing.Size(1158, 117);
            this.Lbl_Date.TabIndex = 16;
            this.Lbl_Date.Text = "Month YEAR";
            this.Lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_selected
            // 
            this.txt_selected.BackColor = System.Drawing.Color.Black;
            this.txt_selected.Font = new System.Drawing.Font("Showcard Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txt_selected.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_selected.Location = new System.Drawing.Point(464, 1132);
            this.txt_selected.Margin = new System.Windows.Forms.Padding(6);
            this.txt_selected.Name = "txt_selected";
            this.txt_selected.ReadOnly = true;
            this.txt_selected.Size = new System.Drawing.Size(263, 57);
            this.txt_selected.TabIndex = 17;
            this.txt_selected.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_selected.TextChanged += new System.EventHandler(this.txt_selected_TextChanged);
            // 
            // lblLoggedInUser
            // 
            this.lblLoggedInUser.AutoSize = true;
            this.lblLoggedInUser.BackColor = System.Drawing.Color.Black;
            this.lblLoggedInUser.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoggedInUser.ForeColor = System.Drawing.Color.White;
            this.lblLoggedInUser.Location = new System.Drawing.Point(2270, 25);
            this.lblLoggedInUser.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLoggedInUser.Name = "lblLoggedInUser";
            this.lblLoggedInUser.Size = new System.Drawing.Size(108, 44);
            this.lblLoggedInUser.TabIndex = 18;
            this.lblLoggedInUser.Text = "User";
            // 
            // btnGetAllTasks
            // 
            this.btnGetAllTasks.BackColor = System.Drawing.Color.Black;
            this.btnGetAllTasks.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnGetAllTasks.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGetAllTasks.Location = new System.Drawing.Point(1341, 93);
            this.btnGetAllTasks.Margin = new System.Windows.Forms.Padding(6);
            this.btnGetAllTasks.Name = "btnGetAllTasks";
            this.btnGetAllTasks.Size = new System.Drawing.Size(465, 90);
            this.btnGetAllTasks.TabIndex = 19;
            this.btnGetAllTasks.Text = "Get all tasks";
            this.btnGetAllTasks.UseVisualStyleBackColor = false;
            this.btnGetAllTasks.Click += new System.EventHandler(this.btnGetAllTasks_Click);
            // 
            // btnGetMyTasks
            // 
            this.btnGetMyTasks.BackColor = System.Drawing.Color.Black;
            this.btnGetMyTasks.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnGetMyTasks.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGetMyTasks.Location = new System.Drawing.Point(1904, 93);
            this.btnGetMyTasks.Margin = new System.Windows.Forms.Padding(6);
            this.btnGetMyTasks.Name = "btnGetMyTasks";
            this.btnGetMyTasks.Size = new System.Drawing.Size(531, 90);
            this.btnGetMyTasks.TabIndex = 20;
            this.btnGetMyTasks.Text = "Get all my tasks";
            this.btnGetMyTasks.UseVisualStyleBackColor = false;
            this.btnGetMyTasks.Click += new System.EventHandler(this.btnGetMyTasks_Click);
            // 
            // btnAddComplaint
            // 
            this.btnAddComplaint.BackColor = System.Drawing.Color.Black;
            this.btnAddComplaint.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnAddComplaint.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddComplaint.Location = new System.Drawing.Point(1262, 1116);
            this.btnAddComplaint.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddComplaint.Name = "btnAddComplaint";
            this.btnAddComplaint.Size = new System.Drawing.Size(544, 90);
            this.btnAddComplaint.TabIndex = 23;
            this.btnAddComplaint.Text = "Make an complaint";
            this.btnAddComplaint.UseVisualStyleBackColor = false;
            this.btnAddComplaint.Click += new System.EventHandler(this.btnAddComplaint_Click_1);
            // 
            // btnSeeComplaints
            // 
            this.btnSeeComplaints.BackColor = System.Drawing.Color.Black;
            this.btnSeeComplaints.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSeeComplaints.ForeColor = System.Drawing.Color.Maroon;
            this.btnSeeComplaints.Location = new System.Drawing.Point(2086, 1116);
            this.btnSeeComplaints.Margin = new System.Windows.Forms.Padding(6);
            this.btnSeeComplaints.Name = "btnSeeComplaints";
            this.btnSeeComplaints.Size = new System.Drawing.Size(494, 90);
            this.btnSeeComplaints.TabIndex = 24;
            this.btnSeeComplaints.Text = "See Complaints";
            this.btnSeeComplaints.UseVisualStyleBackColor = false;
            this.btnSeeComplaints.Click += new System.EventHandler(this.btnSeeComplaints_Click_1);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2653, 1255);
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
            this.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
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
