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
            return FullName(gender, random, true, locales);
        }

        public static string FullName(Gender gender, Random random, bool multiLocale = true, params BaseLocale[] locales)
        {
            //If we're not multicultural then pick a single locale now...
            //...this will force surname and forename to use the same culture (since they only have one option to pick from)
            if (!multiLocale)
                locales = new BaseLocale[1] { locales[random.Next(locales.Length)] };

            return string.Format("{0} {1}", Forename(gender, random, locales), Surname(random, locales));
        }
    }
}
