using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace DigraphLibrary
{
	/// <summary>
	/// Summary description for KeyboardCanvas.
	/// </summary>
	[Serializable()]
	public class KeyboardCanvas : System.Windows.Forms.UserControl
	{
		#region init and dispose
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public KeyboardCanvas()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call

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
			// KeyboardCanvas
			// 
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.Name = "KeyboardCanvas";
			this.Size = new System.Drawing.Size(656, 368);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.KeyboardCanvas_MouseUp);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.KeyboardCanvas_Paint);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KeyboardCanvas_MouseMove);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KeyboardCanvas_MouseDown);

		}
		#endregion

		#endregion
		

		public KeyboardCanvasData data = new KeyboardCanvasData();
		public ButtonMode KeyboardMode
		{
			get
			{
				return data.keyboardMode;
			}
			set
			{
				data.keyboardMode = value;
				foreach (KeyboardButton b in data.keyboardButtons)
				{
					b.Mode = value;
					this.Invalidate();
				}
			}
		}
		public bool addChar(char c)
		{
//			if (data.keyboardChars.Contains(c))
//				return false;
//			else
//			{
				data.keyboardChars.Add(c);
				KeyboardButton b = new KeyboardButton();
				b.InnerCircleRadius = 8.0f;
				b.Location = new PointF(0,0);
				b.Mode = data.keyboardMode;
				b.KeyboardChar = c;
				data.keyboardButtons.Add(b);
				this.Invalidate();
				return true;
//			}
		}

		public bool removeChar(char c)
		{
			if (!data.keyboardChars.Contains(c))
				return false;
			else
			{
				data.keyboardChars.Remove(c);
				foreach (KeyboardButton b in data.keyboardButtons)
				{
					if (b.KeyboardChar == c)
					{
						data.keyboardButtons.Remove(b);
						break;
					}
				}
				this.Invalidate();

				return true;
			}
		}

		private void KeyboardCanvas_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			foreach (KeyboardButton k in data.keyboardButtons)
			{
				k.Draw(g);
			}
		}

		KeyboardButton Dragging = null;
		
		private void KeyboardCanvas_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			foreach (KeyboardButton b in data.keyboardButtons)
			{
				Dragging = b.Get(e,new Point(MousePosition.X,MousePosition.Y));
				
				if (Dragging != null)
				{
					Dragging.SetValues(new Point(MousePosition.X,MousePosition.Y));
					break;
				}
			}
		}
		
		private void KeyboardCanvas_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (Dragging != null)
			{
				Dragging.Move(e,new Point(MousePosition.X,MousePosition.Y));
				this.Invalidate();
			}
		}

		private void KeyboardCanvas_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Dragging = null;
		}


		[System.Xml.Serialization.XmlInclude(typeof(KeyboardButton))]
		public class KeyboardCanvasData
		{
			public ArrayList keyboardChars = new ArrayList();
			public ButtonMode keyboardMode = ButtonMode.Rectangle;
			public ArrayList keyboardButtons = new ArrayList();
			public KeyboardButton[] GetKeyboardButton(char c)
			{
				ArrayList arr = new ArrayList();
				foreach (KeyboardButton btn in keyboardButtons)
				{
					if (btn.KeyboardChar == c)
					{
						arr.Add(btn);
					}
				}
				return (KeyboardButton[]) arr.ToArray(typeof (KeyboardButton));

			}
			public KeyboardCanvasData()
			{
			}
			public KeyboardCanvasData GetCopy()
			{
				KeyboardCanvasData k = new KeyboardCanvasData();
				ArrayList ktemp = new ArrayList();
				foreach (KeyboardButton key in keyboardButtons)
				{
					ktemp.Add(key.GetCopy());
				}
				k.keyboardButtons.AddRange(ktemp);
				k.keyboardChars.AddRange(this.keyboardChars);
				k.keyboardMode = this.keyboardMode;
				return k;
			}

		}
	}

}
