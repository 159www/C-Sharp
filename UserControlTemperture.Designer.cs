
namespace newonenetapp
{
    partial class UserControlTemperture
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartTemperture = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelTempreture = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperture)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTemperture
            // 
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            chartArea1.Name = "ChartArea1";
            this.chartTemperture.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTemperture.Legends.Add(legend1);
            this.chartTemperture.Location = new System.Drawing.Point(2, 31);
            this.chartTemperture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartTemperture.Name = "chartTemperture";
            series1.BorderWidth = 10;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.Name = "温度";
            series1.ShadowOffset = 5;
            this.chartTemperture.Series.Add(series1);
            this.chartTemperture.Size = new System.Drawing.Size(875, 506);
            this.chartTemperture.TabIndex = 0;
            this.chartTemperture.Text = "chart1";
            // 
            // buttonEnd
            // 
            this.buttonEnd.FlatAppearance.BorderSize = 0;
            this.buttonEnd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonEnd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnd.Font = new System.Drawing.Font("华文中宋", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonEnd.Location = new System.Drawing.Point(764, 357);
            this.buttonEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(102, 58);
            this.buttonEnd.TabIndex = 1;
            this.buttonEnd.Text = "暂停";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("华文中宋", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonStart.Location = new System.Drawing.Point(764, 274);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(102, 56);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "开始";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelTempreture
            // 
            this.labelTempreture.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTempreture.Location = new System.Drawing.Point(753, 84);
            this.labelTempreture.Name = "labelTempreture";
            this.labelTempreture.Size = new System.Drawing.Size(113, 52);
            this.labelTempreture.TabIndex = 3;
            this.labelTempreture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlTemperture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.labelTempreture);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.chartTemperture);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserControlTemperture";
            this.Size = new System.Drawing.Size(880, 581);
            this.Load += new System.EventHandler(this.UserControlTemperture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemperture;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelTempreture;
    }
}
