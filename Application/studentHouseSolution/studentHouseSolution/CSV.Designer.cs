namespace studentHouseSolution
{
    partial class CSV
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
            this.btnRead = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.mcCalendar = new System.Windows.Forms.MonthCalendar();
            this.dgData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(635, 418);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(147, 29);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Choose CSV";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.ItemHeight = 20;
            this.lbResult.Location = new System.Drawing.Point(25, 12);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(247, 104);
            this.lbResult.TabIndex = 2;
            // 
            // mcCalendar
            // 
            this.mcCalendar.Location = new System.Drawing.Point(583, 5);
            this.mcCalendar.Name = "mcCalendar";
            this.mcCalendar.TabIndex = 3;
            this.mcCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcCalendar_DateChanged);
            // 
            // dgData
            // 
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Location = new System.Drawing.Point(25, 224);
            this.dgData.Name = "dgData";
            this.dgData.RowHeadersWidth = 51;
            this.dgData.RowTemplate.Height = 29;
            this.dgData.Size = new System.Drawing.Size(757, 188);
            this.dgData.TabIndex = 4;
            // 
            // CSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgData);
            this.Controls.Add(this.mcCalendar);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnRead);
            this.Name = "CSV";
            this.Text = "CSV";
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnRead;
        private ListBox lbResult;
        private MonthCalendar mcCalendar;
        private DataGridView dgData;
    }
}