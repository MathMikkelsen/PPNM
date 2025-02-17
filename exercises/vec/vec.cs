using System;
using static System.Math;

public class vec{
	public double x,y,z; /* the three components of a vector */
	public vec(){ x=y=z=0; } // default constructor
	public vec(double x,double y,double z){ // parametrized constructor
		this.x=x; this.y=y; this.z=z;
		}
	
	public static vec operator*(vec v, double c){return new vec(c*v.x,c*v.y,c*v.z);}
	public static vec operator*(double c, vec v){return v*c;}
	public static vec operator/(vec u, double c){
		return new vec(u.x/c,u.y/c,u.z/c);
		}
	public static vec operator+(vec u, vec v){
		return new vec(u.x+v.x,u.y+v.y,u.z+v.z);
		}
	public static vec operator-(vec u){return new vec(-u.x,-u.y,-u.z);}
	public static vec operator-(vec u, vec v){
		return new vec(u.x-v.x,u.y-v.y,u.z-v.z);
		}
	//print method for debugging
	public void print(string s=""){Console.Write(s);Console.WriteLine($"{x} {y} {z}");}
	//Operator methods again
	public double dot(vec other) => this.x*other.x+this.y*other.y+this.z*other.z;
	public static double dot(vec v, vec w) => v.x*w.x+v.y*w.y+v.z*w.z;
	static bool approx(double a,double b,double acc=1e-9,double eps=1e-9){
		if(Abs(a-b)<acc)return true;
		if(Abs(a-b)<(Abs(a)+Abs(b))*eps)return true;
		return false;
		}
	public static double operator%(vec u, vec v){return u.dot(v);}
	public bool approx(vec other){
		if(!approx(this.x,other.x))return false;
		if(!approx(this.y,other.y))return false;
		if(!approx(this.z,other.z))return false;
		return true;
		}
	public static bool approxd(double a, double b){return approx(a,b);}
	public static bool approx(vec u, vec v) => u.approx(v);
	public override string ToString(){ return $"{x} {y} {z}"; }
}
