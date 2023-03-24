
namespace newonenetapp
{
    partial class DataShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataShow));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonMap = new System.Windows.Forms.Button();
            this.buttonLight = new System.Windows.Forms.Button();
            this.buttonHumity = new System.Windows.Forms.Button();
            this.buttonTemperture = new System.Windows.Forms.Button();
            this.panelShow = new System.Windows.Forms.Panel();
            this.pictureBoxCon = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.pictureBoxCon);
            this.panelMenu.Controls.Add(this.buttonMap);
            this.panelMenu.Controls.Add(this.buttonLight);
            this.panelMenu.Controls.Add(this.buttonHumity);
            this.panelMenu.Controls.Add(this.buttonTemperture);
            this.panelMenu.Location = new System.Drawing.Point(1, 2);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(120, 581);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonMap
            // 
            this.buttonMap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMap.FlatAppearance.BorderSize = 0;
            this.buttonMap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonMap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMap.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonMap.Location = new System.Drawing.Point(2, 259);
            this.buttonMap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMap.Name = "buttonMap";
            this.buttonMap.Size = new System.Drawing.Size(116, 61);
            this.buttonMap.TabIndex = 3;
            this.buttonMap.Text = "位置";
            this.buttonMap.UseVisualStyleBackColor = false;
            this.buttonMap.Click += new System.EventHandler(this.buttonMap_Click);
            // 
            // buttonLight
            // 
            this.buttonLight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLight.FlatAppearance.BorderSize = 0;
            this.buttonLight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonLight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.buttonLight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLight.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonLight.Location = new System.Drawing.Point(2, 168);
            this.buttonLight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLight.Name = "buttonLight";
            this.buttonLight.Size = new System.Drawing.Size(116, 62);
            this.buttonLight.TabIndex = 2;
            this.buttonLight.Text = "光强";
            this.buttonLight.UseVisualStyleBackColor = false;
            this.buttonLight.Click += new System.EventHandler(this.buttonLight_Click);
            // 
            // buttonHumity
            // 
            this.buttonHumity.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonHumity.FlatAppearance.BorderSize = 0;
            this.buttonHumity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonHumity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonHumity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHumity.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonHumity.Location = new System.Drawing.Point(0, 97);
            this.buttonHumity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonHumity.Name = "buttonHumity";
            this.buttonHumity.Size = new System.Drawing.Size(118, 53);
            this.buttonHumity.TabIndex = 1;
            this.buttonHumity.Text = "湿度";
            this.buttonHumity.UseVisualStyleBackColor = false;
            this.buttonHumity.Click += new System.EventHandler(this.buttonHumity_Click);
            // 
            // buttonTemperture
            // 
            this.buttonTemperture.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTemperture.FlatAppearance.BorderSize = 0;
            this.buttonTemperture.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonTemperture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonTemperture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTemperture.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonTemperture.Location = new System.Drawing.Point(0, 18);
            this.buttonTemperture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTemperture.Name = "buttonTemperture";
            this.buttonTemperture.Size = new System.Drawing.Size(118, 59);
            this.buttonTemperture.TabIndex = 0;
            this.buttonTemperture.Text = "温度";
            this.buttonTemperture.UseVisualStyleBackColor = false;
            this.buttonTemperture.Click += new System.EventHandler(this.buttonTemperture_Click);
            // 
            // panelShow
            // 
            this.panelShow.Location = new System.Drawing.Point(123, 2);
            this.panelShow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(880, 581);
            this.panelShow.TabIndex = 1;
            // 
            // pictureBoxCon
            // 
            this.pictureBoxCon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCon.Image")));
            this.pictureBoxCon.Location = new System.Drawing.Point(3, 420);
            this.pictureBoxCon.Name = "pictureBoxCon";
            this.pictureBoxCon.Size = new System.Drawing.Size(114, 158);
            this.pictureBoxCon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCon.TabIndex = 0;
            this.pictureBoxCon.TabStop = false;
            // 
            // DataShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1004, 585);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DataShow";
            this.Text = "DataShow";
            this.Load += new System.EventHandler(this.DataShow_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonLight;
        private System.Windows.Forms.Button buttonHumity;
        private System.Windows.Forms.Button buttonTemperture;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.Button buttonMap;
        private System.Windows.Forms.PictureBox pictureBoxCon;
    }
}