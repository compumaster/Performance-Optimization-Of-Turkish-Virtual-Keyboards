using System;
using System.IO;
using System.Collections;

namespace DigraphLibrary.Converters
{
	/// <summary>
	/// Summary description for OldMilliyetHTML2TXT.
	/// </summary>
	public class OldMilliyetHTML2TXT
	{
		public OldMilliyetHTML2TXT()
		{
			
		}
		public void Execute(string inDir, string outFile)
		{
			StreamWriter error = new StreamWriter("C:\\OldMilliyetHTML2TXTError.txt",false);
			StreamWriter sw = new StreamWriter(outFile,false,System.Text.Encoding.GetEncoding(1254));
			ArrayList directories = getDirectories(inDir);

			foreach (string directory in directories)
			{
				if ((directory.IndexOf("tv") < 0) && (directory.IndexOf("haberindeksi") < 0) )
					foreach (string file in Directory.GetFiles(directory))
					{
						if (file.IndexOf("tbl") < 0)
							if (!doHTMLConversion (sw, file))
							{
								error.WriteLine(file);
							}	
					}
			}
			error.Flush();
			sw.Flush();
			error.Close();
			sw.Close();
		}

		public bool doHTMLConversion (StreamWriter sw, string file)
		{
			StreamReader sr = new StreamReader(file,System.Text.Encoding.GetEncoding(1254));
            string text = sr.ReadToEnd();

			int begin = text.IndexOf("<!-- HABERLER -->");
			int end = -1;
			if (begin != -1)
			{
				end = text.IndexOf("<BR><BR>",begin);
				if (end == -1)
					return false;
				
				text = text.Substring(begin,end - begin);
				sw.WriteLine(CleanHTMLTags(text));

			}
			else
			{ // newer one
				begin = text.IndexOf("<!-- PRINT BASLADI -->");
				if (begin == -1)
					return false;


			}
			return true;
		}

		public string CleanHTMLTags(string HTMLText)
		{
			int begin = 0;
			int end = -1;
			bool nothingToClean = false;
			
			string ReturnText = "";
			HTMLText = HTMLText.Replace("&nbsp;","").Replace("&#149;","");
			while(!nothingToClean)
			{
				begin = HTMLText.IndexOf("<",begin);
				if (begin < 0)
				{
					nothingToClean = true;
					break;
				}
				
				end = HTMLText.IndexOf(">",begin);

				if (end < 0)
				{
					nothingToClean = true;
					break;
				}
				string tag = HTMLText.Substring(begin,end - begin + 1);
				HTMLText = HTMLText.Replace(tag,"");
			}
			foreach (string s in HTMLText.Split('\n'))
			{
				string temp = s.Trim();
				if (temp.Length > 10)
					ReturnText += temp + "\n";
			}
			return ReturnText;
		}
		public ArrayList getDirectories (string baseDir)
		{
			ArrayList arr = new ArrayList();
			arr.AddRange(Directory.GetDirectories(baseDir));
			foreach (string dir in Directory.GetDirectories(baseDir))
			{
				arr.AddRange(getDirectories(dir));
			}
			return arr;

		}
	}
}
