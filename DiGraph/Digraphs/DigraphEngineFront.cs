using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Digraphs
{
	/// <summary>
	/// Summary description for DigraphEngineFront.
	/// </summary>
	public class DigraphEngineFront : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox outFileName;
		private System.Windows.Forms.Button btnChooseOutputFile;
		private System.Windows.Forms.Button btnChooseInFileName;
		private System.Windows.Forms.TextBox inFileName;
		private System.Windows.Forms.CheckBox chUseOutput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox chCaseSensitive;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ListBox lstModelledChars;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox chLetter;
		private System.Windows.Forms.CheckBox chControl;
		private System.Windows.Forms.CheckBox chPunctuation;
		private System.Windows.Forms.CheckBox chSeperators;
		private System.Windows.Forms.CheckBox chDigit09;
		private System.Windows.Forms.CheckBox chWhiteSpace;
		private System.Windows.Forms.CheckBox chSymbol;
		private System.Windows.Forms.Button btnRun;
		private System.Windows.Forms.CheckBox chEverything;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.PictureBox pictureBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public DigraphEngineFront()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(DigraphEngineFront));
			this.outFileName = new System.Windows.Forms.TextBox();
			this.btnChooseOutputFile = new System.Windows.Forms.Button();
			this.btnChooseInFileName = new System.Windows.Forms.Button();
			this.inFileName = new System.Windows.Forms.TextBox();
			this.chUseOutput = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.chCaseSensitive = new System.Windows.Forms.CheckBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.chEverything = new System.Windows.Forms.CheckBox();
			this.chSymbol = new System.Windows.Forms.CheckBox();
			this.chWhiteSpace = new System.Windows.Forms.CheckBox();
			this.chSeperators = new System.Windows.Forms.CheckBox();
			this.chLetter = new System.Windows.Forms.CheckBox();
			this.chDigit09 = new System.Windows.Forms.CheckBox();
			this.chControl = new System.Windows.Forms.CheckBox();
			this.chPunctuation = new System.Windows.Forms.CheckBox();
			this.lstModelledChars = new System.Windows.Forms.ListBox();
			this.btnRun = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// outFileName
			// 
			this.outFileName.Location = new System.Drawing.Point(72, 40);
			this.outFileName.Name = "outFileName";
			this.outFileName.TabIndex = 2;
			this.outFileName.Text = "";
			// 
			// btnChooseOutputFile
			// 
			this.btnChooseOutputFile.Location = new System.Drawing.Point(176, 40);
			this.btnChooseOutputFile.Name = "btnChooseOutputFile";
			this.btnChooseOutputFile.Size = new System.Drawing.Size(24, 20);
			this.btnChooseOutputFile.TabIndex = 3;
			this.btnChooseOutputFile.Text = "...";
			this.btnChooseOutputFile.Click += new System.EventHandler(this.btnChooseOutputFile_Click);
			// 
			// btnChooseInFileName
			// 
			this.btnChooseInFileName.Location = new System.Drawing.Point(176, 16);
			this.btnChooseInFileName.Name = "btnChooseInFileName";
			this.btnChooseInFileName.Size = new System.Drawing.Size(24, 20);
			this.btnChooseInFileName.TabIndex = 1;
			this.btnChooseInFileName.Text = "...";
			this.btnChooseInFileName.Click += new System.EventHandler(this.btnChooseInFileName_Click);
			// 
			// inFileName
			// 
			this.inFileName.Location = new System.Drawing.Point(72, 16);
			this.inFileName.Name = "inFileName";
			this.inFileName.TabIndex = 0;
			this.inFileName.Text = "";
			// 
			// chUseOutput
			// 
			this.chUseOutput.Location = new System.Drawing.Point(72, 64);
			this.chUseOutput.Name = "chUseOutput";
			this.chUseOutput.Size = new System.Drawing.Size(96, 24);
			this.chUseOutput.TabIndex = 2;
			this.chUseOutput.Text = "Write output";
			this.chUseOutput.CheckedChanged += new System.EventHandler(this.chUseOutput_CheckedChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Output:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Input:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.outFileName);
			this.groupBox1.Controls.Add(this.btnChooseOutputFile);
			this.groupBox1.Controls.Add(this.btnChooseInFileName);
			this.groupBox1.Controls.Add(this.inFileName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.chUseOutput);
			this.groupBox1.Location = new System.Drawing.Point(8, 88);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(216, 96);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Select Input and Output";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.checkBox2);
			this.groupBox2.Controls.Add(this.chCaseSensitive);
			this.groupBox2.Location = new System.Drawing.Point(8, 192);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(216, 72);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Options";
			// 
			// checkBox2
			// 
			this.checkBox2.Enabled = false;
			this.checkBox2.Location = new System.Drawing.Point(8, 40);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(152, 24);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Model <Shift> Key";
			// 
			// chCaseSensitive
			// 
			this.chCaseSensitive.Location = new System.Drawing.Point(8, 16);
			this.chCaseSensitive.Name = "chCaseSensitive";
			this.chCaseSensitive.Size = new System.Drawing.Size(200, 24);
			this.chCaseSensitive.TabIndex = 0;
			this.chCaseSensitive.Text = "Case Sensitive (not recommended)";
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.panel1);
			this.groupBox3.Controls.Add(this.lstModelledChars);
			this.groupBox3.Location = new System.Drawing.Point(232, 16);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(256, 248);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "What to Model";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.chEverything);
			this.panel1.Controls.Add(this.chSymbol);
			this.panel1.Controls.Add(this.chWhiteSpace);
			this.panel1.Controls.Add(this.chSeperators);
			this.panel1.Controls.Add(this.chLetter);
			this.panel1.Controls.Add(this.chDigit09);
			this.panel1.Controls.Add(this.chControl);
			this.panel1.Controls.Add(this.chPunctuation);
			this.panel1.Location = new System.Drawing.Point(8, 16);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(120, 224);
			this.panel1.TabIndex = 1;
			// 
			// chEverything
			// 
			this.chEverything.Checked = true;
			this.chEverything.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chEverything.Location = new System.Drawing.Point(8, 8);
			this.chEverything.Name = "chEverything";
			this.chEverything.TabIndex = 0;
			this.chEverything.Tag = "E";
			this.chEverything.Text = "Everything";
			this.chEverything.CheckedChanged += new System.EventHandler(this.ch_CheckedChanged);
			// 
			// chSymbol
			// 
			this.chSymbol.Location = new System.Drawing.Point(8, 152);
			this.chSymbol.Name = "chSymbol";
			this.chSymbol.TabIndex = 6;
			this.chSymbol.Tag = "Sym";
			this.chSymbol.Text = "Symbols";
			this.chSymbol.CheckedChanged += new System.EventHandler(this.ch_CheckedChanged);
			// 
			// chWhiteSpace
			// 
			this.chWhiteSpace.Location = new System.Drawing.Point(8, 176);
			this.chWhiteSpace.Name = "chWhiteSpace";
			this.chWhiteSpace.TabIndex = 7;
			this.chWhiteSpace.Tag = "W";
			this.chWhiteSpace.Text = "White Space";
			this.chWhiteSpace.CheckedChanged += new System.EventHandler(this.ch_CheckedChanged);
			// 
			// chSeperators
			// 
			this.chSeperators.Location = new System.Drawing.Point(8, 128);
			this.chSeperators.Name = "chSeperators";
			this.chSeperators.TabIndex = 5;
			this.chSeperators.Tag = "Sep";
			this.chSeperators.Text = "Seperators";
			this.chSeperators.CheckedChanged += new System.EventHandler(this.ch_CheckedChanged);
			// 
			// chLetter
			// 
			this.chLetter.Location = new System.Drawing.Point(8, 32);
			this.chLetter.Name = "chLetter";
			this.chLetter.TabIndex = 1;
			this.chLetter.Tag = "L";
			this.chLetter.Text = "Letters a-z";
			this.chLetter.CheckedChanged += new System.EventHandler(this.ch_CheckedChanged);
			// 
			// chDigit09
			// 
			this.chDigit09.Location = new System.Drawing.Point(8, 56);
			this.chDigit09.Name = "chDigit09";
			this.chDigit09.TabIndex = 2;
			this.chDigit09.Tag = "D";
			this.chDigit09.Text = "Digits 0-9";
			this.chDigit09.CheckedChanged += new System.EventHandler(this.ch_CheckedChanged);
			// 
			// chControl
			// 
			this.chControl.Location = new System.Drawing.Point(8, 80);
			this.chControl.Name = "chControl";
			this.chControl.TabIndex = 3;
			this.chControl.Tag = "C";
			this.chControl.Text = "Control Chars";
			this.chControl.CheckedChanged += new System.EventHandler(this.ch_CheckedChanged);
			// 
			// chPunctuation
			// 
			this.chPunctuation.Location = new System.Drawing.Point(8, 104);
			this.chPunctuation.Name = "chPunctuation";
			this.chPunctuation.TabIndex = 4;
			this.chPunctuation.Tag = "P";
			this.chPunctuation.Text = "Punctuations";
			this.chPunctuation.CheckedChanged += new System.EventHandler(this.ch_CheckedChanged);
			// 
			// lstModelledChars
			// 
			this.lstModelledChars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lstModelledChars.Location = new System.Drawing.Point(136, 16);
			this.lstModelledChars.MultiColumn = true;
			this.lstModelledChars.Name = "lstModelledChars";
			this.lstModelledChars.Size = new System.Drawing.Size(112, 212);
			this.lstModelledChars.TabIndex = 0;
			// 
			// btnRun
			// 
			this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnRun.BackColor = System.Drawing.SystemColors.Control;
			this.btnRun.Location = new System.Drawing.Point(400, 272);
			this.btnRun.Name = "btnRun";
			this.btnRun.Size = new System.Drawing.Size(80, 24);
			this.btnRun.TabIndex = 3;
			this.btnRun.Text = "Execute";
			this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "txt";
			this.saveFileDialog1.FileName = "out";
			this.saveFileDialog1.Filter = "Txt Files|*.txt|All files|*.*";
			this.saveFileDialog1.Title = "Please specify the output xml file.";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(16, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(168, 72);
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// DigraphEngineFront
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(496, 307);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnRun);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox3);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(504, 336);
			this.Name = "DigraphEngineFront";
			this.Text = "Digraph Engine";
			this.Load += new System.EventHandler(this.DigraphEngineFront_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void DigraphEngineFront_Load(object sender, System.EventArgs e)
		{
		}

		private void ch_CheckedChanged(object sender, System.EventArgs e)
		{
			CheckBox ch = (CheckBox) sender;
			lstModelledChars.Items.Clear();
			if ((string)ch.Tag == "E" && ch.Checked)
			{
				chCaseSensitive.Checked = false;
				chControl.Checked = false;
				chDigit09.Checked = false;
				chLetter.Checked = false;
				chPunctuation.Checked = false;
				chSeperators.Checked = false;
				chSymbol.Checked = false;
				chWhiteSpace.Checked = false;

				lstModelledChars.Items.Add("No limitation");
			}
			else
			{
				chEverything.Checked = false;
				if ((string)ch.Tag == "L" && ch.Checked)
				{
					lstModelledChars.Items.AddRange(new string[] {"a", "b", "c", "ç", "d", "e", "f", "g", "ð", "h", "ý", "i", "j", "k", "l", "m", "n", "o", "ö", "p", "r", "s", "þ", "t", "u", "ü", "v", "y", "z", "q", "w", "x" });  
				}
				else if ((string)ch.Tag == "D" && ch.Checked)
				{
					lstModelledChars.Items.AddRange(new string[] {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}); 
				}
				else if ((string)ch.Tag == "C" && ch.Checked)
				{
					for (int i = 0; i < 256; i++)
					{
						if (Char.IsControl((char) i))
						{
							lstModelledChars.Items.Add (((char)i).ToString());
						}
					}
				}
				else if ((string)ch.Tag == "P" && ch.Checked)
				{
					for (int i = 0; i < 256; i++)
					{
						if (Char.IsPunctuation((char) i))
						{
							lstModelledChars.Items.Add (((char)i).ToString());
						}
					}
				}
				else if ((string)ch.Tag == "Sep"  && ch.Checked)
				{
					for (int i = 0; i < 256; i++)
					{
						if (Char.IsPunctuation((char) i))
						{
							lstModelledChars.Items.Add ("\""+((char)i).ToString()+"\"");
						}
					}
				}
				else if ((string)ch.Tag == "Sym" && ch.Checked) 
				{
					for (int i = 0; i < 256; i++)
					{
						if (Char.IsSymbol((char) i))
						{
							lstModelledChars.Items.Add ("\""+((char)i).ToString()+"\"");
						}
					}
				}
				else if ((string)ch.Tag == "W" && ch.Checked)
				{
					for (int i = 0; i < 256; i++)
					{
						if (Char.IsWhiteSpace((char) i))
						{
							lstModelledChars.Items.Add ("\""+((char)i).ToString()+"\"");
						}
					}
				}
			}
		}

		private void btnChooseInFileName_Click(object sender, System.EventArgs e)
		{
			if (DialogResult.OK == openFileDialog1.ShowDialog())
			{
				inFileName.Text = openFileDialog1.FileName;
			}
		}

		private void btnChooseOutputFile_Click(object sender, System.EventArgs e)
		{
			if (DialogResult.OK == saveFileDialog1.ShowDialog())
			{
				outFileName.Text = saveFileDialog1.FileName;
			}
			chUseOutput.Checked = true;
		}

		private void chUseOutput_CheckedChanged(object sender, System.EventArgs e)
		{
		
		}

		private void btnRun_Click(object sender, System.EventArgs e)
		{

			DiGraphEngine dge = new DiGraphEngine();
			if (!chEverything.Checked)
			{
				if (chLetter.Checked)
				{
					dge.AddChars(new char[] {'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g', 'ð', 'h', 'ý', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'þ', 't', 'u', 'ü', 'v', 'y', 'z', 'q', 'w', 'x' });  
				}
				if (chDigit09.Checked)
				{
					dge.AddChars(new char[] {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'}); 
				}
				if (chControl.Checked)
				{
					for (int i = 0; i < 256; i++)
					{
						if (Char.IsControl((char) i))
						{
							dge.AddChars(new char []{(char)i});
						}
					}
				}
				if (chPunctuation.Checked)
				{
					for (int i = 0; i < 256; i++)
					{
						if (Char.IsPunctuation((char) i))
						{
							dge.AddChars(new char []{(char)i});
						}
					}
				}
				if (chSeperators.Checked)
				{
					for (int i = 0; i < 256; i++)
					{
						if (Char.IsPunctuation((char) i))
						{
							dge.AddChars(new char []{(char)i});
						}
					}
				}
				if (chSymbol.Checked) 
				{
					for (int i = 0; i < 256; i++)
					{
						if (Char.IsSymbol((char) i))
						{
							dge.AddChars(new char []{(char)i});
						}
					}
				}
				if (chWhiteSpace.Checked)
				{
					for (int i = 0; i < 256; i++)
					{
						if (Char.IsWhiteSpace((char) i))
						{
							dge.AddChars(new char []{(char)i});
						}
					}
				}
			}
			dge.CaseSensitive = chCaseSensitive.Checked;				
			dge.Execute(openFileDialog1.FileName,saveFileDialog1.FileName);
			MessageBox.Show(this,"Execution Complete","Digraph Engine",MessageBoxButtons.OK,MessageBoxIcon.Information);



		}


	}
}
