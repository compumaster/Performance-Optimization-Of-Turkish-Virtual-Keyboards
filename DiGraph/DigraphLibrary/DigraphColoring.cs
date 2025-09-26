using System;
using System.IO;
using System.Drawing;
using System.Collections;
namespace DigraphLibrary
{
	/// <summary>
	/// Summary description for DigraphColoring.
	/// </summary>
	public class DigraphColoring
	{
		public DigraphColoring()
		{
		}
		public void Execute(Digraph Digraph, string outFile, char[] valid)
		{
			ArrayList chr = new ArrayList();

			string[] keys = Digraph.GetKeys();
			foreach (char c in valid)
			{
				foreach (string s in keys)
				{
					if (s == c.ToString())
					{
						chr.Add(s);
						break;
					}
				}
			}
			
			chr.Sort(null);
			foreach (string c in chr)
			{
				System.Diagnostics.Debug.Write(c.ToString());
			}
			System.Diagnostics.Debug.WriteLine("");

			Bitmap bmp = new Bitmap((chr.Count+1) * 10,(chr.Count+1) * 10);
			/// r	g	b
			/// 0	0	255	min
			/// 0	0	0	med
			/// 255	0	0	max
			int max = Digraph.Max;
			Graphics g = Graphics.FromImage(bmp);
			Font font = new Font("Tahoma",6);
			
			StreamWriter sw = new StreamWriter(outFile + ".txt",false,System.Text.Encoding.GetEncoding(1254));

			for (int i = 0; i < chr.Count; i++)
			{
				g.DrawString(chr[i].ToString(),font,Brushes.White,(i + 1) * 10,0);

			}

			for (int j = 0; j < chr.Count; j++)
			{
				g.DrawString(chr[j].ToString(),font,Brushes.White,0,(j + 1) * 10);
			}

			for (int i = 0; i < chr.Count; i++)
			{
				for (int j = 0; j < chr.Count; j++)
				{
					sw.Write(chr[i].ToString()+chr[j].ToString()+Digraph.GetDigraphValue(Convert.ToChar(chr[i]),Convert.ToChar(chr[j])).ToString() + "\t");
					int val = Digraph.GetDigraphValue(Convert.ToChar(chr[i]),Convert.ToChar(chr[j]));
					Color c = Color.FromArgb(getR(val,max),0,getB(val,max));

					g.FillRectangle(new SolidBrush(c),(j+1)*10, (i+1)*10,10,10);
				}
				sw.WriteLine("");
			}
			sw.Close();
			




			bmp.Save(outFile,System.Drawing.Imaging.ImageFormat.Bmp);
		}
		public int getR(int val, int max)
		{
			
			long t = (long)val * (long)512 / (long)max ;
			t--;
			if (t > 512)
				return 255;
			else if (t > 256)
				return (int)t - 256;
			else
				return 0;
	
		}
		public int getB(int val, int max)
		{
			long t = (long)val * (long)512 / (long)max ;
			
			if (t <= 255)
				return (int)(255 - t);
			else
				return 0;
		}
	}
}
