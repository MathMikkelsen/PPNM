using System;
using static System.Math;
using static System.Console;

public partial class QR{
	public static (matrix,matrix) decomp(matrix A){
		matrix Q=A.copy();
		matrix R=new matrix(A.size2,A.size2);
		/* orthogonalize Q and fill-in R */
		for(int i=0;i<A.size2;i++){
			R[i,i]=Q[i].norm();
			Q[i]/=R[i,i];
			for(int j=i+1;j<A.size2;j++){
				R[i,j]=Q[i].dot(Q[j]);
				Q[j]-=Q[i]*R[i,j];
			}
		}
		return (Q,R);
	}
	public static vector solve(matrix Q, matrix R, vector b){
		vector c=Q.T*b;
		for(int i=c.size-1; i>=0; i--){
			double sum =0;
			for(int k=i+1; k<c.size; k++){
				sum+=R[i,k]*c[k];
			}
			c[i]=(c[i]-sum)/R[i,i];
		}
		return c;
	}
	public static double det(matrix R){
		var r=1.0;
		for(int i =0; i<R.size1;i++){
			r*=R[i,i];
		}
		return Abs(r);
	}
	public static matrix inverse(matrix Q, matrix R){
		matrix I = new matrix(Q.size1, Q.size2);
		for(int i=0;i<Q.size1;i++){
			vector ei = new vector(Q.size1);
			ei[i]= 1;
			I[i] = QR.solve(Q,R,ei);
		}
		return I;
	}
}
