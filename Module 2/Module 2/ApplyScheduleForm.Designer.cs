namespace Module_2
{
    partial class ApplyScheduleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.groupResult = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMissing = new System.Windows.Forms.Label();
            this.txtDuplicate = new System.Windows.Forms.Label();
            this.txtSuccess = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select the text file with the changes";
            // 
            // txtFile
            // 
            this.txtFile.Enabled = false;
            this.txtFile.Location = new System.Drawing.Point(12, 25);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(304, 20);
            this.txtFile.TabIndex = 1;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(322, 22);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(100, 25);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // groupResult
            // 
            this.groupResult.Controls.Add(this.label4);
            this.groupResult.Controls.Add(this.label3);
            this.groupResult.Controls.Add(this.txtMissing);
            this.groupResult.Controls.Add(this.txtDuplicate);
            this.groupResult.Controls.Add(this.txtSuccess);
            this.groupResult.Controls.Add(this.label2);
            this.groupResult.Location = new System.Drawing.Point(12, 51);
            this.groupResult.Name = "groupResult";
            this.groupResult.Size = new System.Drawing.Size(410, 198);
            this.groupResult.TabIndex = 3;
            this.groupResult.TabStop = false;
            this.groupResult.Text = "Results";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Record with missing fields discarded :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Duplicated Records Discarded :";
            // 
            // txtMissing
            // 
            this.txtMissing.AutoSize = true;
            this.txtMissing.Location = new System.Drawing.Point(250, 129);
            this.txtMissing.Name = "txtMissing";
            this.txtMissing.Size = new System.Drawing.Size(28, 13);
            this.txtMissing.TabIndex = 0;
            this.txtMissing.Text = "[xxx]";
            // 
            // txtDuplicate
            // 
            this.txtDuplicate.AutoSize = true;
            this.txtDuplicate.Location = new System.Drawing.Point(250, 86);
            this.txtDuplicate.Name = "txtDuplicate";
            this.txtDuplicate.Size = new System.Drawing.Size(28, 13);
            this.txtDuplicate.TabIndex = 0;
            this.txtDuplicate.Text = "[xxx]";
            // 
            // txtSuccess
            // 
            this.txtSuccess.AutoSize = true;
            this.txtSuccess.Location = new System.Drawing.Point(250, 48);
            this.txtSuccess.Name = "txtSuccess";
            this.txtSuccess.Size = new System.Drawing.Size(28, 13);
            this.txtSuccess.TabIndex = 0;
            this.txtSuccess.Text = "[xxx]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Successful Changes Applied :";
            // 
            // ApplyScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.groupResult);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.label1);
            this.Name = "ApplyScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apply Schedule Changes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ApplyScheduleForm_FormClosed);
            this.groupResult.ResumeLayout(false);
            this.groupResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.GroupBox groupResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtSuccess;
        private System.Windows.Forms.Label txtDuplicate;
        private System.Windows.Forms.Label txtMissing;
    }
}