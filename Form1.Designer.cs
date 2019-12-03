namespace JDK_packageConvert
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssl_role = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_version = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_notify = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_role,
            this.tssl_version});
            this.statusStrip1.Location = new System.Drawing.Point(0, 352);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(323, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssl_role
            // 
            this.tssl_role.Name = "tssl_role";
            this.tssl_role.Size = new System.Drawing.Size(48, 20);
            this.tssl_role.Text = "toolS";
            // 
            // tssl_version
            // 
            this.tssl_version.Name = "tssl_version";
            this.tssl_version.Size = new System.Drawing.Size(41, 20);
            this.tssl_version.Text = "V1.1";
            // 
            // lb_notify
            // 
            this.lb_notify.Location = new System.Drawing.Point(25, 174);
            this.lb_notify.Name = "lb_notify";
            this.lb_notify.Size = new System.Drawing.Size(272, 23);
            this.lb_notify.TabIndex = 1;
            this.lb_notify.Text = " 请将文件夹拖入此处";
            this.lb_notify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(323, 378);
            this.Controls.Add(this.lb_notify);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JDK-packageConvert";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssl_role;
        private System.Windows.Forms.ToolStripStatusLabel tssl_version;
        private System.Windows.Forms.Label lb_notify;
    }
}

