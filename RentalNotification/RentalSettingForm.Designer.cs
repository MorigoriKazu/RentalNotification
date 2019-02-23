namespace RentalNotification
{
    partial class RentalSettingForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Manga = new System.Windows.Forms.RadioButton();
            this.CDs = new System.Windows.Forms.RadioButton();
            this.DVDAndBluray = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OtherDays = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Days30 = new System.Windows.Forms.RadioButton();
            this.Days1 = new System.Windows.Forms.RadioButton();
            this.Days3 = new System.Windows.Forms.RadioButton();
            this.Days7 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Manga);
            this.groupBox1.Controls.Add(this.CDs);
            this.groupBox1.Controls.Add(this.DVDAndBluray);
            this.groupBox1.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(19, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(303, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "種類";
            // 
            // Manga
            // 
            this.Manga.AutoSize = true;
            this.Manga.Location = new System.Drawing.Point(221, 27);
            this.Manga.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Manga.Name = "Manga";
            this.Manga.Size = new System.Drawing.Size(76, 28);
            this.Manga.TabIndex = 2;
            this.Manga.TabStop = true;
            this.Manga.Text = "マンガ";
            this.Manga.UseVisualStyleBackColor = true;
            this.Manga.CheckedChanged += new System.EventHandler(this.Manga_CheckedChanged);
            // 
            // CDs
            // 
            this.CDs.AutoSize = true;
            this.CDs.Location = new System.Drawing.Point(165, 27);
            this.CDs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CDs.Name = "CDs";
            this.CDs.Size = new System.Drawing.Size(51, 28);
            this.CDs.TabIndex = 1;
            this.CDs.TabStop = true;
            this.CDs.Text = "CD";
            this.CDs.UseVisualStyleBackColor = true;
            this.CDs.CheckedChanged += new System.EventHandler(this.CDs_CheckedChanged);
            // 
            // DVDAndBluray
            // 
            this.DVDAndBluray.AutoSize = true;
            this.DVDAndBluray.Location = new System.Drawing.Point(8, 27);
            this.DVDAndBluray.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DVDAndBluray.Name = "DVDAndBluray";
            this.DVDAndBluray.Size = new System.Drawing.Size(151, 28);
            this.DVDAndBluray.TabIndex = 0;
            this.DVDAndBluray.TabStop = true;
            this.DVDAndBluray.Text = "DVD･ブルーレイ";
            this.DVDAndBluray.UseVisualStyleBackColor = true;
            this.DVDAndBluray.CheckedChanged += new System.EventHandler(this.DVDAndBluray_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(19, 105);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(23, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "名前";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OtherDays);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.Days30);
            this.groupBox2.Controls.Add(this.Days1);
            this.groupBox2.Controls.Add(this.Days3);
            this.groupBox2.Controls.Add(this.Days7);
            this.groupBox2.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox2.Location = new System.Drawing.Point(19, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 201);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "レンタル期間";
            // 
            // OtherDays
            // 
            this.OtherDays.AutoSize = true;
            this.OtherDays.Location = new System.Drawing.Point(8, 162);
            this.OtherDays.Name = "OtherDays";
            this.OtherDays.Size = new System.Drawing.Size(108, 28);
            this.OtherDays.TabIndex = 5;
            this.OtherDays.TabStop = true;
            this.OtherDays.Text = "その他期間";
            this.OtherDays.UseVisualStyleBackColor = true;
            this.OtherDays.CheckedChanged += new System.EventHandler(this.OtherDays_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(116, 161);
            this.textBox2.MaxLength = 4;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(62, 31);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Days30
            // 
            this.Days30.AutoSize = true;
            this.Days30.Location = new System.Drawing.Point(8, 128);
            this.Days30.Name = "Days30";
            this.Days30.Size = new System.Drawing.Size(170, 28);
            this.Days30.TabIndex = 3;
            this.Days30.TabStop = true;
            this.Days30.Text = "1ヶ月間（30日間）";
            this.Days30.UseVisualStyleBackColor = true;
            this.Days30.CheckedChanged += new System.EventHandler(this.Days30_CheckedChanged);
            // 
            // Days1
            // 
            this.Days1.AutoSize = true;
            this.Days1.Location = new System.Drawing.Point(8, 94);
            this.Days1.Name = "Days1";
            this.Days1.Size = new System.Drawing.Size(70, 28);
            this.Days1.TabIndex = 2;
            this.Days1.TabStop = true;
            this.Days1.Text = "1日間";
            this.Days1.UseVisualStyleBackColor = true;
            this.Days1.CheckedChanged += new System.EventHandler(this.Days1_CheckedChanged);
            // 
            // Days3
            // 
            this.Days3.AutoSize = true;
            this.Days3.Location = new System.Drawing.Point(8, 59);
            this.Days3.Name = "Days3";
            this.Days3.Size = new System.Drawing.Size(70, 28);
            this.Days3.TabIndex = 1;
            this.Days3.TabStop = true;
            this.Days3.Text = "3日間";
            this.Days3.UseVisualStyleBackColor = true;
            this.Days3.CheckedChanged += new System.EventHandler(this.Days3_CheckedChanged);
            // 
            // Days7
            // 
            this.Days7.AutoSize = true;
            this.Days7.Location = new System.Drawing.Point(8, 25);
            this.Days7.Name = "Days7";
            this.Days7.Size = new System.Drawing.Size(70, 28);
            this.Days7.TabIndex = 0;
            this.Days7.TabStop = true;
            this.Days7.Text = "7日間";
            this.Days7.UseVisualStyleBackColor = true;
            this.Days7.CheckedChanged += new System.EventHandler(this.Days7_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(240, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "クリア";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button3.Location = new System.Drawing.Point(135, 350);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 30);
            this.button3.TabIndex = 6;
            this.button3.Text = "確認";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RentalSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 388);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "RentalSettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentalSettingForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RentalSettingForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Manga;
        private System.Windows.Forms.RadioButton CDs;
        private System.Windows.Forms.RadioButton DVDAndBluray;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton OtherDays;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton Days30;
        private System.Windows.Forms.RadioButton Days1;
        private System.Windows.Forms.RadioButton Days3;
        private System.Windows.Forms.RadioButton Days7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}