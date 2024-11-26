using MagmaWorks.Taxonomy.Materials;
using MagmaWorks.Taxonomy.Sections.Exceptions;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Sections
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
    }
}
