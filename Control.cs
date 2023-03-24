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
    public partial class Control : Form
    {
        private UserControlAutoControl userControlAutoControl = null;
        private UserControlHandControl userControlHandControl = null;
        public Control()
        {
            InitializeComponent();
        }
        //自动控制按钮点击事件
        private void buttonAutoControl_Click(object sender, EventArgs e)
        {
            if(userControlHandControl!=null)
            {
                userControlHandControl.Dispose();
                userControlHandControl = null;
            }
            if(userControlAutoControl==null)
            {
                userControlAutoControl = new UserControlAutoControl();
                userControlAutoControl.Show();
                panelAutoControl.Controls.Add(userControlAutoControl);
            }
            

        }
        //预先加载
        private void Control_Load(object sender, EventArgs e)
        {
           
        }
        //手动控制按钮点击事件
        private void buttonHandControl_Click(object sender, EventArgs e)
        {
            if(userControlAutoControl!=null)
            {
                userControlAutoControl.Dispose();
                userControlAutoControl = null;
            }
            if(userControlHandControl==null)
            {
                userControlHandControl = new UserControlHandControl();
                userControlHandControl.Show();
                panelHandControl.Controls.Add(userControlHandControl);
            }
           
        }
    }
}
