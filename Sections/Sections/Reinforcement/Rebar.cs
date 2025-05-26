using MagmaWorks.Taxonomy.Materials;
using MagmaWorks.Taxonomy.Sections.Exceptions;

namespace MagmaWorks.Taxonomy.Sections.Reinforcement
{
    public class Rebar : IRebar
    {
        public Length Diameter { get; set; }
        public IMaterial Material { get; set; }

        public Rebar(IMaterial material, Length diameter)
        {
            if (material.Type != MaterialType.Reinforcement)
            {
                throw new InvalidMaterialTypeException("Material type must be Reinforcement");
            }

            Material = material;
            Diameter = diameter;
        }

        public Rebar(IMaterial material, BarDiameter diameter)
        {
            if (material.Type != MaterialType.Reinforcement)
            {
                throw new InvalidMaterialTypeException("Material type must be Reinforcement");
            }

            Material = material;
            Diameter = new Length((double)diameter, LengthUnit.Millimeter);
        }
    }
}
