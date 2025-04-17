using MagmaWorks.Taxonomy.Profiles;

namespace MagmaWorks.Taxonomy.Sections.Exceptions
{
    public class InvalidProfileTypeException : Exception
    {
        public InvalidProfileTypeException(string message) : base(message) { }

        public static void ValidateProfileForFaceReinforcement(IProfile profile)
        {
            switch (profile)
            {
                case IAngle:
                case ICustomI:
                case II:
                case IRectangle:
                case ITee:
                case ITrapezoid:
                    return;

                default:
                    throw new InvalidProfileTypeException($"Unable to create face rebar for {profile.GetType()} profile");
            }
        }
    }
}
