// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//tablica 40 elementowa

int[] tablicaLiczbFibbonacciego = new int[40];
tablicaLiczbFibbonacciego[0] = 0;
tablicaLiczbFibbonacciego[1] = 1;
for (int i = 2; i < tablicaLiczbFibbonacciego.Length; i++)
{
    tablicaLiczbFibbonacciego[i] = 
        tablicaLiczbFibbonacciego[i - 1] 
        + tablicaLiczbFibbonacciego[i - 2];
}

//wypisz tablicę
Console.WriteLine("tablica liczb Fibbonacciego: ");
foreach(int wartosc in tablicaLiczbFibbonacciego)
{
    Console.Write(wartosc+", ");
}

//wypisz w postaci: element nr 0: wartość tego elementu
Console.WriteLine();
Console.WriteLine("liczby Fibonacciego nr:wartosc");
for(int i = 0; i < tablicaLiczbFibbonacciego.Length; i++)
{
    Console.WriteLine("tablica[" + i + "]=  " + tablicaLiczbFibbonacciego[i]);
}


Console.WriteLine("podaj liczbę");
int liczbaWpisana = int.Parse(Console.ReadLine());
int gornaLiczbaFib=0,dolnaLiczbaFib=0;
//wyszukiwanie liniowe
for (int i = 0;i<tablicaLiczbFibbonacciego.Length;i++)
{
    if (liczbaWpisana > tablicaLiczbFibbonacciego[i])
    {
        continue;
    }
    else
    {
        gornaLiczbaFib = tablicaLiczbFibbonacciego[i];
        dolnaLiczbaFib = tablicaLiczbFibbonacciego[i - 1];
        break;
    }
}

Console.WriteLine("gorna " + gornaLiczbaFib);
Console.WriteLine("dolna " + dolnaLiczbaFib);
Console.WriteLine("szukana " + liczbaWpisana);

if(liczbaWpisana - dolnaLiczbaFib > gornaLiczbaFib - liczbaWpisana)
{
    Console.WriteLine("bliżej " + gornaLiczbaFib);
}
else
{
    Console.WriteLine("bliżej " + dolnaLiczbaFib);
}
