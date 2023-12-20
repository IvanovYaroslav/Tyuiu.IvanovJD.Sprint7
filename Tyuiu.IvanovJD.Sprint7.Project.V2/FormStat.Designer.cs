
namespace Tyuiu.IvanovJD.Sprint7.Project.V2
{
    partial class FormStat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTextBoxMax_IJD = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxMin_IJD = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxSred_IJD = new MetroFramework.Controls.MetroTextBox();
            this.metroToolTipStat_IJD = new MetroFramework.Components.MetroToolTip();
            this.SuspendLayout();
            // 
            // metroTextBoxMax_IJD
            // 
            this.metroTextBoxMax_IJD.Location = new System.Drawing.Point(23, 145);
            this.metroTextBoxMax_IJD.Name = "metroTextBoxMax_IJD";
            this.metroTextBoxMax_IJD.Size = new System.Drawing.Size(117, 23);
            this.metroTextBoxMax_IJD.TabIndex = 0;
            this.metroToolTipStat_IJD.SetToolTip(this.metroTextBoxMax_IJD, "Максимальная цена");
            this.metroTextBoxMax_IJD.Click += new System.EventHandler(this.metroTextBoxMax_IJD_Click);
            // 
            // metroTextBoxMin_IJD
            // 
            this.metroTextBoxMin_IJD.Location = new System.Drawing.Point(169, 145);
            this.metroTextBoxMin_IJD.Name = "metroTextBoxMin_IJD";
            this.metroTextBoxMin_IJD.Size = new System.Drawing.Size(117, 23);
            this.metroTextBoxMin_IJD.TabIndex = 1;
            this.metroToolTipStat_IJD.SetToolTip(this.metroTextBoxMin_IJD, "Минимальная цена");
            this.metroTextBoxMin_IJD.Click += new System.EventHandler(this.metroTextBoxMin_IJD_Click);
            // 
            // metroTextBoxSred_IJD
            // 
            this.metroTextBoxSred_IJD.Location = new System.Drawing.Point(315, 145);
            this.metroTextBoxSred_IJD.Name = "metroTextBoxSred_IJD";
            this.metroTextBoxSred_IJD.Size = new System.Drawing.Size(117, 23);
            this.metroTextBoxSred_IJD.TabIndex = 2;
            this.metroToolTipStat_IJD.SetToolTip(this.metroTextBoxSred_IJD, "Средняя цена");
            this.metroTextBoxSred_IJD.Click += new System.EventHandler(this.metroTextBoxSred_IJD_Click);
            // 
            // FormStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 195);
            this.Controls.Add(this.metroTextBoxSred_IJD);
            this.Controls.Add(this.metroTextBoxMin_IJD);
            this.Controls.Add(this.metroTextBoxMax_IJD);
            this.Name = "FormStat";
            this.Text = "Статистика";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBoxMax_IJD;
        private MetroFramework.Components.MetroToolTip metroToolTipStat_IJD;
        private MetroFramework.Controls.MetroTextBox metroTextBoxMin_IJD;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSred_IJD;
    }
}