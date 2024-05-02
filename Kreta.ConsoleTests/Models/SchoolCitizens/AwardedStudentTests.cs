using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kreta.Console.Models.SchoolCitizens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Console.Models.SchoolCitizens.Tests
{
    [TestClass()]
    public class AwardedStudentTests
    {
        [TestMethod()]
        public void IsYoungerTestFirstIsYounger()
        {
            AwardedStudent tunde = new AwardedStudent("Üveges Tünde", 17, 15000, false);
            AwardedStudent denes = new AwardedStudent("Dolgos Dénes", 18, 5000, false);

            bool actual = AwardedStudent.IsYounger(tunde, denes);
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void IsYoungerTestLastIsYounger()
        {
            AwardedStudent tunde = new AwardedStudent("Üveges Tünde", 17, 15000, false);
            AwardedStudent denes = new AwardedStudent("Dolgos Dénes", 15, 5000, false);

            bool actual = AwardedStudent.IsYounger(tunde, denes);
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void IsYoungerTestAgeIsEqual()
        {
            AwardedStudent tunde = new AwardedStudent("Üveges Tünde", 17, 15000, false);
            AwardedStudent denes = new AwardedStudent("Dolgos Dénes", 17, 5000, false);

            bool actual = AwardedStudent.IsYounger(tunde, denes);
            Assert.IsFalse(actual);
        }

    }
}