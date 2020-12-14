namespace Module_3
{
    partial class SearchForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboFrom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboTo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboCabinType = new System.Windows.Forms.ComboBox();
            this.radioReturn = new System.Windows.Forms.RadioButton();
            this.radioOneway = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpOutbound = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.btnApply = new System.Windows.Forms.Button();
            this.dgvOutbound = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.comboOutboundThree = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutbound)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnApply);
            this.groupBox1.Controls.Add(this.dtpReturn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpOutbound);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radioOneway);
            this.groupBox1.Controls.Add(this.radioReturn);
            this.groupBox1.Controls.Add(this.comboCabinType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboTo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Parameters";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // comboFrom
            // 
            this.comboFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFrom.FormattingEnabled = true;
            this.comboFrom.Location = new System.Drawing.Point(58, 24);
            this.comboFrom.Name = "comboFrom";
            this.comboFrom.Size = new System.Drawing.Size(150, 21);
            this.comboFrom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "To";
            // 
            // comboTo
            // 
            this.comboTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTo.FormattingEnabled = true;
            this.comboTo.Location = new System.Drawing.Point(262, 24);
            this.comboTo.Name = "comboTo";
            this.comboTo.Size = new System.Drawing.Size(150, 21);
            this.comboTo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cabin Type";
            // 
            // comboCabinType
            // 
            this.comboCabinType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCabinType.FormattingEnabled = true;
            this.comboCabinType.Location = new System.Drawing.Point(508, 24);
            this.comboCabinType.Name = "comboCabinType";
            this.comboCabinType.Size = new System.Drawing.Size(150, 21);
            this.comboCabinType.TabIndex = 1;
            // 
            // radioReturn
            // 
            this.radioReturn.AutoSize = true;
            this.radioReturn.Location = new System.Drawing.Point(25, 64);
            this.radioReturn.Name = "radioReturn";
            this.radioReturn.Size = new System.Drawing.Size(57, 17);
            this.radioReturn.TabIndex = 2;
            this.radioReturn.TabStop = true;
            this.radioReturn.Text = "Return";
            this.radioReturn.UseVisualStyleBackColor = true;
            // 
            // radioOneway
            // 
            this.radioOneway.AutoSize = true;
            this.radioOneway.Location = new System.Drawing.Point(88, 64);
            this.radioOneway.Name = "radioOneway";
            this.radioOneway.Size = new System.Drawing.Size(67, 17);
            this.radioOneway.TabIndex = 2;
            this.radioOneway.TabStop = true;
            this.radioOneway.Text = "One way";
            this.radioOneway.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Outbound";
            // 
            // dtpOutbound
            // 
            this.dtpOutbound.Location = new System.Drawing.Point(262, 62);
            this.dtpOutbound.Name = "dtpOutbound";
            this.dtpOutbound.Size = new System.Drawing.Size(150, 20);
            this.dtpOutbound.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Return";
            // 
            // dtpReturn
            // 
            this.dtpReturn.Location = new System.Drawing.Point(486, 62);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(150, 20);
            this.dtpReturn.TabIndex = 4;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(654, 60);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(100, 25);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // dgvOutbound
            // 
            this.dgvOutbound.AllowUserToAddRows = false;
            this.dgvOutbound.AllowUserToDeleteRows = false;
            this.dgvOutbound.AllowUserToResizeColumns = false;
            this.dgvOutbound.AllowUserToResizeRows = false;
            this.dgvOutbound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutbound.Location = new System.Drawing.Point(12, 158);
            this.dgvOutbound.Name = "dgvOutbound";
            this.dgvOutbound.ReadOnly = true;
            this.dgvOutbound.RowHeadersVisible = false;
            this.dgvOutbound.Size = new System.Drawing.Size(760, 150);
            this.dgvOutbound.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Outbound flight details :";
            // 
            // comboOutboundThree
            // 
            this.comboOutboundThree.AutoSize = true;
            this.comboOutboundThree.Location = new System.Drawing.Point(582, 135);
            this.comboOutboundThree.Name = "comboOutboundThree";
            this.comboOutboundThree.Size = new System.Drawing.Size(190, 17);
            this.comboOutboundThree.TabIndex = 3;
            this.comboOutboundThree.Text = "Display three days before and after";
            this.comboOutboundThree.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.comboOutboundThree);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvOutbound);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search for flights";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchForm_FormClosed);
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutbound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboFrom;
        private System.Windows.Forms.ComboBox comboTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboCabinType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioReturn;
        private System.Windows.Forms.RadioButton radioOneway;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpOutbound;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.DataGridView dgvOutbound;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox comboOutboundThree;
    }
}

