using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kreta.Console.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kreta.Console.Models.SchoolCitizens;

namespace Kreta.Console.Repos.Tests
{
    [TestClass()]
    public class AwardedStudentRepoTests
    {
        [TestMethod()]
        public void YoungestAwardedStudentTestEmptyRepo()
        {
            AwardedStudentRepo awardedStudentRepo = new AwardedStudentRepo();
            string actual = awardedStudentRepo.GetYoungestAwardedStudentName();
            string expected = string.Empty;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void YoungestAwardedStudentTestMoreStudent()
        {
            AwardedStudentRepo awardedStudentRepo = new AwardedStudentRepo();
            AwardedStudent tunde = new AwardedStudent("Üveges Tünde", 17, 1525, true, "9.a", true);
            AwardedStudent denes = new AwardedStudent("Dolgos Dénes", 18, 5000, false, "9.a", false);
            awardedStudentRepo.Add(tunde);
            awardedStudentRepo.Add(denes);
            awardedStudentRepo.Add(new AwardedStudent("Szorgalmas Szonja", 14, 6527, true, "9.b", true));
            awardedStudentRepo.Add(new AwardedStudent("Mindenttudo Misi", 15, 6514, true, "9.b", false));
            awardedStudentRepo.Add(tunde);
            string actual = awardedStudentRepo.GetYoungestAwardedStudentName();
            string expected = "Szorgalmas Szonja";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void YoungestAwardedStudentTestMoreYoungestStudent()
        {
            AwardedStudentRepo awardedStudentRepo = new AwardedStudentRepo();
            AwardedStudent tunde = new AwardedStudent("Üveges Tünde", 17, 1525, true, "9.a", true);
            AwardedStudent denes = new AwardedStudent("Dolgos Dénes", 16, 5000, false, "9.a", false);
            awardedStudentRepo.Add(tunde);
            awardedStudentRepo.Add(denes);
            awardedStudentRepo.Add(new AwardedStudent("Szorgalmas Szonja", 16, 6527, true, "9.b", true));
            awardedStudentRepo.Add(new AwardedStudent("Mindenttudo Misi", 17, 6514, true, "9.b", false));
            awardedStudentRepo.Add(tunde);
            string actual = awardedStudentRepo.GetYoungestAwardedStudentName();
            string expected = "Dolgos Dénes";
            Assert.AreEqual(expected, actual);
        }

    }
}