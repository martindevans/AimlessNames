# Aimless Names
Aimless names is a procedural name generator which will generate appropriate names for people. Aimless Names is aware of both gender and cultures.

### TL;DR Just Give Me A Name

    Random r = new Random();
    
    //Return a string for the first name
    var forename = Name.Forename(Gender.Female, r, BaseLocale.EnUs);
    
    //Return a string for the last name
    var surname = Name.Surname(Gender.Female, r, BaseLocale.EnUs);
    
    //Return a space separated string of the first and last name
    var fullname = Name.FullName(Gender.Neutral, r, BaseLocale.EnUs);
    
### Genders

Aimless names has three options for gender: Male, Female and Neutral. When generating a forename you must specify one of these options. If you specify neutral, you will get a gender neutral names (e.g. *Robin*), if you specify a specific gender you will get *either* a names specific to that gender or a neutral name.

Surnames are not gendered and when you generate a surname you do not need to specify a gender.

Some example names:

 - **Neutral**:  Leslie, Kerry, Casey, Payton, Angel
 - **Male**: Oliver, Fredrick, Gael, Robert, Michael
 - **Female**: Morgan, Whitney, Arline, Caitlin, Amanda

### Locales

Different cultures have very different sounding names. All of the examples above are from the EnUs (English, United States) locale. When generating a name you may pass in *multiple* locales, a random locale will be chosen for the forename and surname. To ensure that the same locale is used for the forename and surname you may set the "multiLocale" flag to false:

    var n = Name.FullName(Gender.Neutral, r, multiCultural: false, BaseLocale.EnUs);

As is obvious from these example, locales have a default instance attached to the BaseLocale class as a static property. The property has a name based on the [language culture name](https://msdn.microsoft.com/en-us/library/ee825488(v=cs.20).aspx).

#### Adding New Locales

Currently there is only one supported locale, en-US. Luckily contributing a new locale is pretty easy! All you need is a great big list of names. The en-US locale uses a list of the most common names for the last 100 years of US census data, finding this list and extracting the data is often the hardest part! Once you have the data you can simply create a new locale like this:

     class LocaleAbCd : BaseLocale
     {
         private static readonly string[] _maleForenames = { /* data goes here */ };
         private static readonly string[] _femaleForenames = { /* data goes here */ };
         private static readonly string[] _neutralForenames = { /* data goes here */ };
         private static readonly string[] _surnames = { /* data goes here */ };
     
        public LocaleAbCd()
          : base(_maleForenames, _femaleForenames, _neutralForenames, _surnames)
        {
        }
     }
   
That's it! You can use your new locale right away. If you want to submit your locale to be included in the package just add a new static readonly field to the BaseLocale class and submit a [Pull Request ](https://github.com/martindevans/AimlessNames/pulls).