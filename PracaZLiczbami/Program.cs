using System.Numerics;

Console.WriteLine("Praca z wielkimi liczbami");
Console.WriteLine("_________________________");
ulong wielka = ulong.MaxValue;
Console.WriteLine($"{wielka,40:N0}");

BigInteger wieksza = BigInteger.Parse("6723673276641941419499426");
Console.WriteLine($"{wieksza, 40:N0}");
