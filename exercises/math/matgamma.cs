using System;
using static sfuns;

class calc{
static int Main(){
	double x = 0.0;
	System.Console.WriteLine("Gamma");
	while(x<=10){
		System.Console.WriteLine(fgamma(x));
		x++;
	}
	x=0.0;
	System.Console.WriteLine("lnGamma");
	while(x<=10){
		System.Console.WriteLine(lngamma(x));
		x++;
	}
	return 0;
}
}
