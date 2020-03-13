namespace mini_keyboard
{
    partial class Main
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
            this.gb_left = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cb_lWin = new System.Windows.Forms.CheckBox();
            this.cb_lAlt = new System.Windows.Forms.CheckBox();
            this.cb_lShift = new System.Windows.Forms.CheckBox();
            this.cb_lCtrl = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.gb_right = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cb_rWin = new System.Windows.Forms.CheckBox();
            this.cb_rAlt = new System.Windows.Forms.CheckBox();
            this.cb_rShift = new System.Windows.Forms.CheckBox();
            this.cb_rCtrl = new System.Windows.Forms.CheckBox();
            this.gb_left.SuspendLayout();
            this.gb_right.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_left
            // 
            this.gb_left.Controls.Add(this.textBox1);
            this.gb_left.Controls.Add(this.cb_lWin);
            this.gb_left.Controls.Add(this.cb_lAlt);
            this.gb_left.Controls.Add(this.cb_lShift);
            this.gb_left.Controls.Add(this.cb_lCtrl);
            this.gb_left.Enabled = false;
            this.gb_left.Location = new System.Drawing.Point(24, 76);
            this.gb_left.Margin = new System.Windows.Forms.Padding(6);
            this.gb_left.Name = "gb_left";
            this.gb_left.Padding = new System.Windows.Forms.Padding(6);
            this.gb_left.Size = new System.Drawing.Size(384, 136);
            this.gb_left.TabIndex = 0;
            this.gb_left.TabStop = false;
            this.gb_left.Text = "左键";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 84);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(362, 35);
            this.textBox1.TabIndex = 12;
            // 
            // cb_lWin
            // 
            this.cb_lWin.AutoSize = true;
            this.cb_lWin.Location = new System.Drawing.Point(292, 36);
            this.cb_lWin.Margin = new System.Windows.Forms.Padding(4);
            this.cb_lWin.Name = "cb_lWin";
            this.cb_lWin.Size = new System.Drawing.Size(78, 28);
            this.cb_lWin.TabIndex = 11;
            this.cb_lWin.Text = "Win";
            this.cb_lWin.UseVisualStyleBackColor = true;
            // 
            // cb_lAlt
            // 
            this.cb_lAlt.AutoSize = true;
            this.cb_lAlt.Location = new System.Drawing.Point(208, 36);
            this.cb_lAlt.Margin = new System.Windows.Forms.Padding(4);
            this.cb_lAlt.Name = "cb_lAlt";
            this.cb_lAlt.Size = new System.Drawing.Size(78, 28);
            this.cb_lAlt.TabIndex = 10;
            this.cb_lAlt.Text = "Alt";
            this.cb_lAlt.UseVisualStyleBackColor = true;
            // 
            // cb_lShift
            // 
            this.cb_lShift.AutoSize = true;
            this.cb_lShift.Location = new System.Drawing.Point(104, 36);
            this.cb_lShift.Margin = new System.Windows.Forms.Padding(4);
            this.cb_lShift.Name = "cb_lShift";
            this.cb_lShift.Size = new System.Drawing.Size(102, 28);
            this.cb_lShift.TabIndex = 9;
            this.cb_lShift.Text = "Shift";
            this.cb_lShift.UseVisualStyleBackColor = true;
            // 
            // cb_lCtrl
            // 
            this.cb_lCtrl.AutoSize = true;
            this.cb_lCtrl.Location = new System.Drawing.Point(8, 36);
            this.cb_lCtrl.Margin = new System.Windows.Forms.Padding(4);
            this.cb_lCtrl.Name = "cb_lCtrl";
            this.cb_lCtrl.Size = new System.Drawing.Size(90, 28);
            this.cb_lCtrl.TabIndex = 8;
            this.cb_lCtrl.Text = "Ctrl";
            this.cb_lCtrl.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 24);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 32);
            this.comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "扫描";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(440, 20);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "连接";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(632, 20);
            this.button3.Margin = new System.Windows.Forms.Padding(6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 46);
            this.button3.TabIndex = 5;
            this.button3.Text = "修改";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gb_right
            // 
            this.gb_right.Controls.Add(this.textBox2);
            this.gb_right.Controls.Add(this.cb_rWin);
            this.gb_right.Controls.Add(this.cb_rAlt);
            this.gb_right.Controls.Add(this.cb_rShift);
            this.gb_right.Controls.Add(this.cb_rCtrl);
            this.gb_right.Enabled = false;
            this.gb_right.Location = new System.Drawing.Point(428, 76);
            this.gb_right.Margin = new System.Windows.Forms.Padding(6);
            this.gb_right.Name = "gb_right";
            this.gb_right.Padding = new System.Windows.Forms.Padding(6);
            this.gb_right.Size = new System.Drawing.Size(384, 136);
            this.gb_right.TabIndex = 13;
            this.gb_right.TabStop = false;
            this.gb_right.Text = "右键";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 84);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(362, 35);
            this.textBox2.TabIndex = 12;
            // 
            // cb_rWin
            // 
            this.cb_rWin.AutoSize = true;
            this.cb_rWin.Location = new System.Drawing.Point(292, 36);
            this.cb_rWin.Margin = new System.Windows.Forms.Padding(4);
            this.cb_rWin.Name = "cb_rWin";
            this.cb_rWin.Size = new System.Drawing.Size(78, 28);
            this.cb_rWin.TabIndex = 11;
            this.cb_rWin.Text = "Win";
            this.cb_rWin.UseVisualStyleBackColor = true;
            // 
            // cb_rAlt
            // 
            this.cb_rAlt.AutoSize = true;
            this.cb_rAlt.Location = new System.Drawing.Point(208, 36);
            this.cb_rAlt.Margin = new System.Windows.Forms.Padding(4);
            this.cb_rAlt.Name = "cb_rAlt";
            this.cb_rAlt.Size = new System.Drawing.Size(78, 28);
            this.cb_rAlt.TabIndex = 10;
            this.cb_rAlt.Text = "Alt";
            this.cb_rAlt.UseVisualStyleBackColor = true;
            // 
            // cb_rShift
            // 
            this.cb_rShift.AutoSize = true;
            this.cb_rShift.Location = new System.Drawing.Point(104, 36);
            this.cb_rShift.Margin = new System.Windows.Forms.Padding(4);
            this.cb_rShift.Name = "cb_rShift";
            this.cb_rShift.Size = new System.Drawing.Size(102, 28);
            this.cb_rShift.TabIndex = 9;
            this.cb_rShift.Text = "Shift";
            this.cb_rShift.UseVisualStyleBackColor = true;
            // 
            // cb_rCtrl
            // 
            this.cb_rCtrl.AutoSize = true;
            this.cb_rCtrl.Location = new System.Drawing.Point(8, 36);
            this.cb_rCtrl.Margin = new System.Windows.Forms.Padding(4);
            this.cb_rCtrl.Name = "cb_rCtrl";
            this.cb_rCtrl.Size = new System.Drawing.Size(90, 28);
            this.cb_rCtrl.TabIndex = 8;
            this.cb_rCtrl.Text = "Ctrl";
            this.cb_rCtrl.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 224);
            this.Controls.Add(this.gb_right);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.gb_left);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Main";
            this.Text = "键位设置";
            this.Load += new System.EventHandler(this.Main_Load);
            this.gb_left.ResumeLayout(false);
            this.gb_left.PerformLayout();
            this.gb_right.ResumeLayout(false);
            this.gb_right.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_left;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox cb_lWin;
        private System.Windows.Forms.CheckBox cb_lAlt;
        private System.Windows.Forms.CheckBox cb_lShift;
        private System.Windows.Forms.CheckBox cb_lCtrl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gb_right;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox cb_rWin;
        private System.Windows.Forms.CheckBox cb_rAlt;
        private System.Windows.Forms.CheckBox cb_rShift;
        private System.Windows.Forms.CheckBox cb_rCtrl;
    }
}

