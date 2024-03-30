using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC356x368x129 : SingletonEuropeanBase<UC356x368x129>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UC;
        public override string Label => "UC 356 × 368 × 129";
        public Length Height => new Length(355.6, LengthUnit.Millimeter);
        public Length Width => new Length(368.6, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(17.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(10.4, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UC356x368x129() { }
    }
}
