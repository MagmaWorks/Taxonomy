using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB610x229x125 : SingletonEuropeanBase<UB610x229x125>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UB;
        public override string Designation => "UB 610 × 229 × 125";
        public Length Height => new Length(612.2, LengthUnit.Millimeter);
        public Length Width => new Length(229, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(19.6, LengthUnit.Millimeter);
        public Length WebThickness => new Length(11.9, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(13, LengthUnit.Millimeter);

        public UB610x229x125() { }
    }
}

