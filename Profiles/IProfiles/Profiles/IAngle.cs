namespace MagmaWorks.Taxonomy.Profiles
{
    public interface IAngle : IProfile
    {
        Length Height { get; }
        Length Width { get; }
        Length WebThickness { get; }
        Length FlangeThickness { get; }
    }
}
