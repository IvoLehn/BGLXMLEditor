namespace BGLXMLEditor
{
    partial class FormGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGroup));
            this.labelCompany = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.labelReleasePath = new System.Windows.Forms.Label();
            this.checkBoxSachb = new System.Windows.Forms.CheckBox();
            this.textBoxGroupName = new System.Windows.Forms.TextBox();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.textBoxReleasePath = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxCompany = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCompany
            // 
            this.labelCompany.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCompany.AutoSize = true;
            this.labelCompany.Location = new System.Drawing.Point(3, 5);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(43, 17);
            this.labelCompany.TabIndex = 0;
            this.labelCompany.Text = "Firma";
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 32);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelPath
            // 
            this.labelPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(3, 59);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(37, 17);
            this.labelPath.TabIndex = 2;
            this.labelPath.Text = "Pfad";
            // 
            // labelReleasePath
            // 
            this.labelReleasePath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelReleasePath.AutoSize = true;
            this.labelReleasePath.Location = new System.Drawing.Point(3, 86);
            this.labelReleasePath.Name = "labelReleasePath";
            this.labelReleasePath.Size = new System.Drawing.Size(92, 17);
            this.labelReleasePath.TabIndex = 3;
            this.labelReleasePath.Text = "Freigabepfad";
            // 
            // checkBoxSachb
            // 
            this.checkBoxSachb.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.checkBoxSachb, 2);
            this.checkBoxSachb.Location = new System.Drawing.Point(3, 111);
            this.checkBoxSachb.Name = "checkBoxSachb";
            this.checkBoxSachb.Size = new System.Drawing.Size(247, 21);
            this.checkBoxSachb.TabIndex = 4;
            this.checkBoxSachb.Text = "Feld Sachbearbeiter freigeschaltet";
            this.checkBoxSachb.UseVisualStyleBackColor = true;
            // 
            // textBoxGroupName
            // 
            this.textBoxGroupName.Location = new System.Drawing.Point(151, 30);
            this.textBoxGroupName.Name = "textBoxGroupName";
            this.textBoxGroupName.Size = new System.Drawing.Size(549, 22);
            this.textBoxGroupName.TabIndex = 1;
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(151, 57);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(549, 22);
            this.textBoxPath.TabIndex = 2;
            // 
            // textBoxReleasePath
            // 
            this.textBoxReleasePath.Location = new System.Drawing.Point(151, 84);
            this.textBoxReleasePath.Name = "textBoxReleasePath";
            this.textBoxReleasePath.Size = new System.Drawing.Size(549, 22);
            this.textBoxReleasePath.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.94736F));
            this.tableLayoutPanel1.Controls.Add(this.labelCompany, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxSachb, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxReleasePath, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelReleasePath, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPath, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxGroupName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelPath, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonAdd, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonCancel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxCompany, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(703, 189);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(600, 138);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 48);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Hinzufügen";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCancel.Location = new System.Drawing.Point(3, 138);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 48);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Schließen";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonAbbrechen_Click);
            // 
            // comboBoxCompany
            // 
            this.comboBoxCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCompany.FormattingEnabled = true;
            this.comboBoxCompany.Location = new System.Drawing.Point(151, 3);
            this.comboBoxCompany.Name = "comboBoxCompany";
            this.comboBoxCompany.Size = new System.Drawing.Size(549, 24);
            this.comboBoxCompany.TabIndex = 0;
            // 
            // FormGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 189);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGroup";
            this.Load += new System.EventHandler(this.FormGroup_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label labelReleasePath;
        private System.Windows.Forms.CheckBox checkBoxSachb;
        private System.Windows.Forms.TextBox textBoxGroupName;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.TextBox textBoxReleasePath;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxCompany;
    }
}