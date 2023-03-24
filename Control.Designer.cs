
namespace newonenetapp
{
    partial class Control
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonHandControl = new System.Windows.Forms.Button();
            this.buttonAutoControl = new System.Windows.Forms.Button();
            this.panelHandControl = new System.Windows.Forms.Panel();
            this.panelAutoControl = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonHandControl);
            this.panel1.Controls.Add(this.buttonAutoControl);
            this.panel1.Location = new System.Drawing.Point(4, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 101);
            this.panel1.TabIndex = 0;
            // 
            // buttonHandControl
            // 
            this.buttonHandControl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonHandControl.FlatAppearance.BorderSize = 0;
            this.buttonHandControl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonHandControl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonHandControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHandControl.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonHandControl.Location = new System.Drawing.Point(418, 5);
            this.buttonHandControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonHandControl.Name = "buttonHandControl";
            this.buttonHandControl.Size = new System.Drawing.Size(169, 92);
            this.buttonHandControl.TabIndex = 1;
            this.buttonHandControl.Text = "手动控制";
            this.buttonHandControl.UseVisualStyleBackColor = false;
            this.buttonHandControl.Click += new System.EventHandler(this.buttonHandControl_Click);
            // 
            // buttonAutoControl
            // 
            this.buttonAutoControl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAutoControl.FlatAppearance.BorderSize = 0;
            this.buttonAutoControl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonAutoControl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonAutoControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAutoControl.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonAutoControl.Location = new System.Drawing.Point(152, 5);
            this.buttonAutoControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAutoControl.Name = "buttonAutoControl";
            this.buttonAutoControl.Size = new System.Drawing.Size(176, 92);
            this.buttonAutoControl.TabIndex = 0;
            this.buttonAutoControl.Text = "自动控制";
            this.buttonAutoControl.UseVisualStyleBackColor = false;
            this.buttonAutoControl.Click += new System.EventHandler(this.buttonAutoControl_Click);
            // 
            // panelHandControl
            // 
            this.panelHandControl.Location = new System.Drawing.Point(4, 106);
            this.panelHandControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelHandControl.Name = "panelHandControl";
            this.panelHandControl.Size = new System.Drawing.Size(664, 586);
            this.panelHandControl.TabIndex = 1;
            // 
            // panelAutoControl
            // 
            this.panelAutoControl.Location = new System.Drawing.Point(667, 2);
            this.panelAutoControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelAutoControl.Name = "panelAutoControl";
            this.panelAutoControl.Size = new System.Drawing.Size(696, 690);
            this.panelAutoControl.TabIndex = 2;
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1368, 696);
            this.Controls.Add(this.panelAutoControl);
            this.Controls.Add(this.panelHandControl);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Control";
            this.Text = "Control";
            this.Load += new System.EventHandler(this.Control_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHandControl;
        private System.Windows.Forms.Button buttonAutoControl;
        private System.Windows.Forms.Panel panelHandControl;
        private System.Windows.Forms.Panel panelAutoControl;
    }
}