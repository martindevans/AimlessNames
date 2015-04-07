using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AimlessNames.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ForenameIsCorrectGender()
        {
            Assert.AreEqual("forename_f", Name.Forename(Gender.Female, new Random(1), new LocaleTest()));
            Assert.AreEqual("forename_m", Name.Forename(Gender.Male, new Random(1), new LocaleTest()));
            Assert.AreEqual("forename_n", Name.Forename(Gender.Neutral, new Random(1), new LocaleTest()));
        }

        [TestMethod]
        public void SurnameIsSurname()
        {
            Assert.AreEqual("surname", Name.Surname(new Random(1), new LocaleTest()));
        }

        [TestMethod]
        public void FullNameIsCorrectGender()
        {
            Assert.AreEqual("forename_f surname", Name.FullName(Gender.Female, new Random(1), new LocaleTest()));
            Assert.AreEqual("forename_m surname", Name.FullName(Gender.Male, new Random(1), new LocaleTest()));
            Assert.AreEqual("forename_n surname", Name.FullName(Gender.Neutral, new Random(1), new LocaleTest()));

            Assert.AreEqual("forename_n surname", Name.FullName(Gender.Female, new Random(3), new LocaleTest()));
        }

        [TestMethod]
        public void Demo()
        {
            Random r = new Random(1);

            Console.WriteLine("Neutral...");
            for (int i = 0; i < 5; i++)
                Console.WriteLine(Name.FullName(Gender.Neutral, r, BaseLocale.EnUs));

            Console.WriteLine("Male...");
            for (int i = 0; i < 5; i++)
                Console.WriteLine(Name.FullName(Gender.Male, r, BaseLocale.EnUs));

            Console.WriteLine("Female...");
            for (int i = 0; i < 5; i++)
                Console.WriteLine(Name.FullName(Gender.Female, r, BaseLocale.EnUs));
        }
    }
}
