Out.txt : main.exe
	mono main.exe > Out.txt

main.exe : epsilon.cs
	mcs epsilon.cs -target:exe -out:main.exe

clean:
	rm -f Out.txt main.exe
