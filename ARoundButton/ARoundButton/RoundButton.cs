using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace ARoundButton
{
    class RoundButton:Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            this.Size = new Size(50, 50);
            System.Drawing.Drawing2D.GraphicsPath aCircle = new System.Drawing.Drawing2D.GraphicsPath();
            aCircle.AddEllipse(new System.Drawing.RectangleF(0, 0, 50, 50));
            this.Region = new Region(aCircle);
        }
    }
}
