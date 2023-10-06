int[] pole = {22, 56, 45, 2, 12, 3};

Console.WriteLine(pole.Length);

Console.WriteLine(pole.Max());

Console.WriteLine(pole.Min());

double FinalSum = 0;
for (int i = 0; i < pole.Length; i++)
{
    FinalSum += pole[i];
}
Console.WriteLine(FinalSum);

double FinalProduct = 1;
for (int i = 0; i < pole.Length; i++)
{
    FinalProduct *= pole[i];
}
Console.WriteLine(FinalProduct);

double AritmetickýPrůměr = FinalSum / pole.Length;
Console.WriteLine(AritmetickýPrůměr);

double GeometrickýPrůměr = Math.Pow(FinalProduct, 1d / pole.Length);
Console.WriteLine(GeometrickýPrůměr);

double Median(int[] pole)
{
    Array.Sort(pole);
    if (pole.Length % 2 != 0)
    {
        return pole[pole.Length / 2];
    }
    double Větší = pole[(pole.Length - 0) / 2]; //22
    double Menší = pole[(pole.Length - 2) / 2]; //12
    double T = (Větší + Menší) / 2;
    return T;
}
Console.WriteLine(Median(pole));
Console.ReadLine();

