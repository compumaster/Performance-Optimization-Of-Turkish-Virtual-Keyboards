using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace DigraphLibrary
{
	/// <summary>
	/// Summary description for KeyboardLayout.
	/// </summary>
	public class KeyboardLayout : System.Windows.Forms.UserControl
	{
		#region init and dispose

		public DigraphLibrary.KeyboardCanvas keyboardCanvas1;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.ComboBox Type;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.TextBox tbChar;
		private System.Windows.Forms.Button btnAddChar;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Button btnAddCharNum;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public KeyboardLayout()
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
			this.keyboardCanvas1 = new DigraphLibrary.KeyboardCanvas();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.splitter2 = new System.Windows.Forms.Splitter();
			this.panel1 = new System.Windows.Forms.Panel();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.Type = new System.Windows.Forms.ComboBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnLoad = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.tbChar = new System.Windows.Forms.TextBox();
			this.btnAddChar = new System.Windows.Forms.Button();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.btnAddCharNum = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// keyboardCanvas1
			// 
			this.keyboardCanvas1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.keyboardCanvas1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.keyboardCanvas1.KeyboardMode = DigraphLibrary.ButtonMode.Rectangle;
			this.keyboardCanvas1.Location = new System.Drawing.Point(8, 5);
			this.keyboardCanvas1.Name = "keyboardCanvas1";
			this.keyboardCanvas1.Size = new System.Drawing.Size(587, 390);
			this.keyboardCanvas1.TabIndex = 2;
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(5, 5);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 390);
			this.splitter1.TabIndex = 3;
			this.splitter1.TabStop = false;
			// 
			// splitter2
			// 
			this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
			this.splitter2.Location = new System.Drawing.Point(595, 5);
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(8, 390);
			this.splitter2.TabIndex = 4;
			this.splitter2.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkedListBox1);
			this.panel1.Controls.Add(this.Type);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(603, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 390);
			this.panel1.TabIndex = 5;
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkedListBox1.IntegralHeight = false;
			this.checkedListBox1.Location = new System.Drawing.Point(0, 21);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(200, 305);
			this.checkedListBox1.TabIndex = 6;
			this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
			// 
			// Type
			// 
			this.Type.Dock = System.Windows.Forms.DockStyle.Top;
			this.Type.Items.AddRange(new object[] {
													  "Rectangle",
													  "Hexagon",
													  "Circle"});
			this.Type.Location = new System.Drawing.Point(0, 0);
			this.Type.Name = "Type";
			this.Type.Size = new System.Drawing.Size(200, 21);
			this.Type.TabIndex = 7;
			this.Type.Text = "Mode";
			this.Type.SelectedIndexChanged += new System.EventHandler(this.Type_SelectedIndexChanged);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.numericUpDown1);
			this.panel2.Controls.Add(this.btnAddChar);
			this.panel2.Controls.Add(this.tbChar);
			this.panel2.Controls.Add(this.btnReset);
			this.panel2.Controls.Add(this.btnSave);
			this.panel2.Controls.Add(this.btnLoad);
			this.panel2.Controls.Add(this.btnAddCharNum);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 326);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(200, 64);
			this.panel2.TabIndex = 6;
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(128, 32);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(64, 24);
			this.btnReset.TabIndex = 1;
			this.btnReset.Text = "Reset";
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(64, 32);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(64, 24);
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(0, 32);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(64, 24);
			this.btnLoad.TabIndex = 0;
			this.btnLoad.Text = "Load";
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "Xml Files|*.xml";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.FileName = "keyboard.xml";
			this.saveFileDialog1.Filter = "Xml Files|*.xml";
			// 
			// tbChar
			// 
			this.tbChar.Location = new System.Drawing.Point(8, 8);
			this.tbChar.MaxLength = 1;
			this.tbChar.Name = "tbChar";
			this.tbChar.Size = new System.Drawing.Size(24, 20);
			this.tbChar.TabIndex = 2;
			this.tbChar.Text = " ";
			// 
			// btnAddChar
			// 
			this.btnAddChar.Location = new System.Drawing.Point(32, 8);
			this.btnAddChar.Name = "btnAddChar";
			this.btnAddChar.Size = new System.Drawing.Size(16, 23);
			this.btnAddChar.TabIndex = 3;
			this.btnAddChar.Text = "+";
			this.btnAddChar.Click += new System.EventHandler(this.btnAddChar_Click);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(48, 8);
			this.numericUpDown1.Maximum = new System.Decimal(new int[] {
																		   256,
																		   0,
																		   0,
																		   0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
			this.numericUpDown1.TabIndex = 4;
			// 
			// btnAddCharNum
			// 
			this.btnAddCharNum.Location = new System.Drawing.Point(88, 8);
			this.btnAddCharNum.Name = "btnAddCharNum";
			this.btnAddCharNum.Size = new System.Drawing.Size(16, 23);
			this.btnAddCharNum.TabIndex = 3;
			this.btnAddCharNum.Text = "+";
			this.btnAddCharNum.Click += new System.EventHandler(this.btnAddCharNum_Click);
			// 
			// KeyboardLayout
			// 
			this.Controls.Add(this.keyboardCanvas1);
			this.Controls.Add(this.splitter2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.splitter1);
			this.DockPadding.All = 5;
			this.Name = "KeyboardLayout";
			this.Size = new System.Drawing.Size(808, 400);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		#endregion

		public ArrayList CharList
		{
			get
			{
				return charList;
			}
			set
			{
				charList = value;
				LoadCharList();
			}
		}
		private ArrayList charList = new ArrayList();

		private void LoadCharList()
		{
			checkedListBox1.Items.Clear();
			foreach (char c in charList)
				checkedListBox1.Items.Add(c,false);
		}

		private void LoadCharList(ArrayList KeyboardButtonsList)
		{
			checkedListBox1.Items.Clear();
			foreach (char c in charList)
			{
				this.checkedListBox1.ItemCheck -= new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);

				bool check = false;
				foreach (KeyboardButton b in KeyboardButtonsList)
				{
					if (b.KeyboardChar == c)
						check = true;
				}
				checkedListBox1.Items.Add(c,check);
				this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
			}
		}
		private void checkedListBox1_ItemCheck(object sender, System.Windows.Forms.ItemCheckEventArgs e)
		{
			if (e.CurrentValue == CheckState.Checked)
				keyboardCanvas1.removeChar((char) checkedListBox1.SelectedItem);
			else
				keyboardCanvas1.addChar((char) checkedListBox1.SelectedItem);
		}

		private void Type_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch (Type.SelectedIndex)
			{
				case (0):
					keyboardCanvas1.KeyboardMode = ButtonMode.Rectangle;
					break;
				case (1):
					keyboardCanvas1.KeyboardMode = ButtonMode.Hexagon;
					break;
				case (2):
					keyboardCanvas1.KeyboardMode = ButtonMode.Circle;
					break;
			}
		}

		private void btnLoad_Click(object sender, System.EventArgs e)
		{
			if (DialogResult.OK == openFileDialog1.ShowDialog())
			{
				try
				{
					StreamReader sr = new StreamReader (openFileDialog1.FileName,System.Text.Encoding.GetEncoding(1254));
					XmlSerializer xs = new XmlSerializer(typeof (KeyboardCanvas.KeyboardCanvasData));
					keyboardCanvas1.data = (KeyboardCanvas.KeyboardCanvasData) xs.Deserialize(sr);
					sr.Close();
					LoadCharList(keyboardCanvas1.data.keyboardButtons);
					keyboardCanvas1.Invalidate();
				}
				catch (Exception exp)
				{
					System.Diagnostics.Debug.WriteLine(exp.ToString());
				}
			}
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			if (DialogResult.OK == saveFileDialog1.ShowDialog())
			{
				try
				{
					StreamWriter sw = new StreamWriter (saveFileDialog1.FileName,false,System.Text.Encoding.GetEncoding(1254));
					XmlSerializer xs = new XmlSerializer(typeof (KeyboardCanvas.KeyboardCanvasData));
					xs.Serialize(sw,keyboardCanvas1.data);
					sw.Flush();
					sw.Close();
				}
				catch (Exception exp)
				{
					System.Diagnostics.Debug.WriteLine(exp.ToString());
				}
			}
		}

		private void btnReset_Click(object sender, System.EventArgs e)
		{
			keyboardCanvas1.data = new DigraphLibrary.KeyboardCanvas.KeyboardCanvasData();
			keyboardCanvas1.Invalidate();
			LoadCharList();
		}

		private void btnAddChar_Click(object sender, System.EventArgs e)
		{
			charList.Add(Convert.ToChar(tbChar.Text));
			LoadCharList(keyboardCanvas1.data.keyboardButtons);
		}

		private void btnAddCharNum_Click(object sender, System.EventArgs e)
		{
			charList.Add(Convert.ToChar((int)numericUpDown1.Value));
			LoadCharList(keyboardCanvas1.data.keyboardButtons);

		}


	}
}
