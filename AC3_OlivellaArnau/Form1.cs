using AC3_OlivellaArnau.Model;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using AC3_OlivellaArnau_Helper;
using System.Net.Http.Headers;
namespace AC3_OlivellaArnau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GenerarTaula(dgConsum);
            cBAny.DataSource = GenerateAnyComboBox();
            cBComponent.DataSource = Helper.ComponentGenerator().Values.ToList();
        }
        private void GenerarTaula(DataGridView dgConsum)
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
            Dictionary<int, string> components = Helper.ComponentGenerator();
            int CodiComarca = components.FirstOrDefault(x => x.Value == cBComponent.Text).Key;
            Helper.AddToCSV(new Consum
            {
                Any = Convert.ToInt32(cBAny.Text),
                CodiComarca = CodiComarca,
                Comarca = cBComponent.Text,
                Poblacio = Convert.ToInt32(tBPoblacio.Text),
                DomesticXarxa = Convert.ToInt32(tBXarxa.Text),
                Activitats = Convert.ToInt32(tBActivitat.Text),
                Total = Convert.ToInt32(tBTotal.Text),
                ConsumDomesticPC = Convert.ToSingle(tBConsumDPC.Text)
            });
            GenerarTaula(dgConsum);
        }

        private void lbPoblacio_Click(object sender, EventArgs e)
        {

        }

        private void bTClean_Click(object sender, EventArgs e)
        {
            cBAny.Text = string.Empty;
            cBComponent.Text = string.Empty;
            tBPoblacio.Text = string.Empty;
            tBXarxa.Text = string.Empty;
            tBActivitat.Text = string.Empty;
            tBConsumDPC.Text = string.Empty;
            tBTotal.Text = string.Empty;
        }
        private List<string> GenerateAnyComboBox()
        {
            List<string> Anys = new List<string>();
            for (int i = 2012; i < 2051; i++)
            {
                Anys.Add(i.ToString());
            }
            return Anys;
        }
        public void GenerateComponentComboBox()
        {

        }
        private void cBComponent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgConsum_SizeChanged(object sender, EventArgs e)
        {

        }
    }
}
