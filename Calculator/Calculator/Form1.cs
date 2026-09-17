namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btn_0.Click += Number_Click;
            btn_1.Click += Number_Click;
            btn_2.Click += Number_Click;
            btn_3.Click += Number_Click;
            btn_4.Click += Number_Click;
            btn_5.Click += Number_Click;
            btn_6.Click += Number_Click;
            btn_7.Click += Number_Click;
            btn_8.Click += Number_Click;
            btn_9.Click += Number_Click;

            btn_plus.Click += Operation_Click;
            btn_minus.Click += Operation_Click;
            btn_time.Click += Operation_Click;
            btn_divide.Click += Operation_Click;

            btn_equal.Click += Equal_Click;
            btn_delete.Click += Clear_Click;
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            txt_Answer.Text += button.Text;
        }

        private void Operation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            txt_Answer.Text += button.Text;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new System.Data.DataTable()
                    .Compute(txt_Answer.Text, null);

                txt_Answer.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("Biểu thức không hợp lệ!");
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txt_Answer.Clear();
        }
    }
}