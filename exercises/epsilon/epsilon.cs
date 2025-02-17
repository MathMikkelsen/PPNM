using System;


class Epsilon{
public static bool approx(double a, double b, double acc=1e-9, double eps=1e-9){
	return Math.Abs(a-b)<= acc;
}
static int Main(){
	double x=1;
	float y=1F;
	double d1 = 0.1+0.1+0.1+0.1+0.1+0.1+0.1+0.1;
	double d2 = 8*0.1;
	while(1+x!=1){
		x/=2;
	}
	x*=2;
	Console.WriteLine($"lowest double x={x}");
	while((float)(1F+y) != 1F){
		y/=2F;
	}
	y*=2F;
	Console.WriteLine($"lowest float y={y}");
	double epsilon =Math.Pow(2,-52);
	double tiny = epsilon/2;
	double a=1+tiny+tiny;
	double b=tiny+tiny+1;
	Console.WriteLine($"a==b ? {a==b}");
	Console.WriteLine($"a>1 ? {a>1}");
	Console.WriteLine($"b>1 = {b>1}");
	Console.WriteLine("The reason it fails for a is that it adds a number under the machine epsilon, which still gives 1");
	Console.WriteLine($"{approx(d1,d2)}");

	return 0;
}
}
