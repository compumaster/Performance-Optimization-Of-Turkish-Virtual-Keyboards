using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Digraphs
{
	/// <summary>
	/// Summary description for KeyboardModelFrontEnd.
	/// </summary>
	public class KeyboardModelFrontEnd : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox tbKeyboard;
		private System.Windows.Forms.TextBox tbDigraph;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TextBox tbResult;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbResultWPM;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public KeyboardModelFrontEnd()
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
			this.tbKeyboard = new System.Windows.Forms.TextBox();
			this.tbDigraph = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
			this.button3 = new System.Windows.Forms.Button();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.tbResult = new System.Windows.Forms.TextBox();
			this.tbResultWPM = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbKeyboard
			// 
			this.tbKeyboard.Location = new System.Drawing.Point(8, 16);
			this.tbKeyboard.Name = "tbKeyboard";
			this.tbKeyboard.TabIndex = 0;
			this.tbKeyboard.Text = "D:\\sp\\qwerty.xml";
			// 
			// tbDigraph
			// 
			this.tbDigraph.Location = new System.Drawing.Point(8, 40);
			this.tbDigraph.Name = "tbDigraph";
			this.tbDigraph.TabIndex = 1;
			this.tbDigraph.Text = "D:\\sp\\corpusout.txt";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(112, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(32, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(112, 40);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(32, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "...";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "Xml Files|*.xml";
			// 
			// openFileDialog2
			// 
			this.openFileDialog2.Filter = "Digraph Files|*.txt";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(8, 112);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(136, 24);
			this.button3.TabIndex = 4;
			this.button3.Text = "Calculate Mean Time";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(8, 64);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(104, 20);
			this.numericUpDown1.TabIndex = 5;
			this.numericUpDown1.Value = new System.Decimal(new int[] {
																		 100,
																		 0,
																		 0,
																		 0});
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(8, 88);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(152, 24);
			this.checkBox1.TabIndex = 6;
			this.checkBox1.Text = "Turkish Chars (çöýþðü)";
			// 
			// tbResult
			// 
			this.tbResult.Location = new System.Drawing.Point(8, 144);
			this.tbResult.Name = "tbResult";
			this.tbResult.TabIndex = 7;
			this.tbResult.Text = "";
			// 
			// tbResultWPM
			// 
			this.tbResultWPM.Location = new System.Drawing.Point(8, 168);
			this.tbResultWPM.Name = "tbResultWPM";
			this.tbResultWPM.TabIndex = 7;
			this.tbResultWPM.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(112, 168);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 23);
			this.label1.TabIndex = 8;
			this.label1.Text = "WPM";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tbResultWPM);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.tbDigraph);
			this.groupBox1.Controls.Add(this.numericUpDown1);
			this.groupBox1.Controls.Add(this.tbResult);
			this.groupBox1.Controls.Add(this.tbKeyboard);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(8, 96);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(168, 200);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(160, 88);
			this.label2.TabIndex = 10;
			this.label2.Text = "This program creates the  designed keyboard, reads the digraph table, calculates " +
				"the WPM usage, with the optimum space usage probability (if there are more than " +
				"one space) specified";
			// 
			// KeyboardModelFrontEnd
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(184, 302);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "KeyboardModelFrontEnd";
			this.Text = "KeyboardModelFrontEnd";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button3_Click(object sender, System.EventArgs e)
		{
			FittsLawModels.KeyboardModel kbm = new FittsLawModels.KeyboardModel();
			kbm.LoadDigraphFromFile(tbDigraph.Text);
			kbm.LoadKeyboardFromFile(tbKeyboard.Text);
			double t = kbm.Execute((double)numericUpDown1.Value/(100.0d),checkBox1.Checked);
			tbResult.Text = t.ToString();
			tbResultWPM.Text = (60.0d / (5.0d*t)).ToString();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if (DialogResult.OK == openFileDialog1.ShowDialog())
				tbKeyboard.Text = openFileDialog1.FileName;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if (DialogResult.OK == openFileDialog2.ShowDialog())
				tbDigraph.Text = openFileDialog2.FileName;
		}
	}
}
