using System;
using DigraphLibrary;
using System.IO;
using System.Xml.Serialization;

namespace FittsLawModels
{
	/// <summary>
	/// Summary description for KeyboardModel.
	/// </summary>
	public class KeyboardModel
	{
		public KeyboardModel()
		{

		}
		public KeyboardCanvas.KeyboardCanvasData data = null;
		public Digraph di = new Digraph();
		public void LoadKeyboardFromFile(string inFile)
		{
			try
			{
				StreamReader sr = new StreamReader (inFile,System.Text.Encoding.GetEncoding(1254));
				XmlSerializer xs = new XmlSerializer(typeof (KeyboardCanvas.KeyboardCanvasData));
				data = (KeyboardCanvas.KeyboardCanvasData) xs.Deserialize(sr);
				sr.Close();
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
		/// <summary>
		/// Calculates the mean time t for typing a letter in the keyboard.
		/// </summary>
		/// <param name="ShortestAlternativeUsage">should be [0,1]</param>
		/// <param name="TurkishChars">if true than Turkish Chars used, else çöýþüð not used</param>
		/// <returns>the mean time t, in order to find wpm: (60 / (5*t)</returns>
		public double Execute(double ShortestAlternativeUsage, bool TurkishChars)
		{
			//Check parameters
			if ((ShortestAlternativeUsage > 1) || (ShortestAlternativeUsage < 0))
			{
				throw new ArgumentOutOfRangeException("ShortestAlternativeUsage",ShortestAlternativeUsage,"Should be between 0 and 1");
			}

			//Define if Turkish Chars used.
			char[] chars;
			if (TurkishChars)
				chars = new char[]{'a','b','c','ç','d','e','f','g','ð','h','ý','i','j','k','l','m','n','o','ö','p','r','s','þ','t','u','ü','v','y','z','x','q','w',' '};
			else
				chars = new char[]{'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','r','s','t','u','v','y','z','x','q','w',' '};

			//Calculate a Total value so that the useage ratio can be calculated.
			double Total = 0;
			for (int i = 0; i < chars.Length; i++)
			{
				for (int j = 0; j < chars.Length; j++)
				{
					Total += di.GetDigraphValue(chars[i],chars[j]);
				}
			}
			//X position of character i
			double xi;
			//Y position of character i
			double yi;
			//X position of character j
			double xj;
			//Y position of character i
			double yj;
			//Width of the button
			double W;
			//IP index.
			double IP;
			//constant added to each button time
			double a;
			//1/IP
			double b;
			//Distance between button i and button j
			double Dij;
			//time
			double t = 0;
			KeyboardButton ki,kj;

			a = 0.127;
			b = 4.9;
			IP = b;
			

			for (int i = 0; i < chars.Length; i++)
			{
				for (int j = 0; j < chars.Length; j++)
				{
					if (chars[i] == chars[j])
						t += (((double)di.GetDigraphValue(chars[i],chars[j])) / Total) * a;
					else
					{
						getKeyboardButtons(chars[i], chars[j], out ki, out kj,ShortestAlternativeUsage);

						xi = ki.Location.X;
						yi = ki.Location.Y;
						xj = kj.Location.X;
						yj = kj.Location.Y;
						W = kj.InnerCircleRadius * 2;

						Dij = Math.Sqrt( Math.Pow(Math.Abs(xi-xj),2) + Math.Pow(Math.Abs(yi-yj),2) );

						double log = Math.Log( (Dij/W) + 1.0,2.0);
						t += (((double)di.GetDigraphValue(chars[i],chars[j])) / Total) / IP * log;
					}
				}
			}

//			System.Diagnostics.Debug.WriteLine((t).ToString());
//			System.Diagnostics.Debug.WriteLine((60 / (5*t)).ToString() + " wpm");
			return t;
		}
		Random rnd = new Random();
		/// <summary>
		/// returns the NEAREST KeyboardButton Objects with the specified chars for button i and button j.
		/// </summary>
		/// <param name="ic"></param>
		/// <param name="jc"></param>
		/// <param name="io"></param>
		/// <param name="jo"></param>
		private void getKeyboardButtons(char ic, char jc, out KeyboardButton io, out KeyboardButton jo, double Percentage)
		{
			KeyboardButton[] ib = data.GetKeyboardButton(ic);
			KeyboardButton[] jb = data.GetKeyboardButton(jc);
			double minDistance = double.MaxValue;
			double Dij = 0;
			io = null;
			jo = null;
			if (ib.Length == 1 && jb.Length == 1)
			{
				io = ib[0];
				jo = jb[0];
			}
			else
			{
				foreach (KeyboardButton kbi in ib)
				{
					foreach (KeyboardButton kbj in jb)
					{
						Dij = Math.Abs(kbi.Location.X-kbj.Location.X) + Math.Abs(kbi.Location.Y-kbj.Location.Y);
						if (Dij < minDistance)
						{

							io = kbi;
							jo = kbj;
							minDistance = Dij;
							//							System.Diagnostics.Debug.WriteLine(">"+io.KeyboardChar + io.Location.ToString() + jo.KeyboardChar+jo.Location.ToString());

							if (minDistance == 0)
								break;
						}
					}
					if (minDistance == 0)
						break;
				}
				//				System.Diagnostics.Debug.WriteLine(io.KeyboardChar + io.Location.ToString() + jo.KeyboardChar+jo.Location.ToString());
			}
			if (ib.Length > 1)
			{
				if (rnd.NextDouble() > Percentage)
				{
					io = ib[rnd.Next(ib.Length)];
				}
			}
			if (jb.Length > 1)
			{
				if (rnd.NextDouble() > Percentage)
				{
					io = jb[rnd.Next(jb.Length)];
				}
			}
		}
	}
}
