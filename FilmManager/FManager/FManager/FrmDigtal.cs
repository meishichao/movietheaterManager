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
    public partial class FrmDigtal : Form
    {
        int rid;
        int fid;
        DateTime lastDigtalTime;
        DBHelp help = new DBHelp();
        public FrmDigtal()
        {
            InitializeComponent();
        }




        private void FrmDigtal_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM RoomInfo";
            DataTable table = help.GetTableBySql(sql);
            cobRoomInfo.DataSource = table;
            //为combobox指定显示列与值列
            cobRoomInfo.DisplayMember = "R_Name";
            cobRoomInfo.ValueMember = "R_Id";

        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            fid = Convert.ToInt32(this.listBox2.SelectedValue.ToString());
            //得到电影时长
            string sql = string.Format("SELECT F_Long FROM FilmInfo WHERE F_Id={0}", fid);
            DataTable table = help.GetTableBySql(sql);
            int flong = Convert.ToInt32(table.Rows[0][0]);
            //计算可以排场最近的时间
            DateTime nearTime = lastDigtalTime.AddMinutes(flong + 10);
            if (DateTime.Compare(nearTime, dtpStartTime.Value) == -1)
            {
                //向场次表中插入数据
                string sql1 = string.Format("INSERT INTO DigtalInfo VALUES({0},{1},'{2}')", rid, fid, dtpStartTime.Value);
                int count = help.ExecuteIDUBySql(sql1);
                if (count > 0)
                { 
                    //得到刚才上面插入成功的那条场次信息的场次编号
                    string sql3 = string.Format("SELECT TOP 1 D_Id FROM DigtalInfo WHERE R_Id={0} and F_Id={1} ORDER BY F_StartTime DESC", rid, fid);
                    DataTable table3 = help.GetTableBySql(sql3);
                    int did = Convert.ToInt32(table3.Rows[0][0]);
                    //向座位表插入数据
                    //根据影厅编号得到该影厅的座位数
                    string sql2 = string.Format("SELECT R_Scount FROM RoomInfo WHERE R_Id={0}", rid);
                    DataTable table2 = help.GetTableBySql(sql2);
                    int scount = Convert.ToInt32(table2.Rows[0][0]);

                    for (int i = 0; i < scount; i++)
                    {
                        string sname = (i/8+1)+"排"+(i%8+1)+"号";
                        string sql4 = string.Format("INSERT INTO SeatInfo VALUES('{0}',{1},0)",sname,did);
                        help.ExecuteIDUBySql(sql4);
                    }
                    
                }
                    MessageBox.Show("排场成功！");
                    rid = Convert.ToInt32(cobRoomInfo.SelectedValue.ToString());
                    string sql5 = string.Format("SELECT F_Name,F_Long,F_StartTime FROM DigtalInfo INNER JOIN FilmInfo ON DigtalInfo.F_Id=FilmInfo.F_Id WHERE R_Id={0} ORDER BY F_StartTime DESC", rid);
                    DataTable table4 = help.GetTableBySql(sql5);
                    if (table4.Rows.Count > 0)
                    {
                        lastDigtalTime = (DateTime)table4.Rows[0][2];
                    }
                    this.dgvDigtalInfo.DataSource = table4;
                    string sql6 = string.Format("SELECT * FROM FilmInfo WHERE F_Type=(SELECT R_Type FROM RoomInfo WHERE R_Id={0})", rid);
                    DataTable table5 = help.GetTableBySql(sql6);
                    this.listBox2.DataSource = table5;
                    this.listBox2.DisplayMember = "F_Name";
                    this.listBox2.ValueMember = "F_Id";

                }
                else
                {
                    MessageBox.Show("场次时间冲突，请重新选择时间！");
                }
    
        }

        private void cobRoomInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cobRoomInfo.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                rid = Convert.ToInt32(cobRoomInfo.SelectedValue.ToString());
                string sql = string.Format("SELECT F_Name,F_Long,F_StartTime FROM DigtalInfo INNER JOIN FilmInfo ON DigtalInfo.F_Id=FilmInfo.F_Id WHERE R_Id={0} ORDER BY F_StartTime DESC", rid);
                DataTable table = help.GetTableBySql(sql);
                if (table.Rows.Count > 0)
                {
                    lastDigtalTime = (DateTime)table.Rows[0][2];
                }
                this.dgvDigtalInfo.DataSource = table;
                string sql1 = string.Format("SELECT * FROM FilmInfo WHERE F_Type=(SELECT R_Type FROM RoomInfo WHERE R_Id={0})", rid);
                DataTable table1 = help.GetTableBySql(sql1);
                this.listBox2.DataSource = table1;
                this.listBox2.DisplayMember = "F_Name";
                this.listBox2.ValueMember = "F_Id";

            }


        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
