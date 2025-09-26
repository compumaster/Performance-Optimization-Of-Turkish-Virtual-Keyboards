using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Digraphs
{
	/// <summary>
	/// Summary description for MetropolisKeyboardFrontEnd.
	/// </summary>
	public class MetropolisKeyboardFrontEnd : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox tbDigraph;
		private System.Windows.Forms.TextBox tbKeyboard;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog2;
		private DigraphLibrary.KeyboardDisplay keyboardDisplay1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnGetKeyboard;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.TrackBar Temperature;
		private System.Windows.Forms.CheckBox cbAutoTempAdjust;
		private System.Windows.Forms.Timer TempCheckTimer;
		private System.Windows.Forms.Label tbHighertWPM;
		private System.Windows.Forms.Timer UpdateGetTimer;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.ComponentModel.IContainer components;

		public MetropolisKeyboardFrontEnd()
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
			this.components = new System.ComponentModel.Container();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.tbDigraph = new System.Windows.Forms.TextBox();
			this.tbKeyboard = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
			this.keyboardDisplay1 = new DigraphLibrary.KeyboardDisplay();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tbHighertWPM = new System.Windows.Forms.Label();
			this.cbAutoTempAdjust = new System.Windows.Forms.CheckBox();
			this.Temperature = new System.Windows.Forms.TrackBar();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.btnGetKeyboard = new System.Windows.Forms.Button();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.TempCheckTimer = new System.Windows.Forms.Timer(this.components);
			this.UpdateGetTimer = new System.Windows.Forms.Timer(this.components);
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Temperature)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(128, 32);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(32, 23);
			this.button2.TabIndex = 7;
			this.button2.Text = "...";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(128, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(32, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tbDigraph
			// 
			this.tbDigraph.Location = new System.Drawing.Point(24, 32);
			this.tbDigraph.Name = "tbDigraph";
			this.tbDigraph.TabIndex = 5;
			this.tbDigraph.Text = "D:\\sp\\corpusout.txt";
			// 
			// tbKeyboard
			// 
			this.tbKeyboard.Location = new System.Drawing.Point(24, 8);
			this.tbKeyboard.Name = "tbKeyboard";
			this.tbKeyboard.TabIndex = 4;
			this.tbKeyboard.Text = "D:\\sp\\qwerty.xml";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(168, 8);
			this.button3.Name = "button3";
			this.button3.TabIndex = 8;
			this.button3.Text = "Execute";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "Xml Files|*.xml";
			// 
			// openFileDialog2
			// 
			this.openFileDialog2.Filter = "Digraph Files|*.txt";
			// 
			// keyboardDisplay1
			// 
			this.keyboardDisplay1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.keyboardDisplay1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.keyboardDisplay1.Location = new System.Drawing.Point(0, 0);
			this.keyboardDisplay1.Name = "keyboardDisplay1";
			this.keyboardDisplay1.Size = new System.Drawing.Size(600, 350);
			this.keyboardDisplay1.TabIndex = 9;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.numericUpDown1);
			this.panel1.Controls.Add(this.tbHighertWPM);
			this.panel1.Controls.Add(this.cbAutoTempAdjust);
			this.panel1.Controls.Add(this.Temperature);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.btnGetKeyboard);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.tbDigraph);
			this.panel1.Controls.Add(this.tbKeyboard);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 350);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(600, 104);
			this.panel1.TabIndex = 10;
			// 
			// tbHighertWPM
			// 
			this.tbHighertWPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.tbHighertWPM.Location = new System.Drawing.Point(400, 8);
			this.tbHighertWPM.Name = "tbHighertWPM";
			this.tbHighertWPM.Size = new System.Drawing.Size(56, 23);
			this.tbHighertWPM.TabIndex = 15;
			this.tbHighertWPM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cbAutoTempAdjust
			// 
			this.cbAutoTempAdjust.Location = new System.Drawing.Point(248, 8);
			this.cbAutoTempAdjust.Name = "cbAutoTempAdjust";
			this.cbAutoTempAdjust.Size = new System.Drawing.Size(144, 24);
			this.cbAutoTempAdjust.TabIndex = 14;
			this.cbAutoTempAdjust.Text = "Auto Temp Adjust";
			// 
			// Temperature
			// 
			this.Temperature.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Temperature.Location = new System.Drawing.Point(8, 56);
			this.Temperature.Maximum = 100;
			this.Temperature.Name = "Temperature";
			this.Temperature.Size = new System.Drawing.Size(584, 45);
			this.Temperature.TabIndex = 13;
			this.Temperature.Value = 100;
			this.Temperature.ValueChanged += new System.EventHandler(this.Temperature_Scroll);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(168, 32);
			this.button5.Name = "button5";
			this.button5.TabIndex = 12;
			this.button5.Text = "Stop";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(256, 32);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(88, 23);
			this.button4.TabIndex = 10;
			this.button4.Text = "SaveTop100";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// btnGetKeyboard
			// 
			this.btnGetKeyboard.Location = new System.Drawing.Point(504, 8);
			this.btnGetKeyboard.Name = "btnGetKeyboard";
			this.btnGetKeyboard.Size = new System.Drawing.Size(88, 23);
			this.btnGetKeyboard.TabIndex = 9;
			this.btnGetKeyboard.Text = "GetKeyboard";
			this.btnGetKeyboard.Click += new System.EventHandler(this.btnGetKeyboard_Click);
			// 
			// TempCheckTimer
			// 
			this.TempCheckTimer.Interval = 1;
			this.TempCheckTimer.Tick += new System.EventHandler(this.TempCheckTimer_Tick);
			// 
			// UpdateGetTimer
			// 
			this.UpdateGetTimer.Tick += new System.EventHandler(this.UpdateGetTimer_Tick);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(536, 32);
			this.numericUpDown1.Maximum = new System.Decimal(new int[] {
																		   10000,
																		   0,
																		   0,
																		   0});
			this.numericUpDown1.Minimum = new System.Decimal(new int[] {
																		   1,
																		   0,
																		   0,
																		   0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(56, 20);
			this.numericUpDown1.TabIndex = 16;
			this.numericUpDown1.Value = new System.Decimal(new int[] {
																		 1,
																		 0,
																		 0,
																		 0});
			// 
			// MetropolisKeyboardFrontEnd
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(600, 454);
			this.Controls.Add(this.keyboardDisplay1);
			this.Controls.Add(this.panel1);
			this.Name = "MetropolisKeyboardFrontEnd";
			this.Text = "MetropolisKeyboardFrontEnd";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Temperature)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
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
		KeyboardSolutions.MetropolisKeyboard mtr = null;
		System.Threading.Thread t;
		private void button3_Click(object sender, System.EventArgs e)
		{
			if (cbAutoTempAdjust.Checked)
			{
				TempCheckTimer.Enabled = true;
			}
			else
			{
				UpdateGetTimer.Interval = 5000;
				UpdateGetTimer.Enabled = true;
			}
			mtr = new KeyboardSolutions.MetropolisKeyboard();
			mtr.Temp = Temperature.Value;
			mtr.LoadDigraphFromFile(tbDigraph.Text);
			mtr.LoadKeyboardFromFile(tbKeyboard.Text);
			t = new System.Threading.Thread(new System.Threading.ThreadStart(mtr.Execute));
			if (cbAutoTempAdjust.Checked)
			{
				t.Priority = System.Threading.ThreadPriority.BelowNormal;
			}
			t.Start();
		}

		private void btnGetKeyboard_Click(object sender, System.EventArgs e)
		{
			try
			{
				if (mtr != null)
				{
					if (t.IsAlive)
						t.Suspend();
					System.Threading.Thread.Sleep(1000);
					keyboardDisplay1.Display(mtr.keydata);
					System.Threading.Thread.Sleep(800);
					if (t.IsAlive)
						t.Resume();
				}
			}
			catch
			{
			}
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			if (mtr != null)
			{
				t.Suspend();
				System.Threading.Thread.Sleep(500);
				
				object[] data = mtr.Top100.ToArray();
				int i = 0;
				if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
				{
					foreach (DigraphLibrary.KeyboardCanvas.KeyboardCanvasData dat in data)
					{
						try
						{
							System.IO.StreamWriter sw = new System.IO.StreamWriter (folderBrowserDialog1.SelectedPath+"\\Top10_" + i++ + ".xml",false,System.Text.Encoding.GetEncoding(1254));
							System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(typeof (DigraphLibrary.KeyboardCanvas.KeyboardCanvasData));
							xs.Serialize(sw,dat);
							sw.Flush();
							sw.Close();
						}
						catch (Exception exp)
						{
							System.Diagnostics.Debug.WriteLine(exp.ToString());
						}
					}
				}
				t.Resume();
			}
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			DialogResult res = MessageBox.Show(this,"Would you like to save current top 10?","Save Results?",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
			if (res == DialogResult.Yes)
			{
				this.button4_Click(sender,e);
				t.Abort();
			} 
			else if (res == DialogResult.No)
				t.Abort();

		}

		private void Temperature_Scroll(object sender, System.EventArgs e)
		{
			if (mtr != null)
			{
				mtr.Temp = (double)Temperature.Value * (double)numericUpDown1.Value;
			}
		}
		DateTime LastControlled = DateTime.Now;
		int PeekTrials = 10;
		int shuffle = 5;
		private void TempCheckTimer_Tick(object sender, System.EventArgs e)
		{
			int fastforward = 1000;
			tbHighertWPM.Text = (60d / (5d*mtr.smallestTSoFar)).ToString(); 
			if (Temperature.Value > 50)
			{
				numericUpDown1.Value = 1;
				TempCheckTimer.Interval = 10*fastforward;
				Temperature.Value = 25;
			}
			else if (Temperature.Value >= 25)
			{
				TempCheckTimer.Interval = 10*fastforward;
				Temperature.Value = 10;
			}
			else if (Temperature.Value >= 10)
			{
				TempCheckTimer.Interval = 20*fastforward;
				Temperature.Value = 5;
			}
			else if (Temperature.Value >= 5)
			{
				TempCheckTimer.Interval = 20*fastforward;
				Temperature.Value = 3;
			}
			else if (Temperature.Value >= 1)
			{

				if (LastControlled >= mtr.LastChange)
				{
					TempCheckTimer.Interval = 120*fastforward;
					Temperature.Value = 0;
				}
				else
				{
					TempCheckTimer.Interval = 60*fastforward;
					Temperature.Value = 1;
				}
				LastControlled = mtr.LastChange;
				
			}
			else if (Temperature.Value == 0)
			{

				if (LastControlled < mtr.LastChange)
				{
					TempCheckTimer.Interval = 120*fastforward;
					Temperature.Value = 0;
				}
				else
				{
					PeekTrials --;
					if (PeekTrials <= 0)
					{
						PeekTrials = 10;
						shuffle--;
						if (shuffle <= 0)
						{
							shuffle = 5;
							numericUpDown1.Value = 10000;
							Temperature.Value = 100;
							TempCheckTimer.Interval = 120*fastforward;
						}
						else
						{
							TempCheckTimer.Interval = 10*fastforward;
							Temperature.Value = 30;
						}
					}
					else
					{
						TempCheckTimer.Interval = 10*fastforward;
						Temperature.Value = 3;
					}

				}
				LastControlled = mtr.LastChange;
			}
		}



		private void UpdateGetTimer_Tick(object sender, System.EventArgs e)
		{
			tbHighertWPM.Text = (60d / (5d*mtr.smallestTSoFar)).ToString(); 

		}



	}
}
