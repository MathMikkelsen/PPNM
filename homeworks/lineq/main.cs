using System;
using static System.Math;
using static System.Console;

public class main{
static void Main(){
	var rnd = new System.Random(1);
	int n = rnd.Next(5,10);
	int m = rnd.Next(4,n-1);
	vector x = new vector(n);
	matrix A = new matrix(n,m);
	for(int i =0; i<n;i++){
		x[i]=rnd.NextDouble();
	}
	for(int j =0; j<m;j++){
		for(int i=0; i<n;i++){
			A[i,j]=rnd.NextDouble();
		}
	}

	var B = QR.decomp(A);
	matrix Q = B.Item1;
	matrix R = B.Item2;
	R.print("R:");
	matrix U = new matrix(B.Item2.size2,B.Item2.size2);
	U.set_unity();
	WriteLine($"Q^T Q = unity is {U.approx(Q.T*Q)}");
	WriteLine($"QR equals A is {A.approx(Q*R)}");

	
	int rand_num =rnd.Next(4,10);
	vector rand_vec = new vector(rand_num);

	for(int i =0;i<rand_vec.size;i++) rand_vec[i]=rnd.NextDouble();
	matrix rand_square = new matrix(rand_num);

	for(int i =0;i<rand_square.size1;i++){
		for(int j =0;j<rand_square.size2;j++) rand_square[i,j] = rnd.NextDouble();
	}

	var C = QR.decomp(rand_square);
	matrix Q1 = C.Item1;
	matrix R1 = C.Item2;
	WriteLine($"QR.det(R)={QR.det(rand_square)}");
	var sol = QR.solve(Q1,R1,rand_vec);

	matrix Q1R1 = Q1*R1;
	vector l_r=Q1R1*sol;
	vector Ax=rand_square*sol;
	WriteLine($"\nRx=Q^Tb is {Ax.approx(l_r)}");
	
}

}
	
