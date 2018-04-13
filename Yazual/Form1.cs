using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazual
{
    
    public partial class Form1 : Form
    {
        int S;
        int k;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          if(textBox1.Text!=String.Empty && textBox2.Text != String.Empty)
            {
                S = Convert.ToInt32(textBox1.Text);
                k = Convert.ToInt32(textBox2.Text);

                // this.ShowInTaskbar = false;
                //this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
                this.Visible = false;
                Form2 f = new Form2(this.S, this.k);
                f.ShowDialog();
            } else { MessageBox.Show("Empty one or two boxes. Please, type something...","Error"); }
            
         
        }
    }
}
