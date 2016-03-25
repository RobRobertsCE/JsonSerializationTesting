namespace SetupParameterManager
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
            this.cboGroups = new System.Windows.Forms.ComboBox();
            this.cboSubGroups = new System.Windows.Forms.ComboBox();
            this.cboParameters = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboGroups
            // 
            this.cboGroups.FormattingEnabled = true;
            this.cboGroups.Location = new System.Drawing.Point(12, 12);
            this.cboGroups.Name = "cboGroups";
            this.cboGroups.Size = new System.Drawing.Size(163, 21);
            this.cboGroups.TabIndex = 0;
            this.cboGroups.SelectedIndexChanged += new System.EventHandler(this.cboGroups_SelectedIndexChanged);
            // 
            // cboSubGroups
            // 
            this.cboSubGroups.FormattingEnabled = true;
            this.cboSubGroups.Location = new System.Drawing.Point(181, 12);
            this.cboSubGroups.Name = "cboSubGroups";
            this.cboSubGroups.Size = new System.Drawing.Size(163, 21);
            this.cboSubGroups.TabIndex = 1;
            this.cboSubGroups.SelectedIndexChanged += new System.EventHandler(this.cboSubGroups_SelectedIndexChanged);
            // 
            // cboParameters
            // 
            this.cboParameters.FormattingEnabled = true;
            this.cboParameters.Location = new System.Drawing.Point(350, 12);
            this.cboParameters.Name = "cboParameters";
            this.cboParameters.Size = new System.Drawing.Size(163, 21);
            this.cboParameters.TabIndex = 2;
            this.cboParameters.SelectedIndexChanged += new System.EventHandler(this.cboParameters_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "New Group";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKey);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(17, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 101);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Group";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(9, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(9, 75);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(151, 20);
            this.txtKey.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboParameters);
            this.Controls.Add(this.cboSubGroups);
            this.Controls.Add(this.cboGroups);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboGroups;
        private System.Windows.Forms.ComboBox cboSubGroups;
        private System.Windows.Forms.ComboBox cboParameters;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtName;
    }
}

