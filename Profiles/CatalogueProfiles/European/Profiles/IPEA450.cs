using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEA450 : SingletonEuropeanBase<IPEA450>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.IPEA;
        public override string Designation => "IPE A 450";
        public Length Height => new Length(447, LengthUnit.Millimeter);
        public Length Width => new Length(190, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(13.1, LengthUnit.Millimeter);
        public Length WebThickness => new Length(7.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(21, LengthUnit.Millimeter);

        public IPEA450() { }
    }
}
