
using System;
using System.Collections.Generic;
using AimlessNames.Locales;

namespace AimlessNames
{
    public abstract class BaseLocale
    {
        public static readonly BaseLocale EnUs = new LocaleEnUs();

        private readonly string[] _maleFornames;
        private readonly string[] _femaleForenames;
        private readonly string[] _neutralForenames;

        private readonly string[] _surnames;

        protected BaseLocale(string[] maleFornames, string[] femaleForenames, string[] neutralForenames, string[] surnames)
        {
            _maleFornames = maleFornames;
            _femaleForenames = femaleForenames;
            _neutralForenames = neutralForenames;

            _surnames = surnames;
        }

        public string Forename(Gender gender, Random random)
        {
            return SelectOption(random, gender, _maleFornames, _femaleForenames, _neutralForenames);
        }

        public string Surname(Random random)
        {
            return SelectOption(random, _surnames);
        }

        public string FullName(Gender gender, Random random)
        {
            return string.Format("{0} {1}", Forename(gender, random), Surname(random));
        }

        private static string SelectOption(Random random, Gender gender, IList<string> male, IList<string> female, IList<string> neutral)
        {
            if (gender == Gender.Neutral)
                return SelectOption(random, neutral);
            return SelectOption(random, gender == Gender.Female ? female : male, neutral);
        }

        private static string SelectOption(Random random, IList<string> gendered, IList<string> neutral)
        {
            int index = random.Next(gendered.Count + neutral.Count);

            if (index < gendered.Count)
                return gendered[index];
            return neutral[index - gendered.Count];
        }

        private static string SelectOption(Random random, IList<string> options)
        {
            return options[random.Next(options.Count)];
        }
    }
}
