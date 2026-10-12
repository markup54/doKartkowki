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

//na cel wyszukiwanie binarne

//kolejna wersja na kartkówkę

//wylosuj 30 liczb z zakresu <50 do 100> do listy 
Random random = new Random();
List<int> listaLiczbWylosowanych = new List<int>();
for (int i = 0; i < 30; i++)
{
    listaLiczbWylosowanych.Add(random.Next(50,101));
}

//wypisz liczby wylosowane
Console.WriteLine("liczby wylosowane:");
for (int i = 0;i < 30; i++)
{
    Console.Write(listaLiczbWylosowanych[i]+" ** ");
}


//wypisz liczby wylosowane bez powtórzeń

HashSet<int> zbiorLiczbWylosowanych = 
    new HashSet<int>(listaLiczbWylosowanych);
Console.WriteLine();
Console.WriteLine("liczby wylosowane bez powtórzeń :");
foreach (int wartosc in zbiorLiczbWylosowanych)
{
    Console.Write(wartosc+" -- ");
}

//inaczej
HashSet<int> zbior2 = new HashSet<int>();
for (int i = 0; i < 30; i++)
{
    zbior2.Add(listaLiczbWylosowanych[i]);
}

//znajdz liczbę która została wylosowana najczęściej

int maksymalnewystapienie = 0;
List<int> maksymalne = new List<int>();
foreach(int wartosc in zbior2)
{
    if(maksymalnewystapienie == policz(wartosc, listaLiczbWylosowanych))
    {
        maksymalne.Add(wartosc);
    }
    else
    if (maksymalnewystapienie < policz(wartosc, listaLiczbWylosowanych))
    {
        maksymalnewystapienie = policz(wartosc, listaLiczbWylosowanych);
        maksymalne = new List<int>();
        maksymalne.Add(wartosc);
    }
   
        Console.WriteLine(wartosc + " " + policz(wartosc, listaLiczbWylosowanych));
}

//oblicz średnią wylosowanych liczb

int policz(int wartosc , List<int> lista)
{
    int ile = 0;
    for (int i = 0; i < lista.Count; i++)
    {
        if(wartosc == lista[i])
        {
            ile++;
        }
    }
    return ile;

}
