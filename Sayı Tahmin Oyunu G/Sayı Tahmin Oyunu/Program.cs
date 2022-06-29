Console.WriteLine("*********************************** 1 ile 1000 arası rastgele sayıyı bulma***************************************");



int tahmin = 0;
int hafiza;
int sayac = 0;

Random rastgele = new Random();
hafiza = rastgele.Next(1, 1001);
while (tahmin != hafiza)
{
    sayac++;
    Console.WriteLine("Sayı Girin: ");
    tahmin = Convert.ToInt32(Console.ReadLine());

    if(tahmin> hafiza)
    {
        Console.WriteLine("daha küçük sayı girin: ");

    }
    else if (tahmin< hafiza)
    {
        Console.WriteLine("daha büyük sayı girin: ");
    }
}
Console.WriteLine("Tebriklerr.....");
Console.WriteLine("{0}. denemede buldunuz", sayac);
Console.Read();
