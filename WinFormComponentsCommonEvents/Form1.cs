using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WinFormComponentsCommonEvents
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            messagesTextBox.Text = "Main Form loaded." + Environment.NewLine;
        }

        private void mainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                messagesTextBox.Text += "Left button of the mouse has been clicked over the form." + Environment.NewLine;
            }
            else if (e.Button == MouseButtons.Right)
            {
                messagesTextBox.Text += "Right button of the mouse has been clicked over the form." + Environment.NewLine;
            }
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            messagesTextBox.Text += "The label has been double clicked." + Environment.NewLine;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            messagesTextBox.Text += "Numeric Up Down value changed to " + numericUpDown1.Value + Environment.NewLine;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            messagesTextBox.Text += "List Box selected index has changed to " + listBox1.SelectedIndex + Environment.NewLine;
        }
    }
}
