using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Digraphs
{
	/// <summary>
	/// Summary description for KeyboardDesignerFront.
	/// </summary>
	public class KeyboardDesignerFront : System.Windows.Forms.Form
	{
		private DigraphLibrary.KeyboardLayout keyboardLayout1;
		private System.Windows.Forms.PictureBox pictureBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public KeyboardDesignerFront()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(KeyboardDesignerFront));
			this.keyboardLayout1 = new DigraphLibrary.KeyboardLayout();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// keyboardLayout1
			// 
			this.keyboardLayout1.DockPadding.All = 5;
			this.keyboardLayout1.Location = new System.Drawing.Point(8, 88);
			this.keyboardLayout1.Name = "keyboardLayout1";
			this.keyboardLayout1.Size = new System.Drawing.Size(792, 256);
			this.keyboardLayout1.TabIndex = 0;
			this.keyboardLayout1.Load += new System.EventHandler(this.keyboardLayout1_Load);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(8, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(168, 72);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// KeyboardDesignerFront
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(808, 499);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.keyboardLayout1);
			this.Name = "KeyboardDesignerFront";
			this.Text = "Keyboard Designer";
			this.ResumeLayout(false);

		}
		#endregion

		private void keyboardLayout1_Load(object sender, System.EventArgs e)
		{
			ArrayList Chars = new ArrayList();
			Chars.Add('a');
			Chars.Add('b');
			Chars.Add('c');
			Chars.Add('ç');
			Chars.Add('d');
			Chars.Add('e');
			Chars.Add('f');
			Chars.Add('g');
			Chars.Add('ð');
			Chars.Add('h');
			Chars.Add('ý');
			Chars.Add('i');
			Chars.Add('j');
			Chars.Add('k');
			Chars.Add('l');
			Chars.Add('m');
			Chars.Add('n');
			Chars.Add('o');
			Chars.Add('ö');
			Chars.Add('p');
			Chars.Add('r');
			Chars.Add('s');
			Chars.Add('þ');
			Chars.Add('t');
			Chars.Add('u');
			Chars.Add('ü');
			Chars.Add('v');
			Chars.Add('y');
			Chars.Add('z');
			Chars.Add('q');
			Chars.Add('w');
			Chars.Add('x');

			keyboardLayout1.CharList = Chars;
		}
	}
}
