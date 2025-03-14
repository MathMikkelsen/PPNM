using System;
using static System.Math;
using System.Diagnostics;
using System.IO;

public partial class plot{

	public static void Main(){
		string pgm = @"/usr/bin/gnuplot-qt";
		Process extPro = new Process();
		extPro.StartInfo.FileName = pgm;
		extPro.StartInfo.UseShellExecute = false;
		extPro.StartInfo.WorkingDirectory = @"~/repos/PPNM/exercises/plot";
		extPro.Start();

		StreamWriter gnupStWr = extPro.StandardInput;
		gnupStWr.WriteLine("plot \"insert.dat\" with lines ");
		gnupStWr.Flush();
	}
}
