﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniPaint
{
    public partial class frmMain : Form
    {
        Graphics gCanvas;
        SolidBrush brush = new SolidBrush(Color.Green);
        public frmMain()
        {
            InitializeComponent();
            gCanvas = PictureBox.CreateGraphics();
        }

        private void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
