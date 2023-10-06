int[] pole = { 12, 5, 58 };
Console.WriteLine(pole[0]);
pole[1] = 8;
Console.WriteLine(pole[1]);

int delka = pole.Length;
Console.WriteLine(delka);
Array.Sort(pole); //řazení pole
for (int i = 0; i < delka; i++)
{
    Console.WriteLine(pole[i]);
}

Console.WriteLine("výpis pomocí foreach");
foreach (int prvek in pole)
{
    Console.WriteLine(prvek);
    Console.WriteLine(pole.Contains(0));
    Console.WriteLine(pole.Contains(58));
}


Console.ReadLine();


