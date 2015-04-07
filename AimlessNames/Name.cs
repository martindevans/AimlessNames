using System;

namespace AimlessNames
{
    public class Name
    {
        public static string Forename(Gender gender, Random random, params BaseLocale[] locales)
        {
            return locales[random.Next(locales.Length)].Forename(gender, random);
        }

        public static string Surname(Random random, params BaseLocale[] locales)
        {
            return locales[random.Next(locales.Length)].Surname(random);
        }

        public static string FullName(Gender gender, Random random, params BaseLocale[] locales)
        {
            return string.Format("{0} {1}", Forename(gender, random, locales), Surname(random, locales));
        }
    }
}
