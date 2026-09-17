namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDataGridView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadDataGridView()
        {
            List<Module.SinhVien> listSV = new List<Module.SinhVien>();

            listSV.Add(new Module.SinhVien("1", "Nguyen Van A", 20));
            listSV.Add(new Module.SinhVien("2", "Nguyen Van B", 30));
            listSV.Add(new Module.SinhVien("3", "Nguyen Van C", 22));

            dgv_Sinhvien.DataSource = listSV;
        }
       
    }
}
