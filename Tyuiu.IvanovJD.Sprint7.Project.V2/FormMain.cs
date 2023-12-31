﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;
using System.IO;
using Tyuiu.IvanovJD.Sprint7.Project.V2.Lib;

namespace Tyuiu.IvanovJD.Sprint7.Project.V2
{
    public partial class FormMain : MetroForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        
        public static string[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath,Encoding.Default);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            string[,] arrayValues = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = line_r[c];
                }
            }

            return arrayValues;
        }
        private void LoadDataIntoDataGridView(string filePath)
        {
            
            string[,] dataArray = LoadFromFileData(filePath);

         
            dataGridViewIn_IJD.Rows.Clear();
            dataGridViewIn_IJD.Columns.Clear();

            
            for (int i = 0; i < dataArray.GetLength(1); i++)
            {
                dataGridViewIn_IJD.Columns.Add("", dataArray[0, i]);
            }

            
            for (int i = 1; i < dataArray.GetLength(0); i++)
            {
                List<string> rowData = new List<string>();
                for (int j = 0; j < dataArray.GetLength(1); j++)
                {
                    rowData.Add(dataArray[i, j]);
                }
                dataGridViewIn_IJD.Rows.Add(rowData.ToArray());
            }
        }

        private void buttonOpenFile_IJD_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog_IJD = new OpenFileDialog();
            openFileDialog_IJD.Filter = "csv Files|*.csv";
            if (openFileDialog_IJD.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog_IJD.FileName;

               
                LoadDataIntoDataGridView(filePath);
            }
        }

        private void buttonInfo_IJD_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();
            formInfo.ShowDialog();
            
        }

        private void buttonStat_IJD_Click(object sender, EventArgs e)
        {
            FormStat formStat = new FormStat();
            formStat.ShowDialog();
        }

        private void buttonSaveFile_IJD_Click(object sender, EventArgs e)
        {
            
            saveFileDialog_IJD.FileName = "OutPutMagaz.csv";
            saveFileDialog_IJD.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_IJD.ShowDialog();

            string path = saveFileDialog_IJD.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewIn_IJD.RowCount;
            int columns = dataGridViewIn_IJD.ColumnCount;

            string str = "Название;Номер;Адрес;Телефон магазина;Фио поставщика;Телефон поставщика;Стоимость поставки\n";
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewIn_IJD.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewIn_IJD.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine,Encoding.Default);
                str = "";
            }

            DialogResult dialogres = MessageBox.Show("Файл " + path + " сохранен успешно!\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogres == DialogResult.Yes)
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
        }

        private void textBoxSearch_IJD_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBoxSearch_IJD.Text.ToLower();

            foreach (DataGridViewRow row in dataGridViewIn_IJD.Rows)
            {
                if (row.IsNewRow) continue; 

                bool found = false;

                for (int j = 0; j < dataGridViewIn_IJD.Columns.Count; j++)
                {
                    if (row.Cells[j].Value != null && row.Cells[j].Value.ToString().ToLower().Contains(searchValue))
                    {
                        found = true;
                        break;
                    }
                }

                row.Visible = found;
            }
        }

        private void ценаПоУбываниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewIn_IJD.Sort(dataGridViewIn_IJD.Columns[6], ListSortDirection.Descending);
        }

        private void buttonSortCenaUp_IJD_Click(object sender, EventArgs e)
        {
            contextMenuStrip_IJD.Show(buttonSortCenaUp_IJD, 1, buttonSortCenaUp_IJD.Height);
        }

        private void поВозрастаниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewIn_IJD.Sort(dataGridViewIn_IJD.Columns[6], ListSortDirection.Ascending);
        }

        private void aZИлиZAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridViewIn_IJD.Sort(dataGridViewIn_IJD.Columns[0], ListSortDirection.Ascending);
        }
        private void aZИлиZAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewIn_IJD.Sort(dataGridViewIn_IJD.Columns[0], ListSortDirection.Descending);
        }

        private void поВозрастаниюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewIn_IJD.Rows.Count - 1; i++)
            {
                for (int j = i + 1; j < dataGridViewIn_IJD.Rows.Count; j++)
                {
                    if (dataGridViewIn_IJD.Rows[i].Cells[1].Value != null && dataGridViewIn_IJD.Rows[j].Cells[1].Value != null)
                    {
                        if (Convert.ToDouble(dataGridViewIn_IJD.Rows[i].Cells[1].Value) > Convert.ToDouble(dataGridViewIn_IJD.Rows[j].Cells[1].Value))
                        {

                            for (int k = 0; k < dataGridViewIn_IJD.Columns.Count; k++)
                            {
                                object temp = dataGridViewIn_IJD.Rows[i].Cells[k].Value;
                                dataGridViewIn_IJD.Rows[i].Cells[k].Value = dataGridViewIn_IJD.Rows[j].Cells[k].Value;
                                dataGridViewIn_IJD.Rows[j].Cells[k].Value = temp;
                            }
                        }
                    }
                }
            }
        }

        private void поУбываниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewIn_IJD.Rows.Count - 1; i++)
            {
                for (int j = i + 1; j < dataGridViewIn_IJD.Rows.Count; j++)
                {
                    if (dataGridViewIn_IJD.Rows[i].Cells[1].Value != null && dataGridViewIn_IJD.Rows[j].Cells[1].Value != null)
                    {
                        if (Convert.ToDouble(dataGridViewIn_IJD.Rows[i].Cells[1].Value) < Convert.ToDouble(dataGridViewIn_IJD.Rows[j].Cells[1].Value))
                        {

                            for (int k = 0; k < dataGridViewIn_IJD.Columns.Count; k++)
                            {
                                object temp = dataGridViewIn_IJD.Rows[i].Cells[k].Value;
                                dataGridViewIn_IJD.Rows[i].Cells[k].Value = dataGridViewIn_IJD.Rows[j].Cells[k].Value;
                                dataGridViewIn_IJD.Rows[j].Cells[k].Value = temp;
                            }
                        }
                    }
                }
            }
        }

        private void aЯToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewIn_IJD.Sort(dataGridViewIn_IJD.Columns[4], ListSortDirection.Ascending);
        }

        private void aЯИлиЯAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewIn_IJD.Sort(dataGridViewIn_IJD.Columns[4], ListSortDirection.Descending);
        }

        private void buttonAdd_IJD_Click(object sender, EventArgs e)
        {
            CntextMenuStrip1_IJD.Show(buttonAdd_IJD, 1, buttonAdd_IJD.Height);
        }

        private void добавитьМагазинToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdd addDataForm = new FormAdd();
            if (addDataForm.ShowDialog() == DialogResult.OK)
            {
                // Получите данные из формы ввода данных
                string[] rowData = addDataForm.GetRowData();

                // Добавьте новую строку в DataGridView
                dataGridViewIn_IJD.Rows.Add(rowData);
            }
        }

        private void buttonRukovodstvo_IJD_Click(object sender, EventArgs e)
        {
            FormRuk formRuk = new FormRuk();
            formRuk.ShowDialog();
        }
    }
}
