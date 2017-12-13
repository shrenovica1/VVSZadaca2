namespace Aplikacija
{
    partial class Pregled
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
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Pregled uposlenika");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Pregled predmeta");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Pregled studenata");
            this.treeViewpregled = new System.Windows.Forms.TreeView();
            this.listBoxpregled = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // treeViewpregled
            // 
            this.treeViewpregled.BackColor = System.Drawing.SystemColors.Menu;
            this.treeViewpregled.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewpregled.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.treeViewpregled.Location = new System.Drawing.Point(12, 12);
            this.treeViewpregled.Name = "treeViewpregled";
            treeNode4.Name = "Node1";
            treeNode4.Text = "Pregled uposlenika";
            treeNode5.Name = "Node2";
            treeNode5.Text = "Pregled predmeta";
            treeNode6.Name = "Node4";
            treeNode6.Text = "Pregled studenata";
            this.treeViewpregled.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            this.treeViewpregled.Size = new System.Drawing.Size(137, 236);
            this.treeViewpregled.TabIndex = 0;
            this.treeViewpregled.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewpregled_AfterSelect);
            this.treeViewpregled.DoubleClick += new System.EventHandler(this.treeViewpregled_DoubleClick);
            // 
            // listBoxpregled
            // 
            this.listBoxpregled.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxpregled.FormattingEnabled = true;
            this.listBoxpregled.ItemHeight = 16;
            this.listBoxpregled.Location = new System.Drawing.Point(197, 12);
            this.listBoxpregled.Name = "listBoxpregled";
            this.listBoxpregled.Size = new System.Drawing.Size(285, 196);
            this.listBoxpregled.TabIndex = 1;
            // 
            // Pregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 265);
            this.Controls.Add(this.listBoxpregled);
            this.Controls.Add(this.treeViewpregled);
            this.Name = "Pregled";
            this.Text = "Pregled";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pregled_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Pregled_FormClosed);
            this.Load += new System.EventHandler(this.Pregled_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewpregled;
        private System.Windows.Forms.ListBox listBoxpregled;
    }
}