namespace FileReadWri_BenM_
{
    partial class frmFileReadWrite
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblLookInFile = new System.Windows.Forms.Label();
            this.lblTextEqualOrNot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(125, 121);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(140, 58);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblLookInFile
            // 
            this.lblLookInFile.AutoSize = true;
            this.lblLookInFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLookInFile.Location = new System.Drawing.Point(47, 61);
            this.lblLookInFile.Name = "lblLookInFile";
            this.lblLookInFile.Size = new System.Drawing.Size(299, 40);
            this.lblLookInFile.TabIndex = 1;
            this.lblLookInFile.Text = "Check if the text in the input file are equal\r\n\r\n";
            // 
            // lblTextEqualOrNot
            // 
            this.lblTextEqualOrNot.AutoSize = true;
            this.lblTextEqualOrNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextEqualOrNot.Location = new System.Drawing.Point(132, 248);
            this.lblTextEqualOrNot.Name = "lblTextEqualOrNot";
            this.lblTextEqualOrNot.Size = new System.Drawing.Size(155, 20);
            this.lblTextEqualOrNot.TabIndex = 2;
            this.lblTextEqualOrNot.Text = "Check the output file";
            // 
            // frmFileReadWrite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 323);
            this.Controls.Add(this.lblTextEqualOrNot);
            this.Controls.Add(this.lblLookInFile);
            this.Controls.Add(this.btnCheck);
            this.Name = "frmFileReadWrite";
            this.Text = "File/Read, Write";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblLookInFile;
        private System.Windows.Forms.Label lblTextEqualOrNot;
    }
}

