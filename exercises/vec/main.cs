using static System.Console;
using static System.Math;

static class main{

public static void print(this double x, string s=""){Write(s);WriteLine(x);}

static int Main(){
	var rnd=new System.Random();
	var u=new vec(rnd.NextDouble(),rnd.NextDouble(),rnd.NextDouble());
	var v=new vec(rnd.NextDouble(),rnd.NextDouble(),rnd.NextDouble());
	u.print("u=");
	v.print("v=");
	WriteLine($"u={u}");
	WriteLine($"v={v}");
	WriteLine();
	vec t;

	t=new vec(-u.x,-u.y,-u.z);
	(-u).print("-u =");
	t.print("t =");
	if(vec.approx(t,-u))WriteLine("test 'unary -' passed\n");
	
	t=new vec(u.x-v.x,u.y-v.y,u.z-v.z);
	(u-v).print("u-v =");
	t.print("t =");
	if(vec.approx(t,u-v))WriteLine("test 'operator-' passed\n");

	t=new vec(u.x+v.x,u.y+v.y,u.z+v.z);
	(u+v).print("u+v =");
	t.print("t =");
	if(vec.approx(t,u+v))WriteLine("test 'operator+' passed\n");

	double c=rnd.NextDouble();
	t=new vec(u.x*c,u.y*c,u.z*c);
	var tmp=u*c; //bug in mcs
	tmp.print("u*c =");
	t.print("t =");
	if(vec.approx(t,u*c))WriteLine("test 'operator*' passed\n");
	
	double d = u.x*v.x+u.y*v.y+u.z*v.z;
	(u%v).print("u%v=");
	d.print("d =");
	if(vec.approxd(d,u%v))WriteLine("test 'operator%' passed\n");

	t=new vec(u.y*v.z-u.z*v.y,u.z*v.x-u.x*v.z,u.x*v.y-u.y*v.x);
	vec.cross(u,v).print("u cross v =");
	t.print("t =");
	if(vec.approx(t,vec.cross(u,v)))WriteLine("test 'crossproduct' passed\n");

	double norm = Sqrt(u%u);
	double unorm = u.norm();
	double vecnorm = vec.norm(u);
	norm.print("Sqrt(u%u) =");
	unorm.print("u.norm() =");
	vecnorm.print("vec.norm(u) =");
	if(vec.approxd(norm,unorm))WriteLine("test 'object norm' passed\n");
	if(vec.approxd(norm,vecnorm))WriteLine("test 'static norm' passed\n");


	return 0;
	}	

}
