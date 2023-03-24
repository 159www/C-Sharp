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
     
    public partial class UserControlTemperture : UserControl
    {
        private int index = 0;
        private ShowSever ShowSever = null;
        private bool ChartTempertureShowFlag = true;
        public UserControlTemperture()
        {
            InitializeComponent();
        }
        public delegate void ShowTempertureDelegate(int  tempreture);
        public void TempertureShow(int tempreture)
        {   
            if(ChartTempertureShowFlag==true)
            {
                chartTemperture.Series[0].Points.AddXY(index, tempreture);
                System.Threading.Thread.Sleep(10);
                index++;
                if (index > 10)
                {
                    index = 0;
                    chartTemperture.Series[0].Points.Clear();
                }
                labelTempreture.Text = tempreture.ToString();
            }
           
            
        }
        public void UIshow(int temp)
        {
             
            if(this.IsHandleCreated==true)
            {
                this.BeginInvoke(new ShowTempertureDelegate(TempertureShow), temp);
            }
          

        }

        //开始按钮点击事件
        private void buttonStart_Click(object sender, EventArgs e)
        {
            ChartTempertureShowFlag = true;
            ShowSever = new ShowSever();
            labelTempreture.Visible = true;
            ShowSever.StartShowTemperture(UIshow);


        }
        //暂停按钮点击事件
        private void buttonEnd_Click(object sender, EventArgs e)
        {
            ChartTempertureShowFlag = false;
        }

        private void UserControlTemperture_Load(object sender, EventArgs e)
        {
            labelTempreture.Visible = false;
        }
    }
}
