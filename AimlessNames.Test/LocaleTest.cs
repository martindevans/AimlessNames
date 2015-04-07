namespace AimlessNames.Test
{
    public class LocaleTest
        : BaseLocale
    {
        private readonly static string[] _maleForenames = {
            "forename_m"
        };

        private readonly static string[] _femaleForenames = {
            "forename_f"
        };

        private readonly static string[] _neutralForenames = {
            "forename_n"
        };

        private readonly static string[] _surnames = {
            "surname"
        };

        public LocaleTest()
            : base(_maleForenames, _femaleForenames, _neutralForenames, _surnames)
        {
            
        }
    }
}
