namespace Vidu3_4
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
            header = new Label();
            label_vandongvien = new Label();
            label_thoigiandangky = new Label();
            label_listTheThao = new Label();
            cbb_vandongvien = new ComboBox();
            dtp_thoigiandangky = new DateTimePicker();
            lb_danhsach = new ListBox();
            lb_danhsachdachon = new ListBox();
            btn_chonhet = new Button();
            btn_chontung = new Button();
            btn_bochontung = new Button();
            btn_bochonhet = new Button();
            label_ketqua = new Label();
            tb_dangky = new TextBox();
            btn_dangky = new Button();
            btn_huy = new Button();
            btn_thoat = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // header
            // 
            header.AutoSize = true;
            header.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            header.ForeColor = Color.Red;
            header.Location = new Point(112, 26);
            header.Name = "header";
            header.Size = new Size(441, 32);
            header.TabIndex = 0;
            header.Text = "ĐĂNG KÝ CÁC MÔN THỂ THAO";
            // 
            // label_vandongvien
            // 
            label_vandongvien.AutoSize = true;
            label_vandongvien.Font = new Font("Times New Roman", 12F);
            label_vandongvien.Location = new Point(53, 88);
            label_vandongvien.Name = "label_vandongvien";
            label_vandongvien.Size = new Size(129, 22);
            label_vandongvien.TabIndex = 1;
            label_vandongvien.Text = "Vận động viên:";
            // 
            // label_thoigiandangky
            // 
            label_thoigiandangky.AutoSize = true;
            label_thoigiandangky.Font = new Font("Times New Roman", 12F);
            label_thoigiandangky.Location = new Point(53, 133);
            label_thoigiandangky.Name = "label_thoigiandangky";
            label_thoigiandangky.Size = new Size(158, 22);
            label_thoigiandangky.TabIndex = 2;
            label_thoigiandangky.Text = "Thời gian đăng ký:";
            // 
            // label_listTheThao
            // 
            label_listTheThao.AutoSize = true;
            label_listTheThao.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_listTheThao.Location = new Point(53, 178);
            label_listTheThao.Name = "label_listTheThao";
            label_listTheThao.Size = new Size(250, 23);
            label_listTheThao.TabIndex = 3;
            label_listTheThao.Text = "Danh sách các môn thể thao:";
            // 
            // cbb_vandongvien
            // 
            cbb_vandongvien.Font = new Font("Times New Roman", 10.2F);
            cbb_vandongvien.FormattingEnabled = true;
            cbb_vandongvien.Items.AddRange(new object[] { "Nguyễn Văn Long", "Nguyễn Minh Long", "Nguyễn Hữu Đạt" });
            cbb_vandongvien.Location = new Point(261, 83);
            cbb_vandongvien.Name = "cbb_vandongvien";
            cbb_vandongvien.Size = new Size(328, 27);
            cbb_vandongvien.TabIndex = 4;
            // 
            // dtp_thoigiandangky
            // 
            dtp_thoigiandangky.Font = new Font("Times New Roman", 10.2F);
            dtp_thoigiandangky.Location = new Point(261, 129);
            dtp_thoigiandangky.Name = "dtp_thoigiandangky";
            dtp_thoigiandangky.Size = new Size(328, 27);
            dtp_thoigiandangky.TabIndex = 5;
            // 
            // lb_danhsach
            // 
            lb_danhsach.Font = new Font("Times New Roman", 10.2F);
            lb_danhsach.FormattingEnabled = true;
            lb_danhsach.ItemHeight = 19;
            lb_danhsach.Items.AddRange(new object[] { "Bóng đá", "Bóng chuyền", "Cầu lông", "Tennis", "Bơi" });
            lb_danhsach.Location = new Point(53, 217);
            lb_danhsach.Name = "lb_danhsach";
            lb_danhsach.Size = new Size(204, 156);
            lb_danhsach.TabIndex = 6;
            // 
            // lb_danhsachdachon
            // 
            lb_danhsachdachon.Font = new Font("Times New Roman", 10.2F);
            lb_danhsachdachon.FormattingEnabled = true;
            lb_danhsachdachon.ItemHeight = 19;
            lb_danhsachdachon.Items.AddRange(new object[] { "Đấu kiếm", "Bắn súng" });
            lb_danhsachdachon.Location = new Point(360, 216);
            lb_danhsachdachon.Name = "lb_danhsachdachon";
            lb_danhsachdachon.Size = new Size(229, 156);
            lb_danhsachdachon.TabIndex = 7;
            // 
            // btn_chonhet
            // 
            btn_chonhet.Location = new Point(289, 217);
            btn_chonhet.Name = "btn_chonhet";
            btn_chonhet.Size = new Size(40, 31);
            btn_chonhet.TabIndex = 8;
            btn_chonhet.Text = ">>";
            btn_chonhet.UseVisualStyleBackColor = true;
            btn_chonhet.Click += btn_chonhet_Click;
            // 
            // btn_chontung
            // 
            btn_chontung.Location = new Point(289, 256);
            btn_chontung.Name = "btn_chontung";
            btn_chontung.Size = new Size(40, 33);
            btn_chontung.TabIndex = 9;
            btn_chontung.Text = ">";
            btn_chontung.UseVisualStyleBackColor = true;
            btn_chontung.Click += btn_chontung_Click;
            // 
            // btn_bochontung
            // 
            btn_bochontung.Location = new Point(289, 295);
            btn_bochontung.Name = "btn_bochontung";
            btn_bochontung.Size = new Size(40, 34);
            btn_bochontung.TabIndex = 10;
            btn_bochontung.Text = "<";
            btn_bochontung.UseVisualStyleBackColor = true;
            btn_bochontung.Click += btn_bochontung_Click;
            // 
            // btn_bochonhet
            // 
            btn_bochonhet.Location = new Point(289, 335);
            btn_bochonhet.Name = "btn_bochonhet";
            btn_bochonhet.Size = new Size(40, 37);
            btn_bochonhet.TabIndex = 11;
            btn_bochonhet.Text = "<<";
            btn_bochonhet.UseVisualStyleBackColor = true;
            btn_bochonhet.Click += btn_bochonhet_Click;
            // 
            // label_ketqua
            // 
            label_ketqua.AutoSize = true;
            label_ketqua.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_ketqua.Location = new Point(53, 398);
            label_ketqua.Name = "label_ketqua";
            label_ketqua.Size = new Size(154, 23);
            label_ketqua.TabIndex = 12;
            label_ketqua.Text = "Kết quả đăng ký:";
            // 
            // tb_dangky
            // 
            tb_dangky.Font = new Font("Times New Roman", 10.2F);
            tb_dangky.Location = new Point(53, 436);
            tb_dangky.Multiline = true;
            tb_dangky.Name = "tb_dangky";
            tb_dangky.Size = new Size(536, 114);
            tb_dangky.TabIndex = 13;
            // 
            // btn_dangky
            // 
            btn_dangky.Font = new Font("Times New Roman", 12F);
            btn_dangky.Location = new Point(55, 556);
            btn_dangky.Name = "btn_dangky";
            btn_dangky.Size = new Size(101, 29);
            btn_dangky.TabIndex = 14;
            btn_dangky.Text = "Đăng ký";
            btn_dangky.UseVisualStyleBackColor = true;
            btn_dangky.Click += btn_dangky_Click;
            // 
            // btn_huy
            // 
            btn_huy.Font = new Font("Times New Roman", 12F);
            btn_huy.Location = new Point(194, 556);
            btn_huy.Name = "btn_huy";
            btn_huy.Size = new Size(94, 29);
            btn_huy.TabIndex = 15;
            btn_huy.Text = "Hủy";
            btn_huy.UseVisualStyleBackColor = true;
            btn_huy.Click += btn_huy_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.Font = new Font("Times New Roman", 12F);
            btn_thoat.Location = new Point(323, 556);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(94, 29);
            btn_thoat.TabIndex = 16;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(226, 58);
            label1.Name = "label1";
            label1.Size = new Size(191, 15);
            label1.TabIndex = 17;
            label1.Text = "Nguyễn Đắc Đăng - 75DCTT21300";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 610);
            Controls.Add(label1);
            Controls.Add(btn_thoat);
            Controls.Add(btn_huy);
            Controls.Add(btn_dangky);
            Controls.Add(tb_dangky);
            Controls.Add(label_ketqua);
            Controls.Add(btn_bochonhet);
            Controls.Add(btn_bochontung);
            Controls.Add(btn_chontung);
            Controls.Add(btn_chonhet);
            Controls.Add(lb_danhsachdachon);
            Controls.Add(lb_danhsach);
            Controls.Add(dtp_thoigiandangky);
            Controls.Add(cbb_vandongvien);
            Controls.Add(label_listTheThao);
            Controls.Add(label_thoigiandangky);
            Controls.Add(label_vandongvien);
            Controls.Add(header);
            Name = "Form1";
            Text = "Đăng ký";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label header;
        private Label label_vandongvien;
        private Label label_thoigiandangky;
        private Label label_listTheThao;
        private ComboBox cbb_vandongvien;
        private DateTimePicker dtp_thoigiandangky;
        private ListBox lb_danhsach;
        private ListBox lb_danhsachdachon;
        private Button btn_chonhet;
        private Button btn_chontung;
        private Button btn_bochontung;
        private Button btn_bochonhet;
        private Label label_ketqua;
        private TextBox tb_dangky;
        private Button btn_dangky;
        private Button btn_huy;
        private Button btn_thoat;
        private Label label1;
    }
}
