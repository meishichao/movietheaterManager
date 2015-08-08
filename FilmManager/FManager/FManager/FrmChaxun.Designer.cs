namespace FManager
{
    partial class FrmChaxun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChaxun));
            this.label1 = new System.Windows.Forms.Label();
            this.Chaxun = new System.Windows.Forms.DataGridView();
            this.R_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R_Type = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.R_Scount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Chaxun)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "影厅目录：";
            // 
            // Chaxun
            // 
            this.Chaxun.AllowUserToAddRows = false;
            this.Chaxun.AllowUserToDeleteRows = false;
            this.Chaxun.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Chaxun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Chaxun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.R_Id,
            this.R_Name,
            this.R_Type,
            this.R_Scount});
            this.Chaxun.Location = new System.Drawing.Point(84, 12);
            this.Chaxun.Name = "Chaxun";
            this.Chaxun.ReadOnly = true;
            this.Chaxun.RowTemplate.Height = 23;
            this.Chaxun.Size = new System.Drawing.Size(444, 187);
            this.Chaxun.TabIndex = 2;
            // 
            // R_Id
            // 
            this.R_Id.DataPropertyName = "R_Id";
            this.R_Id.HeaderText = "影厅编号";
            this.R_Id.Name = "R_Id";
            this.R_Id.ReadOnly = true;
            // 
            // R_Name
            // 
            this.R_Name.DataPropertyName = "R_Name";
            this.R_Name.HeaderText = "影厅名称";
            this.R_Name.Name = "R_Name";
            this.R_Name.ReadOnly = true;
            // 
            // R_Type
            // 
            this.R_Type.DataPropertyName = "R_Type";
            this.R_Type.HeaderText = "是否3D";
            this.R_Type.Name = "R_Type";
            this.R_Type.ReadOnly = true;
            this.R_Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.R_Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // R_Scount
            // 
            this.R_Scount.DataPropertyName = "R_Scount";
            this.R_Scount.HeaderText = "座位数量";
            this.R_Scount.Name = "R_Scount";
            this.R_Scount.ReadOnly = true;
            // 
            // FrmChaxun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FManager.Properties.Resources.SPIDERMAN02;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(540, 211);
            this.Controls.Add(this.Chaxun);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmChaxun";
            this.Text = "查找影厅";
            this.Load += new System.EventHandler(this.FrmChaxun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chaxun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Chaxun;
        private System.Windows.Forms.DataGridViewTextBoxColumn R_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn R_Name;
        private System.Windows.Forms.DataGridViewCheckBoxColumn R_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn R_Scount;
    }
}