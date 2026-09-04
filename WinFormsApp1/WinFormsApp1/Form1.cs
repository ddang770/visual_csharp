using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtn_ptb1.Checked)
            {
                textBox_c.Enabled = false;
                textBox_c.Clear();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtn_ptb2.Checked)
            {
                textBox_c.Enabled = true;
            }
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            textBox_a.Clear();
            textBox_b.Clear();
            textBox_c.Clear();
            textBox_ketqua.Clear();
            radiobtn_ptb1.Checked = false;
            radiobtn_ptb2.Checked = false;
            textBox_c.Enabled = true;
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát ko?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
                Application.Exit();
        }

        private void giai_ptb1(double a, double b)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    textBox_ketqua.Text = "Phương trình vô số nghiệm";
                }
                else
                {
                    textBox_ketqua.Text = "Phương trình vô nghiệm";
                }
            }
            else
            {
                textBox_ketqua.Text = $"x = {-b / a}";
            }
        }

        private void giai_ptb2(double a, double b, double c)
        {

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        textBox_ketqua.Text = "Phương trình vô số nghiệm";
                        return;
                    }
                    textBox_ketqua.Text = "Phương trình vô nghiệm";
                    return;
                }
                textBox_ketqua.Text = "x = " + (-c / b);
                return;
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta == 0)
                {
                    textBox_ketqua.Text = "x1 = x2 = " + (-b / (2 * a));
                }
                else if (delta < 0)
                {
                    textBox_ketqua.Text = "Phương trình vô nghiệm";
                }
                else
                {
                    textBox_ketqua.Text = $"x1 = {((-b + Math.Sqrt(delta)) / (2 * a))}, x2 = {((-b - Math.Sqrt(delta)) / (2 * a))}";
                }
            }
        }

        private void button_giai_Click(object sender, EventArgs e)
        {
            textBox_ketqua.Clear();

            if(!radiobtn_ptb1.Checked && !radiobtn_ptb2.Checked)
            {
                MessageBox.Show("Vui lòng chọn loại phương trình!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if(!double.TryParse(textBox_a.Text, out double a))
            {
                MessageBox.Show("Hệ số a ko hợp lệ!", "Type error", MessageBoxButtons.OK);
                textBox_a.Focus();
                return;
            }
            //Debug.WriteLine(a + 1);
            if (!double.TryParse(textBox_b.Text, out double b))
            {
                MessageBox.Show("Hệ số b ko hợp lệ!", "Type error", MessageBoxButtons.OK);
                textBox_b.Focus();
                return;
            }

            //giai ptb1
            if (radiobtn_ptb1.Checked)
            {
                giai_ptb1(a, b);
            }
            else if (radiobtn_ptb2.Checked)
            {
                if (!double.TryParse(textBox_c.Text, out double c))
                {
                    MessageBox.Show("Hệ số c ko hợp lệ!", "Type error", MessageBoxButtons.OK);
                    textBox_c.Focus();
                    return;
                }

                giai_ptb2(a, b, c);
            }
        }
    }
}
