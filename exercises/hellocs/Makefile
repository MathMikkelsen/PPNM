Out.txt : hello.exe
	mono hello.exe > Out.txt
hello.exe : hello.cs
	mcs -out:hello.exe hello.cs
clean:
	rm --force Out.txt hello.exe
