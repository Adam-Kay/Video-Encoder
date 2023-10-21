using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Video_Encoder__NET_Core_Version_.CustomControls {

    public class ColoredProgressBar : ProgressBar {

        /// <summary>
        /// Allows to change the color of the progress bar rect. Code referenced from: https://stackoverflow.com/a/7490884/8233240
        /// </summary>

        public ColoredProgressBar() {
            this.SetStyle(ControlStyles.UserPaint, true); /// Sets style to user made so there is no interference
        }

        protected override void OnPaintBackground(PaintEventArgs pevent) {
            /// Helps control the flicker.
        }

        protected override void OnPaint(PaintEventArgs e) {
            const int inset = 2; /// A single value to control the sizing of the inner rect for a border.

            using (Image offscreenImage = new Bitmap(this.Width, this.Height)) {
                using (Graphics offscreen = Graphics.FromImage(offscreenImage)) {
                    Rectangle rect = new(0, 0, this.Width, this.Height);

                    if (ProgressBarRenderer.IsSupported) { ProgressBarRenderer.DrawHorizontalBar(offscreen, rect); }

                    rect.Inflate(new Size(-inset, -inset)); /// Deflate inner rect.
                    rect.Width = (int)(rect.Width * ((double)this.Value / this.Maximum));
                    if (rect.Width == 0) { rect.Width = 1; } /// Can't draw rect with width of 0.

                    SolidBrush brush = new(this.ForeColor);
                    offscreen.FillRectangle(brush, inset, inset, rect.Width, rect.Height);

                    e.Graphics.DrawImage(offscreenImage, 0, 0);
                }
            }
        }


    }
}
