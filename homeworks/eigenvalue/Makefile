Out.txt: main.exe
	mono main.exe > out.txt

main.exe : main.cs EVD.cs matrix.dll
	mcs -target:exe -out:main.exe -reference:matrix.dll EVD.cs $<

matrix.dll : vector.cs matrix.cs
	mcs -target:library -out:matrix.dll $^
clean:
	rm -f main.exe Out.txt matrix.dll
