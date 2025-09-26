using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Digraphs
{
	/// <summary>
	/// Summary description for frmDigraphColoring.
	/// </summary>
	public class frmDigraphColoring : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox tbDigraph;
		private System.Windows.Forms.Button btnDigraph;
		private System.Windows.Forms.Button btnImage;
		private System.Windows.Forms.TextBox tbImage;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button btnColor;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmDigraphColoring()
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
			this.tbDigraph = new System.Windows.Forms.TextBox();
			this.btnDigraph = new System.Windows.Forms.Button();
			this.btnImage = new System.Windows.Forms.Button();
			this.tbImage = new System.Windows.Forms.TextBox();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.btnColor = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbDigraph
			// 
			this.tbDigraph.Location = new System.Drawing.Point(48, 32);
			this.tbDigraph.Name = "tbDigraph";
			this.tbDigraph.TabIndex = 0;
			this.tbDigraph.Text = "D:\\sp\\corpusout.txt";
			// 
			// btnDigraph
			// 
			this.btnDigraph.Location = new System.Drawing.Point(152, 32);
			this.btnDigraph.Name = "btnDigraph";
			this.btnDigraph.Size = new System.Drawing.Size(32, 23);
			this.btnDigraph.TabIndex = 1;
			this.btnDigraph.Text = "...";
			this.btnDigraph.Click += new System.EventHandler(this.btnDigraph_Click);
			// 
			// btnImage
			// 
			this.btnImage.Location = new System.Drawing.Point(152, 56);
			this.btnImage.Name = "btnImage";
			this.btnImage.Size = new System.Drawing.Size(32, 23);
			this.btnImage.TabIndex = 1;
			this.btnImage.Text = "...";
			this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
			// 
			// tbImage
			// 
			this.tbImage.Location = new System.Drawing.Point(48, 56);
			this.tbImage.Name = "tbImage";
			this.tbImage.TabIndex = 0;
			this.tbImage.Text = "D:\\sp\\corpus.bmp";
			// 
			// btnColor
			// 
			this.btnColor.Location = new System.Drawing.Point(112, 88);
			this.btnColor.Name = "btnColor";
			this.btnColor.TabIndex = 2;
			this.btnColor.Text = "Color!";
			this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
			// 
			// frmDigraphColoring
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 271);
			this.Controls.Add(this.btnColor);
			this.Controls.Add(this.btnDigraph);
			this.Controls.Add(this.tbDigraph);
			this.Controls.Add(this.btnImage);
			this.Controls.Add(this.tbImage);
			this.Name = "frmDigraphColoring";
			this.Text = "frmDigraphColoring";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnDigraph_Click(object sender, System.EventArgs e)
		{
			if (DialogResult.OK == openFileDialog1.ShowDialog())
			{
				tbDigraph.Text = openFileDialog1.FileName;
			}
		}

		private void btnImage_Click(object sender, System.EventArgs e)
		{
			if (DialogResult.OK == saveFileDialog1.ShowDialog())
			{
				tbImage.Text = saveFileDialog1.FileName;
			}
		}

		private void btnColor_Click(object sender, System.EventArgs e)
		{
			if (System.IO.File.Exists(tbDigraph.Text) && System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(tbImage.Text)))
			{
				DigraphLibrary.DigraphColoring dg = new DigraphLibrary.DigraphColoring();
				DigraphLibrary.Digraph d = new DigraphLibrary.Digraph();
				d.LoadFromTableFile(tbDigraph.Text);
				dg.Execute(d,tbImage.Text,new char[] {'a','b','c','ç','d','e','f','g','ð','h','ý','i','j','k','l','m','n','o','ö','p','r','s','þ','t','u','ü','v','y','z','q','w','x',' '});
			}
		}
	}
}
