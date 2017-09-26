using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Client.Custom
{
    /// <summary>
    /// Radius border
    /// </summary>
    public partial class RadiusBorder : Control
    {
        public Color FontColor { get; set; }
        public Color BorderColor { get; set; }
        public float Radius { get; set; }
        public float BorderSize { get; set; }

        /// <summary>
        /// Set the control background transparent
        /// </summary>
        public RadiusBorder()
        {
            SetStyle(System.Windows.Forms.ControlStyles.Opaque, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.UpdateStyles();
            base.CreateControl();
            this.Radius = 3.0f;
        }

        /// <summary>
        /// Enable controls to be transparent
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020;

                return cp;
            }
        }

        /// <summary>
        /// OnText changed
        /// </summary>
        /// <param name="e"></param>
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.Invalidate();
        }

        /// <summary>
        /// Paint self
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Graphics graphics = pevent.Graphics;

            Rectangle actualArea = new Rectangle(
                                                 this.DisplayRectangle.X,
                                                 this.DisplayRectangle.Y,
                                                 this.DisplayRectangle.Width - 1,
                                                 this.DisplayRectangle.Height - 1
                                                 );

            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            GraphicsPath path = CreateBorderPath(actualArea, this.Radius, this.BorderSize);

            //Draw border
            if (this.BorderSize > 0)
            {
                graphics.DrawPath(new Pen(this.BorderColor, this.BorderSize), path);
            }

            //Draw background
            graphics.FillPath(new SolidBrush(this.BackColor), path);

            //Draw text
            Rectangle textArea = new Rectangle(actualArea.X, actualArea.Y, actualArea.Width, (int)(actualArea.Height * 0.9));
            TextRenderer.DrawText(graphics, Text, this.Font, textArea, ForeColor);
        }

        /// <summary>
        /// Graphics the box style
        /// </summary>
        /// <param name="rectangle"></param>
        /// <param name="radius"></param>
        /// <param name="width"></param>
        /// <returns></returns>
        public GraphicsPath CreateBorderPath(RectangleF rectangle, float radius, float width)
        {
            int halfWidth = (int)(width / 2);
            float actualRadius = radius - halfWidth;

            GraphicsPath graphics = new GraphicsPath();

            graphics.AddLine(
                new PointF(rectangle.X + radius / 2, rectangle.Y + halfWidth),
                new PointF(rectangle.Right - radius, rectangle.Y + halfWidth)
            );

            graphics.AddArc(
                new RectangleF(rectangle.Right - radius, rectangle.Y + halfWidth, actualRadius, actualRadius),
                270F,
                90F
            );

            graphics.AddLine(
                new PointF(rectangle.Right - halfWidth, rectangle.Y + radius),
                new PointF(rectangle.Right - halfWidth, rectangle.Bottom - radius)
            );

            graphics.AddArc(
                new RectangleF(rectangle.Right - radius, rectangle.Bottom - radius, actualRadius, actualRadius),
                0F,
                90F
            );

            graphics.AddLine(
                new PointF(rectangle.Right - radius, rectangle.Bottom - halfWidth),
                new PointF(rectangle.X + radius, rectangle.Bottom - halfWidth)
            );

            graphics.AddArc(
                new RectangleF(rectangle.X + halfWidth, rectangle.Bottom - radius, actualRadius, actualRadius),
                90F,
                90F
            );

            graphics.AddLine(
                new PointF(rectangle.X + halfWidth, rectangle.Bottom - radius),
                new PointF(rectangle.X + halfWidth, rectangle.Y + radius)
            );

            graphics.AddArc(
                new RectangleF(rectangle.X + halfWidth, rectangle.Y, actualRadius, actualRadius),
                180F,
                90F
            );

            return graphics;
        }
    }
}