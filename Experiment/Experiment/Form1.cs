using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Experiment
{
    public partial class Form1 : Form
    {
        Random rand;
        public Form1()
        {
            InitializeComponent();
            rand = new Random();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;

            if (!int.TryParse(textBox1.Text, out a))
            {
                MessageBox.Show("---------");
                return;
            }

            if (!int.TryParse(textBox2.Text, out b))
            {
                MessageBox.Show("---------");
                return;
            }

            if (!int.TryParse(textBox3.Text, out c))
            {
                MessageBox.Show("---------");
                return;
            }

            Point[] p = new Point[a + 1];

            int count = 0;
            while(true)
            {
                int i = rand.Next(1, 102);
                int j = rand.Next(0, 2);

                if(p[i-1].Direction == 0 && p[i].Direction == 0 && p[i + 1].Direction == 0)
                {
                    p[i].Direction = j;
                    if (++count == b) break;
                }
            }

            print(p);

            for (int i = 0; i < c; i++)
            {
                while(!WeyIsEmty(p))
                {
                    p[0].Direction = p[p.Length - 1].Direction = 0;

                    for (int j = 1; j < p.Length - 1; j++)
                    {
                        if (p[i].Direction == 1 && p[i+1].Direction == -1)
                        {
                            p[i].Direction = 0;
                            p[i+1].Direction = 0;

                            p[i - 1].Direction = -1;
                            p[i + 1].Direction = 1;

                        }


      
                    }
                }
            }






        }

        private bool WeyIsEmty(Point[] p)
        {
            for (int i = 1; i < p.Length; i++)
            {
                if (p[i].Direction != 0)
                    return false;
            }
            return true;
        }

         void print(Point[] p)
        {
            for (int i = 1; i < p.Length; i++)
                Console.WriteLine(p[i].Direction);
        }
    }
}
