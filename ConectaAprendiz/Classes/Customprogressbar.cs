using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ConectaAprendiz.Classes
{
    public class Customprogressbar : ProgressBar
    {
        public Customprogressbar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rect = this.ClientRectangle;
            Graphics g = e.Graphics;

            ProgressBarRenderer.DrawHorizontalBar(g, rect);
            rect.Inflate(-3, -3);

            if (this.Value > 0)
            {
                Rectangle clip = new Rectangle(rect.X, rect.Y,
                    (int)Math.Round(((double)this.Value / this.Maximum) * rect.Width), rect.Height);
                g.FillRectangle(new SolidBrush(Color.Blue), clip);
            }

        }
    }
}
