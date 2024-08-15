int[] tamsayilar = new int[10];

for (int i = 0; i < tamsayilar.Length; i++)
{
    Console.WriteLine($"Lütfen {i+1}. sayıyı giriniz:");
    tamsayilar[i] = int.Parse(Console.ReadLine());
}

foreach (int i in tamsayilar)
{
    Console.WriteLine(i);
}

Console.WriteLine("Diziye eklemek istediğin 11. elemanı giriniz");
int yeniSayi = int.Parse(Console.ReadLine());

int[] yeniDizi = new int[tamsayilar.Length + 1];

for (int i = 0; i< tamsayilar.Length; i++)
{
    yeniDizi[i] = tamsayilar[i];
}

yeniDizi[yeniDizi.Length - 1] = yeniSayi;

Console.WriteLine("_________________________________");

var shortednumber = yeniDizi.OrderByDescending(n => n);

foreach (int number in shortednumber)
{
    Console.WriteLine(number);
}