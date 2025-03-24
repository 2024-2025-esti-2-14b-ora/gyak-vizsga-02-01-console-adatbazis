using ScholarshipApplicationProject.Console.Models;
using ScholarshipApplicationProject.Console.Repo;
using System.Reflection.Metadata;


Console.WriteLine("1. feladat");
try
{
    ScholarshipApplicant empty = new ScholarshipApplicant("", "Null");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine("2. feladat");
ScholarshipApplicant odon = new ScholarshipApplicant("odon@nyertes.hu", "Ösztöndíj Ödön");
Console.WriteLine(odon);

Console.WriteLine("3. feladat");
try
{
    odon.Win(-30000);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine("4. feladat");
odon.Win(20000);
odon.Win(30000);
Console.WriteLine(odon);

Console.WriteLine("5. feladat");
ScholarshipRepo repo = new ScholarshipRepo();
Console.WriteLine($"{repo.GetNumberOfScholarship()} öszdíjas van.");

Console.WriteLine("6. feladat");
repo.AddScholarship(new ScholarshipApplicant("ugyeske@suli.net", "Ügyeske Ignác"));

Console.WriteLine("5. feladat");
Console.WriteLine($"{repo.GetNumberOfScholarship()} öszdíjas van.");

repo.RemoveSholarship("bob@example.com");
Console.WriteLine("5. feladat");
Console.WriteLine($"{repo.GetNumberOfScholarship()} öszdíjas van.");
