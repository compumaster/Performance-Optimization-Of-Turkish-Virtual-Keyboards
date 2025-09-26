using System;
using System.Collections;
using System.IO;
namespace DigraphLibrary
{
	/// <summary>
	/// Summary description for Digraph.
	/// </summary>
	public class Digraph
	{
		Hashtable HT = new Hashtable();
		string[] Chars = new string[0];
		double Total = 0;
		int max = 0;
		public Digraph()
		{
			
		}
		
		public int Max
		{
			get
			{
				return max;
			}
		}
		public string[] GetKeys()
		{
			return Chars;
		}
		public int GetDigraphValue(char From, char To)
		{
			string key = ((int)From).ToString()+ " " + ((int)To).ToString();

			object val = null;
			val = HT[key];
//			if (From == 'b')
//				System.Diagnostics.Debug.WriteLine(From.ToString() + To.ToString(),val.ToString());

			if (val != null)
				return (int) val;
			else
				return -1;
		}

		public double GetDigraphRatio(char From, char To)
		{
			string key = ((int)From).ToString()+ " " + ((int)To).ToString();

			object val = null;
			val = HT[key];
			if (val != null)
				return ((double)((int) val))/Total;
			else
				return -1;
		}

		public void LoadFromTableFile(string FileName)
		{
			StreamReader sr = new StreamReader(FileName,System.Text.Encoding.GetEncoding(1254));
			string line = sr.ReadLine();
			//first is TAB last is TAB, get rid of them.
			string[] chars = (line.Substring(1,line.Length - 2)).Split('\t');
			for (int i = 0; i < chars.Length; i++)
			{
				if (chars[i].Length != 1)
				{
					string val = chars[i];
					val = val.Substring(2);
					chars[i] = ((char) int.Parse(val,System.Globalization.NumberStyles.AllowHexSpecifier)).ToString();
				}
			}


			Chars = chars;

			while (sr.Peek() >0)
			{
				string[] values = sr.ReadLine().Split('\t');
				string currentChar = "";
				if (values[0].Length == 1)
					currentChar = values[0];
				else
				{
					string val = values[0];
					val = val.Substring(2);
					currentChar = ((char) int.Parse(val,System.Globalization.NumberStyles.AllowHexSpecifier)).ToString();
				}
				for (int i = 0; i < chars.Length; i++)
				{
					string key = ((int)Convert.ToChar(currentChar)).ToString()+ " " + ((int)Convert.ToChar(chars[i])).ToString();
					if (!HT.Contains(key))
					{
						int val = int.Parse(values[i+1]);
						Total += val;
						if (max < val)
							max = val;

						HT.Add(key, val);
//						System.Diagnostics.Debug.WriteLine(key, val.ToString() + "(" + currentChar + chars[i] + ")");
					}
				}
			}
		}
	}
}
