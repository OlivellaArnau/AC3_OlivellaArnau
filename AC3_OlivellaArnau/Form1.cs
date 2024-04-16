using AC3_OlivellaArnau.Model;
using CsvHelper;
using AC3_OlivellaArnau_Helper;
namespace AC3_OlivellaArnau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GenerarTaula(dgConsum);
        }
        public static void GenerarTaula(DataGridView dgConsum)
        {
            List<Consum> recConsums = Helper.CSVReader();
            dgConsum.DataSource = recConsums;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void label1_Click_2(object sender, EventArgs e)
        {

        }
        private void label1_Click_3(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void cBAny_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btSave_Click(object sender, EventArgs e)
        {

        }
    }
}
