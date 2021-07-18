using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWinApp
{
    public partial class FormMain : Form
    {
        
        public FormMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //string s = string.Format("Wprowadziałeś: {0}", tbFirstName.Text);
            //MessageBox.Show(s);
            mmuFile.Enabled = !mmuFile.Enabled;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            button11.Click += Button11_Click;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world!");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
           DialogResult result =  ofdFile.ShowDialog();
            if (result == DialogResult.OK)
                MessageBox.Show(ofdFile.FileName);

        }

        FormExternal form = null;
        private void button3_Click(object sender, EventArgs e)
        {
            if (form != null)
            {
                form.Focus();
                return;
            }
            
            
             form = new FormExternal();
            form.FormClosed += Form_FormClosed;
             form.Show();
            
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            form = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (form != null)
            {
                form.Close();
                form = null;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A");

        }
        private void ShowCharacter_Click(object sender, EventArgs e)
        {
            //Button btn = (Button)sender;  // w razie problemów będzie wyjątek
            Button btn = sender as Button; //jak coś będzie nie tak to dostaniemy NULL
            //string s = (Button)sender.Tag.ToString();
            if (btn != null)
                //MessageBox.Show(s);
                MessageBox.Show(btn.Tag.ToString());
        }

     
    }
}
