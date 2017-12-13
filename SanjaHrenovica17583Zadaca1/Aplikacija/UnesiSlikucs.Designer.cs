namespace Aplikacija
{
    partial class UnesiSlikucs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnesiSlikucs));
            this.dateTimePickerSlika = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUcitaj = new System.Windows.Forms.Button();
            this.pictureBoxSlika = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerSlika
            // 
            this.dateTimePickerSlika.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSlika.Location = new System.Drawing.Point(74, 44);
            this.dateTimePickerSlika.Name = "dateTimePickerSlika";
            this.dateTimePickerSlika.Size = new System.Drawing.Size(75, 20);
            this.dateTimePickerSlika.TabIndex = 27;
            this.dateTimePickerSlika.ValueChanged += new System.EventHandler(this.dateTimePickerSlika_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 26);
            this.label1.TabIndex = 26;
            this.label1.Text = "Unesite datum \r\nnastanka slike:";
            // 
            // buttonUcitaj
            // 
            this.buttonUcitaj.Location = new System.Drawing.Point(0, 83);
            this.buttonUcitaj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonUcitaj.Name = "buttonUcitaj";
            this.buttonUcitaj.Size = new System.Drawing.Size(62, 22);
            this.buttonUcitaj.TabIndex = 24;
            this.buttonUcitaj.Text = "Učitaj";
            this.buttonUcitaj.UseVisualStyleBackColor = true;
            this.buttonUcitaj.Click += new System.EventHandler(this.buttonUcitaj_Click);
            // 
            // pictureBoxSlika
            // 
            this.pictureBoxSlika.BackColor = System.Drawing.Color.LightGray;
            this.pictureBoxSlika.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSlika.BackgroundImage")));
            this.pictureBoxSlika.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSlika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSlika.Location = new System.Drawing.Point(3, 4);
            this.pictureBoxSlika.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxSlika.Name = "pictureBoxSlika";
            this.pictureBoxSlika.Size = new System.Drawing.Size(65, 71);
            this.pictureBoxSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSlika.TabIndex = 23;
            this.pictureBoxSlika.TabStop = false;
            // 
            // UnesiSlikucs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePickerSlika);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUcitaj);
            this.Controls.Add(this.pictureBoxSlika);
            this.Name = "UnesiSlikucs";
            this.Size = new System.Drawing.Size(154, 124);
            this.Load += new System.EventHandler(this.UnesiSlikucs_Load);
           // this.Validating += new System.ComponentModel.CancelEventHandler(this.UnesiSlikucs_Validating);
            //this.Validated += new System.EventHandler(this.UnesiSlikucs_Validated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerSlika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUcitaj;
        private System.Windows.Forms.PictureBox pictureBoxSlika;
    }
}
