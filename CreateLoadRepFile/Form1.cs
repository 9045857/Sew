using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace CreateLoadRepFile
{
    public partial class Form1 : Form
    {
        private List<string> _COINFiles;
        private List<string> _ETHUSDFiles;

        private const string COINCheckPhrase = "Instrument=COIN";
        private const string ETHUSDCheckPhrase = "Instrument=ETHUSD";
        private const string InstrumentSearchPhrase = "Instrument=";
        private const string FolderSearchPhrase = "Folder=";

        private string _saveFilePath;

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "strategy files (*.rep)|*.rep|" +
        "All files (*.*)|*.*";

            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            _COINFiles = new List<string>();
            _ETHUSDFiles = new List<string>();

        }

        private void COINFilesLabel_Click(object sender, EventArgs e)
        {
            OpenFiles(_COINFiles, textBoxCOIN);
        }

        private void textBoxCOIN_TextChanged(object sender, EventArgs e)
        {

        }

        private void ETHUSDFilesLabel_Click(object sender, EventArgs e)
        {
            OpenFiles(_ETHUSDFiles, textBoxETHUSD);
        }

        private void OpenFiles(List<string> files, TextBox textBox)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                AddPaths(files, openFileDialog1.FileNames, textBox);
            }
        }

        private void AddPaths(List<string> files, string path, TextBox textBox)
        {
            files.Add(path);

            textBox.Clear();
            foreach (string file in files)
            {
                textBox.AppendText(file + Environment.NewLine);
            }
        }

        private void AddPaths(List<string> files, string[] paths, TextBox textBox)
        {
            files.AddRange(paths);

            textBox.Clear();
            foreach (string file in files)
            {
                textBox.AppendText(file + Environment.NewLine);
            }
        }

        private void AddPaths(List<string> files, List<string> paths, TextBox textBox)
        {
            files.AddRange(paths);

            textBox.Clear();
            foreach (string file in files)
            {
                textBox.AppendText(file + Environment.NewLine);
            }
        }

        private void COINFolderAdd_Click(object sender, EventArgs e)
        {
            AddFolder(_COINFiles, textBoxCOIN);
        }

        private void AddFolder(List<string> files, TextBox textBox)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                AddPaths(files, folderBrowserDialog1.SelectedPath, textBox);
            }
        }

        private void ETHUSDFolderAdd_Click(object sender, EventArgs e)
        {
            AddFolder(_ETHUSDFiles, textBoxETHUSD);
        }

        private void setFileButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                string fileName = saveFileDialog1.FileName;

                saveFileLabel.Text = "Файл: " + fileName;
                _saveFilePath = fileName;

                using (StreamWriter sw = new StreamWriter(fileName, false, System.Text.Encoding.UTF8))
                {
                    sw.WriteLine("Первая строка с некими данными");

                    if (_COINFiles.Count > 0)
                    {
                        sw.WriteLine(COINCheckPhrase);
                        foreach (string line in _COINFiles)
                        {
                            sw.WriteLine(line);
                        }
                    }

                    if (_ETHUSDFiles.Count > 0)
                    {
                        sw.WriteLine(ETHUSDCheckPhrase);
                        foreach (string line in _ETHUSDFiles)
                        {
                            sw.WriteLine(line);
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
            System.Diagnostics.Process.Start(_saveFilePath);
        }
    }
}
