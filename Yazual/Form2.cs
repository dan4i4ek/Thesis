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
    public partial class Form2 : Form
    {
        int S, k;  
        public Form2(int S, int k)
        {
            InitializeComponent();
            this.S = S;
            this.k = k;
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
           for (int i = 0; i < k; i++)
            {
                this.Controls.Add(new TextBox() { Name = i.ToString(), Location = new Point(152 + i * 150, 3), Text = "" });
                for(int j = 0; j < S; j++)
                {
                    this.Controls.Add(new TextBox() { Name = i.ToString(), Location = new Point(2, 40 + j * 40), Text = "" });
                    this.Controls.Add(new TextBox() { Name = i.ToString(), Location = new Point(152 + i * 150, 40 + j * 40), Text = "" });
                }
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
