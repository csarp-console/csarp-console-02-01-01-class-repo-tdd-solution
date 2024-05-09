using Kreta.Console.Models.Scholarship;
using Kreta.Console.Models.SchoolCitizens;
using Kreta.Console.Repos;

AwardedStudent tunde = new AwardedStudent("Üveges Tünde", 17, 1525, true,"9.a",true);
Console.WriteLine(tunde);
AwardedStudent denes = new AwardedStudent("Dolgos Dénes", 18, 5000, false,"9.a", false);

if (tunde.Age > denes.Age)
    Console.WriteLine($"{tunde.Name} idősebb, mint {denes.Age}!");
else if (tunde.Age < denes.Age)
    Console.WriteLine($"{denes.Name} idősebb, mint {tunde.Age}!");
else
    Console.WriteLine("A két diák ugyan annyi éves!");

AwardedStudentRepo awardedStudentRepo = new AwardedStudentRepo();
awardedStudentRepo.Add(tunde);
awardedStudentRepo.Add(denes);
awardedStudentRepo.Add(new AwardedStudent("Szorgalmas Szonja", 16, 6527,true,"9.b",true));
awardedStudentRepo.Add(new AwardedStudent("Mindenttudo Misi", 16, 6514, true, "9.b", false));

double avarage = awardedStudentRepo.GetAwardAvarage();
Console.WriteLine($"\nA havi ösztöndíjak átlaga {avarage} Ft!");

Console.WriteLine("\nÖsztöndíjasok megoszlása nemenként:");
int numberOfWoman = awardedStudentRepo.GetNumberOfGender(true);
int numberOfMan = awardedStudentRepo.GetNumberOfGender(false);
Console.WriteLine($"A fiú diákok száma {numberOfMan} fő.");
Console.WriteLine($"A lány diákok száma {numberOfWoman} fő.");

int oneTimePaymentInYear = awardedStudentRepo.GetOneTimePaymentInYear();
Console.WriteLine($"\nEgy évben {oneTimePaymentInYear} egyszeri kifizetés történt!");

int annualScholarshipAmount=awardedStudentRepo.GetAnnualScholarshipAmount();
Console.WriteLine($"\nEgy ébven kifizetésre kerülő ösztöndíj összege {annualScholarshipAmount} Ft.");

Console.Write("\nAdjon meg egy osztályazonosítót:");
string? schoolClass = Console.ReadLine();
if (schoolClass is not null)
{
    int maxAwarded = awardedStudentRepo.MaxMinAmount(schoolClass, true);
    int minAwarded = awardedStudentRepo.MaxMinAmount(schoolClass, false);
    if (minAwarded < 0 || maxAwarded < 0)
        Console.WriteLine("Nincs ilyen osztály!");
    else
        Console.WriteLine($"Az {schoolClass} osztályban a legnagyobb osztöndíj {maxAwarded}, a legkisebb ösztöndíj {minAwarded}");
}

List<ScholarshipPerScoolClass> scholarshipPerScoolClasses = awardedStudentRepo.GetScholarshipPaidPerScoolClass();
if (!scholarshipPerScoolClasses.Any())
    Console.WriteLine("\nNincs egy osztály sem az adatbázisban!");
else
{
    Console.WriteLine("\nOsztályonként évente a következő ösztöndíj kifizetések történnek:");
    foreach(ScholarshipPerScoolClass ssc in scholarshipPerScoolClasses)
    {
        Console.WriteLine($"{ssc.SchoolClass} osztályban {ssc.Scholarship} Ft kifizetés történik.");
    }
}

List<StudentScholarship> studentScholarships = awardedStudentRepo.GetAdultStudentScholarship();
if (!studentScholarships.Any())
    Console.WriteLine("\nEgy diáknak sem kell adóigazolást kiállítani!");
else
{
    Console.WriteLine("\nA következő diákoknak kell adóigazolást kiállítani:");
    foreach(StudentScholarship studentScholarship in  studentScholarships)
        Console.WriteLine($"{studentScholarship.Name} ({studentScholarship.Award})");
}




