namespace SetupParameterManager
{
    partial class SetupGroupsEditor
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
            this.tvSetup = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxGroup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmEditGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDeleteGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.addSubGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSubGroup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.addParameterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxParameter = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.pnlGroup = new System.Windows.Forms.Panel();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlParam = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.chkTranslatable = new System.Windows.Forms.CheckBox();
            this.txtTranslatedSuffix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOriginalSuffix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlEditButtons = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tsbLoad = new System.Windows.Forms.ToolStripButton();
            this.btnCopy = new System.Windows.Forms.ToolStripButton();
            this.tsbPaste = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.editSubGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSubGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editParameterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteParameterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.ctxGroup.SuspendLayout();
            this.ctxSubGroup.SuspendLayout();
            this.ctxParameter.SuspendLayout();
            this.pnlGroup.SuspendLayout();
            this.pnlParam.SuspendLayout();
            this.pnlEditButtons.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvSetup
            // 
            this.tvSetup.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvSetup.Location = new System.Drawing.Point(0, 49);
            this.tvSetup.Name = "tvSetup";
            this.tvSetup.Size = new System.Drawing.Size(202, 283);
            this.tvSetup.TabIndex = 0;
            this.tvSetup.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvSetup_AfterSelect);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLoad,
            this.toolStripSeparator1,
            this.btnCopy,
            this.tsbPaste,
            this.toolStripSeparator2,
            this.btnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(535, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ctxGroup
            // 
            this.ctxGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEditGroup,
            this.tsmDeleteGroup,
            this.pasteToolStripMenuItem2,
            this.toolStripMenuItem1,
            this.addSubGroupToolStripMenuItem});
            this.ctxGroup.Name = "ctxGroup";
            this.ctxGroup.Size = new System.Drawing.Size(155, 120);
            // 
            // tsmEditGroup
            // 
            this.tsmEditGroup.Image = global::SetupParameterManager.Properties.Resources.Edit;
            this.tsmEditGroup.Name = "tsmEditGroup";
            this.tsmEditGroup.Size = new System.Drawing.Size(154, 22);
            this.tsmEditGroup.Text = "Edit";
            this.tsmEditGroup.Click += new System.EventHandler(this.tsmEditGroup_Click);
            // 
            // tsmDeleteGroup
            // 
            this.tsmDeleteGroup.Image = global::SetupParameterManager.Properties.Resources.delete;
            this.tsmDeleteGroup.Name = "tsmDeleteGroup";
            this.tsmDeleteGroup.Size = new System.Drawing.Size(154, 22);
            this.tsmDeleteGroup.Text = "Delete";
            this.tsmDeleteGroup.Click += new System.EventHandler(this.tsmDeleteGroup_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(151, 6);
            // 
            // addSubGroupToolStripMenuItem
            // 
            this.addSubGroupToolStripMenuItem.Image = global::SetupParameterManager.Properties.Resources.NewWindow;
            this.addSubGroupToolStripMenuItem.Name = "addSubGroupToolStripMenuItem";
            this.addSubGroupToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.addSubGroupToolStripMenuItem.Text = "New SubGroup";
            this.addSubGroupToolStripMenuItem.Click += new System.EventHandler(this.addSubGroupToolStripMenuItem_Click);
            // 
            // ctxSubGroup
            // 
            this.ctxSubGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editSubGroupToolStripMenuItem,
            this.deleteSubGroupToolStripMenuItem,
            this.pasteToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.addParameterToolStripMenuItem});
            this.ctxSubGroup.Name = "ctxSubGroup";
            this.ctxSubGroup.Size = new System.Drawing.Size(156, 98);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 6);
            // 
            // addParameterToolStripMenuItem
            // 
            this.addParameterToolStripMenuItem.Image = global::SetupParameterManager.Properties.Resources.NewWindow;
            this.addParameterToolStripMenuItem.Name = "addParameterToolStripMenuItem";
            this.addParameterToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.addParameterToolStripMenuItem.Text = "New Parameter";
            this.addParameterToolStripMenuItem.Click += new System.EventHandler(this.addParameterToolStripMenuItem_Click);
            // 
            // ctxParameter
            // 
            this.ctxParameter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editParameterToolStripMenuItem,
            this.deleteParameterToolStripMenuItem,
            this.toolStripMenuItem3,
            this.copyToolStripMenuItem});
            this.ctxParameter.Name = "ctxParameter";
            this.ctxParameter.Size = new System.Drawing.Size(108, 76);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(104, 6);
            // 
            // pnlGroup
            // 
            this.pnlGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGroup.Controls.Add(this.txtKey);
            this.pnlGroup.Controls.Add(this.label2);
            this.pnlGroup.Controls.Add(this.txtName);
            this.pnlGroup.Controls.Add(this.label1);
            this.pnlGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGroup.Location = new System.Drawing.Point(202, 49);
            this.pnlGroup.Name = "pnlGroup";
            this.pnlGroup.Size = new System.Drawing.Size(333, 69);
            this.pnlGroup.TabIndex = 6;
            this.pnlGroup.Visible = false;
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Location = new System.Drawing.Point(144, 43);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(167, 22);
            this.txtKey.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(99, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Key";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(144, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(167, 22);
            this.txtName.TabIndex = 1;
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // pnlParam
            // 
            this.pnlParam.BackColor = System.Drawing.Color.DimGray;
            this.pnlParam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlParam.Controls.Add(this.label5);
            this.pnlParam.Controls.Add(this.chkTranslatable);
            this.pnlParam.Controls.Add(this.txtTranslatedSuffix);
            this.pnlParam.Controls.Add(this.label3);
            this.pnlParam.Controls.Add(this.txtOriginalSuffix);
            this.pnlParam.Controls.Add(this.label4);
            this.pnlParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlParam.Location = new System.Drawing.Point(202, 118);
            this.pnlParam.Name = "pnlParam";
            this.pnlParam.Size = new System.Drawing.Size(333, 177);
            this.pnlParam.TabIndex = 7;
            this.pnlParam.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Is Translatable";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkTranslatable
            // 
            this.chkTranslatable.AutoSize = true;
            this.chkTranslatable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkTranslatable.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chkTranslatable.Location = new System.Drawing.Point(144, 67);
            this.chkTranslatable.Name = "chkTranslatable";
            this.chkTranslatable.Size = new System.Drawing.Size(15, 14);
            this.chkTranslatable.TabIndex = 8;
            this.chkTranslatable.UseVisualStyleBackColor = true;
            // 
            // txtTranslatedSuffix
            // 
            this.txtTranslatedSuffix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTranslatedSuffix.Location = new System.Drawing.Point(144, 32);
            this.txtTranslatedSuffix.Name = "txtTranslatedSuffix";
            this.txtTranslatedSuffix.Size = new System.Drawing.Size(126, 22);
            this.txtTranslatedSuffix.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Translated Suffix";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOriginalSuffix
            // 
            this.txtOriginalSuffix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOriginalSuffix.Location = new System.Drawing.Point(144, 2);
            this.txtOriginalSuffix.Name = "txtOriginalSuffix";
            this.txtOriginalSuffix.Size = new System.Drawing.Size(126, 22);
            this.txtOriginalSuffix.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Original Suffix";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlEditButtons
            // 
            this.pnlEditButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEditButtons.Controls.Add(this.btnCancel);
            this.pnlEditButtons.Controls.Add(this.btnSave);
            this.pnlEditButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlEditButtons.Location = new System.Drawing.Point(202, 295);
            this.pnlEditButtons.Name = "pnlEditButtons";
            this.pnlEditButtons.Size = new System.Drawing.Size(333, 37);
            this.pnlEditButtons.TabIndex = 8;
            this.pnlEditButtons.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(535, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem1,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem1.Text = "Copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.copyToolStripMenuItem1_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem2
            // 
            this.pasteToolStripMenuItem2.Enabled = false;
            this.pasteToolStripMenuItem2.Image = global::SetupParameterManager.Properties.Resources.paste;
            this.pasteToolStripMenuItem2.Name = "pasteToolStripMenuItem2";
            this.pasteToolStripMenuItem2.Size = new System.Drawing.Size(154, 22);
            this.pasteToolStripMenuItem2.Text = "Paste";
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::SetupParameterManager.Properties.Resources._305_Close_16x16_72;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(251, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 29);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::SetupParameterManager.Properties.Resources.saveHS;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(168, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 29);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tsbLoad
            // 
            this.tsbLoad.Image = global::SetupParameterManager.Properties.Resources.RepeatHS;
            this.tsbLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoad.Name = "tsbLoad";
            this.tsbLoad.Size = new System.Drawing.Size(53, 22);
            this.tsbLoad.Text = "Load";
            this.tsbLoad.Click += new System.EventHandler(this.tsbLoad_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Image = global::SetupParameterManager.Properties.Resources.copy;
            this.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(55, 22);
            this.btnCopy.Text = "Copy";
            this.btnCopy.Click += new System.EventHandler(this.tsbCopy_Click);
            // 
            // tsbPaste
            // 
            this.tsbPaste.Enabled = false;
            this.tsbPaste.Image = global::SetupParameterManager.Properties.Resources.paste;
            this.tsbPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPaste.Name = "tsbPaste";
            this.tsbPaste.Size = new System.Drawing.Size(55, 22);
            this.tsbPaste.Text = "Paste";
            this.tsbPaste.Click += new System.EventHandler(this.tsbPaste_Click);
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.Image = global::SetupParameterManager.Properties.Resources.delete;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 22);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // editSubGroupToolStripMenuItem
            // 
            this.editSubGroupToolStripMenuItem.Image = global::SetupParameterManager.Properties.Resources.Edit;
            this.editSubGroupToolStripMenuItem.Name = "editSubGroupToolStripMenuItem";
            this.editSubGroupToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.editSubGroupToolStripMenuItem.Text = "Edit";
            this.editSubGroupToolStripMenuItem.Click += new System.EventHandler(this.editSubGroupToolStripMenuItem_Click);
            // 
            // deleteSubGroupToolStripMenuItem
            // 
            this.deleteSubGroupToolStripMenuItem.Image = global::SetupParameterManager.Properties.Resources.delete;
            this.deleteSubGroupToolStripMenuItem.Name = "deleteSubGroupToolStripMenuItem";
            this.deleteSubGroupToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.deleteSubGroupToolStripMenuItem.Text = "Delete";
            this.deleteSubGroupToolStripMenuItem.Click += new System.EventHandler(this.deleteSubGroupToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Enabled = false;
            this.pasteToolStripMenuItem1.Image = global::SetupParameterManager.Properties.Resources.paste;
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.pasteToolStripMenuItem1.Text = "Paste";
            // 
            // editParameterToolStripMenuItem
            // 
            this.editParameterToolStripMenuItem.Image = global::SetupParameterManager.Properties.Resources.Edit;
            this.editParameterToolStripMenuItem.Name = "editParameterToolStripMenuItem";
            this.editParameterToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editParameterToolStripMenuItem.Text = "Edit";
            this.editParameterToolStripMenuItem.Click += new System.EventHandler(this.editParameterToolStripMenuItem_Click);
            // 
            // deleteParameterToolStripMenuItem
            // 
            this.deleteParameterToolStripMenuItem.Image = global::SetupParameterManager.Properties.Resources.delete;
            this.deleteParameterToolStripMenuItem.Name = "deleteParameterToolStripMenuItem";
            this.deleteParameterToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteParameterToolStripMenuItem.Text = "Delete";
            this.deleteParameterToolStripMenuItem.Click += new System.EventHandler(this.deleteParameterToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::SetupParameterManager.Properties.Resources.copy;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // SetupGroupsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(535, 332);
            this.Controls.Add(this.pnlParam);
            this.Controls.Add(this.pnlEditButtons);
            this.Controls.Add(this.pnlGroup);
            this.Controls.Add(this.tvSetup);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SetupGroupsEditor";
            this.Text = "Setup Definition Editor";
            this.Load += new System.EventHandler(this.SetupGroupsEditor_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ctxGroup.ResumeLayout(false);
            this.ctxSubGroup.ResumeLayout(false);
            this.ctxParameter.ResumeLayout(false);
            this.pnlGroup.ResumeLayout(false);
            this.pnlGroup.PerformLayout();
            this.pnlParam.ResumeLayout(false);
            this.pnlParam.PerformLayout();
            this.pnlEditButtons.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvSetup;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbLoad;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnCopy;
        private System.Windows.Forms.ContextMenuStrip ctxGroup;
        private System.Windows.Forms.ToolStripMenuItem tsmEditGroup;
        private System.Windows.Forms.ToolStripMenuItem tsmDeleteGroup;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addSubGroupToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctxSubGroup;
        private System.Windows.Forms.ContextMenuStrip ctxParameter;
        private System.Windows.Forms.ToolStripMenuItem editSubGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSubGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem addParameterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editParameterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteParameterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.Panel pnlGroup;
        private System.Windows.Forms.Panel pnlParam;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlEditButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtTranslatedSuffix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOriginalSuffix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkTranslatable;
        private System.Windows.Forms.ToolStripButton tsbPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem2;
    }
}