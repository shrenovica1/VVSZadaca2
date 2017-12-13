using System;

namespace Aplikacija
{
    partial class StudentiProzor
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
            this.labeldd = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.treeViewp = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPpredmetiP = new System.Windows.Forms.ComboBox();
            this.buttonPrijavi = new System.Windows.Forms.Button();
            this.buttonOdjavise = new System.Windows.Forms.Button();
            this.comboBoxO = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labeldd
            // 
            this.labeldd.AutoSize = true;
            this.labeldd.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labeldd.ForeColor = System.Drawing.Color.Indigo;
            this.labeldd.Location = new System.Drawing.Point(14, 11);
            this.labeldd.Name = "labeldd";
            this.labeldd.Size = new System.Drawing.Size(115, 30);
            this.labeldd.TabIndex = 1;
            this.labeldd.Text = "Dobrodošli!";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Sitka Small", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabel1.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.linkLabel1.Location = new System.Drawing.Point(347, 11);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(45, 16);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Odjava";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // treeViewp
            // 
            this.treeViewp.Location = new System.Drawing.Point(20, 86);
            this.treeViewp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.treeViewp.Name = "treeViewp";
            this.treeViewp.Size = new System.Drawing.Size(151, 180);
            this.treeViewp.TabIndex = 4;
            this.treeViewp.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewp_AfterSelect);
            this.treeViewp.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeViewp_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vaši predmeti:";
            // 
            // comboBoxPpredmetiP
            // 
            this.comboBoxPpredmetiP.FormattingEnabled = true;
            this.comboBoxPpredmetiP.Location = new System.Drawing.Point(188, 91);
            this.comboBoxPpredmetiP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxPpredmetiP.Name = "comboBoxPpredmetiP";
            this.comboBoxPpredmetiP.Size = new System.Drawing.Size(127, 24);
            this.comboBoxPpredmetiP.TabIndex = 7;
            this.comboBoxPpredmetiP.SelectedIndexChanged += new System.EventHandler(this.comboBoxPpredmetiP_SelectedIndexChanged);
            this.comboBoxPpredmetiP.Click += new System.EventHandler(this.comboBoxPpredmetiP_Click);
            // 
            // buttonPrijavi
            // 
            this.buttonPrijavi.Location = new System.Drawing.Point(321, 91);
            this.buttonPrijavi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPrijavi.Name = "buttonPrijavi";
            this.buttonPrijavi.Size = new System.Drawing.Size(71, 24);
            this.buttonPrijavi.TabIndex = 8;
            this.buttonPrijavi.Text = "Prijavi se";
            this.buttonPrijavi.UseVisualStyleBackColor = true;
            this.buttonPrijavi.Click += new System.EventHandler(this.buttonPrijavi_Click);
            // 
            // buttonOdjavise
            // 
            this.buttonOdjavise.Location = new System.Drawing.Point(321, 189);
            this.buttonOdjavise.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOdjavise.Name = "buttonOdjavise";
            this.buttonOdjavise.Size = new System.Drawing.Size(71, 24);
            this.buttonOdjavise.TabIndex = 10;
            this.buttonOdjavise.Text = "Odjavi se";
            this.buttonOdjavise.UseVisualStyleBackColor = true;
            this.buttonOdjavise.Click += new System.EventHandler(this.buttonOdjavise_Click);
            // 
            // comboBoxO
            // 
            this.comboBoxO.FormattingEnabled = true;
            this.comboBoxO.Location = new System.Drawing.Point(188, 190);
            this.comboBoxO.Name = "comboBoxO";
            this.comboBoxO.Size = new System.Drawing.Size(127, 24);
            this.comboBoxO.TabIndex = 11;
            this.comboBoxO.Click += new System.EventHandler(this.comboBoxO_Click);
            // 
            // StudentiProzor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 276);
            this.Controls.Add(this.comboBoxO);
            this.Controls.Add(this.buttonOdjavise);
            this.Controls.Add(this.buttonPrijavi);
            this.Controls.Add(this.comboBoxPpredmetiP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeViewp);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.labeldd);
            this.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StudentiProzor";
            this.Text = "Studenti";
            this.Load += new System.EventHandler(this.Studenti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void comboBoxPredmetiO_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label labeldd;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TreeView treeViewp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPpredmetiP;
        private System.Windows.Forms.Button buttonPrijavi;
        private System.Windows.Forms.Button buttonOdjavise;
        private System.Windows.Forms.ComboBox comboBoxO;
    }
}