﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace miniPaint
{
    class CBezier : CTwoDFigure
    {
        public CBezier(Color color, Point[] points, Graphics canv) : base(color, points, canv)
        {
            Draw();
        }
        public override double getPerimeter()
        {
            int deltX = Math.Abs(coordinates[0].X - coordinates[1].X);
            int deltY = Math.Abs(coordinates[0].Y - coordinates[1].Y);
            return Math.Sqrt(deltX * deltX + deltY * deltY);
        }

        public override void Draw()
        {
            gCanvas.DrawBezier(new Pen(brush, 3), coordinates[0], coordinates[2], coordinates[3], coordinates[1]);
        }
    }
}
