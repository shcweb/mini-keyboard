using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mini_keyboard
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string port;
            for (int i = 0; i < 23; i++)
            {
                port = "COM" + i;
                serialPort1.PortName = port;
                try
                {
                    serialPort1.Open();
                    comboBox1.Items.Add(port);
                }
                catch (Exception)
                {

                }
                serialPort1.Close();
            }
            if (comboBox1.Items.Count > 0)
                serialPort1.PortName = comboBox1.Text = comboBox1.Items[0].ToString();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "连接")
            {
                try
                {
                    serialPort1.Open();
                }
                catch (Exception)
                {
                    serialPort1.Close();
                    MessageBox.Show("串口打开失败qwq");
                    return;
                }
                button2.Text = "断开";
                button3.Enabled = gb_left.Enabled = gb_right.Enabled = true;
                button1.Enabled = false;
            }
            else
            {
                serialPort1.Close();
                button2.Text = "连接";
                button3.Enabled = gb_left.Enabled = gb_right.Enabled = false;
                button1.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = "";
            str += cb_lCtrl.Checked ? 1 : 0;
            str += cb_lShift.Checked ? 1 : 0;
            str += cb_lAlt.Checked ? 1 : 0;
            str += cb_lWin.Checked ? 1 : 0;
            str += cb_lTab.Checked ? 1 : 0;
            str += cb_lDel.Checked ? 1 : 0;
            str += cb_lEsc.Checked ? 1 : 0;
            str += cb_lBak.Checked ? 1 : 0;
            str += cb_lF1.Checked ? 1 : 0;
            str += cb_lF2.Checked ? 1 : 0;
            str += cb_lF3.Checked ? 1 : 0;
            str += cb_lF4.Checked ? 1 : 0;
            str += cb_lF5.Checked ? 1 : 0;
            str += cb_lF6.Checked ? 1 : 0;
            str += cb_lF7.Checked ? 1 : 0;
            str += cb_lF8.Checked ? 1 : 0;
            str += cb_lF9.Checked ? 1 : 0;
            str += cb_lF10.Checked ? 1 : 0;
            str += cb_lF11.Checked ? 1 : 0;
            str += cb_lF12.Checked ? 1 : 0;
            str += (char)29;
            str += textBox1.Text;
            str += (char)29;
            str += cb_rCtrl.Checked ? 1 : 0;
            str += cb_rShift.Checked ? 1 : 0;
            str += cb_rAlt.Checked ? 1 : 0;
            str += cb_rWin.Checked ? 1 : 0;
            str += cb_rTab.Checked ? 1 : 0;
            str += cb_rDel.Checked ? 1 : 0;
            str += cb_rEsc.Checked ? 1 : 0;
            str += cb_rBak.Checked ? 1 : 0;
            str += cb_rF1.Checked ? 1 : 0;
            str += cb_rF2.Checked ? 1 : 0;
            str += cb_rF3.Checked ? 1 : 0;
            str += cb_rF4.Checked ? 1 : 0;
            str += cb_rF5.Checked ? 1 : 0;
            str += cb_rF6.Checked ? 1 : 0;
            str += cb_rF7.Checked ? 1 : 0;
            str += cb_rF8.Checked ? 1 : 0;
            str += cb_rF9.Checked ? 1 : 0;
            str += cb_rF10.Checked ? 1 : 0;
            str += cb_rF11.Checked ? 1 : 0;
            str += cb_rF12.Checked ? 1 : 0;
            str += (char)29;
            str += textBox2.Text;
            str += (char)29;
            //MessageBox.Show(str.Replace((char)29, '|'));
            serialPort1.WriteLine(str.ToLower());
        }
    }
}
