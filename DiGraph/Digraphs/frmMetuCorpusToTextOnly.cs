using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Digraphs
{
	/// <summary>
	/// Summary description for frmMetuCorpusToTextOnly.
	/// </summary>
	public class frmMetuCorpusToTextOnly : System.Windows.Forms.Form
	{
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.TextBox tbInDir;
		private System.Windows.Forms.Button btnInDirBrowse;
		private System.Windows.Forms.TextBox tbOutFile;
		private System.Windows.Forms.Button btnOutFileBrowse;
		private System.Windows.Forms.Button btnGo;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmMetuCorpusToTextOnly()
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
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.tbInDir = new System.Windows.Forms.TextBox();
			this.btnInDirBrowse = new System.Windows.Forms.Button();
			this.tbOutFile = new System.Windows.Forms.TextBox();
			this.btnOutFileBrowse = new System.Windows.Forms.Button();
			this.btnGo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.FileName = "corpus.txt";
			this.saveFileDialog1.Filter = "Text Files|*.txt";
			// 
			// tbInDir
			// 
			this.tbInDir.Location = new System.Drawing.Point(72, 24);
			this.tbInDir.Name = "tbInDir";
			this.tbInDir.TabIndex = 0;
			this.tbInDir.Text = "";
			// 
			// btnInDirBrowse
			// 
			this.btnInDirBrowse.Location = new System.Drawing.Point(176, 24);
			this.btnInDirBrowse.Name = "btnInDirBrowse";
			this.btnInDirBrowse.TabIndex = 1;
			this.btnInDirBrowse.Text = "...";
			this.btnInDirBrowse.Click += new System.EventHandler(this.btnInDirBrowse_Click);
			// 
			// tbOutFile
			// 
			this.tbOutFile.Location = new System.Drawing.Point(72, 56);
			this.tbOutFile.Name = "tbOutFile";
			this.tbOutFile.TabIndex = 0;
			this.tbOutFile.Text = "";
			// 
			// btnOutFileBrowse
			// 
			this.btnOutFileBrowse.Location = new System.Drawing.Point(176, 56);
			this.btnOutFileBrowse.Name = "btnOutFileBrowse";
			this.btnOutFileBrowse.TabIndex = 1;
			this.btnOutFileBrowse.Text = "...";
			this.btnOutFileBrowse.Click += new System.EventHandler(this.btnOutFileBrowse_Click);
			// 
			// btnGo
			// 
			this.btnGo.Location = new System.Drawing.Point(176, 88);
			this.btnGo.Name = "btnGo";
			this.btnGo.TabIndex = 2;
			this.btnGo.Text = "Go";
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// frmMetuCorpusToTextOnly
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.Add(this.btnGo);
			this.Controls.Add(this.btnInDirBrowse);
			this.Controls.Add(this.tbInDir);
			this.Controls.Add(this.tbOutFile);
			this.Controls.Add(this.btnOutFileBrowse);
			this.Name = "frmMetuCorpusToTextOnly";
			this.Text = "frmMetuCorpusToTextOnly";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnGo_Click(object sender, System.EventArgs e)
		{
			if (System.IO.Directory.Exists(tbInDir.Text) && (System.IO.Directory.Exists (System.IO.Path.GetDirectoryName(tbOutFile.Text))))
			{
				CorpusParsers.MetuCorpusToTextOnly mctto = new CorpusParsers.MetuCorpusToTextOnly();
				mctto.Execute(tbInDir.Text,tbOutFile.Text);
			}
		}

		private void btnInDirBrowse_Click(object sender, System.EventArgs e)
		{
			if (DialogResult.OK == folderBrowserDialog1.ShowDialog())
			{
				tbInDir.Text = folderBrowserDialog1.SelectedPath;
			}
		}

		private void btnOutFileBrowse_Click(object sender, System.EventArgs e)
		{
			if (DialogResult.OK == saveFileDialog1.ShowDialog())
			{
				tbOutFile.Text = saveFileDialog1.FileName;
			}
		}
	}
}
