using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UPE200 : SingletonEuropeanBase<UPE200>, IChannelParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UPE;
        public override string Designation => "UPE 200";
        public Length Height => new Length(200, LengthUnit.Millimeter);
        public Length Width => new Length(80, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(6, LengthUnit.Millimeter);
        public Length WebThickness => new Length(11, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(13, LengthUnit.Millimeter);

        public UPE200() { }
    }
}

