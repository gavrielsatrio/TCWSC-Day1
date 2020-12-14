namespace Module_1
{
    partial class CrashForm
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblReason = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.radioSoftware = new System.Windows.Forms.RadioButton();
            this.radioSystem = new System.Windows.Forms.RadioButton();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(188, 13);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "No logout detected from your last login";
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(12, 45);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(50, 13);
            this.lblReason.TabIndex = 0;
            this.lblReason.Text = "Reason :";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(12, 61);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(410, 180);
            this.txtReason.TabIndex = 0;
            // 
            // radioSoftware
            // 
            this.radioSoftware.AutoSize = true;
            this.radioSoftware.Location = new System.Drawing.Point(12, 247);
            this.radioSoftware.Name = "radioSoftware";
            this.radioSoftware.Size = new System.Drawing.Size(97, 17);
            this.radioSoftware.TabIndex = 1;
            this.radioSoftware.TabStop = true;
            this.radioSoftware.Text = "Software Crash";
            this.radioSoftware.UseVisualStyleBackColor = true;
            // 
            // radioSystem
            // 
            this.radioSystem.AutoSize = true;
            this.radioSystem.Location = new System.Drawing.Point(115, 247);
            this.radioSystem.Name = "radioSystem";
            this.radioSystem.Size = new System.Drawing.Size(89, 17);
            this.radioSystem.TabIndex = 2;
            this.radioSystem.TabStop = true;
            this.radioSystem.Text = "System Crash";
            this.radioSystem.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(347, 247);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // CrashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.radioSystem);
            this.Controls.Add(this.radioSoftware);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.lblHeader);
            this.Name = "CrashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "No logout detected";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CrashForm_FormClosed);
            this.Load += new System.EventHandler(this.CrashForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.RadioButton radioSoftware;
        private System.Windows.Forms.RadioButton radioSystem;
        private System.Windows.Forms.Button btnConfirm;
    }
}