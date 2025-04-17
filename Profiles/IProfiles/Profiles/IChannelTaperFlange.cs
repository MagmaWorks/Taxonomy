namespace MagmaWorks.Taxonomy.Profiles
{
    public interface IChannelTaperFlange : IChannel
    {
        Length FilletRadius { get; }
        Length ToeRadius { get; }
        Length WebHeight { get; }
    }
}
