namespace studentHouseSolution
{
    partial class EventForm
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
            this.txt_Date = new System.Windows.Forms.TextBox();
            this.txt_Event = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Date
            // 
            this.txt_Date.Location = new System.Drawing.Point(180, 107);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Size = new System.Drawing.Size(634, 47);
            this.txt_Date.TabIndex = 0;
            // 
            // txt_Event
            // 
            this.txt_Event.Location = new System.Drawing.Point(180, 223);
            this.txt_Event.Name = "txt_Event";
            this.txt_Event.Size = new System.Drawing.Size(634, 47);
            this.txt_Event.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 569);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Event);
            this.Controls.Add(this.txt_Date);
            this.Name = "EventForm";
            this.Text = "EventForm";
            this.Load += new System.EventHandler(this.EventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_Date;
        private TextBox txt_Event;
        private Button button1;
    }
}