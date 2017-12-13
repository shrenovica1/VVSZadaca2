namespace Aplikacija
{
    partial class Pretraga
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
            this.textBoxZaunosPretrage = new System.Windows.Forms.TextBox();
            this.listBoxpret = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxZaunosPretrage
            // 
            this.textBoxZaunosPretrage.Location = new System.Drawing.Point(118, 50);
            this.textBoxZaunosPretrage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxZaunosPretrage.Name = "textBoxZaunosPretrage";
            this.textBoxZaunosPretrage.Size = new System.Drawing.Size(233, 21);
            this.textBoxZaunosPretrage.TabIndex = 1;
            this.textBoxZaunosPretrage.TabIndexChanged += new System.EventHandler(this.textBoxZaunosPretrage_TextChanged);
            this.textBoxZaunosPretrage.TextChanged += new System.EventHandler(this.textBoxZaunosPretrage_TextChanged);
            // 
            // listBoxpret
            // 
            this.listBoxpret.FormattingEnabled = true;
            this.listBoxpret.ItemHeight = 16;
            this.listBoxpret.Location = new System.Drawing.Point(118, 91);
            this.listBoxpret.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxpret.Name = "listBoxpret";
            this.listBoxpret.Size = new System.Drawing.Size(233, 180);
            this.listBoxpret.TabIndex = 2;
            this.listBoxpret.SelectedIndexChanged += new System.EventHandler(this.textBoxZaunosPretrage_TextChanged);
            this.listBoxpret.TabIndexChanged += new System.EventHandler(this.textBoxZaunosPretrage_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Unos za pretragu:";
            // 
            // Pretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 291);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxpret);
            this.Controls.Add(this.textBoxZaunosPretrage);
            this.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Pretraga";
            this.Text = "Pretraži";
            this.Load += new System.EventHandler(this.Pretraga_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxZaunosPretrage;
        private System.Windows.Forms.ListBox listBoxpret;
        private System.Windows.Forms.Label label1;
    }
}