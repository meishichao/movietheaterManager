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
    public partial class FrmChaxun : Form
    {
        public FrmChaxun()
        {
            InitializeComponent();
        }

        private void FrmChaxun_Load(object sender, EventArgs e)
        {
            //创建一个工具箱实例
            DBHelp help = new DBHelp();
            string sql = "SELECT * FROM RoomInfo";
            DataTable table = help.GetTableBySql(sql);
            this.Chaxun.DataSource = table;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
