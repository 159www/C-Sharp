using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newonenetapp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        //鼠标进入设备按钮预览设备页面的大概功能
        private void button_device_MouseEnter(object sender, EventArgs e)
        {
            panel_overview.BackgroundImage = Image.FromFile(@"C:\Users\七瑾\Desktop\sgt\c#\newonenetapp\newonenetapp\Images\device.png");
            panel_overview.BackgroundImageLayout = ImageLayout.Stretch;
        }
        //鼠标离开设备按钮设备页面预览关闭
        private void button_device_MouseLeave(object sender, EventArgs e)
        {
            panel_overview.BackgroundImage = Image.FromFile(@"C:\Users\七瑾\Desktop\sgt\c#\newonenetapp\newonenetapp\Images\main.gif");
            panel_overview.BackgroundImageLayout = ImageLayout.Stretch;

        }
        //设备按钮点击事件
        private void button_device_Click(object sender, EventArgs e)
        {
            Device device = new Device();
            device.Show();
        }
        //鼠标进入数据按钮预览数据界面概况
        private void button_data_MouseEnter(object sender, EventArgs e)
        {
            panel_overview.BackgroundImage = Image.FromFile(@"C:\Users\七瑾\Desktop\sgt\c#\newonenetapp\newonenetapp\Images\datashow.png");
            panel_overview.BackgroundImageLayout = ImageLayout.Stretch;
        }
        //鼠标离开数据按钮关闭数据页面预览
        private void button_data_MouseLeave(object sender, EventArgs e)
        {
            panel_overview.BackgroundImage = Image.FromFile(@"C:\Users\七瑾\Desktop\sgt\c#\newonenetapp\newonenetapp\Images\main.gif");
            panel_overview.BackgroundImageLayout = ImageLayout.Stretch;
        }
        //数据按钮点击事件
        private void button_data_Click(object sender, EventArgs e)
        {
            DataShow dataShow = new DataShow();
            dataShow.Show();
        }
        //鼠标进入查询按钮开启查询界面预览
        private void button_query_MouseEnter(object sender, EventArgs e)
        {
            panel_overview.BackgroundImage = Image.FromFile(@"C:\Users\七瑾\Desktop\sgt\c#\newonenetapp\newonenetapp\Images\control.png");
            panel_overview.BackgroundImageLayout = ImageLayout.Stretch;
        }
        //鼠标离开查询按钮关闭查询界面预览
        private void button_query_MouseLeave(object sender, EventArgs e)
        {
            panel_overview.BackgroundImage = Image.FromFile(@"C:\Users\七瑾\Desktop\sgt\c#\newonenetapp\newonenetapp\Images\main.gif");
            panel_overview.BackgroundImageLayout = ImageLayout.Stretch;
        }
        //查询按钮点击事件
        private void button_query_Click(object sender, EventArgs e)
        {
            Control control = new Control();
            control.Show();
        }
       
    }
}
