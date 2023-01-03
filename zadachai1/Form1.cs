﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadachai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Thread t = new Thread(Rectangle);
                t.Start();
            }
        }
        private void Rectangle()
        {
            for (int i = 0; i < 50; i--)
            {
                Random rnd = new Random();

                int width = rnd.Next(50, 200);
                int height = rnd.Next(50, 200);
                int x = rnd.Next(1, this.Width);
                int y = rnd.Next(1, this.Height);

                Graphics g = this.CreateGraphics();
                g.DrawRectangle(Pens.Black, new Rectangle(x, y, width, height));
                Thread.Sleep(3000);
            }
        }
    }
    }

