
namespace Tyuiu.IvanovJD.Sprint7.Project.V2
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSearch_IJD = new System.Windows.Forms.TextBox();
            this.buttonInfo_IJD = new System.Windows.Forms.Button();
            this.buttonOpenFile_IJD = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewIn_IJD = new System.Windows.Forms.DataGridView();
            this.buttonSaveFile_IJD = new System.Windows.Forms.Button();
            this.buttonStat_IJD = new System.Windows.Forms.Button();
            this.openFileDialog_IJD = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_IJD = new System.Windows.Forms.SaveFileDialog();
            this.buttonSortCenaUp_IJD = new System.Windows.Forms.Button();
            this.contextMenuStrip_IJD = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ценаПоВозрастаниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ценаПоУбываниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поВозрастаниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.названиеМагазинаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.номерМагазинаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фИОПоставщикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aZИлиZAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aZИлиZAToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поВозрастаниюToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поУбываниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aЯToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aЯИлиЯAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_IJD)).BeginInit();
            this.contextMenuStrip_IJD.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.buttonInfo_IJD);
            this.panel1.Controls.Add(this.buttonOpenFile_IJD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 100);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxSearch_IJD);
            this.groupBox1.Location = new System.Drawing.Point(625, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 54);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // textBoxSearch_IJD
            // 
            this.textBoxSearch_IJD.Location = new System.Drawing.Point(7, 26);
            this.textBoxSearch_IJD.Name = "textBoxSearch_IJD";
            this.textBoxSearch_IJD.Size = new System.Drawing.Size(218, 22);
            this.textBoxSearch_IJD.TabIndex = 0;
            this.textBoxSearch_IJD.TextChanged += new System.EventHandler(this.textBoxSearch_IJD_TextChanged);
            // 
            // buttonInfo_IJD
            // 
            this.buttonInfo_IJD.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonInfo_IJD.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_IJD.Image")));
            this.buttonInfo_IJD.Location = new System.Drawing.Point(883, 24);
            this.buttonInfo_IJD.Name = "buttonInfo_IJD";
            this.buttonInfo_IJD.Size = new System.Drawing.Size(58, 54);
            this.buttonInfo_IJD.TabIndex = 1;
            this.buttonInfo_IJD.UseVisualStyleBackColor = false;
            this.buttonInfo_IJD.Click += new System.EventHandler(this.buttonInfo_IJD_Click);
            // 
            // buttonOpenFile_IJD
            // 
            this.buttonOpenFile_IJD.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonOpenFile_IJD.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_IJD.Image")));
            this.buttonOpenFile_IJD.Location = new System.Drawing.Point(12, 24);
            this.buttonOpenFile_IJD.Name = "buttonOpenFile_IJD";
            this.buttonOpenFile_IJD.Size = new System.Drawing.Size(60, 54);
            this.buttonOpenFile_IJD.TabIndex = 0;
            this.buttonOpenFile_IJD.UseVisualStyleBackColor = false;
            this.buttonOpenFile_IJD.Click += new System.EventHandler(this.buttonOpenFile_IJD_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 160);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewIn_IJD);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer1.Panel2.Controls.Add(this.buttonSortCenaUp_IJD);
            this.splitContainer1.Panel2.Controls.Add(this.buttonSaveFile_IJD);
            this.splitContainer1.Panel2.Controls.Add(this.buttonStat_IJD);
            this.splitContainer1.Size = new System.Drawing.Size(965, 403);
            this.splitContainer1.SplitterDistance = 856;
            this.splitContainer1.TabIndex = 1;
            // 
            // dataGridViewIn_IJD
            // 
            this.dataGridViewIn_IJD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_IJD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIn_IJD.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewIn_IJD.Name = "dataGridViewIn_IJD";
            this.dataGridViewIn_IJD.RowHeadersWidth = 51;
            this.dataGridViewIn_IJD.RowTemplate.Height = 24;
            this.dataGridViewIn_IJD.Size = new System.Drawing.Size(856, 403);
            this.dataGridViewIn_IJD.TabIndex = 0;
            // 
            // buttonSaveFile_IJD
            // 
            this.buttonSaveFile_IJD.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSaveFile_IJD.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_IJD.Image")));
            this.buttonSaveFile_IJD.Location = new System.Drawing.Point(23, 329);
            this.buttonSaveFile_IJD.Name = "buttonSaveFile_IJD";
            this.buttonSaveFile_IJD.Size = new System.Drawing.Size(58, 52);
            this.buttonSaveFile_IJD.TabIndex = 1;
            this.buttonSaveFile_IJD.UseVisualStyleBackColor = false;
            this.buttonSaveFile_IJD.Click += new System.EventHandler(this.buttonSaveFile_IJD_Click);
            // 
            // buttonStat_IJD
            // 
            this.buttonStat_IJD.BackColor = System.Drawing.SystemColors.Control;
            this.buttonStat_IJD.Image = ((System.Drawing.Image)(resources.GetObject("buttonStat_IJD.Image")));
            this.buttonStat_IJD.Location = new System.Drawing.Point(23, 278);
            this.buttonStat_IJD.Name = "buttonStat_IJD";
            this.buttonStat_IJD.Size = new System.Drawing.Size(58, 45);
            this.buttonStat_IJD.TabIndex = 0;
            this.buttonStat_IJD.UseVisualStyleBackColor = false;
            this.buttonStat_IJD.Click += new System.EventHandler(this.buttonStat_IJD_Click);
            // 
            // openFileDialog_IJD
            // 
            this.openFileDialog_IJD.FileName = "openFileDialog_IJD";
            // 
            // buttonSortCenaUp_IJD
            // 
            this.buttonSortCenaUp_IJD.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSortCenaUp_IJD.Image = ((System.Drawing.Image)(resources.GetObject("buttonSortCenaUp_IJD.Image")));
            this.buttonSortCenaUp_IJD.Location = new System.Drawing.Point(23, 18);
            this.buttonSortCenaUp_IJD.Name = "buttonSortCenaUp_IJD";
            this.buttonSortCenaUp_IJD.Size = new System.Drawing.Size(58, 49);
            this.buttonSortCenaUp_IJD.TabIndex = 3;
            this.buttonSortCenaUp_IJD.UseVisualStyleBackColor = false;
            this.buttonSortCenaUp_IJD.Click += new System.EventHandler(this.buttonSortCenaUp_IJD_Click);
            // 
            // contextMenuStrip_IJD
            // 
            this.contextMenuStrip_IJD.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_IJD.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ценаПоВозрастаниюToolStripMenuItem,
            this.названиеМагазинаToolStripMenuItem,
            this.номерМагазинаToolStripMenuItem,
            this.фИОПоставщикаToolStripMenuItem});
            this.contextMenuStrip_IJD.Name = "contextMenuStrip_IJD";
            this.contextMenuStrip_IJD.Size = new System.Drawing.Size(217, 128);
            // 
            // ценаПоВозрастаниюToolStripMenuItem
            // 
            this.ценаПоВозрастаниюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ценаПоУбываниюToolStripMenuItem,
            this.поВозрастаниюToolStripMenuItem});
            this.ценаПоВозрастаниюToolStripMenuItem.Name = "ценаПоВозрастаниюToolStripMenuItem";
            this.ценаПоВозрастаниюToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.ценаПоВозрастаниюToolStripMenuItem.Text = "Цена ";
            // 
            // ценаПоУбываниюToolStripMenuItem
            // 
            this.ценаПоУбываниюToolStripMenuItem.Name = "ценаПоУбываниюToolStripMenuItem";
            this.ценаПоУбываниюToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ценаПоУбываниюToolStripMenuItem.Text = " По убыванию";
            this.ценаПоУбываниюToolStripMenuItem.Click += new System.EventHandler(this.ценаПоУбываниюToolStripMenuItem_Click);
            // 
            // поВозрастаниюToolStripMenuItem
            // 
            this.поВозрастаниюToolStripMenuItem.Name = "поВозрастаниюToolStripMenuItem";
            this.поВозрастаниюToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.поВозрастаниюToolStripMenuItem.Text = "По возрастанию";
            this.поВозрастаниюToolStripMenuItem.Click += new System.EventHandler(this.поВозрастаниюToolStripMenuItem_Click);
            // 
            // названиеМагазинаToolStripMenuItem
            // 
            this.названиеМагазинаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aZИлиZAToolStripMenuItem,
            this.aZИлиZAToolStripMenuItem1});
            this.названиеМагазинаToolStripMenuItem.Name = "названиеМагазинаToolStripMenuItem";
            this.названиеМагазинаToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.названиеМагазинаToolStripMenuItem.Text = "Название магазина";
            // 
            // номерМагазинаToolStripMenuItem
            // 
            this.номерМагазинаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поВозрастаниюToolStripMenuItem1,
            this.поУбываниюToolStripMenuItem});
            this.номерМагазинаToolStripMenuItem.Name = "номерМагазинаToolStripMenuItem";
            this.номерМагазинаToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.номерМагазинаToolStripMenuItem.Text = "Номер магазина";
            // 
            // фИОПоставщикаToolStripMenuItem
            // 
            this.фИОПоставщикаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aЯToolStripMenuItem,
            this.aЯИлиЯAToolStripMenuItem});
            this.фИОПоставщикаToolStripMenuItem.Name = "фИОПоставщикаToolStripMenuItem";
            this.фИОПоставщикаToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.фИОПоставщикаToolStripMenuItem.Text = "ФИО поставщика";
            // 
            // aZИлиZAToolStripMenuItem
            // 
            this.aZИлиZAToolStripMenuItem.Name = "aZИлиZAToolStripMenuItem";
            this.aZИлиZAToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aZИлиZAToolStripMenuItem.Text = "A-Я ";
            this.aZИлиZAToolStripMenuItem.Click += new System.EventHandler(this.aZИлиZAToolStripMenuItem_Click);
            // 
            // aZИлиZAToolStripMenuItem1
            // 
            this.aZИлиZAToolStripMenuItem1.Name = "aZИлиZAToolStripMenuItem1";
            this.aZИлиZAToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.aZИлиZAToolStripMenuItem1.Text = "Я-A";
            this.aZИлиZAToolStripMenuItem1.Click += new System.EventHandler(this.aZИлиZAToolStripMenuItem1_Click);
            // 
            // поВозрастаниюToolStripMenuItem1
            // 
            this.поВозрастаниюToolStripMenuItem1.Name = "поВозрастаниюToolStripMenuItem1";
            this.поВозрастаниюToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.поВозрастаниюToolStripMenuItem1.Text = "По возрастанию";
            this.поВозрастаниюToolStripMenuItem1.Click += new System.EventHandler(this.поВозрастаниюToolStripMenuItem1_Click);
            // 
            // поУбываниюToolStripMenuItem
            // 
            this.поУбываниюToolStripMenuItem.Name = "поУбываниюToolStripMenuItem";
            this.поУбываниюToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.поУбываниюToolStripMenuItem.Text = "По убыванию";
            this.поУбываниюToolStripMenuItem.Click += new System.EventHandler(this.поУбываниюToolStripMenuItem_Click);
            // 
            // aЯToolStripMenuItem
            // 
            this.aЯToolStripMenuItem.Name = "aЯToolStripMenuItem";
            this.aЯToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aЯToolStripMenuItem.Text = "A-Я ";
            this.aЯToolStripMenuItem.Click += new System.EventHandler(this.aЯToolStripMenuItem_Click);
            // 
            // aЯИлиЯAToolStripMenuItem
            // 
            this.aЯИлиЯAToolStripMenuItem.Name = "aЯИлиЯAToolStripMenuItem";
            this.aЯИлиЯAToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aЯИлиЯAToolStripMenuItem.Text = "Я-A";
            this.aЯИлиЯAToolStripMenuItem.Click += new System.EventHandler(this.aЯИлиЯAToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 583);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1005, 583);
            this.MinimumSize = new System.Drawing.Size(1005, 583);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_IJD)).EndInit();
            this.contextMenuStrip_IJD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonInfo_IJD;
        private System.Windows.Forms.Button buttonOpenFile_IJD;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewIn_IJD;
        private System.Windows.Forms.Button buttonStat_IJD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSearch_IJD;
        private System.Windows.Forms.Button buttonSaveFile_IJD;
        private System.Windows.Forms.OpenFileDialog openFileDialog_IJD;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_IJD;
        private System.Windows.Forms.Button buttonSortCenaUp_IJD;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_IJD;
        private System.Windows.Forms.ToolStripMenuItem ценаПоВозрастаниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ценаПоУбываниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поВозрастаниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem названиеМагазинаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aZИлиZAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aZИлиZAToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem номерМагазинаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поВозрастаниюToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поУбываниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фИОПоставщикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aЯToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aЯИлиЯAToolStripMenuItem;
    }
}

