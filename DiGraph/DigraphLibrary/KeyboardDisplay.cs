using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace DigraphLibrary
{
	/// <summary>
	/// Summary description for KeyboardDisplay.
	/// </summary>
	public class KeyboardDisplay : System.Windows.Forms.UserControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public KeyboardDisplay()
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
			// KeyboardDisplay
			// 
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.Name = "KeyboardDisplay";
			this.Size = new System.Drawing.Size(448, 248);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.KeyboardDisplay_Paint);

		}
		#endregion
		public void Display(KeyboardCanvas.KeyboardCanvasData data)
		{
			this.data = data;
			this.Invalidate();
		}
		KeyboardCanvas.KeyboardCanvasData data = null;

		private void KeyboardDisplay_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			if (data != null)
				for (int i = 0; i < data.keyboardButtons.Count; i++)				{
					((KeyboardButton)data.keyboardButtons[i]).Draw(g);
				}
		}
    }
}
