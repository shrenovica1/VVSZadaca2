namespace Aplikacija
{
    partial class Profesori
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelbsText = new System.Windows.Forms.Label();
            this.labelBStuden = new System.Windows.Forms.Label();
            this.labeltextetcs = new System.Windows.Forms.Label();
            this.labelpred = new System.Windows.Forms.Label();
            this.labeltextp = new System.Windows.Forms.Label();
            this.labelvj = new System.Windows.Forms.Label();
            this.labeltextv = new System.Windows.Forms.Label();
            this.labeletcs = new System.Windows.Forms.Label();
            this.linkLabelodjava = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(14, 62);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(154, 114);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelbsText);
            this.groupBox1.Controls.Add(this.labelBStuden);
            this.groupBox1.Controls.Add(this.labeltextetcs);
            this.groupBox1.Controls.Add(this.labelpred);
            this.groupBox1.Controls.Add(this.labeltextp);
            this.groupBox1.Controls.Add(this.labelvj);
            this.groupBox1.Controls.Add(this.labeltextv);
            this.groupBox1.Controls.Add(this.labeletcs);
            this.groupBox1.Location = new System.Drawing.Point(184, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(226, 178);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o predmetu";
            // 
            // labelbsText
            // 
            this.labelbsText.AutoSize = true;
            this.labelbsText.Location = new System.Drawing.Point(175, 149);
            this.labelbsText.Name = "labelbsText";
            this.labelbsText.Size = new System.Drawing.Size(42, 16);
            this.labelbsText.TabIndex = 7;
            this.labelbsText.Text = "label2";
            this.labelbsText.Click += new System.EventHandler(this.labelbsText_Click);
            // 
            // labelBStuden
            // 
            this.labelBStuden.AutoSize = true;
            this.labelBStuden.Location = new System.Drawing.Point(7, 149);
            this.labelBStuden.Name = "labelBStuden";
            this.labelBStuden.Size = new System.Drawing.Size(93, 16);
            this.labelBStuden.TabIndex = 6;
            this.labelBStuden.Text = "Broj studenata:";
            // 
            // labeltextetcs
            // 
            this.labeltextetcs.AutoSize = true;
            this.labeltextetcs.Location = new System.Drawing.Point(175, 112);
            this.labeltextetcs.Name = "labeltextetcs";
            this.labeltextetcs.Size = new System.Drawing.Size(42, 16);
            this.labeltextetcs.TabIndex = 5;
            this.labeltextetcs.Text = "label5";
            this.labeltextetcs.Click += new System.EventHandler(this.labeltextetcs_Click);
            // 
            // labelpred
            // 
            this.labelpred.AutoSize = true;
            this.labelpred.Location = new System.Drawing.Point(7, 74);
            this.labelpred.Name = "labelpred";
            this.labelpred.Size = new System.Drawing.Size(99, 16);
            this.labelpred.TabIndex = 4;
            this.labelpred.Text = "Broj predavanja:";
            // 
            // labeltextp
            // 
            this.labeltextp.AutoSize = true;
            this.labeltextp.Location = new System.Drawing.Point(175, 74);
            this.labeltextp.Name = "labeltextp";
            this.labeltextp.Size = new System.Drawing.Size(42, 16);
            this.labeltextp.TabIndex = 3;
            this.labeltextp.Text = "label3";
            this.labeltextp.Click += new System.EventHandler(this.labeltextp_Click);
            // 
            // labelvj
            // 
            this.labelvj.AutoSize = true;
            this.labelvj.Location = new System.Drawing.Point(7, 34);
            this.labelvj.Name = "labelvj";
            this.labelvj.Size = new System.Drawing.Size(72, 16);
            this.labelvj.TabIndex = 2;
            this.labelvj.Text = "Broj vježbi:";
            // 
            // labeltextv
            // 
            this.labeltextv.AutoSize = true;
            this.labeltextv.Location = new System.Drawing.Point(175, 34);
            this.labeltextv.Name = "labeltextv";
            this.labeltextv.Size = new System.Drawing.Size(41, 16);
            this.labeltextv.TabIndex = 1;
            this.labeltextv.Text = "label1";
            this.labeltextv.Click += new System.EventHandler(this.labeltextv_Click);
            // 
            // labeletcs
            // 
            this.labeletcs.AutoSize = true;
            this.labeletcs.Location = new System.Drawing.Point(7, 112);
            this.labeletcs.Name = "labeletcs";
            this.labeletcs.Size = new System.Drawing.Size(110, 16);
            this.labeletcs.TabIndex = 0;
            this.labeletcs.Text = "Broj ETCS bodova:";
            // 
            // linkLabelodjava
            // 
            this.linkLabelodjava.AutoSize = true;
            this.linkLabelodjava.Location = new System.Drawing.Point(375, 11);
            this.linkLabelodjava.Name = "linkLabelodjava";
            this.linkLabelodjava.Size = new System.Drawing.Size(46, 16);
            this.linkLabelodjava.TabIndex = 2;
            this.linkLabelodjava.TabStop = true;
            this.linkLabelodjava.Text = "Odjava";
            this.linkLabelodjava.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelodjava_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dobrodošli!";
            // 
            // Profesori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 253);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabelodjava);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Profesori";
            this.Text = "Profesori";
            this.Load += new System.EventHandler(this.Profesori_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labeltextetcs;
        private System.Windows.Forms.Label labelpred;
        private System.Windows.Forms.Label labeltextp;
        private System.Windows.Forms.Label labelvj;
        private System.Windows.Forms.Label labeltextv;
        private System.Windows.Forms.Label labeletcs;
        private System.Windows.Forms.Label labelbsText;
        private System.Windows.Forms.Label labelBStuden;
        private System.Windows.Forms.LinkLabel linkLabelodjava;
        private System.Windows.Forms.Label label1;
    }
}