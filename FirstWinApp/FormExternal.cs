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
    public partial class FormExternal : Form
    {
        public FormExternal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///this.
                Close();
        }

        private void FormExternal_Load(object sender, EventArgs e)
        {
            //Setapowanie 
            SetUp();
        }
        internal void SetUp()
        {
            trackBar1.Value = 80;
        }
    }
}
