using System;
using System.IO;
using System.Collections;
using System.Xml.Serialization;

namespace Digraphs
{
	/// <summary>
	/// Summary description for DiGraphEngine.
	/// </summary>
	public class DiGraphEngine
	{
		public ArrayList Digraphs = new ArrayList(512);
		public Hashtable HT = new Hashtable();

		public DiGraphEngine()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		private ArrayList Chars = new ArrayList();

		/// <summary>
		/// Adds specified chars into the internal array of controlled chars.
		/// </summary>
		/// <param name="chars">chars to create digraph.</param>
		public void AddChars(char[] chars)
		{
			foreach (char c in chars)
			{
				if (!Chars.Contains(c))
					Chars.Add(c);
			}
			NoCharLimitation = false;
		}
		public bool CaseSensitive = true;
		private bool NoCharLimitation = true;
		/// <summary>
		/// Creates Digraph
		/// </summary>
		/// <param name="InputPath">Input file to create digraph</param>
		/// <param name="FileOutputPath">Outputfile to write digraph result</param>
		public void Execute(string InputPath, string FileOutputPath)
		{

			StreamReader sr = new StreamReader(File.Open(InputPath,FileMode.Open),System.Text.Encoding.GetEncoding(1254));
			char[] di = new char[1];
			char lastRead = ' ';
			
			if (CaseSensitive)
			{
				while (sr.Peek() > 0)
				{
					sr.Read(di,0,1);
					char lowerCase = char.ToLower(di[0]);
					if (NoCharLimitation)
					{
						addToDigraph(lastRead,di[0]);
						lastRead = di[0];
					}
					else if ( Chars.Contains( lowerCase))
					{
						addToDigraph(lastRead,di[0]);
						lastRead = di[0];	
					}
				}
			}
			else
			{
				while (sr.Peek() > 0)
				{
					sr.Read(di,0,1);
					char lowerCase = char.ToLower(di[0]);
					if (NoCharLimitation)
					{
						addToDigraph(lastRead,lowerCase);
						lastRead = lowerCase;
					}
					else if ( Chars.Contains(lowerCase))
					{
						addToDigraph(lastRead,lowerCase);
						lastRead = lowerCase;	
					}
				}
			}
			sr.Close();

			if (FileOutputPath != null)
			{
				StreamWriter sw = new StreamWriter (FileOutputPath,false,System.Text.Encoding.GetEncoding(1254));

				sw.Write("\t");

				foreach (char c in HT.Keys)
				{
					if (Char.IsControl(c))
						sw.Write("0x" + Convert.ToInt32(c).ToString("x"));
					else
						sw.Write(c);
					sw.Write("\t");
				}
				sw.WriteLine("");

				foreach (char c in HT.Keys)
				{
					if (Char.IsControl(c))
						sw.Write("0x" + Convert.ToInt32(c).ToString("x"));
					else
						sw.Write(c);
					sw.Write("\t");
					foreach (char ch in HT.Keys)
					{
						int first = (int)HT[c];
						int second = (int)HT[ch];
						sw.Write(((ArrayList)Digraphs[first])[second]);
						sw.Write("\t");
					}
					sw.WriteLine("");
				}
				sw.Close();
			}
		}

		private void addToDigraph (char first, char next)
		{
			int firstLoc, nextLoc;
			if (HT.ContainsKey(first))
				firstLoc = (int)HT[first];
			else
			{
				foreach (ArrayList arr in Digraphs)
				{
					arr.Add(0);
				}
				firstLoc = Digraphs.Add(new ArrayList(512));
				HT[first] = firstLoc;
				for (int i = 0; i <= firstLoc; i++)
					((ArrayList)Digraphs[firstLoc]).Add(0);

			}

			if (HT.ContainsKey(next))
				nextLoc = (int)HT[next];
			else
			{
				foreach (ArrayList arr in Digraphs)
				{
					arr.Add(0);
				}
				nextLoc = Digraphs.Add(new ArrayList(512));
				HT[next] = nextLoc;
				for (int i = 0; i <= nextLoc; i++)
					((ArrayList)Digraphs[nextLoc]).Add(0);

			}
			((ArrayList)Digraphs[firstLoc])[nextLoc] = ((int)((ArrayList)Digraphs[firstLoc])[nextLoc])+1;


		}

	}
}
