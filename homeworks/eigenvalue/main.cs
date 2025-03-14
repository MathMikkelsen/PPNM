using System;
using static System.Math;
using static System.Console;

public class main{

	static void Main(){
		var rnd = new System.Random();
		int n = rnd.Next(5,10);
		matrix A = new matrix(n,n);
		for(int j =0; j<n;j++){
			for(int i=0; i<n;i++){
				A[i,j]=rnd.NextDouble()*10.0;
			}
		}
		matrix Asym = (A+A.transpose())/2;
		Asym.print("A:");
		
		var wVD = jacobi.cyclic(Asym);
		wVD.Item3.print("D:");
		matrix V = wVD.Item2;
		matrix D = wVD.Item3;
		
		var VAVt = V*D*V.transpose();
		VAVt.print("VAVt:");
		var id = matrix.id(V.size1);
		WriteLine($"A=VDVt is {Asym.approx(VAVt)}");
		WriteLine($"VtAV=D is {(V.transpose()*Asym*V).approx(D)}");
		WriteLine($"VVt=1 is {(V*V.transpose()).approx(id)}");
		WriteLine($"VtV=1 is {(V.transpose()*V).approx(id)}");
	}

}
