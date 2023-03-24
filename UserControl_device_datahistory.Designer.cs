
namespace newonenetapp
{
    partial class UserControl_device_datahistory
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
            this.dataGridView_datahistory = new System.Windows.Forms.DataGridView();
            this.groupBox_select = new System.Windows.Forms.GroupBox();
            this.labelDataStream = new System.Windows.Forms.Label();
            this.labelDeviceName = new System.Windows.Forms.Label();
            this.comboBoxDeviceName = new System.Windows.Forms.ComboBox();
            this.comboBoxDataStream = new System.Windows.Forms.ComboBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.numericUpDownDataNumber = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerEndTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_StartTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_datahistory)).BeginInit();
            this.groupBox_select.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDataNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_datahistory
            // 
            this.dataGridView_datahistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_datahistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_datahistory.Location = new System.Drawing.Point(14, 19);
            this.dataGridView_datahistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_datahistory.Name = "dataGridView_datahistory";
            this.dataGridView_datahistory.RowHeadersWidth = 51;
            this.dataGridView_datahistory.RowTemplate.Height = 27;
            this.dataGridView_datahistory.Size = new System.Drawing.Size(1289, 475);
            this.dataGridView_datahistory.TabIndex = 0;
            // 
            // groupBox_select
            // 
            this.groupBox_select.Controls.Add(this.labelDataStream);
            this.groupBox_select.Controls.Add(this.labelDeviceName);
            this.groupBox_select.Controls.Add(this.comboBoxDeviceName);
            this.groupBox_select.Controls.Add(this.comboBoxDataStream);
            this.groupBox_select.Controls.Add(this.labelNumber);
            this.groupBox_select.Controls.Add(this.labelEnd);
            this.groupBox_select.Controls.Add(this.labelStart);
            this.groupBox_select.Controls.Add(this.buttonQuery);
            this.groupBox_select.Controls.Add(this.numericUpDownDataNumber);
            this.groupBox_select.Controls.Add(this.dateTimePickerEndTime);
            this.groupBox_select.Controls.Add(this.dateTimePicker_StartTime);
            this.groupBox_select.Location = new System.Drawing.Point(14, 520);
            this.groupBox_select.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_select.Name = "groupBox_select";
            this.groupBox_select.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_select.Size = new System.Drawing.Size(1289, 150);
            this.groupBox_select.TabIndex = 1;
            this.groupBox_select.TabStop = false;
            this.groupBox_select.Text = "筛选条件";
            // 
            // labelDataStream
            // 
            this.labelDataStream.AutoSize = true;
            this.labelDataStream.Location = new System.Drawing.Point(680, 41);
            this.labelDataStream.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDataStream.Name = "labelDataStream";
            this.labelDataStream.Size = new System.Drawing.Size(82, 15);
            this.labelDataStream.TabIndex = 10;
            this.labelDataStream.Text = "数据流选择";
            // 
            // labelDeviceName
            // 
            this.labelDeviceName.AutoSize = true;
            this.labelDeviceName.Location = new System.Drawing.Point(485, 41);
            this.labelDeviceName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDeviceName.Name = "labelDeviceName";
            this.labelDeviceName.Size = new System.Drawing.Size(67, 15);
            this.labelDeviceName.TabIndex = 9;
            this.labelDeviceName.Text = "设备选择";
            // 
            // comboBoxDeviceName
            // 
            this.comboBoxDeviceName.FormattingEnabled = true;
            this.comboBoxDeviceName.Location = new System.Drawing.Point(443, 86);
            this.comboBoxDeviceName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxDeviceName.Name = "comboBoxDeviceName";
            this.comboBoxDeviceName.Size = new System.Drawing.Size(160, 23);
            this.comboBoxDeviceName.TabIndex = 8;
            this.comboBoxDeviceName.SelectedValueChanged += new System.EventHandler(this.comboBoxDeviceName_SelectedValueChanged);
            // 
            // comboBoxDataStream
            // 
            this.comboBoxDataStream.FormattingEnabled = true;
            this.comboBoxDataStream.Location = new System.Drawing.Point(643, 85);
            this.comboBoxDataStream.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxDataStream.Name = "comboBoxDataStream";
            this.comboBoxDataStream.Size = new System.Drawing.Size(160, 23);
            this.comboBoxDataStream.TabIndex = 7;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(900, 41);
            this.labelNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(67, 15);
            this.labelNumber.TabIndex = 6;
            this.labelNumber.Text = "查询条数";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(273, 41);
            this.labelEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(67, 15);
            this.labelEnd.TabIndex = 5;
            this.labelEnd.Text = "截至时间";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(77, 41);
            this.labelStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(67, 15);
            this.labelStart.TabIndex = 4;
            this.labelStart.Text = "起始时间";
            // 
            // buttonQuery
            // 
            this.buttonQuery.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonQuery.Location = new System.Drawing.Point(1053, 41);
            this.buttonQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(207, 86);
            this.buttonQuery.TabIndex = 3;
            this.buttonQuery.Text = "筛选";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // numericUpDownDataNumber
            // 
            this.numericUpDownDataNumber.Location = new System.Drawing.Point(835, 84);
            this.numericUpDownDataNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownDataNumber.Name = "numericUpDownDataNumber";
            this.numericUpDownDataNumber.Size = new System.Drawing.Size(196, 25);
            this.numericUpDownDataNumber.TabIndex = 2;
            // 
            // dateTimePickerEndTime
            // 
            this.dateTimePickerEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePickerEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEndTime.Location = new System.Drawing.Point(231, 85);
            this.dateTimePickerEndTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerEndTime.Name = "dateTimePickerEndTime";
            this.dateTimePickerEndTime.Size = new System.Drawing.Size(187, 25);
            this.dateTimePickerEndTime.TabIndex = 1;
            // 
            // dateTimePicker_StartTime
            // 
            this.dateTimePicker_StartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker_StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_StartTime.Location = new System.Drawing.Point(8, 85);
            this.dateTimePicker_StartTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker_StartTime.Name = "dateTimePicker_StartTime";
            this.dateTimePicker_StartTime.Size = new System.Drawing.Size(188, 25);
            this.dateTimePicker_StartTime.TabIndex = 0;
            this.dateTimePicker_StartTime.Value = new System.DateTime(2022, 6, 18, 17, 3, 0, 0);
            // 
            // UserControl_device_datahistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.groupBox_select);
            this.Controls.Add(this.dataGridView_datahistory);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControl_device_datahistory";
            this.Size = new System.Drawing.Size(1304, 674);
            this.Load += new System.EventHandler(this.UserControl_device_datahistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_datahistory)).EndInit();
            this.groupBox_select.ResumeLayout(false);
            this.groupBox_select.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDataNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_datahistory;
        private System.Windows.Forms.GroupBox groupBox_select;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.NumericUpDown numericUpDownDataNumber;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker_StartTime;
        private System.Windows.Forms.Label labelDataStream;
        private System.Windows.Forms.Label labelDeviceName;
        private System.Windows.Forms.ComboBox comboBoxDeviceName;
        private System.Windows.Forms.ComboBox comboBoxDataStream;
    }
}
