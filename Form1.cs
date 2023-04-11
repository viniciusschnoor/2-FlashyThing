using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_FlashyThing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (Visible)
            {
                for (int c = 0; c < 254 && Visible; c++)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(3);
                }
                for (int c = 254; c >= 0 && Visible; c--)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(3);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 0;
            String Poem = "";

            while (x < 4)
            {
                Poem += "a";
                if (x < 1)
                {
                    Poem += " ";
                }
                Poem += "n";
                if (x > 1)
                {
                    Poem += Poem + " oyster";
                    x += 2;
                }
                if (x == 1)
                {
                    Poem += "noys ";
                }
                if (x < 1)
                {
                    Poem += "oise ";
                }
                x++;
            }
            MessageBox.Show(Poem);
        }
    }
}
