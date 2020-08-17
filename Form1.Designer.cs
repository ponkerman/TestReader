namespace TestReader
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.FolderButt = new System.Windows.Forms.ToolStripMenuItem();
            this.ScanButton = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchButton = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.file_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prerequisites = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.test_result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FolderButt,
            this.ScanButton,
            this.UpdateButton,
            this.SearchButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FolderButt
            // 
            this.FolderButt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FolderButt.Name = "FolderButt";
            this.FolderButt.Size = new System.Drawing.Size(52, 25);
            this.FolderButt.Text = "Folder";
            this.FolderButt.Click += new System.EventHandler(this.FolderButt_Click);
            // 
            // ScanButton
            // 
            this.ScanButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ScanButton.Enabled = false;
            this.ScanButton.Name = "ScanButton";
            this.ScanButton.Size = new System.Drawing.Size(44, 25);
            this.ScanButton.Text = "Scan";
            this.ScanButton.Click += new System.EventHandler(this.Scan_Button_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UpdateButton.Enabled = false;
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(57, 25);
            this.UpdateButton.Text = "Update";
            // 
            // SearchButton
            // 
            this.SearchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SearchButton.Enabled = false;
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(54, 25);
            this.SearchButton.Text = "Search";
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.file_name,
            this.prerequisites,
            this.description,
            this.test_result});
            this.dataGridView1.Location = new System.Drawing.Point(2, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(786, 410);
            this.dataGridView1.TabIndex = 0;
            // 
            // file_name
            // 
            this.file_name.HeaderText = "file name";
            this.file_name.Name = "file_name";
            // 
            // prerequisites
            // 
            this.prerequisites.HeaderText = "Prerequisites";
            this.prerequisites.Name = "prerequisites";
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            // 
            // test_result
            // 
            this.test_result.HeaderText = "Test result";
            this.test_result.Name = "test_result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem FolderButt;
        private System.Windows.Forms.ToolStripMenuItem ScanButton;
        private System.Windows.Forms.ToolStripMenuItem UpdateButton;
        private System.Windows.Forms.ToolStripMenuItem SearchButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn file_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn prerequisites;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn test_result;
    }
}

