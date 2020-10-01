namespace BGLXMLEditor
{
    partial class TestEcht
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestEcht));
            this.buttonTestSystem = new System.Windows.Forms.Button();
            this.buttonEchtSystem = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonTestSystem
            // 
            this.buttonTestSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonTestSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTestSystem.Location = new System.Drawing.Point(3, 3);
            this.buttonTestSystem.Name = "buttonTestSystem";
            this.buttonTestSystem.Size = new System.Drawing.Size(247, 228);
            this.buttonTestSystem.TabIndex = 0;
            this.buttonTestSystem.Text = "Testsystem";
            this.buttonTestSystem.UseVisualStyleBackColor = false;
            this.buttonTestSystem.Click += new System.EventHandler(this.buttonTestSystem_Click);
            // 
            // buttonEchtSystem
            // 
            this.buttonEchtSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonEchtSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEchtSystem.Location = new System.Drawing.Point(256, 3);
            this.buttonEchtSystem.Name = "buttonEchtSystem";
            this.buttonEchtSystem.Size = new System.Drawing.Size(248, 228);
            this.buttonEchtSystem.TabIndex = 1;
            this.buttonEchtSystem.Text = "Echtsystem";
            this.buttonEchtSystem.UseVisualStyleBackColor = false;
            this.buttonEchtSystem.Click += new System.EventHandler(this.buttonEchtSystem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonTestSystem, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonEchtSystem, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(507, 234);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // TestEcht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 234);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(525, 281);
            this.MinimumSize = new System.Drawing.Size(525, 281);
            this.Name = "TestEcht";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Systemauswahl";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTestSystem;
        private System.Windows.Forms.Button buttonEchtSystem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}