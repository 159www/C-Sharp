
namespace newonenetapp
{
    partial class UserControlHandControl
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
            this.comboBoxDeviceSelect = new System.Windows.Forms.ComboBox();
            this.labelDevice = new System.Windows.Forms.Label();
            this.labelCommand = new System.Windows.Forms.Label();
            this.comboBoxCommand = new System.Windows.Forms.ComboBox();
            this.buttonCommand = new System.Windows.Forms.Button();
            this.groupBoxAddCommand = new System.Windows.Forms.GroupBox();
            this.textBoxCmdName = new System.Windows.Forms.TextBox();
            this.labelCmdName = new System.Windows.Forms.Label();
            this.labelCMD = new System.Windows.Forms.Label();
            this.buttonAddCommand = new System.Windows.Forms.Button();
            this.textBoxAddCommand = new System.Windows.Forms.TextBox();
            this.groupBoxAddCommand.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxDeviceSelect
            // 
            this.comboBoxDeviceSelect.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxDeviceSelect.FormattingEnabled = true;
            this.comboBoxDeviceSelect.Location = new System.Drawing.Point(232, 81);
            this.comboBoxDeviceSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxDeviceSelect.Name = "comboBoxDeviceSelect";
            this.comboBoxDeviceSelect.Size = new System.Drawing.Size(276, 31);
            this.comboBoxDeviceSelect.TabIndex = 0;
            this.comboBoxDeviceSelect.SelectedValueChanged += new System.EventHandler(this.comboBoxDeviceSelect_SelectedValueChanged);
            // 
            // labelDevice
            // 
            this.labelDevice.BackColor = System.Drawing.Color.White;
            this.labelDevice.Font = new System.Drawing.Font("华文中宋", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelDevice.Location = new System.Drawing.Point(228, 0);
            this.labelDevice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDevice.Name = "labelDevice";
            this.labelDevice.Size = new System.Drawing.Size(159, 52);
            this.labelDevice.TabIndex = 1;
            this.labelDevice.Text = "设备选择";
            this.labelDevice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCommand
            // 
            this.labelCommand.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCommand.Font = new System.Drawing.Font("华文中宋", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCommand.Location = new System.Drawing.Point(228, 151);
            this.labelCommand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCommand.Name = "labelCommand";
            this.labelCommand.Size = new System.Drawing.Size(159, 48);
            this.labelCommand.TabIndex = 2;
            this.labelCommand.Text = "命令选择";
            this.labelCommand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxCommand
            // 
            this.comboBoxCommand.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxCommand.FormattingEnabled = true;
            this.comboBoxCommand.Location = new System.Drawing.Point(232, 240);
            this.comboBoxCommand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxCommand.Name = "comboBoxCommand";
            this.comboBoxCommand.Size = new System.Drawing.Size(276, 31);
            this.comboBoxCommand.TabIndex = 3;
            // 
            // buttonCommand
            // 
            this.buttonCommand.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCommand.FlatAppearance.BorderSize = 0;
            this.buttonCommand.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonCommand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCommand.Font = new System.Drawing.Font("华文中宋", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCommand.Location = new System.Drawing.Point(232, 312);
            this.buttonCommand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCommand.Name = "buttonCommand";
            this.buttonCommand.Size = new System.Drawing.Size(189, 68);
            this.buttonCommand.TabIndex = 4;
            this.buttonCommand.Text = "命令下发";
            this.buttonCommand.UseVisualStyleBackColor = false;
            this.buttonCommand.Click += new System.EventHandler(this.buttonCommand_Click);
            // 
            // groupBoxAddCommand
            // 
            this.groupBoxAddCommand.Controls.Add(this.textBoxCmdName);
            this.groupBoxAddCommand.Controls.Add(this.labelCmdName);
            this.groupBoxAddCommand.Controls.Add(this.labelCMD);
            this.groupBoxAddCommand.Controls.Add(this.buttonAddCommand);
            this.groupBoxAddCommand.Controls.Add(this.textBoxAddCommand);
            this.groupBoxAddCommand.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxAddCommand.Location = new System.Drawing.Point(4, 419);
            this.groupBoxAddCommand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxAddCommand.Name = "groupBoxAddCommand";
            this.groupBoxAddCommand.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxAddCommand.Size = new System.Drawing.Size(656, 164);
            this.groupBoxAddCommand.TabIndex = 5;
            this.groupBoxAddCommand.TabStop = false;
            this.groupBoxAddCommand.Text = "命令添加";
            // 
            // textBoxCmdName
            // 
            this.textBoxCmdName.Location = new System.Drawing.Point(116, 41);
            this.textBoxCmdName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCmdName.Name = "textBoxCmdName";
            this.textBoxCmdName.Size = new System.Drawing.Size(300, 41);
            this.textBoxCmdName.TabIndex = 7;
            // 
            // labelCmdName
            // 
            this.labelCmdName.AutoSize = true;
            this.labelCmdName.Location = new System.Drawing.Point(8, 38);
            this.labelCmdName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCmdName.Name = "labelCmdName";
            this.labelCmdName.Size = new System.Drawing.Size(91, 29);
            this.labelCmdName.TabIndex = 6;
            this.labelCmdName.Text = "命令名";
            // 
            // labelCMD
            // 
            this.labelCMD.AutoSize = true;
            this.labelCMD.Location = new System.Drawing.Point(8, 104);
            this.labelCMD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCMD.Name = "labelCMD";
            this.labelCMD.Size = new System.Drawing.Size(65, 29);
            this.labelCMD.TabIndex = 6;
            this.labelCMD.Text = "命令";
            // 
            // buttonAddCommand
            // 
            this.buttonAddCommand.Location = new System.Drawing.Point(455, 65);
            this.buttonAddCommand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddCommand.Name = "buttonAddCommand";
            this.buttonAddCommand.Size = new System.Drawing.Size(193, 65);
            this.buttonAddCommand.TabIndex = 1;
            this.buttonAddCommand.Text = "添加命令";
            this.buttonAddCommand.UseVisualStyleBackColor = true;
            this.buttonAddCommand.Click += new System.EventHandler(this.buttonAddCommand_Click);
            // 
            // textBoxAddCommand
            // 
            this.textBoxAddCommand.Location = new System.Drawing.Point(116, 100);
            this.textBoxAddCommand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAddCommand.Name = "textBoxAddCommand";
            this.textBoxAddCommand.Size = new System.Drawing.Size(300, 41);
            this.textBoxAddCommand.TabIndex = 0;
            // 
            // UserControlHandControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.groupBoxAddCommand);
            this.Controls.Add(this.buttonCommand);
            this.Controls.Add(this.comboBoxCommand);
            this.Controls.Add(this.labelCommand);
            this.Controls.Add(this.labelDevice);
            this.Controls.Add(this.comboBoxDeviceSelect);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControlHandControl";
            this.Size = new System.Drawing.Size(664, 586);
            this.Load += new System.EventHandler(this.UserControlHandControl_Load);
            this.groupBoxAddCommand.ResumeLayout(false);
            this.groupBoxAddCommand.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDeviceSelect;
        private System.Windows.Forms.Label labelDevice;
        private System.Windows.Forms.Label labelCommand;
        private System.Windows.Forms.ComboBox comboBoxCommand;
        private System.Windows.Forms.Button buttonCommand;
        private System.Windows.Forms.GroupBox groupBoxAddCommand;
        private System.Windows.Forms.TextBox textBoxAddCommand;
        private System.Windows.Forms.Label labelCMD;
        private System.Windows.Forms.Button buttonAddCommand;
        private System.Windows.Forms.TextBox textBoxCmdName;
        private System.Windows.Forms.Label labelCmdName;
    }
}
