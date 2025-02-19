using System;
using static System.Math;
using System.Globalization;
using static System.Console;

public class ccalc{

public static void Main(){
	complex c = new complex(-1,0);
	complex d = new complex(0,1);
	WriteLine(cmath.sqrt(c));
	WriteLine(cmath.sqrt(c).approx(d));
	
	var v1 = cmath.log(d);
	complex b = new complex(0,PI/2);
	var v2 = cmath.log(cmath.exp(b));
	cmath.print(b);
	cmath.print(v1);
	cmath.print(v2);
	WriteLine($"ln(i)=ln(e^iPi/2) {v1.approx(v2)}");
	WriteLine($"ln(i)=iPi/2) {v1.approx(b)}");
	WriteLine($"ln(e^iPi/2)=iPi/2 {v2.approx(b)}");
	
	v1 = cmath.sqrt(complex.I);
	cmath.print(v1);
	v2 = cmath.exp(cmath.log(complex.I)/2);
	cmath.print(v2);
	var v3 = cmath.exp(complex.I*PI/4);
	cmath.print(v3);
	var v4 = cmath.cos(PI/4)+complex.I*cmath.sin(PI/4);
	cmath.print(v4);
	complex b2 = new complex(1/Sqrt(2),1/Sqrt(2));
	cmath.print(b2);
	
	WriteLine(v1.approx(v2));
	WriteLine(v2.approx(v3));
	WriteLine(v3.approx(v4));
	WriteLine(v4.approx(b2));

	v1 = cmath.pow(complex.I,complex.I);
	v2 = cmath.exp(complex.I*cmath.log(complex.I));
	v3 = cmath.exp(-PI/2);
	v4 = new complex(0.208,0.0);
	cmath.print(v3);
	cmath.print(v4);
	WriteLine(v1.approx(v2));
	WriteLine(v2.approx(v3));
	WriteLine(v3.approx(v4));
}

}
