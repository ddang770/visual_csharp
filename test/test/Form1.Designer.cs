namespace test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStripContainer1 = new ToolStripContainer();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            dgv_Sinhvien = new DataGridView();
            masv = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            age = new DataGridViewTextBoxColumn();
            toolStripContainer1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Sinhvien).BeginInit();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Size = new Size(778, 0);
            toolStripContainer1.Location = new Point(9, 5);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(778, 17);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, saveToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(128, 26);
            newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(128, 26);
            openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(49, 24);
            saveToolStripMenuItem.Text = "Edit";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // dgv_Sinhvien
            // 
            dgv_Sinhvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Sinhvien.Columns.AddRange(new DataGridViewColumn[] { masv, name, age });
            dgv_Sinhvien.Location = new Point(16, 105);
            dgv_Sinhvien.Name = "dgv_Sinhvien";
            dgv_Sinhvien.RowHeadersWidth = 51;
            dgv_Sinhvien.Size = new Size(764, 271);
            dgv_Sinhvien.TabIndex = 3;
            dgv_Sinhvien.CellContentClick += dataGridView1_CellContentClick;
            // 
            // masv
            // 
            masv.DataPropertyName = "Masv";
            masv.HeaderText = "Mã svien";
            masv.MinimumWidth = 6;
            masv.Name = "masv";
            masv.Width = 125;
            // 
            // name
            // 
            name.DataPropertyName = "Name";
            name.HeaderText = "Họ tên";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.Width = 125;
            // 
            // age
            // 
            age.DataPropertyName = "Age";
            age.HeaderText = "Tuổi";
            age.MinimumWidth = 6;
            age.Name = "age";
            age.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_Sinhvien);
            Controls.Add(menuStrip1);
            Controls.Add(toolStripContainer1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Sinhvien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripContainer toolStripContainer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private DataGridView dgv_Sinhvien;
        private DataGridViewTextBoxColumn masv;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn age;
    }
}
