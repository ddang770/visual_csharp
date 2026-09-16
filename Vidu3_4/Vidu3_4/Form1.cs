using System.Windows.Forms;

namespace Vidu3_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbb_vandongvien.SelectedIndex = 0;
        }

        private void btn_chonhet_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lb_danhsach.Items.Count; i++)
            {
                string mon = lb_danhsach.Items[i].ToString();

                if (!lb_danhsachdachon.Items.Contains(mon))
                {
                    lb_danhsachdachon.Items.Add(mon);
                }
            }
            lb_danhsach.Items.Clear();

        }

        private void btn_chontung_Click(object sender, EventArgs e)
        {
            if (lb_danhsach.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn 1 môn thể thao");
                return;
            }
            string mon = lb_danhsach.SelectedItem.ToString();
            if (!lb_danhsachdachon.Items.Contains(mon))
            {
                lb_danhsachdachon.Items.Add(mon);
                lb_danhsach.Items.Remove(mon);
            }

        }

        private void btn_bochontung_Click(object sender, EventArgs e)
        {
            if (lb_danhsachdachon.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn 1 môn thể thao");
                return;
            }
            string mon = lb_danhsachdachon.SelectedItem.ToString();
            if (!lb_danhsach.Items.Contains(mon))
            {
                lb_danhsach.Items.Add(mon);
                lb_danhsachdachon.Items.Remove(mon);
            }
        }

        private void btn_bochonhet_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lb_danhsachdachon.Items.Count; i++)
            {
                string mon = lb_danhsachdachon.Items[i].ToString();

                if (!lb_danhsach.Items.Contains(mon))
                {
                    lb_danhsach.Items.Add(mon);
                }
            }
            lb_danhsachdachon.Items.Clear();
        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            string vanDongVien = cbb_vandongvien.Text;
            DateTime ngayDangKy = dtp_thoigiandangky.Value;

            List<string> danhSachMon = new List<string>();

            foreach (var item in lb_danhsachdachon.Items)
            {
                danhSachMon.Add(item.ToString());
            }
            string monThi = string.Join("; ", danhSachMon);

            tb_dangky.Text =
                "Vận động viên: " + vanDongVien + Environment.NewLine +
                "Đăng ký: " + ngayDangKy.ToString("dd-MM-yyyy hh:mm:ss tt") + Environment.NewLine +
                "Các môn đã chọn: " + Environment.NewLine +
                monThi;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            cbb_vandongvien.SelectedIndex = 0;
            dtp_thoigiandangky.Value = DateTime.Now;

            lb_danhsach.Items.Clear();
            lb_danhsachdachon.Items.Clear();

            lb_danhsach.Items.Add("Bóng đá");
            lb_danhsach.Items.Add("Bóng chuyền");
            lb_danhsach.Items.Add("Cầu lông");
            lb_danhsach.Items.Add("Tennis");
            lb_danhsach.Items.Add("Bơi");

            lb_danhsachdachon.Items.Add("Đấu kiếm");
            lb_danhsachdachon.Items.Add("Bắn súng");

            tb_dangky.Clear();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
