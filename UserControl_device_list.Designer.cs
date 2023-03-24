
namespace newonenetapp
{
    partial class UserControl_device_list
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_device_list = new System.Windows.Forms.DataGridView();
            this.groupBox_device_manage = new System.Windows.Forms.GroupBox();
            this.textBox_author = new System.Windows.Forms.TextBox();
            this.label_author = new System.Windows.Forms.Label();
            this.button_delete_device = new System.Windows.Forms.Button();
            this.button_add_device = new System.Windows.Forms.Button();
            this.textBox_device_id = new System.Windows.Forms.TextBox();
            this.label_device_id = new System.Windows.Forms.Label();
            this.textBox_devicename = new System.Windows.Forms.TextBox();
            this.label_device_name = new System.Windows.Forms.Label();
            this.richTextBox_device_describe = new System.Windows.Forms.RichTextBox();
            this.label_device_describe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_device_list)).BeginInit();
            this.groupBox_device_manage.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_device_list
            // 
            this.dataGridView_device_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_device_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_device_list.Location = new System.Drawing.Point(23, 18);
            this.dataGridView_device_list.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_device_list.Name = "dataGridView_device_list";
            this.dataGridView_device_list.RowHeadersWidth = 51;
            this.dataGridView_device_list.RowTemplate.Height = 27;
            this.dataGridView_device_list.Size = new System.Drawing.Size(1292, 370);
            this.dataGridView_device_list.TabIndex = 0;
            // 
            // groupBox_device_manage
            // 
            this.groupBox_device_manage.Controls.Add(this.label_device_describe);
            this.groupBox_device_manage.Controls.Add(this.richTextBox_device_describe);
            this.groupBox_device_manage.Controls.Add(this.textBox_author);
            this.groupBox_device_manage.Controls.Add(this.label_author);
            this.groupBox_device_manage.Controls.Add(this.button_delete_device);
            this.groupBox_device_manage.Controls.Add(this.button_add_device);
            this.groupBox_device_manage.Controls.Add(this.textBox_device_id);
            this.groupBox_device_manage.Controls.Add(this.label_device_id);
            this.groupBox_device_manage.Controls.Add(this.textBox_devicename);
            this.groupBox_device_manage.Controls.Add(this.label_device_name);
            this.groupBox_device_manage.Location = new System.Drawing.Point(23, 416);
            this.groupBox_device_manage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_device_manage.Name = "groupBox_device_manage";
            this.groupBox_device_manage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_device_manage.Size = new System.Drawing.Size(1148, 235);
            this.groupBox_device_manage.TabIndex = 1;
            this.groupBox_device_manage.TabStop = false;
            this.groupBox_device_manage.Text = "设备管理";
            // 
            // textBox_author
            // 
            this.textBox_author.Location = new System.Drawing.Point(378, 122);
            this.textBox_author.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_author.Name = "textBox_author";
            this.textBox_author.Size = new System.Drawing.Size(157, 25);
            this.textBox_author.TabIndex = 7;
            // 
            // label_author
            // 
            this.label_author.AutoSize = true;
            this.label_author.Location = new System.Drawing.Point(436, 85);
            this.label_author.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(37, 15);
            this.label_author.TabIndex = 6;
            this.label_author.Text = "鉴权";
            // 
            // button_delete_device
            // 
            this.button_delete_device.Location = new System.Drawing.Point(900, 155);
            this.button_delete_device.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_delete_device.Name = "button_delete_device";
            this.button_delete_device.Size = new System.Drawing.Size(163, 41);
            this.button_delete_device.TabIndex = 5;
            this.button_delete_device.Text = "删除设备";
            this.button_delete_device.UseVisualStyleBackColor = true;
            this.button_delete_device.Click += new System.EventHandler(this.button_delete_device_Click);
            // 
            // button_add_device
            // 
            this.button_add_device.Location = new System.Drawing.Point(900, 70);
            this.button_add_device.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_add_device.Name = "button_add_device";
            this.button_add_device.Size = new System.Drawing.Size(163, 45);
            this.button_add_device.TabIndex = 4;
            this.button_add_device.Text = "添加设备";
            this.button_add_device.UseVisualStyleBackColor = true;
            this.button_add_device.Click += new System.EventHandler(this.button_add_device_Click);
            // 
            // textBox_device_id
            // 
            this.textBox_device_id.Location = new System.Drawing.Point(202, 122);
            this.textBox_device_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_device_id.Name = "textBox_device_id";
            this.textBox_device_id.Size = new System.Drawing.Size(119, 25);
            this.textBox_device_id.TabIndex = 3;
            // 
            // label_device_id
            // 
            this.label_device_id.AutoSize = true;
            this.label_device_id.Location = new System.Drawing.Point(235, 85);
            this.label_device_id.Name = "label_device_id";
            this.label_device_id.Size = new System.Drawing.Size(53, 15);
            this.label_device_id.TabIndex = 2;
            this.label_device_id.Text = "设备ID";
            // 
            // textBox_devicename
            // 
            this.textBox_devicename.Location = new System.Drawing.Point(27, 122);
            this.textBox_devicename.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_devicename.Name = "textBox_devicename";
            this.textBox_devicename.Size = new System.Drawing.Size(121, 25);
            this.textBox_devicename.TabIndex = 1;
            // 
            // label_device_name
            // 
            this.label_device_name.AutoSize = true;
            this.label_device_name.Location = new System.Drawing.Point(64, 85);
            this.label_device_name.Name = "label_device_name";
            this.label_device_name.Size = new System.Drawing.Size(52, 15);
            this.label_device_name.TabIndex = 0;
            this.label_device_name.Text = "设备名";
            // 
            // richTextBox_device_describe
            // 
            this.richTextBox_device_describe.Location = new System.Drawing.Point(563, 82);
            this.richTextBox_device_describe.Name = "richTextBox_device_describe";
            this.richTextBox_device_describe.Size = new System.Drawing.Size(283, 135);
            this.richTextBox_device_describe.TabIndex = 8;
            this.richTextBox_device_describe.Text = "";
            // 
            // label_device_describe
            // 
            this.label_device_describe.AutoSize = true;
            this.label_device_describe.Location = new System.Drawing.Point(668, 49);
            this.label_device_describe.Name = "label_device_describe";
            this.label_device_describe.Size = new System.Drawing.Size(67, 15);
            this.label_device_describe.TabIndex = 9;
            this.label_device_describe.Text = "设备描述";
            // 
            // UserControl_device_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_device_manage);
            this.Controls.Add(this.dataGridView_device_list);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControl_device_list";
            this.Size = new System.Drawing.Size(1341, 674);
            this.Load += new System.EventHandler(this.UserControl_device_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_device_list)).EndInit();
            this.groupBox_device_manage.ResumeLayout(false);
            this.groupBox_device_manage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_device_list;
        private System.Windows.Forms.GroupBox groupBox_device_manage;
        private System.Windows.Forms.Button button_delete_device;
        private System.Windows.Forms.Button button_add_device;
        private System.Windows.Forms.TextBox textBox_device_id;
        private System.Windows.Forms.Label label_device_id;
        private System.Windows.Forms.TextBox textBox_devicename;
        private System.Windows.Forms.Label label_device_name;
        private System.Windows.Forms.TextBox textBox_author;
        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.Label label_device_describe;
        private System.Windows.Forms.RichTextBox richTextBox_device_describe;
    }
}
