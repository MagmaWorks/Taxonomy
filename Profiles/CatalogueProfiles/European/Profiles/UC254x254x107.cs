using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC254x254x107 : SingletonEuropeanBase<UC254x254x107>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UC;
        public override string Label => "UC 254 × 254 × 107";
        public Length Height => new Length(266.7, LengthUnit.Millimeter);
        public Length Width => new Length(258.8, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(20.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(12.8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(13, LengthUnit.Millimeter);

        public UC254x254x107() { }
    }
}
