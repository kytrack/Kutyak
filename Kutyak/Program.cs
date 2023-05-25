using Kutyak;

List<KutyaClass> kutyak = new List<KutyaClass>();

StreamReader sr = new StreamReader("KutyaNevek.csv");
sr.ReadLine();
while (!sr.EndOfStream)
{
    string[] adatok = sr.ReadLine().Split(";");
    kutyak.Add(new KutyaClass(int.Parse(adatok[0]), adatok[1]));
}
sr.Close();

StreamReader sr2 = new StreamReader("KutyaNevek.csv");
sr2.ReadLine();
while (!sr.EndOfStream)
{
    string[] adatok = sr2.ReadLine().Split(";");
    kutyak.Add(new KutyaClass(int.Parse(adatok[0]), adatok[1]));
}
sr2.Close();

Console.WriteLine($"3.feladat: Kutyanevek száma: {kutyak.Count()}");