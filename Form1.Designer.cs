namespace HabrHtmlParser
{
    partial class Form1
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
            this.ListTitles = new System.Windows.Forms.ListBox();
            this.StartPoint = new System.Windows.Forms.Label();
            this.EndPoint = new System.Windows.Forms.Label();
            this.numericStart = new System.Windows.Forms.NumericUpDown();
            this.numericEnd = new System.Windows.Forms.NumericUpDown();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonAbort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // ListTitles
            // 
            this.ListTitles.FormattingEnabled = true;
            this.ListTitles.Location = new System.Drawing.Point(12, 12);
            this.ListTitles.Name = "ListTitles";
            this.ListTitles.Size = new System.Drawing.Size(261, 186);
            this.ListTitles.TabIndex = 0;
            // 
            // StartPoint
            // 
            this.StartPoint.AutoSize = true;
            this.StartPoint.Location = new System.Drawing.Point(279, 12);
            this.StartPoint.Name = "StartPoint";
            this.StartPoint.Size = new System.Drawing.Size(56, 13);
            this.StartPoint.TabIndex = 1;
            this.StartPoint.Text = "Start Point";
            // 
            // EndPoint
            // 
            this.EndPoint.AutoSize = true;
            this.EndPoint.Location = new System.Drawing.Point(279, 61);
            this.EndPoint.Name = "EndPoint";
            this.EndPoint.Size = new System.Drawing.Size(53, 13);
            this.EndPoint.TabIndex = 2;
            this.EndPoint.Text = "End Point";
            // 
            // numericStart
            // 
            this.numericStart.Location = new System.Drawing.Point(279, 28);
            this.numericStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericStart.Name = "numericStart";
            this.numericStart.Size = new System.Drawing.Size(120, 20);
            this.numericStart.TabIndex = 3;
            this.numericStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericEnd
            // 
            this.numericEnd.Location = new System.Drawing.Point(279, 77);
            this.numericEnd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericEnd.Name = "numericEnd";
            this.numericEnd.Size = new System.Drawing.Size(120, 20);
            this.numericEnd.TabIndex = 4;
            this.numericEnd.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(279, 118);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(120, 37);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonAbort
            // 
            this.buttonAbort.Location = new System.Drawing.Point(279, 161);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(120, 40);
            this.buttonAbort.TabIndex = 6;
            this.buttonAbort.Text = "Abort";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 213);
            this.Controls.Add(this.buttonAbort);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.numericEnd);
            this.Controls.Add(this.numericStart);
            this.Controls.Add(this.EndPoint);
            this.Controls.Add(this.StartPoint);
            this.Controls.Add(this.ListTitles);
            this.Name = "Form1";
            this.Text = "HabrParser";
            ((System.ComponentModel.ISupportInitialize)(this.numericStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListTitles;
        private System.Windows.Forms.Label StartPoint;
        private System.Windows.Forms.Label EndPoint;
        private System.Windows.Forms.NumericUpDown numericStart;
        private System.Windows.Forms.NumericUpDown numericEnd;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonAbort;
    }
}

