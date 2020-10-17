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
            NotifyLog.RunLoger();
        }

        private void fileName_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Portfolio files(*.txt)|*.txt|All files(*.*)|*.*";

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
                //Strategy strategy = StrategyRepParse.ParseCreateStrategy(path);
                Portfolio portfolio = PortfolioRepParse.ParseCreatePortfolio(path);
                //MessageBox.Show(portfolio.Instruments.Count.ToString());

                textBox1.Clear();

                foreach (Instrument instrument in portfolio.Instruments)
                {
                    currentInstrument.Clear();
                    currentInstrument.AppendText(instrument.InstrumentType.ToString());

                    int strategyNumber = 0;

                    foreach (Strategy strategy in instrument.Strategies)
                    {
                        // currentStrategy.Text = strategy.ToString();
                        currentStrategy.Clear();
                        currentStrategy.AppendText(strategyNumber.ToString());

                        foreach (Deal deal in strategy.Deals)
                        {
                            textBox1.AppendText(deal.DealMoment + " | " + deal.DealType + " | " + deal.DealAmount + Environment.NewLine);
                        }
                        strategyNumber++;
                    }
                }

                //foreach (Deal deal in portfolio.Instruments strategy.Deals)
                //{
                //    textBox1.AppendText(deal.DealMoment + " | " + deal.DealType + " | " + deal.DealAmount+Environment.NewLine);
                //}
            }
            else
            {
                textBox1.Text = "Нажмите на слово <Файл> слева вверху и выберите файл.";
            }
        }
    }
}
