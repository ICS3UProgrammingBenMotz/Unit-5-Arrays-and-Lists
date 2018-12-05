namespace Lists_BenM_
{
    partial class frmLists
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
            this.components = new System.ComponentModel.Container();
            this.txtScores = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblEnter = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnCalcuAver = new System.Windows.Forms.Button();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lstScores = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScores
            // 
            this.txtScores.Location = new System.Drawing.Point(233, 41);
            this.txtScores.Name = "txtScores";
            this.txtScores.Size = new System.Drawing.Size(100, 20);
            this.txtScores.TabIndex = 0;
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Location = new System.Drawing.Point(118, 44);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(109, 13);
            this.lblEnter.TabIndex = 1;
            this.lblEnter.Text = "Enter your text scores";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(368, 39);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnCalcuAver
            // 
            this.btnCalcuAver.Location = new System.Drawing.Point(177, 273);
            this.btnCalcuAver.Name = "btnCalcuAver";
            this.btnCalcuAver.Size = new System.Drawing.Size(117, 30);
            this.btnCalcuAver.TabIndex = 3;
            this.btnCalcuAver.Text = "Calculate Average";
            this.btnCalcuAver.UseVisualStyleBackColor = true;
            this.btnCalcuAver.Click += new System.EventHandler(this.btnCalcuAver_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(174, 306);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(93, 13);
            this.lblAverage.TabIndex = 4;
            this.lblAverage.Text = "Your average is:-1";
            this.lblAverage.Click += new System.EventHandler(this.lblAverage_Click);
            // 
            // lstScores
            // 
            this.lstScores.FormattingEnabled = true;
            this.lstScores.Location = new System.Drawing.Point(138, 77);
            this.lstScores.Name = "lstScores";
            this.lstScores.Size = new System.Drawing.Size(195, 173);
            this.lstScores.TabIndex = 5;
            // 
            // frmLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 348);
            this.Controls.Add(this.lstScores);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.btnCalcuAver);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.txtScores);
            this.Name = "frmLists";
            this.Text = "Lists";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScores;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnCalcuAver;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.ListBox lstScores;
    }
}

