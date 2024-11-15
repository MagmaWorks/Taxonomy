using System.Collections.Generic;
using MagmaWorks.Taxonomy.Materials;
using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Sections.Exceptions;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Sections
{
    public class ConcreteSection : Section, IConcreteSection
    {
        public IList<ILongitudinalReinforcement> Rebars { get; set; } = new List<ILongitudinalReinforcement>();
        public IRebar Link { get; set; }
        public Length Cover { get; set; } = Length.Zero;

        public ConcreteSection(IProfile profile, IMaterial material) : base(profile, material)
        {
            if (material.Type != MaterialType.Concrete)
            {
                throw new InvalidMaterialTypeException("Material type must be Concrete");
            }
        }

        public ConcreteSection(IProfile profile, IMaterial material, IList<ILongitudinalReinforcement> rebars, IRebar link, Length cover)
            : base(profile, material)
        {
            if (material.Type != MaterialType.Concrete)
            {
                throw new InvalidMaterialTypeException("Material type must be Concrete");
            }

            Rebars = rebars;
            Link = link;
            Cover = cover;
        }

        public void AddRebars(IRebar rebar, int numberOfBars, SectionFace face)
        {

        }

        public void AddRebars(IRebar rebar, Length spacing, SectionFace face)
        {

        }

        public void AddRebars(IRebar rebar, int numberOfBars)
        {

        }

        public void AddRebars(IRebar rebar, Length spacing)
        {

        }
    }
}
