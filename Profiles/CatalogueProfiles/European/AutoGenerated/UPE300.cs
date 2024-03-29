using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UPE300 : SingletonEuropeanBase<UPE300>, IChannelParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UPE;
        public override string Designation => "UPE 300";
        public Length Height => new Length(300, LengthUnit.Millimeter);
        public Length Width => new Length(100, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(15, LengthUnit.Millimeter);
        public Length WebThickness => new Length(9.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UPE300() { }
    }
}
