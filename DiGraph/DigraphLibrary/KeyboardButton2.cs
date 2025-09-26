using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace DigraphLibrary
{
	/// <summary>
	/// Summary description for KeyboardButton.
	/// </summary>
	public class KeyboardButton2 : System.Windows.Forms.UserControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public KeyboardButton2()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();


		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			// 
			// KeyboardButton
			// 
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Name = "KeyboardButton";
			this.Size = new System.Drawing.Size(20, 20);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.KeyboardButton_Paint);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KeyboardButton_MouseMove);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KeyboardButton_MouseDown);

		}
		#endregion
		private Font font = new Font("Tahoma",8);
		private void KeyboardButton_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			if (Mode == ButtonMode.Rectangle)
			{
				g.FillRectangle(wbrush,0,0,this.Size.Width-1,this.Size.Height-1);
				g.DrawRectangle(bpen,0,0,this.Size.Width-1,this.Size.Height-1);

				g.DrawString(KeyboardChar.ToString(),font,bbrush,new RectangleF(new PointF(((float)this.Width)/8,((float)this.Height)/8), new SizeF (3.0f * ((float)this.Size.Width) / 4.0f,3.0f * ((float)this.Size.Height) / 4.0f)));

			}
			else if (Mode == ButtonMode.Hexagon)
			{
				PointF[] p = new PointF[6];
				float f = this.Width;
				float sqrt3 = (float)Math.Sqrt(3);
				f = f / sqrt3;
				float widthOver4 = (float)this.Size.Width / 4.0f;
				float heightOver4 = (float)this.Size.Width /4.0f;

				p[0] = new PointF(widthOver4 * 2.0f ,0);
				p[1] = new PointF(2.0f * widthOver4 + widthOver4 * sqrt3,heightOver4);
				p[2] = new PointF(2.0f * widthOver4 + widthOver4 * sqrt3, 3.0f * heightOver4);
				p[3] = new PointF(widthOver4 * 2.0f, heightOver4 * 4.0f);
				p[4] = new PointF(widthOver4 - sqrt3, heightOver4* 3.0f);
				p[5] = new PointF(widthOver4 - sqrt3, heightOver4);

				g.FillPolygon(wbrush,p);
				g.DrawPolygon(bpen,p);

				g.DrawString(KeyboardChar.ToString(),font,bbrush,new RectangleF(new PointF(0, ((float)this.Size.Height) / 4.0f),new SizeF(2*f,this.Height/2)));
			}
			else if (Mode == ButtonMode.Circle)
			{
				g.FillEllipse(wbrush,0,0,this.Width,this.Height);
				g.DrawEllipse(bpen,0,0,this.Width,this.Height);

				g.DrawString(KeyboardChar.ToString(),font,bbrush,new RectangleF(new PointF(((float)this.Width)/8,((float)this.Height)/8), new SizeF (3.0f * ((float)this.Size.Width) / 4.0f,3.0f * ((float)this.Size.Height) / 4.0f)));

			}

		}
		private Pen bpen= Pens.Black;
		private Brush bbrush= Brushes.Black;
		private Pen wpen= Pens.White;
		private Brush wbrush= Brushes.White;
//		private Font font;
		public ButtonMode Mode = ButtonMode.Rectangle;
		public char KeyboardChar;

		private void KeyboardButton_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Middle)
			{
				sX = sX + (MousePosition.X - mX);
				sY = sY + (MousePosition.Y - mY);
				this.Size = new Size(sX - (sX % 4), sY - (sY % 4));
				mX = MousePosition.X;
				mY = MousePosition.Y;
			} 
			else if (e.Button == MouseButtons.Right)
			{
				fX = fX + (MousePosition.X - mX);
				fY = fY + (MousePosition.Y - mY);

				this.Location = new Point(fX-(fX%4),fY-(fY%4));

				mX = MousePosition.X;
				mY = MousePosition.Y;
			}
			else
			{
				System.Diagnostics.Debug.WriteLine(e.X.ToString() + "," + e.Y.ToString());
			}
			this.Invalidate();
		}

		private void KeyboardButton_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			fX = this.Location.X;
			fY = this.Location.Y;
			mX = MousePosition.X;
			mY = MousePosition.Y;
			sX = this.Size.Width;
			sY = this.Size.Height;
		}

		int mX,mY;//mouse old position
		int fX,fY;//location 
		int sX,sY;//size


	


	}
	public enum ButtonMode
	{
		Rectangle, Hexagon, Circle
	}
}
