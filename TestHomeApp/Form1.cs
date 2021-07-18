using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestHomeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StringBuilder text = new StringBuilder();
        private void button1_Click(object sender, EventArgs e)
        {
            text.Append("A");

            textBox1.Text = text.ToString();
            //textBox1.Text.Append("A");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                comboBox1.Items.Add(i);

                listBox1.Items.Add(i);
                listBox2.Items.Add(i + 10);
            }

            comboBox1.SelectedIndex = 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            
            MessageBox.Show(comboBox1.SelectedIndex.ToString());
            MessageBox.Show(comboBox1.SelectedItem.ToString());
            MessageBox.Show(comboBox1.Text);
        }



    }
}
