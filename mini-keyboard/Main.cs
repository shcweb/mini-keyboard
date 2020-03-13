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
            }
            else
            {
                serialPort1.Close();
                button2.Text = "连接";
                button3.Enabled = gb_left.Enabled = gb_right.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = "";
            str += cb_lCtrl.Checked ? 1 : 0;
            str += cb_lShift.Checked ? 1 : 0;
            str += cb_lAlt.Checked ? 1 : 0;
            str += cb_lWin.Checked ? 1 : 0;
            str += (char)29;
            str += textBox1.Text;
            str += (char)29;
            str += "";
            str += cb_rCtrl.Checked ? 1 : 0;
            str += cb_rShift.Checked ? 1 : 0;
            str += cb_rAlt.Checked ? 1 : 0;
            str += cb_rWin.Checked ? 1 : 0;
            str += (char)29;
            str += textBox2.Text;
            str += (char)29;
            serialPort1.WriteLine(str.ToLower());
        }
    }
}
