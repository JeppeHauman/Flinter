namespace Flinter
{
    /// <summary>
    /// This class represents a person profile,
    /// for instance for a dating website
    /// </summary>
    public class Profile
    {
        #region Instance fields
        private Gender _gender;
        private EyeColor _eyeColor;
        private HairColor _hairColor;
        private HeightCategory _heightCategory;
        #endregion

        public enum HairColor {Brown, Leverpostej, White, Blue, Purple, Pink, Black}

        public enum EyeColor {Brown, Blue, Green, Grey}

        public enum Gender {Woman, Man}

        public enum HeightCategory {VeryShort, Short, MediumHeight, Tall}



        #region Constructor
        public Profile(Gender Gender, EyeColor EyeColor, HairColor HairColor, HeightCategory HeightCategory)
        {
            _gender = Gender;
            _eyeColor = EyeColor;
            _hairColor = HairColor;
            _heightCategory = HeightCategory;
        }

        #endregion

        #region Properties
        public string Description
        {
            get
            {
                return $"You got a {_gender} with {_eyeColor} eyes and {_hairColor} hair, who is {_heightCategory}";
            }
        }
        #endregion
    }
}