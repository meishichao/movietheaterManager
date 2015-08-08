namespace FManager
{
    partial class FrmFilmDel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFilmDel));
            this.btnDel = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.F_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Arter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Type = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.F_Long = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDel.Location = new System.Drawing.Point(321, 31);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(61, 23);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(220, 31);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(85, 21);
            this.txtID.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.F_Id,
            this.F_Name,
            this.F_Arter,
            this.F_Type,
            this.F_Long});
            this.dataGridView1.Location = new System.Drawing.Point(12, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(510, 160);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // F_Id
            // 
            this.F_Id.DataPropertyName = "F_Id";
            this.F_Id.HeaderText = "电影编号";
            this.F_Id.Name = "F_Id";
            this.F_Id.ReadOnly = true;
            // 
            // F_Name
            // 
            this.F_Name.DataPropertyName = "F_Name";
            this.F_Name.HeaderText = "电影名称";
            this.F_Name.Name = "F_Name";
            this.F_Name.ReadOnly = true;
            // 
            // F_Arter
            // 
            this.F_Arter.DataPropertyName = "F_Arter";
            this.F_Arter.HeaderText = "电影演员";
            this.F_Arter.Name = "F_Arter";
            this.F_Arter.ReadOnly = true;
            // 
            // F_Type
            // 
            this.F_Type.DataPropertyName = "F_Type";
            this.F_Type.HeaderText = "是否3D";
            this.F_Type.Name = "F_Type";
            this.F_Type.ReadOnly = true;
            this.F_Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.F_Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // F_Long
            // 
            this.F_Long.DataPropertyName = "F_Long";
            this.F_Long.HeaderText = "电影时长";
            this.F_Long.Name = "F_Long";
            this.F_Long.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(151, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "电影编号：";
            // 
            // FrmFilmDel
            // 
            this.AcceptButton = this.btnDel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FManager.Properties.Resources.SPIDERMAN01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 250);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnDel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFilmDel";
            this.Text = "删除电影";
            this.Load += new System.EventHandler(this.FrmFilmDel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Arter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn F_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Long;
    }
}