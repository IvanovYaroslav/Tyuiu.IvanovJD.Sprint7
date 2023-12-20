using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.IvanovJD.Sprint7.Project.V2.Lib;
using System.IO;
using MetroFramework.Components;
using MetroFramework.Forms;


namespace Tyuiu.IvanovJD.Sprint7.Project.V2
{
    public partial class FormAdd : MetroForm
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void buttonAddText_IJD_Click(object sender, EventArgs e)
        {
            // Получите данные из элементов управления на форме ввода данных
            string[] rowData = new string[] { textBoxNazv_IJD.Text, textBoxNomer_IJD.Text, textBoxAdressAdd_IJD.Text, textBoxPhoneMagazAdd_IJD.Text, textBoxFIOpost_IJD.Text, textBoxPhonePost_IJD.Text, textBoxCostPost_IJD.Text };


            // Установите свойство DialogResult в OK и закройте форму
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        public string[] GetRowData()
        {
            // Возвращает массив строк, содержащий данные из элементов управления на форме ввода данных
            return new string[] { textBoxNazv_IJD.Text, textBoxNomer_IJD.Text, textBoxAdressAdd_IJD.Text, textBoxPhoneMagazAdd_IJD.Text, textBoxFIOpost_IJD.Text, textBoxPhonePost_IJD.Text, textBoxCostPost_IJD.Text };

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
