namespace DigitalPlatform.DTLP
{
    partial class DefaultProjectDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefaultProjectDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_databaseName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_defaultProjectName = new System.Windows.Forms.TextBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_findProjectName = new System.Windows.Forms.Button();
            this.button_findDatabaseName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "���ݿ�(&D):";
            // 
            // textBox_databaseName
            // 
            this.textBox_databaseName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_databaseName.Location = new System.Drawing.Point(12, 27);
            this.textBox_databaseName.Name = "textBox_databaseName";
            this.textBox_databaseName.ReadOnly = true;
            this.textBox_databaseName.Size = new System.Drawing.Size(219, 25);
            this.textBox_databaseName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "ȱʡ���ط���(&D):";
            // 
            // textBox_defaultProjectName
            // 
            this.textBox_defaultProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_defaultProjectName.Location = new System.Drawing.Point(12, 91);
            this.textBox_defaultProjectName.Name = "textBox_defaultProjectName";
            this.textBox_defaultProjectName.Size = new System.Drawing.Size(219, 25);
            this.textBox_defaultProjectName.TabIndex = 4;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(205, 174);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 28);
            this.button_Cancel.TabIndex = 7;
            this.button_Cancel.Text = "ȡ��";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_OK
            // 
            this.button_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_OK.Location = new System.Drawing.Point(124, 174);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 28);
            this.button_OK.TabIndex = 6;
            this.button_OK.Text = "ȷ��";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_findProjectName
            // 
            this.button_findProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_findProjectName.Location = new System.Drawing.Point(237, 91);
            this.button_findProjectName.Name = "button_findProjectName";
            this.button_findProjectName.Size = new System.Drawing.Size(43, 26);
            this.button_findProjectName.TabIndex = 5;
            this.button_findProjectName.Text = "...";
            this.button_findProjectName.UseVisualStyleBackColor = true;
            this.button_findProjectName.Click += new System.EventHandler(this.button_findProjectName_Click);
            // 
            // button_findDatabaseName
            // 
            this.button_findDatabaseName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_findDatabaseName.Enabled = false;
            this.button_findDatabaseName.Location = new System.Drawing.Point(237, 27);
            this.button_findDatabaseName.Name = "button_findDatabaseName";
            this.button_findDatabaseName.Size = new System.Drawing.Size(43, 26);
            this.button_findDatabaseName.TabIndex = 2;
            this.button_findDatabaseName.Text = "...";
            this.button_findDatabaseName.UseVisualStyleBackColor = true;
            this.button_findDatabaseName.Click += new System.EventHandler(this.button_findDatabaseName_Click);
            // 
            // DefaultProjectDialog
            // 
            this.AcceptButton = this.button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Cancel;
            this.ClientSize = new System.Drawing.Size(292, 214);
            this.Controls.Add(this.button_findDatabaseName);
            this.Controls.Add(this.button_findProjectName);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.textBox_defaultProjectName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_databaseName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DefaultProjectDialog";
            this.ShowInTaskbar = false;
            this.Text = "ȱʡ��ϵ����";
            this.Load += new System.EventHandler(this.DefaultProjectDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_databaseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_defaultProjectName;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_findProjectName;
        private System.Windows.Forms.Button button_findDatabaseName;
    }
}