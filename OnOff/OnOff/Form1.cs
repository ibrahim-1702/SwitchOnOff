using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnOff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            OnOrOff Obj = new OnOrOff();
            
            Obj.IsOn = radioButton1.Checked;
            Obj.IsOff = !radioButton1.Checked;

            if (!radioButton1.Checked)
            {
                BackColor = Color.Green;
                radioButton1.Text = "On";
            }
            else if (radioButton1.Checked)
            {
                BackColor = Color.Red;
                radioButton1.Text = "Off";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnOrOff Obj = new OnOrOff();

            Obj.IsOn = button1.BackColor == Color.Green;
            Obj.IsOff = button1.BackColor == Color.Red;

            if (Obj.IsOn)
            {
                button1.BackColor = Color.Red;
                label1.ForeColor = Color.Red;
                label1.Text = "Off";
            }
            else if (Obj.IsOff)
            {
                button1.BackColor = Color.Green;
                label1.ForeColor = Color.Green;
                label1.Text = "On";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
    }
    
}
