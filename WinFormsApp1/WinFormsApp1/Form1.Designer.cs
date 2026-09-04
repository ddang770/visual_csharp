namespace WinFormsApp1
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
            groupBox_chonpt = new GroupBox();
            radiobtn_ptb2 = new RadioButton();
            radiobtn_ptb1 = new RadioButton();
            groupBox_thongso = new GroupBox();
            textBox_ketqua = new TextBox();
            textBox_c = new TextBox();
            textBox_b = new TextBox();
            textBox_a = new TextBox();
            label_ketqua = new Label();
            label_nhapc = new Label();
            label_nhapb = new Label();
            label_nhapa = new Label();
            button_giai = new Button();
            button_xoa = new Button();
            button_thoat = new Button();
            label5 = new Label();
            groupBox_chonpt.SuspendLayout();
            groupBox_thongso.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_chonpt
            // 
            groupBox_chonpt.Controls.Add(radiobtn_ptb2);
            groupBox_chonpt.Controls.Add(radiobtn_ptb1);
            groupBox_chonpt.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox_chonpt.Location = new Point(70, 83);
            groupBox_chonpt.Name = "groupBox_chonpt";
            groupBox_chonpt.Size = new Size(528, 120);
            groupBox_chonpt.TabIndex = 0;
            groupBox_chonpt.TabStop = false;
            groupBox_chonpt.Text = "Chọn phương trình";
            // 
            // radiobtn_ptb2
            // 
            radiobtn_ptb2.AutoSize = true;
            radiobtn_ptb2.Location = new Point(27, 72);
            radiobtn_ptb2.Name = "radiobtn_ptb2";
            radiobtn_ptb2.Size = new Size(328, 26);
            radiobtn_ptb2.TabIndex = 1;
            radiobtn_ptb2.TabStop = true;
            radiobtn_ptb2.Text = "Phương trình bậc 2: ax^2 + bx + c = 0";
            radiobtn_ptb2.UseVisualStyleBackColor = true;
            radiobtn_ptb2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radiobtn_ptb1
            // 
            radiobtn_ptb1.AutoSize = true;
            radiobtn_ptb1.Location = new Point(27, 40);
            radiobtn_ptb1.Name = "radiobtn_ptb1";
            radiobtn_ptb1.Size = new Size(271, 26);
            radiobtn_ptb1.TabIndex = 0;
            radiobtn_ptb1.TabStop = true;
            radiobtn_ptb1.Text = "Phương trình bậc 1: ax + b = 0";
            radiobtn_ptb1.UseVisualStyleBackColor = true;
            radiobtn_ptb1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox_thongso
            // 
            groupBox_thongso.Controls.Add(textBox_ketqua);
            groupBox_thongso.Controls.Add(textBox_c);
            groupBox_thongso.Controls.Add(textBox_b);
            groupBox_thongso.Controls.Add(textBox_a);
            groupBox_thongso.Controls.Add(label_ketqua);
            groupBox_thongso.Controls.Add(label_nhapc);
            groupBox_thongso.Controls.Add(label_nhapb);
            groupBox_thongso.Controls.Add(label_nhapa);
            groupBox_thongso.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox_thongso.Location = new Point(70, 228);
            groupBox_thongso.Name = "groupBox_thongso";
            groupBox_thongso.Size = new Size(528, 222);
            groupBox_thongso.TabIndex = 1;
            groupBox_thongso.TabStop = false;
            groupBox_thongso.Text = "Thông số";
            // 
            // textBox_ketqua
            // 
            textBox_ketqua.Location = new Point(124, 163);
            textBox_ketqua.Name = "textBox_ketqua";
            textBox_ketqua.Size = new Size(351, 30);
            textBox_ketqua.TabIndex = 7;
            // 
            // textBox_c
            // 
            textBox_c.Location = new Point(124, 124);
            textBox_c.Name = "textBox_c";
            textBox_c.Size = new Size(351, 30);
            textBox_c.TabIndex = 6;
            // 
            // textBox_b
            // 
            textBox_b.Location = new Point(124, 85);
            textBox_b.Name = "textBox_b";
            textBox_b.Size = new Size(351, 30);
            textBox_b.TabIndex = 5;
            // 
            // textBox_a
            // 
            textBox_a.Location = new Point(124, 43);
            textBox_a.Name = "textBox_a";
            textBox_a.Size = new Size(351, 30);
            textBox_a.TabIndex = 4;
            // 
            // label_ketqua
            // 
            label_ketqua.AutoSize = true;
            label_ketqua.Location = new Point(32, 163);
            label_ketqua.Name = "label_ketqua";
            label_ketqua.Size = new Size(77, 22);
            label_ketqua.TabIndex = 3;
            label_ketqua.Text = "Kết quả:";
            // 
            // label_nhapc
            // 
            label_nhapc.AutoSize = true;
            label_nhapc.Location = new Point(32, 127);
            label_nhapc.Name = "label_nhapc";
            label_nhapc.Size = new Size(72, 22);
            label_nhapc.TabIndex = 2;
            label_nhapc.Text = "Nhập c:";
            // 
            // label_nhapb
            // 
            label_nhapb.AutoSize = true;
            label_nhapb.Location = new Point(32, 85);
            label_nhapb.Name = "label_nhapb";
            label_nhapb.Size = new Size(73, 22);
            label_nhapb.TabIndex = 1;
            label_nhapb.Text = "Nhập b:";
            // 
            // label_nhapa
            // 
            label_nhapa.AutoSize = true;
            label_nhapa.Location = new Point(32, 46);
            label_nhapa.Name = "label_nhapa";
            label_nhapa.Size = new Size(72, 22);
            label_nhapa.TabIndex = 0;
            label_nhapa.Text = "Nhập a:";
            // 
            // button_giai
            // 
            button_giai.Font = new Font("Times New Roman", 12F);
            button_giai.Location = new Point(148, 473);
            button_giai.Name = "button_giai";
            button_giai.Size = new Size(85, 35);
            button_giai.TabIndex = 2;
            button_giai.Text = "Giải";
            button_giai.UseVisualStyleBackColor = true;
            button_giai.Click += button_giai_Click;
            // 
            // button_xoa
            // 
            button_xoa.Font = new Font("Times New Roman", 12F);
            button_xoa.Location = new Point(273, 473);
            button_xoa.Name = "button_xoa";
            button_xoa.Size = new Size(86, 35);
            button_xoa.TabIndex = 3;
            button_xoa.Text = "Xóa";
            button_xoa.UseVisualStyleBackColor = true;
            button_xoa.Click += button_xoa_Click;
            // 
            // button_thoat
            // 
            button_thoat.Font = new Font("Times New Roman", 12F);
            button_thoat.Location = new Point(391, 473);
            button_thoat.Name = "button_thoat";
            button_thoat.Size = new Size(79, 35);
            button_thoat.TabIndex = 4;
            button_thoat.Text = "Thoát";
            button_thoat.UseVisualStyleBackColor = true;
            button_thoat.Click += button_thoat_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(157, 21);
            label5.Name = "label5";
            label5.Size = new Size(373, 38);
            label5.TabIndex = 5;
            label5.Text = "GIẢI PHƯƠNG TRÌNH";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 531);
            Controls.Add(label5);
            Controls.Add(button_thoat);
            Controls.Add(button_xoa);
            Controls.Add(button_giai);
            Controls.Add(groupBox_thongso);
            Controls.Add(groupBox_chonpt);
            Name = "Form1";
            Text = "Giải phương trình";
            groupBox_chonpt.ResumeLayout(false);
            groupBox_chonpt.PerformLayout();
            groupBox_thongso.ResumeLayout(false);
            groupBox_thongso.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox_chonpt;
        private RadioButton radiobtn_ptb2;
        private RadioButton radiobtn_ptb1;
        private GroupBox groupBox_thongso;
        private TextBox textBox_ketqua;
        private TextBox textBox_c;
        private TextBox textBox_b;
        private TextBox textBox_a;
        private Label label_ketqua;
        private Label label_nhapc;
        private Label label_nhapb;
        private Label label_nhapa;
        private Button button_giai;
        private Button button_xoa;
        private Button button_thoat;
        private Label label5;
    }
}
