using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles
{
    public class Circle : ICircle
    {
        public Length Diameter { get; set; }

        public Circle(Length diameter)
        {
            Diameter = diameter;
        }
    }
}
