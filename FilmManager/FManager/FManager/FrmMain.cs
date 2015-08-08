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
    public partial class FrmMain : Form
    {
        string type;
        public FrmMain()
        {
            InitializeComponent();
        }
        public FrmMain(string type)
        {
            InitializeComponent();
            this.type = type;
        }

        private void 添加影院ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //创建添加影厅的窗体
            FrmRoom room = new FrmRoom();
            room.MdiParent = this;
            room.Show();

        }

        private void 添加电影ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //创建添加电影的窗体
            FrmFilm film = new FrmFilm();
            film.MdiParent = this;
            film.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (type == "售票员")
            {
                this.电影管理ToolStripMenuItem.Visible = false;
                this.影厅管理ToolStripMenuItem.Visible = false;
                this.场次管理ToolStripMenuItem.Visible = false;
            }

        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //关闭整个程序
            Application.Exit();
        }

        private void 删除电影ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //创建删除电影的窗体
            FrmFilmDel filmdel = new FrmFilmDel();
            filmdel.MdiParent = this;
            filmdel.Show();
        }

        private void 查找影厅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //创建查找影厅的窗体
            FrmChaxun chaxun = new FrmChaxun();
            chaxun.MdiParent = this;
            chaxun.Show();
        }

        private void 安排场次ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //创建安排场次的窗体
            FrmDigtal digtal = new FrmDigtal();
            digtal.MdiParent = this;
            digtal.Show();
        }

        private void 购票选座ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //创建购票选座的窗体
            FrmSeat seat = new FrmSeat();
            seat.MdiParent = this;
            seat.Show();
        }
    }
}
