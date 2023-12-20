using System;
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
    public partial class FormStat : MetroForm
    {

        public static string[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
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
        DataService ds = new DataService();

        public FormStat()
        {
            InitializeComponent();
        }

        string filePath = $@"C:\DataSprint6\projectX.csv";

        private void metroTextBoxMax_IJD_Click(object sender, EventArgs e)
        {
            string[,] dataArray = LoadFromFileData(filePath);
            metroTextBoxMax_IJD.Text = Convert.ToString(ds.MaxCena(dataArray));
        }

        private void metroTextBoxMin_IJD_Click(object sender, EventArgs e)
        {
            string[,] dataArray = LoadFromFileData(filePath);
            metroTextBoxMin_IJD.Text = Convert.ToString(ds.MixCena(dataArray));
        }

        private void metroTextBoxSred_IJD_Click(object sender, EventArgs e)
        {
            string[,] dataArray = LoadFromFileData(filePath);
            metroTextBoxSred_IJD.Text = Convert.ToString(ds.SredCena(dataArray));
        }
    }
}
