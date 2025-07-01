using MagmaWorks.Taxonomy.Materials;

namespace MagmaWorks.Taxonomy.Sections.Reinforcement
{
    public class Link : Rebar, ILink
    {
        public Length MinimumMandrelDiameter
        {
            get => _minimumMandrelDiameter.HasValue
                    ? _minimumMandrelDiameter.Value
                    : new Length(Diameter.Millimeters > 16
                    ? Diameter.Millimeters * 7 : Diameter.Millimeters * 4, LengthUnit.Millimeter);
            set
            {
                _minimumMandrelDiameter = value;
            }
        }

        private Length? _minimumMandrelDiameter;

        public Link(IMaterial material, Length diameter) : base(material, diameter) { }

        public Link(IMaterial material, BarDiameter diameter) : base(material, diameter) { }

        public Link(IRebar rebar) : base(rebar.Material, rebar.Diameter) { }
    }
}
