
namespace newonenetapp
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_query = new System.Windows.Forms.Button();
            this.button_data = new System.Windows.Forms.Button();
            this.button_device = new System.Windows.Forms.Button();
            this.panel_overview = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button_query);
            this.panel1.Controls.Add(this.button_data);
            this.panel1.Controls.Add(this.button_device);
            this.panel1.Location = new System.Drawing.Point(1, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 124);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(995, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button_query
            // 
            this.button_query.BackColor = System.Drawing.Color.Green;
            this.button_query.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_query.BackgroundImage")));
            this.button_query.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_query.FlatAppearance.BorderSize = 0;
            this.button_query.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_query.Font = new System.Drawing.Font("华文中宋", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_query.Location = new System.Drawing.Point(696, 4);
            this.button_query.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_query.Name = "button_query";
            this.button_query.Size = new System.Drawing.Size(192, 111);
            this.button_query.TabIndex = 2;
            this.button_query.Text = "控制";
            this.button_query.UseVisualStyleBackColor = false;
            this.button_query.Click += new System.EventHandler(this.button_query_Click);
            this.button_query.MouseEnter += new System.EventHandler(this.button_query_MouseEnter);
            this.button_query.MouseLeave += new System.EventHandler(this.button_query_MouseLeave);
            // 
            // button_data
            // 
            this.button_data.BackColor = System.Drawing.Color.GreenYellow;
            this.button_data.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_data.BackgroundImage")));
            this.button_data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_data.FlatAppearance.BorderSize = 0;
            this.button_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_data.Font = new System.Drawing.Font("华文中宋", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_data.Location = new System.Drawing.Point(375, 4);
            this.button_data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_data.Name = "button_data";
            this.button_data.Size = new System.Drawing.Size(204, 111);
            this.button_data.TabIndex = 1;
            this.button_data.Text = "数据";
            this.button_data.UseVisualStyleBackColor = false;
            this.button_data.Click += new System.EventHandler(this.button_data_Click);
            this.button_data.MouseEnter += new System.EventHandler(this.button_data_MouseEnter);
            this.button_data.MouseLeave += new System.EventHandler(this.button_data_MouseLeave);
            // 
            // button_device
            // 
            this.button_device.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_device.BackgroundImage")));
            this.button_device.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_device.FlatAppearance.BorderSize = 0;
            this.button_device.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_device.Font = new System.Drawing.Font("华文中宋", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_device.Location = new System.Drawing.Point(52, 1);
            this.button_device.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_device.Name = "button_device";
            this.button_device.Size = new System.Drawing.Size(219, 116);
            this.button_device.TabIndex = 0;
            this.button_device.Text = "设备";
            this.button_device.UseVisualStyleBackColor = true;
            this.button_device.Click += new System.EventHandler(this.button_device_Click);
            this.button_device.MouseEnter += new System.EventHandler(this.button_device_MouseEnter);
            this.button_device.MouseLeave += new System.EventHandler(this.button_device_MouseLeave);
            // 
            // panel_overview
            // 
            this.panel_overview.Location = new System.Drawing.Point(5, 192);
            this.panel_overview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_overview.Name = "panel_overview";
            this.panel_overview.Size = new System.Drawing.Size(1201, 468);
            this.panel_overview.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1209, 660);
            this.Controls.Add(this.panel_overview);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_query;
        private System.Windows.Forms.Button button_data;
        private System.Windows.Forms.Button button_device;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_overview;
    }
}