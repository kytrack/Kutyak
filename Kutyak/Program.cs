using Kutyak;

List<KutyaNevClass> kutyanevek = new List<KutyaNevClass>();
List<KutyaFajtaClass> kutyafajtak = new List<KutyaFajtaClass>();
List<KutyaClass> kutyak = new List<KutyaClass>();

StreamReader sr = new StreamReader("KutyaNevek.csv");
sr.ReadLine();
while (!sr.EndOfStream)
{
    string[] adatok = sr.ReadLine().Split(";");
    kutyanevek.Add(new KutyaNevClass(int.Parse(adatok[0]), adatok[1]));
}
sr.Close();

StreamReader sr2 = new StreamReader("KutyaFajtak.csv");
sr2.ReadLine();
while (!sr2.EndOfStream)
{
    string[] adatok = sr2.ReadLine().Split(";");
    kutyafajtak.Add(new KutyaFajtaClass(int.Parse(adatok[0]), adatok[1], adatok[2]));
}
sr2.Close();

StreamReader sr3 = new StreamReader("Kutyak.csv");
sr3.ReadLine();
while (!sr3.EndOfStream)
{
    string[] adatok = sr3.ReadLine().Split(";");
    kutyak.Add(new KutyaClass(int.Parse(adatok[0]), int.Parse(adatok[1]), int.Parse(adatok[2]), int.Parse(adatok[3]), adatok[4]));
}
sr3.Close();

Console.WriteLine($"3.feladat: Kutyanevek száma: {kutyanevek.Count()}");

Console.WriteLine($"6.feladat: Kutyák átlag életkora: {Math.Round(kutyak.Average(k => k.Eletkor),2)}");

KutyaClass legidosebbkutya = kutyak.OrderByDescending(k => k.Eletkor).First();
int legidosebbfajtaid = legidosebbkutya.Fajtaid;
int legidosebbnevid = legidosebbkutya.Nevid;

KutyaFajtaClass legidosebbfajtakutya = kutyafajtak.First(k => k.Kutyaid == legidosebbfajtaid);
string legidosebbfajta = legidosebbfajtakutya.Kutyanev;

KutyaNevClass legidosebbnevukutya = kutyanevek.First(k => k.Kutyaid == legidosebbnevid);
string legidosebbnev=legidosebbnevukutya.Kutyanev;

Console.WriteLine($"7.feladat: Legidősebb Kutya neve és fajtája: {legidosebbnev}, {legidosebbfajta}");

int[] januar10esvizsgalatidk=kutyak.Where(k => k.Utolsoell == "2018.01.10").Select(k => k.Fajtaid).ToArray();
string[]fajtak=kutyafajtak.Where(k => januar10esvizsgalatidk.Contains(k.Kutyaid)).Select(k => k.Kutyanev).ToArray();

var ismetlodasNelkuliAdatok = fajtak.Distinct();

Console.WriteLine($"8.feladat: Január 10.-en vizsgált kutya fajták:");
foreach (var adat in ismetlodasNelkuliAdatok)
{
    int adatSzamlalo = fajtak.Count(k => k == adat);
    Console.WriteLine($"\t{adat}: {adatSzamlalo} kutya");
}

var legtobbEll = kutyak.GroupBy(k => k.Utolsoell).OrderByDescending(g => g.Count()).First();
Console.WriteLine($"9.feladat: Legjobban terhelt nap: {legtobbEll.Key}: {legtobbEll.Count()} kutya");

StreamWriter sw = new StreamWriter("névstatisztika.txt", append: true);


var kutyanevekossz = kutyanevek.GroupBy(k => k.Kutyanev).OrderByDescending(k => k.Count());

foreach (var item in kutyanevekossz)
{
    sw.WriteLine($"{item.Key}, {item.Count()}");
}


sw.Close();
Console.WriteLine($"10.feladat: névstatisztika.txt");

