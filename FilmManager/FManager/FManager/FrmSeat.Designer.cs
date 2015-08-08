namespace FManager
{
    partial class FrmSeat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeat));
            this.panTest = new System.Windows.Forms.Panel();
            this.cobFilmInfo = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // panTest
            // 
            this.panTest.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panTest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panTest.Location = new System.Drawing.Point(212, 12);
            this.panTest.Name = "panTest";
            this.panTest.Size = new System.Drawing.Size(501, 492);
            this.panTest.TabIndex = 0;
            this.panTest.Paint += new System.Windows.Forms.PaintEventHandler(this.panTest_Paint);
            // 
            // cobFilmInfo
            // 
            this.cobFilmInfo.FormattingEnabled = true;
            this.cobFilmInfo.Location = new System.Drawing.Point(12, 12);
            this.cobFilmInfo.Name = "cobFilmInfo";
            this.cobFilmInfo.Size = new System.Drawing.Size(185, 20);
            this.cobFilmInfo.TabIndex = 2;
            this.cobFilmInfo.SelectedIndexChanged += new System.EventHandler(this.cobFilmInfo_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(185, 460);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // FrmSeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FManager.Properties.Resources.SPIDERMAN03;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(725, 516);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cobFilmInfo);
            this.Controls.Add(this.panTest);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSeat";
            this.Text = "购票选座";
            this.Load += new System.EventHandler(this.FrmSeat_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTest;
        private System.Windows.Forms.ComboBox cobFilmInfo;
        private System.Windows.Forms.ListBox listBox1;
    }
}