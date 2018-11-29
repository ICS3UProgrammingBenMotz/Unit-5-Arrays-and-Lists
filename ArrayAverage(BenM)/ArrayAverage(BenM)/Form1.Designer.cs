namespace ArrayAverage_BenM_
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
            this.lstNumbs = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCalculateAv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstNumbs
            // 
            this.lstNumbs.FormattingEnabled = true;
            this.lstNumbs.Location = new System.Drawing.Point(178, 73);
            this.lstNumbs.Name = "lstNumbs";
            this.lstNumbs.Size = new System.Drawing.Size(144, 199);
            this.lstNumbs.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(204, 25);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(85, 29);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCalculateAv
            // 
            this.btnCalculateAv.Location = new System.Drawing.Point(191, 293);
            this.btnCalculateAv.Name = "btnCalculateAv";
            this.btnCalculateAv.Size = new System.Drawing.Size(118, 23);
            this.btnCalculateAv.TabIndex = 2;
            this.btnCalculateAv.Text = "Calculate Average";
            this.btnCalculateAv.UseVisualStyleBackColor = true;
            this.btnCalculateAv.Click += new System.EventHandler(this.btnCalculateAv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 328);
            this.Controls.Add(this.btnCalculateAv);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lstNumbs);
            this.Name = "Form1";
            this.Text = "Array Average";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstNumbs;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCalculateAv;
    }
}

