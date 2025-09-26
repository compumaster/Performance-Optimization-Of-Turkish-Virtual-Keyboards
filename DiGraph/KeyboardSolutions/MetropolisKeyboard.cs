using System;
using DigraphLibrary;
using System.IO;
using System.Xml.Serialization;
using System.Collections;

namespace KeyboardSolutions
{
	/// <summary>
	/// Summary description for MetropolisKeyboard.
	/// </summary>
	public class MetropolisKeyboard
	{
		public KeyboardCanvas.KeyboardCanvasData keydata = null;
		Digraph di = new Digraph();
		Random rnd = new Random(31415);
		public Queue Top100 = new Queue(101); 
		public double Temp = 100d;
		public DateTime LastChange = DateTime.Now;
		public double smallestTSoFar = double.MaxValue;

		public MetropolisKeyboard()
		{

		}
		public void LoadKeyboardFromFile(string inFile)
		{
			try
			{
				StreamReader sr = new StreamReader (inFile,System.Text.Encoding.GetEncoding(1254));
				XmlSerializer xs = new XmlSerializer(typeof (KeyboardCanvas.KeyboardCanvasData));
				keydata = (KeyboardCanvas.KeyboardCanvasData) xs.Deserialize(sr);
				sr.Close();
				int i = keydata.keyboardChars.Count;
				
			}
			catch (Exception exp)
			{
				System.Diagnostics.Debug.WriteLine(exp.ToString());
			}
		}
		public void LoadDigraphFromFile(string inFile)
		{
			di = new Digraph();
			di.LoadFromTableFile(inFile);
		}
		public void Execute()
		{
			KeyboardButton one = null;
			KeyboardButton two = null;
			int lone,ltwo;
			FittsLawModels.KeyboardModel kbm = new FittsLawModels.KeyboardModel();
			kbm.di = di;
			kbm.data = keydata;
			double t, oldt;
			oldt = kbm.Execute(1,true);

			double k = 0.0001;

			
			double rndnr = 0;
			double eq4 = 0;

			
			while (true)
			{
				System.Windows.Forms.Application.DoEvents();
				int length = keydata.keyboardButtons.Count;
				lone = rnd.Next(length);
				ltwo = rnd.Next(length);
				one = ((KeyboardButton)keydata.keyboardButtons[lone]);
				two = ((KeyboardButton)keydata.keyboardButtons[ltwo]);
				char c = one.KeyboardChar;
				one.KeyboardChar = two.KeyboardChar;
				two.KeyboardChar = c;
				keydata.keyboardButtons[lone] = one;
				keydata.keyboardButtons[ltwo] = two;

				kbm.data = keydata;

				t = kbm.Execute(1,true);
				if (t < smallestTSoFar)
				{
					smallestTSoFar = t;
					LastChange = DateTime.Now;
					Top100.Enqueue(kbm.data.GetCopy());
					if (Top100.Count > 100)
						Top100.Dequeue();
				}
				//if old temperature is less then current temperature.
				//then it's the exponential work.
				if (oldt < t)
				{
					rndnr = rnd.NextDouble();
					eq4 = Math.Exp(-(t-oldt)/(k * Temp));
					
					if (rndnr > eq4)
					{
						// reject it.
						c = one.KeyboardChar;
						one.KeyboardChar = two.KeyboardChar;
						two.KeyboardChar = c;
						keydata.keyboardButtons[lone] = one;
						keydata.keyboardButtons[ltwo] = two;
					}
					else
					{	
						//accept it.
						System.Diagnostics.Debug.Write ( (60d / (5d*t)).ToString() + " ");
						System.Diagnostics.Debug.WriteLine ( rndnr.ToString() + " < " + eq4.ToString() + ": ");
						oldt = t;
					}				
				}
				else //else it we accept it.
				{
					System.Diagnostics.Debug.WriteLine ( (60d / (5d*t)).ToString() + " > " + (60d / (5d*oldt)));
					oldt = t;
				}
			}
		}
	}
}
