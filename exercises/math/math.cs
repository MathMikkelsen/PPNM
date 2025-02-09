using System;

class math{
static int Main(){
	double sqrt2=System.Math.Sqrt(2.0);
	System.Console.WriteLine($"Sqrt(2) = {sqrt2}");
	double root5=System.Math.Pow(2.0,(1.0/5));
	System.Console.WriteLine($"2**1/5 = {root5}");
	double expPi=System.Math.Exp(System.Math.PI);
	System.Console.WriteLine($"e**(pi)= {expPi}");
	double Piexp=System.Math.Pow(System.Math.PI,System.Math.E);
	System.Console.WriteLine($"pi**(e)= {Piexp}");
	return 0;
}
}
