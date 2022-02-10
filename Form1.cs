using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta_10_deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Kitap Adı", typeof(string)); //kitap adını tablonun satırlarına ekleyip türünü belirledik
            table.Columns.Add("Kitap Yılı", typeof(int)); //Kitap yılını tablo satırlarına ekleyip türünü belirledik

            dataGridView1.DataSource = table;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
       
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtKitapAdi.Text, txtKitapYili.Text);
        }
    }
}
