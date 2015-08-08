﻿using System;
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
    public partial class FrmFilm : Form
    {
        public FrmFilm()
        {
            InitializeComponent();
        }



        private void btnOk_Click(object sender, EventArgs e)
        {
            //第一步:创建连接对象
            SqlConnection conn = new SqlConnection("server=(local);database=FilmDB;integrated security=true");
            //取界面中的值
            string name = this.txtName.Text;
            string arter = this.txtArter.Text;
            int type = this.rad3D.Checked ? 1 : 0;
            int sCount = Convert.ToInt32(this.txtTime.Text);
            //声明一个字符串取表示要执行的命令
            string sql = string.Format("INSERT INTO FilmInfo VALUES('{0}','{1}',{2},{3})", name, arter, type, sCount);
            //声明工具箱对象
            DBHelp help = new DBHelp();
            int count = help.ExecuteIDUBySql(sql);
            //根据执行结果,判断是否执行成功,给用户提示
            if (count > 0)
            {
                MessageBox.Show("电影信息添加成功！");
            }
            else
            {
                MessageBox.Show("电影信息添加失败，请检查！");
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtName.Text = "";
            this.txtArter.Text = "";
            this.txtTime.Text = "";
        }

    }
}
