Out.txt : main.exe
	mono main.exe -numbers:1,2,3,4,5 > Out.txt

main.exe: cCommand.cs
	mcs -target:exe -out:main.exe cCommand.cs
mainf.exe: fStreams.cs
	mcs -target:exe -out:main.exe fStreams.cs

clean:
	rm -f Out.txt main.exe
