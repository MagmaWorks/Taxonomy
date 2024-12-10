using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public class Circle : ICircle
    {
        public Length Diameter { get; set; }
        public string Description => $"Ø{Utility.Description.Create(Diameter)}";

        public Circle(Length diameter)
        {
            Diameter = diameter;
        }
    }
}
