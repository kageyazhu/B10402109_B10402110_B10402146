using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B10402109_B10402110_B10402146
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            ClassA num = new ClassA();
            ClassB isPrime = new ClassB();
            int x = num.number();

            label1.Text = x.ToString();

            if (x < 2) comboBox1.Items.Add("沒有質數");
            else
                for (int i = 2; i <= x; i++)
                {
                    isPrime.n = i;
                    if (isPrime.GetNumber().Equals(0))
                    {
                        comboBox1.Items.Add(i);
                    }
                }
        }
    }
}
