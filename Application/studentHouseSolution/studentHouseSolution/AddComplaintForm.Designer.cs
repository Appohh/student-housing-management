namespace studentHouseSolution
{
    partial class AddComplaintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddComplaintForm));
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAnonymous = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(340, 195);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(6);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(984, 662);
            this.tbDescription.TabIndex = 0;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(340, 86);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(6);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(984, 47);
            this.tbTitle.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(742, 935);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(200, 59);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(798, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(733, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description";
            // 
            // cbAnonymous
            // 
            this.cbAnonymous.AutoSize = true;
            this.cbAnonymous.BackColor = System.Drawing.Color.Transparent;
            this.cbAnonymous.ForeColor = System.Drawing.Color.White;
            this.cbAnonymous.Location = new System.Drawing.Point(725, 869);
            this.cbAnonymous.Margin = new System.Windows.Forms.Padding(6);
            this.cbAnonymous.Name = "cbAnonymous";
            this.cbAnonymous.Size = new System.Drawing.Size(229, 45);
            this.cbAnonymous.TabIndex = 5;
            this.cbAnonymous.Text = "Anonymous?";
            this.cbAnonymous.UseVisualStyleBackColor = false;
            // 
            // AddComplaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1700, 1019);
            this.Controls.Add(this.cbAnonymous);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.tbDescription);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddComplaintForm";
            this.Text = "Add complaint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbDescription;
        private TextBox tbTitle;
        private Button btnSubmit;
        private Label label1;
        private Label label2;
        private CheckBox cbAnonymous;
    }
}