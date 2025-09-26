using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
namespace DigraphLibrary
{
	/// <summary>
	/// Summary description for KeyboardButton.
	/// </summary>
	public class KeyboardButton
	{
		public KeyboardButton()
		{
			font = new Font(FontFamily.GenericSansSerif,8);
		}

		public float InnerCircleRadius = 0.0f;
		/// <summary>
		/// Center of the inner circle.
		/// </summary>
		public PointF Location = new Point(0,0);
		public ButtonMode Mode = ButtonMode.Rectangle;
		public char KeyboardChar;

		private Pen bpen= Pens.Black;
		private Brush bbrush= Brushes.Black;
		private Pen wpen= Pens.White;
		private Brush wbrush= Brushes.White;
		private Font font;
		
		private int mX,mY;//mouse old position
		private float fX,fY;//location 
		private float icR;//inner circle radius (used for resizing.

		public KeyboardButton Get(System.Windows.Forms.MouseEventArgs e, Point MousePosition)
		{
			// bound the point with the square that bounds the inner circle.
			if ((e.X > this.Location.X - InnerCircleRadius) && (e.X < this.Location.X + InnerCircleRadius) 
				&& (e.Y > this.Location.Y - InnerCircleRadius) && (e.Y < this.Location.Y + InnerCircleRadius))
			{
				return this;
			}
			else return null;
		}
		public void Move(System.Windows.Forms.MouseEventArgs e, Point MousePosition)
		{
			if (e.Button == MouseButtons.Middle)
			{
				icR = icR + (float)Math.Sqrt((MousePosition.X - mX) * (MousePosition.X - mX) + (MousePosition.Y - mY) * (MousePosition.Y - mY));

				InnerCircleRadius = icR - (icR % 8);

				mX = MousePosition.X;
				mY = MousePosition.Y;
			} 
			else if (e.Button == MouseButtons.Right)
			{
				fX = fX + (MousePosition.X - mX);
				fY = fY + (MousePosition.Y - mY);
				if (this.Mode == ButtonMode.Rectangle)
				{
					this.Location = new PointF(fX-(fX%8),fY-(float)(fY%(8.0f)));
				}
				else
				{
					this.Location = new PointF(fX-(fX%8),fY-(float)(fY%(8.0f*Math.Sqrt(3))));
				}
//				if ((fY % 8) < (fY % (8.0f * Math.Sqrt(3))))
//					
//				else
					

				mX = MousePosition.X;
				mY = MousePosition.Y;
			}
			else
			{
				System.Diagnostics.Debug.WriteLine(e.X.ToString() + "," + e.Y.ToString());
			}
		}

		public void SetValues(Point MousePosition)
		{
			fX = (int)this.Location.X;
			fY = (int)this.Location.Y;
			mX = MousePosition.X;
			mY = MousePosition.Y;
			icR = InnerCircleRadius;
		}
		public void Draw (Graphics g)
		{
			if (Mode == ButtonMode.Rectangle)
			{
				g.FillRectangle(wbrush,Location.X-InnerCircleRadius,Location.Y-InnerCircleRadius,InnerCircleRadius*2,InnerCircleRadius*2);
				g.DrawRectangle(bpen,Location.X-InnerCircleRadius,Location.Y-InnerCircleRadius,InnerCircleRadius*2,InnerCircleRadius*2);

				g.DrawString(KeyboardChar.ToString(),font,bbrush,new RectangleF(new PointF(Location.X - 3.0f * InnerCircleRadius/4.0f,Location.Y - 3.0f * InnerCircleRadius/4.0f), new SizeF (3.0f * InnerCircleRadius/2.0f,3.0f * InnerCircleRadius/2.0f)));

			}
			else if (Mode == ButtonMode.Hexagon)
			{
				PointF[] p = new PointF[6];
				float f = (float)InnerCircleRadius / (float)Math.Sqrt(3.0);
				float sqrt3 = (float)Math.Sqrt(3);

				p[0] = new PointF(Location.X, Location.Y + 2.0f * f);
				p[1] = new PointF(Location.X + InnerCircleRadius,Location.Y + f);
				p[2] = new PointF(Location.X + InnerCircleRadius,Location.Y - f);
				p[3] = new PointF(Location.X, Location.Y - 2.0f * f );
				p[4] = new PointF(Location.X - InnerCircleRadius,Location.Y - f);
				p[5] = new PointF(Location.X - InnerCircleRadius,Location.Y + f);

				g.FillPolygon(wbrush,p);
				g.DrawPolygon(bpen,p);

				g.DrawString(KeyboardChar.ToString(),font,bbrush,new RectangleF(new PointF(Location.X - 3.0f * InnerCircleRadius/4.0f,Location.Y - 3.0f * InnerCircleRadius/4.0f), new SizeF (3.0f * InnerCircleRadius/2.0f,3.0f * InnerCircleRadius/2.0f)));
			}
			else if (Mode == ButtonMode.Circle)
			{
				g.FillEllipse(wbrush,Location.X - InnerCircleRadius,Location.Y - InnerCircleRadius,InnerCircleRadius * 2,InnerCircleRadius * 2);
				g.DrawEllipse(bpen,Location.X - InnerCircleRadius,Location.Y - InnerCircleRadius,InnerCircleRadius * 2,InnerCircleRadius * 2);

				g.DrawString(KeyboardChar.ToString(),font,bbrush,new RectangleF(new PointF(Location.X - 3.0f * InnerCircleRadius/4.0f,Location.Y - 3.0f * InnerCircleRadius/4.0f), new SizeF (3.0f * InnerCircleRadius/2.0f,3.0f * InnerCircleRadius/2.0f)));

			}

		}
		public KeyboardButton GetCopy()
		{

			KeyboardButton b = new KeyboardButton();
			b.Location = new PointF(this.Location.X,this.Location.Y);
			b.KeyboardChar = this.KeyboardChar;
			b.Mode = this.Mode;
			b.InnerCircleRadius = this.InnerCircleRadius;
			return b;
		}
	}
}
