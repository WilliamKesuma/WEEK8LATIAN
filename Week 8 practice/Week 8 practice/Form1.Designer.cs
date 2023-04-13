namespace Week_8_practice
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
            this.DGV_pemain = new System.Windows.Forms.DataGridView();
            this.CB_Nationality = new System.Windows.Forms.ComboBox();
            this.LB_ValueMember = new System.Windows.Forms.Label();
            this.CB_KANAN = new System.Windows.Forms.ComboBox();
            this.LB_Value = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_pemain)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_pemain
            // 
            this.DGV_pemain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_pemain.Location = new System.Drawing.Point(12, 55);
            this.DGV_pemain.Name = "DGV_pemain";
            this.DGV_pemain.Size = new System.Drawing.Size(776, 314);
            this.DGV_pemain.TabIndex = 0;
            // 
            // CB_Nationality
            // 
            this.CB_Nationality.FormattingEnabled = true;
            this.CB_Nationality.Location = new System.Drawing.Point(13, 12);
            this.CB_Nationality.Name = "CB_Nationality";
            this.CB_Nationality.Size = new System.Drawing.Size(121, 21);
            this.CB_Nationality.TabIndex = 1;
            this.CB_Nationality.UseWaitCursor = true;
            this.CB_Nationality.SelectedIndexChanged += new System.EventHandler(this.CB_Nationality_SelectedIndexChanged);
            // 
            // LB_ValueMember
            // 
            this.LB_ValueMember.Location = new System.Drawing.Point(15, 39);
            this.LB_ValueMember.Name = "LB_ValueMember";
            this.LB_ValueMember.Size = new System.Drawing.Size(89, 13);
            this.LB_ValueMember.TabIndex = 0;
            this.LB_ValueMember.Text = "Value Member";
            // 
            // CB_KANAN
            // 
            this.CB_KANAN.FormattingEnabled = true;
            this.CB_KANAN.Location = new System.Drawing.Point(667, 12);
            this.CB_KANAN.Name = "CB_KANAN";
            this.CB_KANAN.Size = new System.Drawing.Size(121, 21);
            this.CB_KANAN.TabIndex = 2;
            this.CB_KANAN.SelectedIndexChanged += new System.EventHandler(this.CB_KANAN_SelectedIndexChanged);
            // 
            // LB_Value
            // 
            this.LB_Value.AutoSize = true;
            this.LB_Value.Location = new System.Drawing.Point(99, 39);
            this.LB_Value.Name = "LB_Value";
            this.LB_Value.Size = new System.Drawing.Size(31, 13);
            this.LB_Value.TabIndex = 3;
            this.LB_Value.Text = "hehe";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LB_Value);
            this.Controls.Add(this.CB_KANAN);
            this.Controls.Add(this.LB_ValueMember);
            this.Controls.Add(this.CB_Nationality);
            this.Controls.Add(this.DGV_pemain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_pemain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_pemain;
        private System.Windows.Forms.ComboBox CB_Nationality;
        private System.Windows.Forms.Label LB_ValueMember;
        private System.Windows.Forms.ComboBox CB_KANAN;
        private System.Windows.Forms.Label LB_Value;
    }
}

