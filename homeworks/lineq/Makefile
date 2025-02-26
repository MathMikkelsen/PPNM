Out.txt: main.exe
	mono main.exe > Out.txt

main.exe : main.cs matrix.dll
	mcs -target:exe -out:main.exe -reference:matrix.dll $<

matrix.dll : vector.cs matrix.cs QR.cs
	mcs -target:library -out:matrix.dll $^
clean:
	rm -f main.exe Out.txt
