using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace FManager
{
    public partial class FrmFilmDel : Form
    {
        public FrmFilmDel()
        {
            InitializeComponent();
        }

        private void FrmFilmDel_Load(object sender, EventArgs e)
        {
            //创建一个工具箱实例
            DBHelp help = new DBHelp();
            string sql = "SELECT * FROM FilmInfo";
            DataTable table = help.GetTableBySql(sql);
            this.dataGridView1.DataSource = table;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            {
                string id = this.txtID.Text;
                SqlConnection conne = new SqlConnection("server=(local);database=FilmDB;integrated security=true");
                string sql = string.Format("delete FilmInfo where F_ID='{0}'", id);
                SqlCommand comm = new SqlCommand(sql, conne);
                conne.Open();
                int count = comm.ExecuteNonQuery();
                conne.Close();
                if (count > 0)
                {
                    MessageBox.Show("电影删除成功");
                    DBHelp help1 = new DBHelp();
                    string sql1 = "SELECT * FROM FilmInfo";
                    DataTable table = help1.GetTableBySql(sql1);
                    this.dataGridView1.DataSource = table;
                }
                else
                {
                    MessageBox.Show("删除失败,请重试");
                }
           
        }

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
