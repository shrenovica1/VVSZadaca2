namespace Aplikacija
{
    partial class BrisanjePredmetacs
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonBrisiPredmet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBrisiPredmet = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonBrisiPredmet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxBrisiPredmet);
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(167, 201);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izbriši predmet";
            // 
            // buttonBrisiPredmet
            // 
            this.buttonBrisiPredmet.Location = new System.Drawing.Point(70, 131);
            this.buttonBrisiPredmet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBrisiPredmet.Name = "buttonBrisiPredmet";
            this.buttonBrisiPredmet.Size = new System.Drawing.Size(72, 23);
            this.buttonBrisiPredmet.TabIndex = 10;
            this.buttonBrisiPredmet.Text = "Izbriši";
            this.buttonBrisiPredmet.UseVisualStyleBackColor = true;
            this.buttonBrisiPredmet.Click += new System.EventHandler(this.buttonBrisiPredmet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite ime predmeta:";
            // 
            // textBoxBrisiPredmet
            // 
            this.textBoxBrisiPredmet.Location = new System.Drawing.Point(10, 89);
            this.textBoxBrisiPredmet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxBrisiPredmet.Name = "textBoxBrisiPredmet";
            this.textBoxBrisiPredmet.Size = new System.Drawing.Size(132, 21);
            this.textBoxBrisiPredmet.TabIndex = 9;
            // 
            // BrisanjePredmetacs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 230);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BrisanjePredmetacs";
            this.Text = "Izbriši";
            this.Load += new System.EventHandler(this.BrisanjePredmetacs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBrisiPredmet;
        private System.Windows.Forms.Button buttonBrisiPredmet;
    }
}