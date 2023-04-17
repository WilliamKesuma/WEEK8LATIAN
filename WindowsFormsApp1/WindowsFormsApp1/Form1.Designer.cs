namespace WindowsFormsApp1
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
            this.DGV_Team_Players = new System.Windows.Forms.DataGridView();
            this.DGV_Team_manager = new System.Windows.Forms.DataGridView();
            this.CB_SelectTeam = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pROGRAMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tEAMDATAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tEAMMATCHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Team_Players)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Team_manager)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Team_Players
            // 
            this.DGV_Team_Players.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Team_Players.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Team_Players.Location = new System.Drawing.Point(12, 84);
            this.DGV_Team_Players.Name = "DGV_Team_Players";
            this.DGV_Team_Players.Size = new System.Drawing.Size(775, 150);
            this.DGV_Team_Players.TabIndex = 0;
            // 
            // DGV_Team_manager
            // 
            this.DGV_Team_manager.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Team_manager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Team_manager.Location = new System.Drawing.Point(12, 240);
            this.DGV_Team_manager.Name = "DGV_Team_manager";
            this.DGV_Team_manager.Size = new System.Drawing.Size(775, 150);
            this.DGV_Team_manager.TabIndex = 1;
            // 
            // CB_SelectTeam
            // 
            this.CB_SelectTeam.FormattingEnabled = true;
            this.CB_SelectTeam.Location = new System.Drawing.Point(12, 43);
            this.CB_SelectTeam.Name = "CB_SelectTeam";
            this.CB_SelectTeam.Size = new System.Drawing.Size(138, 21);
            this.CB_SelectTeam.TabIndex = 2;
            this.CB_SelectTeam.SelectedIndexChanged += new System.EventHandler(this.CB_SelectTeam_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pROGRAMToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pROGRAMToolStripMenuItem
            // 
            this.pROGRAMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tEAMDATAToolStripMenuItem,
            this.tEAMMATCHToolStripMenuItem});
            this.pROGRAMToolStripMenuItem.Name = "pROGRAMToolStripMenuItem";
            this.pROGRAMToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.pROGRAMToolStripMenuItem.Text = "PROGRAM";
            // 
            // tEAMDATAToolStripMenuItem
            // 
            this.tEAMDATAToolStripMenuItem.Name = "tEAMDATAToolStripMenuItem";
            this.tEAMDATAToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.tEAMDATAToolStripMenuItem.Text = "TEAM DATA";
            this.tEAMDATAToolStripMenuItem.Click += new System.EventHandler(this.tEAMDATAToolStripMenuItem_Click);
            // 
            // tEAMMATCHToolStripMenuItem
            // 
            this.tEAMMATCHToolStripMenuItem.Name = "tEAMMATCHToolStripMenuItem";
            this.tEAMMATCHToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.tEAMMATCHToolStripMenuItem.Text = "TEAM MATCH";
            this.tEAMMATCHToolStripMenuItem.Click += new System.EventHandler(this.tEAMMATCHToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 442);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 604);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CB_SelectTeam);
            this.Controls.Add(this.DGV_Team_manager);
            this.Controls.Add(this.DGV_Team_Players);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Team_Players)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Team_manager)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Team_Players;
        private System.Windows.Forms.DataGridView DGV_Team_manager;
        private System.Windows.Forms.ComboBox CB_SelectTeam;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pROGRAMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tEAMDATAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tEAMMATCHToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

