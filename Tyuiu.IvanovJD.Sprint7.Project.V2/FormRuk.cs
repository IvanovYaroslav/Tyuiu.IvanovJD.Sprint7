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
    public partial class FormRuk : MetroForm
    {
        public FormRuk()
        {
            InitializeComponent();
        }

        private void buttonOKRuk_IJD_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
