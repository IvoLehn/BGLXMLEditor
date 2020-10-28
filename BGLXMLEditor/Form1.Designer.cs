namespace BGLXMLEditor
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeViewUser = new System.Windows.Forms.TreeView();
            this.treeViewCompany = new System.Windows.Forms.TreeView();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonRemoveUser = new System.Windows.Forms.Button();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.buttonRemoveGroup = new System.Windows.Forms.Button();
            this.buttonEditUser = new System.Windows.Forms.Button();
            this.buttonEditGroup = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxUsers = new System.Windows.Forms.GroupBox();
            this.groupBoxCompany = new System.Windows.Forms.GroupBox();
            this.labelVersion = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxUsers.SuspendLayout();
            this.groupBoxCompany.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewUser
            // 
            this.treeViewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.treeViewUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewUser.ForeColor = System.Drawing.Color.White;
            this.treeViewUser.HideSelection = false;
            this.treeViewUser.Location = new System.Drawing.Point(3, 18);
            this.treeViewUser.Name = "treeViewUser";
            this.treeViewUser.Size = new System.Drawing.Size(384, 569);
            this.treeViewUser.TabIndex = 6;
            this.treeViewUser.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeViewCompanyAndUser_AfterExpand);
            // 
            // treeViewCompany
            // 
            this.treeViewCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.treeViewCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewCompany.ForeColor = System.Drawing.Color.White;
            this.treeViewCompany.HideSelection = false;
            this.treeViewCompany.Location = new System.Drawing.Point(3, 18);
            this.treeViewCompany.Name = "treeViewCompany";
            this.treeViewCompany.Size = new System.Drawing.Size(390, 569);
            this.treeViewCompany.TabIndex = 9;
            this.treeViewCompany.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeViewCompanyAndUser_AfterExpand);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddUser.Location = new System.Drawing.Point(3, 3);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(126, 44);
            this.buttonAddUser.TabIndex = 0;
            this.buttonAddUser.Text = "Benutzer hinzufügen";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonRemoveUser
            // 
            this.buttonRemoveUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRemoveUser.Location = new System.Drawing.Point(267, 3);
            this.buttonRemoveUser.Name = "buttonRemoveUser";
            this.buttonRemoveUser.Size = new System.Drawing.Size(126, 44);
            this.buttonRemoveUser.TabIndex = 2;
            this.buttonRemoveUser.Text = "Benutzer entfernen";
            this.buttonRemoveUser.UseVisualStyleBackColor = true;
            this.buttonRemoveUser.Click += new System.EventHandler(this.buttonRemoveUser_Click);
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddGroup.Location = new System.Drawing.Point(531, 3);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(126, 44);
            this.buttonAddGroup.TabIndex = 3;
            this.buttonAddGroup.Text = "Gruppe hinzufügen";
            this.buttonAddGroup.UseVisualStyleBackColor = true;
            this.buttonAddGroup.Click += new System.EventHandler(this.buttonAddGroup_Click);
            // 
            // buttonRemoveGroup
            // 
            this.buttonRemoveGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRemoveGroup.Location = new System.Drawing.Point(795, 3);
            this.buttonRemoveGroup.Name = "buttonRemoveGroup";
            this.buttonRemoveGroup.Size = new System.Drawing.Size(132, 44);
            this.buttonRemoveGroup.TabIndex = 5;
            this.buttonRemoveGroup.Text = "Gruppe entfernen";
            this.buttonRemoveGroup.UseVisualStyleBackColor = true;
            this.buttonRemoveGroup.Click += new System.EventHandler(this.buttonRemoveGroup_Click);
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEditUser.Location = new System.Drawing.Point(135, 3);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(126, 44);
            this.buttonEditUser.TabIndex = 1;
            this.buttonEditUser.Text = "Benutzer bearbeiten";
            this.buttonEditUser.UseVisualStyleBackColor = true;
            this.buttonEditUser.Click += new System.EventHandler(this.buttonEditUser_Click);
            // 
            // buttonEditGroup
            // 
            this.buttonEditGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEditGroup.Location = new System.Drawing.Point(663, 3);
            this.buttonEditGroup.Name = "buttonEditGroup";
            this.buttonEditGroup.Size = new System.Drawing.Size(126, 44);
            this.buttonEditGroup.TabIndex = 4;
            this.buttonEditGroup.Text = "Gruppe bearbeiten";
            this.buttonEditGroup.UseVisualStyleBackColor = true;
            this.buttonEditGroup.Click += new System.EventHandler(this.buttonEditGroup_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdd.Location = new System.Drawing.Point(399, 291);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(126, 54);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "<- Hinzufügen";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRemove.Location = new System.Drawing.Point(399, 351);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(126, 54);
            this.buttonRemove.TabIndex = 8;
            this.buttonRemove.Text = "Entfernen ->";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.Controls.Add(this.buttonAddUser, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonRemove, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonEditUser, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonRemoveGroup, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonEditGroup, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAdd, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonRemoveUser, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAddGroup, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxUsers, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxCompany, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelVersion, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(930, 666);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // groupBoxUsers
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBoxUsers, 3);
            this.groupBoxUsers.Controls.Add(this.treeViewUser);
            this.groupBoxUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxUsers.Location = new System.Drawing.Point(3, 53);
            this.groupBoxUsers.Name = "groupBoxUsers";
            this.tableLayoutPanel1.SetRowSpan(this.groupBoxUsers, 4);
            this.groupBoxUsers.Size = new System.Drawing.Size(390, 590);
            this.groupBoxUsers.TabIndex = 9;
            this.groupBoxUsers.TabStop = false;
            this.groupBoxUsers.Text = "Benuzter";
            // 
            // groupBoxCompany
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBoxCompany, 3);
            this.groupBoxCompany.Controls.Add(this.treeViewCompany);
            this.groupBoxCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCompany.Location = new System.Drawing.Point(531, 53);
            this.groupBoxCompany.Name = "groupBoxCompany";
            this.tableLayoutPanel1.SetRowSpan(this.groupBoxCompany, 4);
            this.groupBoxCompany.Size = new System.Drawing.Size(396, 590);
            this.groupBoxCompany.TabIndex = 10;
            this.groupBoxCompany.TabStop = false;
            this.groupBoxCompany.Text = "Gruppen";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelVersion, 7);
            this.labelVersion.Location = new System.Drawing.Point(3, 646);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(0, 17);
            this.labelVersion.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 666);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BGLXML-Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBoxUsers.ResumeLayout(false);
            this.groupBoxCompany.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewUser;
        private System.Windows.Forms.TreeView treeViewCompany;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonRemoveUser;
        private System.Windows.Forms.Button buttonAddGroup;
        private System.Windows.Forms.Button buttonRemoveGroup;
        private System.Windows.Forms.Button buttonEditUser;
        private System.Windows.Forms.Button buttonEditGroup;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxUsers;
        private System.Windows.Forms.GroupBox groupBoxCompany;
        private System.Windows.Forms.Label labelVersion;
    }
}

