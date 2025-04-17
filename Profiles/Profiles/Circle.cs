namespace MagmaWorks.Taxonomy.Profiles
{
    public class Circle : ICircle
    {
        public Length Diameter { get; set; }
        public string Description => $"Ø\u2009{Utility.Describe(Diameter)}";

        public Circle(Length diameter)
        {
            Diameter = diameter;
        }
    }
}
