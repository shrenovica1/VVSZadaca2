namespace Aplikacija
{
    partial class BrisanjeStudenta
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
            this.textBoxUnos = new System.Windows.Forms.TextBox();
            this.groupBoxStudent = new System.Windows.Forms.GroupBox();
            this.labelindex = new System.Windows.Forms.Label();
            this.buttonBrisanjeS = new System.Windows.Forms.Button();
            this.groupBoxStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUnos
            // 
            this.textBoxUnos.Location = new System.Drawing.Point(155, 64);
            this.textBoxUnos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxUnos.Name = "textBoxUnos";
            this.textBoxUnos.Size = new System.Drawing.Size(136, 21);
            this.textBoxUnos.TabIndex = 5;
            // 
            // groupBoxStudent
            // 
            this.groupBoxStudent.Controls.Add(this.buttonBrisanjeS);
            this.groupBoxStudent.Controls.Add(this.labelindex);
            this.groupBoxStudent.Controls.Add(this.textBoxUnos);
            this.groupBoxStudent.Location = new System.Drawing.Point(12, 13);
            this.groupBoxStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxStudent.Name = "groupBoxStudent";
            this.groupBoxStudent.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxStudent.Size = new System.Drawing.Size(305, 143);
            this.groupBoxStudent.TabIndex = 0;
            this.groupBoxStudent.TabStop = false;
            this.groupBoxStudent.Text = "Izbriši studenta";
            // 
            // labelindex
            // 
            this.labelindex.AutoSize = true;
            this.labelindex.Location = new System.Drawing.Point(7, 64);
            this.labelindex.Name = "labelindex";
            this.labelindex.Size = new System.Drawing.Size(121, 16);
            this.labelindex.TabIndex = 6;
            this.labelindex.Text = "Unesite broj indexa:";
            // 
            // buttonBrisanjeS
            // 
            this.buttonBrisanjeS.Location = new System.Drawing.Point(219, 93);
            this.buttonBrisanjeS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBrisanjeS.Name = "buttonBrisanjeS";
            this.buttonBrisanjeS.Size = new System.Drawing.Size(72, 25);
            this.buttonBrisanjeS.TabIndex = 7;
            this.buttonBrisanjeS.Text = "Izbriši";
            this.buttonBrisanjeS.UseVisualStyleBackColor = true;
            this.buttonBrisanjeS.Click += new System.EventHandler(this.buttonBrisanjeS_Click);
            // 
            // BrisanjeStudenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 172);
            this.Controls.Add(this.groupBoxStudent);
            this.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BrisanjeStudenta";
            this.Text = "Izbriši";
            this.Load += new System.EventHandler(this.BrisanjeStudenta_Load);
            this.groupBoxStudent.ResumeLayout(false);
            this.groupBoxStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxUnos;
        private System.Windows.Forms.GroupBox groupBoxStudent;
        private System.Windows.Forms.Label labelindex;
        private System.Windows.Forms.Button buttonBrisanjeS;
    }
}