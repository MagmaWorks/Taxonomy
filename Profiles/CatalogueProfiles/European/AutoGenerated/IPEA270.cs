using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEA270 : SingletonEuropeanBase<IPEA270>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.IPEA;
        public override string Designation => "IPE A 270";
        public Length Height => new Length(267, LengthUnit.Millimeter);
        public Length Width => new Length(135, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(8.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(5.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public IPEA270() { }
    }
}
