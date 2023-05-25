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

