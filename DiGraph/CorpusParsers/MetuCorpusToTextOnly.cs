using System;
using System.IO;
namespace CorpusParsers
{
	/// <summary>
	/// Summary description for MetuCorpusToTextOnly.
	/// </summary>
	public class MetuCorpusToTextOnly
	{
		public MetuCorpusToTextOnly()
		{
		}
		System.Text.RegularExpressions.Regex reg = 
			new System.Text.RegularExpressions.Regex("<.*>");

		public void Execute(string DirectoryName, string OutFile)
		{
			StreamWriter sw = new StreamWriter(OutFile,false,System.Text.Encoding.GetEncoding(1254));
			foreach (string FileName in Directory.GetFiles(DirectoryName))
			{
				StreamReader sr = new StreamReader(FileName,System.Text.Encoding.GetEncoding(1254));
				string InText = sr.ReadToEnd();
				int BodyBegin = InText.IndexOf("<body>") + "<body>".Length;
				int BodyEnd = InText.LastIndexOf("</body>");
				if ((BodyBegin == 5)||(BodyEnd == -1))
				{
					BodyBegin = InText.IndexOf("<text>") + "<text>".Length;
					BodyEnd = InText.LastIndexOf("</text>");
				}
				if ((BodyBegin != 5)&&(BodyEnd != -1))
					InText = InText.Substring(BodyBegin,BodyEnd - BodyBegin);
				
				bool done = false;
				int begin = 0, end = 0;
				while (!done)
				{
					begin = InText.IndexOf("<");
					if (begin > 0)
						end = InText.IndexOf(">",begin);
					if ((begin != -1) && (end != -1))
					{
						string subs = InText.Substring(begin,end-begin +1);

						InText = InText.Replace(subs,"");
					}
					else
					{
						done = true;
					}

				}


				sw.WriteLine(InText);
			}
			sw.Flush();
			sw.Close();
		}
	}
}
