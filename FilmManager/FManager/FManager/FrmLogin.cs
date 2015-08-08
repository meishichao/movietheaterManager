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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //第一步:创建一个程序与数据库连接的连接对象
            SqlConnection conn = new SqlConnection("server=(local);database=FilmDB;integrated security=true");
            //第二部:创建一个用于执行操作适配器对象
            //获取用户输入的用户及密码
            string user = this.txtName.Text;
            string pwd = this.txtPwd.Text;
            SqlDataAdapter da = new SqlDataAdapter(string.Format("SELECT * FROM UserInfo WHERE U_Name='{0}' and U_Pwd='{1}'", user, pwd), conn);
            DataTable table = new DataTable();
            //第四部:执行适配器的fill方法,执行查询命令,并将结果填充到表格容器对象中
            da.Fill(table);
            if (table.Rows.Count > 0)
            {
                string userType = table.Rows[0][3].ToString();
                FrmMain main = new FrmMain(userType);
                main.Show();
                //将窗体隐藏起来
                this.Hide();

            }
            else
            {
                MessageBox.Show("用户名或密码输入错误,请确认！");
            }
            //第五部:将表格容器中的数据绑定到数据控件dgvUserInfo上
            //this.dgvUserInfo.DataSource = table;

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtName.Text = "";
            this.txtPwd.Text = "";
        }
    }
}
