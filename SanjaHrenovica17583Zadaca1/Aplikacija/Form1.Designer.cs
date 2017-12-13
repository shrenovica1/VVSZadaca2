namespace Aplikacija
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.labelKime = new System.Windows.Forms.Label();
            this.labelLoz = new System.Windows.Forms.Label();
            this.textBoxKime = new System.Windows.Forms.TextBox();
            this.textBoxLoz = new System.Windows.Forms.TextBox();
            this.buttonPrijava = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelgr = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvidergreska = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidergreska)).BeginInit();
            this.SuspendLayout();
            // 
            // labelKime
            // 
            this.labelKime.AutoSize = true;
            this.labelKime.Location = new System.Drawing.Point(63, 112);
            this.labelKime.Name = "labelKime";
            this.labelKime.Size = new System.Drawing.Size(97, 16);
            this.labelKime.TabIndex = 0;
            this.labelKime.Text = "Korisničko ime:";
            // 
            // labelLoz
            // 
            this.labelLoz.AutoSize = true;
            this.labelLoz.Location = new System.Drawing.Point(63, 162);
            this.labelLoz.Name = "labelLoz";
            this.labelLoz.Size = new System.Drawing.Size(56, 16);
            this.labelLoz.TabIndex = 1;
            this.labelLoz.Text = "Lozinka:";
            // 
            // textBoxKime
            // 
            this.textBoxKime.Location = new System.Drawing.Point(176, 108);
            this.textBoxKime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxKime.Name = "textBoxKime";
            this.textBoxKime.Size = new System.Drawing.Size(116, 21);
            this.textBoxKime.TabIndex = 2;
            this.textBoxKime.TextChanged += new System.EventHandler(this.textBoxKime_TextChanged);
            this.textBoxKime.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxKime_Validating);
            this.textBoxKime.Validated += new System.EventHandler(this.textBoxKime_Validated);
            // 
            // textBoxLoz
            // 
            this.textBoxLoz.Location = new System.Drawing.Point(176, 154);
            this.textBoxLoz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxLoz.Name = "textBoxLoz";
            this.textBoxLoz.PasswordChar = '*';
            this.textBoxLoz.Size = new System.Drawing.Size(116, 21);
            this.textBoxLoz.TabIndex = 3;
            this.textBoxLoz.TextChanged += new System.EventHandler(this.textBoxLoz_TextChanged);
            this.textBoxLoz.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxLoz_Validating);
            this.textBoxLoz.Validated += new System.EventHandler(this.textBoxLoz_Validated);
            // 
            // buttonPrijava
            // 
            this.buttonPrijava.Location = new System.Drawing.Point(205, 210);
            this.buttonPrijava.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPrijava.Name = "buttonPrijava";
            this.buttonPrijava.Size = new System.Drawing.Size(87, 28);
            this.buttonPrijava.TabIndex = 4;
            this.buttonPrijava.Text = "Prijavi se";
            this.buttonPrijava.UseVisualStyleBackColor = true;
            this.buttonPrijava.Click += new System.EventHandler(this.buttonPrijava_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelgr});
            this.statusStrip1.Location = new System.Drawing.Point(0, 299);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(331, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelgr
            // 
            this.toolStripStatusLabelgr.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripStatusLabelgr.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabelgr.Name = "toolStripStatusLabelgr";
            this.toolStripStatusLabelgr.Size = new System.Drawing.Size(0, 17);
            // 
            // errorProvidergreska
            // 
            this.errorProvidergreska.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 321);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonPrijava);
            this.Controls.Add(this.textBoxLoz);
            this.Controls.Add(this.textBoxKime);
            this.Controls.Add(this.labelLoz);
            this.Controls.Add(this.labelKime);
            this.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidergreska)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKime;
        private System.Windows.Forms.Label labelLoz;
        private System.Windows.Forms.TextBox textBoxKime;
        private System.Windows.Forms.TextBox textBoxLoz;
        private System.Windows.Forms.Button buttonPrijava;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelgr;
        private System.Windows.Forms.ErrorProvider errorProvidergreska;
    }
}