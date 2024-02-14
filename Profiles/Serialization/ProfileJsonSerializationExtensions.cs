using MagmaWorks.Taxonomy.Profiles;
using Newtonsoft.Json;

namespace MagmaWorks.Taxonomy.Serialization.Profiles
{
    public static class ProfileJsonSerializationExtensions
    {
        public static string ToJson<T>(this T profile) where T : IProfile
        {
            return JsonConvert.SerializeObject(profile, Formatting.Indented, TaxonomyJsonSerializer.Settings);
        }

        public static T FromJson<T>(this string json) where T : IProfile
        {
            var settings = TaxonomyJsonSerializer.Settings;
            return typeof(T) switch
            {
                var profile when profile == typeof(IAngle)
                    => (T)(IAngle)JsonConvert.DeserializeObject<Angle>(json, settings),
                var profile when profile == typeof(IC)
                    => (T)(IC)JsonConvert.DeserializeObject<C>(json, settings),
                var profile when profile == typeof(IChannel)
                    => (T)(IChannel)JsonConvert.DeserializeObject<Channel>(json, settings),
                var profile when profile == typeof(ICircularHollow)
                    => (T)(ICircularHollow)JsonConvert.DeserializeObject<CircularHollow>(json, settings),
                var profile when profile == typeof(ICircle)
                    => (T)(ICircle)JsonConvert.DeserializeObject<Circle>(json, settings),
                var profile when profile == typeof(ICruciform)
                    => (T)(ICruciform)JsonConvert.DeserializeObject<Cruciform>(json, settings),
                var profile when profile == typeof(IEllipseHollow)
                    => (T)(IEllipseHollow)JsonConvert.DeserializeObject<EllipseHollow>(json, settings),
                var profile when profile == typeof(IEllipse)
                    => (T)(IEllipse)JsonConvert.DeserializeObject<Ellipse>(json, settings),
                var profile when profile == typeof(II)
                    => (T)(II)JsonConvert.DeserializeObject<I>(json, settings),
                var profile when profile == typeof(ICustomI)
                    => (T)(ICustomI)JsonConvert.DeserializeObject<CustomI>(json, settings),
                var profile when profile == typeof(IRectangularHollow)
                    => (T)(IRectangularHollow)JsonConvert.DeserializeObject<RectangularHollow>(json, settings),
                var profile when profile == typeof(IRectangle)
                    => (T)(IRectangle)JsonConvert.DeserializeObject<Rectangle>(json, settings),
                var profile when profile == typeof(ITee)
                    => (T)(ITee)JsonConvert.DeserializeObject<Tee>(json, settings),
                var profile when profile == typeof(ITrapezoid)
                    => (T)(ITrapezoid)JsonConvert.DeserializeObject<Trapezoid>(json, settings),
                var profile when profile == typeof(IZ)
                    => (T)(IZ)JsonConvert.DeserializeObject<Z>(json, settings),
                _ => default,
            };
        }
    }
}
