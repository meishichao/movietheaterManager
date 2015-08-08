namespace FManager
{
    partial class FrmDigtal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDigtal));
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.cobRoomInfo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dgvDigtalInfo = new System.Windows.Forms.DataGridView();
            this.F_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Long = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDigtalInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择影厅：";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnOk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOk.Location = new System.Drawing.Point(233, 307);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cobRoomInfo
            // 
            this.cobRoomInfo.FormattingEnabled = true;
            this.cobRoomInfo.Location = new System.Drawing.Point(73, 31);
            this.cobRoomInfo.Name = "cobRoomInfo";
            this.cobRoomInfo.Size = new System.Drawing.Size(141, 20);
            this.cobRoomInfo.TabIndex = 1;
            this.cobRoomInfo.SelectedIndexChanged += new System.EventHandler(this.cobRoomInfo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(263, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "开始时间：";
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(379, 77);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(148, 208);
            this.listBox2.TabIndex = 4;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(322, 30);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(205, 21);
            this.dtpStartTime.TabIndex = 2;
            // 
            // dgvDigtalInfo
            // 
            this.dgvDigtalInfo.AllowUserToAddRows = false;
            this.dgvDigtalInfo.AllowUserToDeleteRows = false;
            this.dgvDigtalInfo.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvDigtalInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDigtalInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.F_Name,
            this.F_Long,
            this.F_StartTime});
            this.dgvDigtalInfo.Location = new System.Drawing.Point(12, 77);
            this.dgvDigtalInfo.Name = "dgvDigtalInfo";
            this.dgvDigtalInfo.ReadOnly = true;
            this.dgvDigtalInfo.RowTemplate.Height = 23;
            this.dgvDigtalInfo.Size = new System.Drawing.Size(343, 208);
            this.dgvDigtalInfo.TabIndex = 7;
            // 
            // F_Name
            // 
            this.F_Name.DataPropertyName = "F_Name";
            this.F_Name.HeaderText = "电影名称";
            this.F_Name.Name = "F_Name";
            this.F_Name.ReadOnly = true;
            // 
            // F_Long
            // 
            this.F_Long.DataPropertyName = "F_Long";
            this.F_Long.HeaderText = "电影时长";
            this.F_Long.Name = "F_Long";
            this.F_Long.ReadOnly = true;
            // 
            // F_StartTime
            // 
            this.F_StartTime.DataPropertyName = "F_StartTime";
            this.F_StartTime.HeaderText = "开始时间";
            this.F_StartTime.Name = "F_StartTime";
            this.F_StartTime.ReadOnly = true;
            // 
            // FrmDigtal
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FManager.Properties.Resources.SPIDERMAN01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(539, 342);
            this.Controls.Add(this.dgvDigtalInfo);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.cobRoomInfo);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDigtal";
            this.Text = "场次管理";
            this.Load += new System.EventHandler(this.FrmDigtal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDigtalInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox cobRoomInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DataGridView dgvDigtalInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Long;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_StartTime;
    }
}