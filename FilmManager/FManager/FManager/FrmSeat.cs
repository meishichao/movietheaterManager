using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FManager
{
    public partial class FrmSeat : Form
    {
        int rid;
        int fid;
        DBHelp help = new DBHelp();
        public FrmSeat()
        {
            InitializeComponent();
        }


        private void myClick(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.YellowGreen;
            //得到当前点击按钮座位编号信息
            int sCode = Convert.ToInt32(((Button)sender).Tag);
            //MessageBox.Show(sCode.ToString());
            string sql = string.Format("UPDATE SeatInfo SET S_State=1 WHERE S_Id={0}", sCode);
            help.ExecuteIDUBySql(sql);
        }

        private void FrmSeat_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM FilmInfo";
            DataTable table = help.GetTableBySql(sql);
            cobFilmInfo.DataSource = table;
            //为combobox指定显示列与值列
            cobFilmInfo.DisplayMember = "F_Name";
            cobFilmInfo.ValueMember = "F_Id";
        }

        private void cobFilmInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cobFilmInfo.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                rid = Convert.ToInt32(this.cobFilmInfo.SelectedValue.ToString());
                //string sql = "SELECT D_Id,(Convert(varchar(10),R_Id)+'     '+(Convert(varchar(30),F_StartTime))) AS gg FROM DigtalInfo WHERE F_Id="+rid;
                string sql = "SELECT D_Id,F_StartTime FROM DigtalInfo WHERE F_Id=" + rid;
                string sql1 = string.Format(sql, rid);
                DataTable table = help.GetTableBySql(sql1);
                this.listBox1.DataSource = table;
                this.listBox1.DisplayMember = "F_StartTime";
                this.listBox1.ValueMember = "D_Id";

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {

                fid = Convert.ToInt32(this.listBox1.SelectedValue.ToString());
                string sql = "SELECT * FROM SeatInfo WHERE D_Id={0}";
                string sql1 = string.Format(sql, fid);
                DataTable table = help.GetTableBySql(sql1);
                this.panTest.Controls.Clear();
                //得到此场次有多少座位
                int sCount = table.Rows.Count;
                for (int i = 0; i < sCount; i++)
                {
                    Button bt = new Button();
                    //将座位编号绑定到按钮的Tag属性中去
                    bt.Tag = table.Rows[i][0];
                    bt.Location = new Point(i % 8 * 60 + 10, i / 8 * 60 + 10);
                    bt.Size = new Size(55, 50);
                    bt.BackColor = Color.White;
                    bt.Text = table.Rows[i][1].ToString();
                    if (Convert.ToInt32(table.Rows[i][3]) == 1)
                    {
                        bt.BackColor = Color.YellowGreen;
                    }
                    panTest.Controls.Add(bt);
                    bt.Click += new System.EventHandler(this.myClick);
                }

            }

        }

        private void panTest_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


