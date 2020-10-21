using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ForSew
{
    public partial class Form1 : Form
    {
        private string _inputFilePath;
        private string _outputFilePath;

        private bool isInputFileSelected;

        private NotifyLog notifyLog;
        private PortfolioRepParse portfolioRepParse;

        public Form1()
        {
            InitializeComponent();
            isInputFileSelected = false;
            portfolioRepParse = new PortfolioRepParse();
            notifyLog = new NotifyLog(portfolioRepParse);

            openFileDialog1.Filter = "Portfolio files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Portfolio files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private string GetEncoding(string path)
        {
            string encoding = string.Empty;

            Stream fs = new FileStream(path, FileMode.Open);
            using (StreamReader sr = new StreamReader(fs, true))
            {
                encoding = sr.CurrentEncoding.ToString();
            }
            return encoding;
        }

        private void fileName_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            // получаем выбранный файл
            _inputFilePath = openFileDialog1.FileName;
            isInputFileSelected = true;
            fileName.Text = "Файл: " + _inputFilePath;
        }

        private void parsing_Click(object sender, EventArgs e)
        {
            if (!isInputFileSelected)
            {
                MessageBox.Show("Нажмите на слово <Файл> слева вверху и выберите файл входных данных.");
                return;
            }

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                string fileName = saveFileDialog1.FileName;

                saveFileLabel.Text = "Файл: " + fileName;
                _outputFilePath = fileName;

                Portfolio portfolio = portfolioRepParse.ParseCreatePortfolio(_inputFilePath);

                using (StreamWriter sw = new StreamWriter(fileName, false, System.Text.Encoding.UTF8))
                {
                    foreach (Instrument instrument in portfolio.Instruments)
                    {
                        sw.WriteLine(instrument.InstrumentType.ToString());

                        foreach (Strategy strategy in instrument.Strategies)
                        {
                            foreach (Deal deal in strategy.Deals)
                            {
                                string dealMoment = deal.DealMoment.ToString();
                                string dealType = deal.DealType.ToString();
                                string dealAmount = deal.DealAmount.ToString();

                                sw.WriteLine(dealMoment + " - " + dealType + " - " + dealAmount);
                            }
                        }
                    }
                }

                MessageBox.Show("Запись выполнена");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveFileLabel_Click(object sender, EventArgs e)
        {
            if (File.Exists(_outputFilePath))
            {
                System.Diagnostics.Process.Start(_outputFilePath);
            }
        }
    }
}
