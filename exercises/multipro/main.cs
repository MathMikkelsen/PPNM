using System;
using static System.Math;

public class mT{

public static void Main[string args](){
	int nthreads = 1, nterms = (int)1e8;
	foreach(var arg in args){
		var words = arg.Split(':');
		if(words[0]=="-threads") nthreads=int.Parse(words[1]);
		if(words[0]=="-terms") nterms=(int)float.Parse(words[1]);
	}
	data[] params = new data[nthreads];
	for(int i =0;i<nthreads;i++){
		params[i] = new data();
		params[i].a = 1+nterms/nthreads*i;
		params[i].b = 1+nterms/nthreads*(i+1);
	}
	var threads = new System.Threading.Thread[nthreads];
	for(int i =0;i<nthreads;i++){
		threads[i] = new System.Threading.Thread(harm);
		threads[i].Start(params[i]);
	}
	foreach(var thread in threads) thread.Join();
	double total = 0; foreach(var p in params) total+=p.sum;
}

}
