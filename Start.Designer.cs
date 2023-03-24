
namespace newonenetapp
{
    partial class Start
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.enter = new System.Windows.Forms.Button();
            this.progressBarstart = new System.Windows.Forms.ProgressBar();
            this.timer_start = new System.Windows.Forms.Timer(this.components);
            this.button_test = new System.Windows.Forms.Button();
            this.textBox_test = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.enter.FlatAppearance.BorderSize = 0;
            this.enter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enter.Font = new System.Drawing.Font("华文中宋", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.enter.Location = new System.Drawing.Point(370, 385);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(209, 66);
            this.enter.TabIndex = 0;
            this.enter.Text = "登入";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // progressBarstart
            // 
            this.progressBarstart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBarstart.ForeColor = System.Drawing.Color.Gold;
            this.progressBarstart.Location = new System.Drawing.Point(-2, 490);
            this.progressBarstart.Name = "progressBarstart";
            this.progressBarstart.Size = new System.Drawing.Size(945, 26);
            this.progressBarstart.TabIndex = 1;
            // 
            // timer_start
            // 
            this.timer_start.Tick += new System.EventHandler(this.timer_start_Tick);
            // 
            // button_test
            // 
            this.button_test.Location = new System.Drawing.Point(54, 122);
            this.button_test.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(75, 53);
            this.button_test.TabIndex = 2;
            this.button_test.Text = "test";
            this.button_test.UseVisualStyleBackColor = true;
            this.button_test.Click += new System.EventHandler(this.button_test_Click);
            // 
            // textBox_test
            // 
            this.textBox_test.Location = new System.Drawing.Point(182, 39);
            this.textBox_test.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_test.Multiline = true;
            this.textBox_test.Name = "textBox_test";
            this.textBox_test.Size = new System.Drawing.Size(370, 265);
            this.textBox_test.TabIndex = 3;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(942, 531);
            this.Controls.Add(this.textBox_test);
            this.Controls.Add(this.button_test);
            this.Controls.Add(this.progressBarstart);
            this.Controls.Add(this.enter);
            this.MaximumSize = new System.Drawing.Size(960, 577);
            this.Name = "Start";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.ProgressBar progressBarstart;
        private System.Windows.Forms.Timer timer_start;
        private System.Windows.Forms.Button button_test;
        private System.Windows.Forms.TextBox textBox_test;
    }
}

