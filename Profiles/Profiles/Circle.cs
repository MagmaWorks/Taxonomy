using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles
{
    public class Circle : ICircle
    {
        public Length Diameter { get; set; }
        public string Description => $"Ø{Utility.Describe(Diameter)}";

        public Circle(Length diameter)
        {
            Diameter = diameter;
        }
    }
}
