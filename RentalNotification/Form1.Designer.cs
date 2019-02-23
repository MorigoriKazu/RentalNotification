namespace RentalNotification
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotifRightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.セットToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.返却予定物ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.NotifRightClickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.NotifRightClickMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "レンタル通知";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.NotifyIcon1_DoubleClick);
            // 
            // NotifRightClickMenu
            // 
            this.NotifRightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.セットToolStripMenuItem,
            this.返却予定物ToolStripMenuItem,
            this.終了ToolStripMenuItem});
            this.NotifRightClickMenu.Name = "NotifRightClickMenu";
            this.NotifRightClickMenu.Size = new System.Drawing.Size(159, 70);
            this.NotifRightClickMenu.DoubleClick += new System.EventHandler(this.NotifRightClickMenu_DoubleClick);
            // 
            // セットToolStripMenuItem
            // 
            this.セットToolStripMenuItem.Name = "セットToolStripMenuItem";
            this.セットToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.セットToolStripMenuItem.Text = "セット";
            this.セットToolStripMenuItem.Click += new System.EventHandler(this.セットToolStripMenuItem_Click);
            // 
            // 返却予定物ToolStripMenuItem
            // 
            this.返却予定物ToolStripMenuItem.Name = "返却予定物ToolStripMenuItem";
            this.返却予定物ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.返却予定物ToolStripMenuItem.Text = "返却予定物確認";
            this.返却予定物ToolStripMenuItem.Click += new System.EventHandler(this.返却予定物ToolStripMenuItem_Click);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Form1";
            this.Text = "Form1";
            this.NotifRightClickMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip NotifRightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem セットToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 返却予定物ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

