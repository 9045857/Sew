using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForSew
{
    public partial class Form1 : Form
    {
        private string path;
        private bool isFileSelected;

        public Form1()
        {
            InitializeComponent();
            isFileSelected = false;
        }

        private void fileName_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Strategy files(*.rep)|*.rep|All files(*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            // получаем выбранный файл
            path = openFileDialog1.FileName;
            isFileSelected = true;
            fileName.Text = path;
        }

        private void parsing_Click(object sender, EventArgs e)
        {
            if (isFileSelected)
            {
                Strategy strategy = StrategyRepParse.ParseCreateStrategy(path);

                MessageBox.Show(strategy.Deals.Count.ToString());

                textBox1.Clear();

                foreach (Deal deal in strategy.Deals)
                {
                    textBox1.AppendText(deal.DealMoment + " | " + deal.DealType + " | " + deal.DealAmount+Environment.NewLine);
                }
            }
            else
            {
                textBox1.Text = "Нажмите на слово <Файл> слева вверху и выберите файл.";
            }
        }
    }
}
