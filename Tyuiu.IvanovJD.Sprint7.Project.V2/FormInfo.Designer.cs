
namespace Tyuiu.IvanovJD.Sprint7.Project.V2
{
    partial class FormInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOKClose_IJD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 153);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // buttonOKClose_IJD
            // 
            this.buttonOKClose_IJD.Location = new System.Drawing.Point(445, 244);
            this.buttonOKClose_IJD.Name = "buttonOKClose_IJD";
            this.buttonOKClose_IJD.Size = new System.Drawing.Size(52, 48);
            this.buttonOKClose_IJD.TabIndex = 1;
            this.buttonOKClose_IJD.Text = "OK";
            this.buttonOKClose_IJD.UseVisualStyleBackColor = true;
            this.buttonOKClose_IJD.Click += new System.EventHandler(this.buttonOKClose_IJD_Click);
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 315);
            this.Controls.Add(this.buttonOKClose_IJD);
            this.Controls.Add(this.label1);
            this.Name = "FormInfo";
            this.Text = "Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOKClose_IJD;
    }
}