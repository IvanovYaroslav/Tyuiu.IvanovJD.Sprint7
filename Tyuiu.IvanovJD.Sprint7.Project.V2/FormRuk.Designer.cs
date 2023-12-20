
namespace Tyuiu.IvanovJD.Sprint7.Project.V2
{
    partial class FormRuk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRuk));
            this.textBoxRuk_IJD = new System.Windows.Forms.TextBox();
            this.buttonOKRuk_IJD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxRuk_IJD
            // 
            this.textBoxRuk_IJD.Location = new System.Drawing.Point(41, 62);
            this.textBoxRuk_IJD.Multiline = true;
            this.textBoxRuk_IJD.Name = "textBoxRuk_IJD";
            this.textBoxRuk_IJD.ReadOnly = true;
            this.textBoxRuk_IJD.Size = new System.Drawing.Size(747, 500);
            this.textBoxRuk_IJD.TabIndex = 0;
            this.textBoxRuk_IJD.Text = resources.GetString("textBoxRuk_IJD.Text");
            // 
            // buttonOKRuk_IJD
            // 
            this.buttonOKRuk_IJD.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonOKRuk_IJD.Location = new System.Drawing.Point(808, 523);
            this.buttonOKRuk_IJD.Name = "buttonOKRuk_IJD";
            this.buttonOKRuk_IJD.Size = new System.Drawing.Size(40, 39);
            this.buttonOKRuk_IJD.TabIndex = 1;
            this.buttonOKRuk_IJD.Text = "OK";
            this.buttonOKRuk_IJD.UseVisualStyleBackColor = false;
            this.buttonOKRuk_IJD.Click += new System.EventHandler(this.buttonOKRuk_IJD_Click);
            // 
            // FormRuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 577);
            this.Controls.Add(this.buttonOKRuk_IJD);
            this.Controls.Add(this.textBoxRuk_IJD);
            this.Name = "FormRuk";
            this.Text = "Руководство";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRuk_IJD;
        private System.Windows.Forms.Button buttonOKRuk_IJD;
    }
}