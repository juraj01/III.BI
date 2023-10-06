Console.WriteLine("Vitaj v našej kalkulačke");
int i = 0;
while (i == 0)
{
	Console.WriteLine("Zadaj prvé číslo:");
	float a = float.Parse(Console.ReadLine());
	Console.WriteLine("Zadaj druhé číslo:");
	float b = float.Parse(Console.ReadLine());
	Console.WriteLine("Zvoľte si operáciu:");
	Console.WriteLine("1 - sčítanie");
	Console.WriteLine("2 - odčítanie");
	Console.WriteLine("3 - násobenie");
	Console.WriteLine("4 - delenie");
	int volba = int.Parse(Console.ReadLine());
	float vysledok = 0;
	switch (volba)
	{
		case 1:
			vysledok = a + b;
			break;
		case 2:
			vysledok = a - b;
			break;
		case 3:
			vysledok = a * b;
			break;
		case 4:
			vysledok = a / b;
			break;
	}
	if ((volba > 0) && (volba < 5))
		Console.WriteLine("Výsledok: {0}", vysledok);
	else
		Console.WriteLine("Neplatná voľba");
	Console.WriteLine("Ďakujem za použitie kalkulačky.");
}
Console.ReadKey();
