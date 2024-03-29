using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UPE220 : SingletonEuropeanBase<UPE220>, IChannelParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UPE;
        public override string Designation => "UPE 220";
        public Length Height => new Length(220, LengthUnit.Millimeter);
        public Length Width => new Length(85, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(12, LengthUnit.Millimeter);
        public Length WebThickness => new Length(6.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(13, LengthUnit.Millimeter);

        public UPE220() { }
    }
}
