using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEA600 : SingletonEuropeanBase<IPEA600>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.IPEA;
        public override string Designation => "IPE A 600";
        public Length Height => new Length(597, LengthUnit.Millimeter);
        public Length Width => new Length(220, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(9.8, LengthUnit.Millimeter);
        public Length WebThickness => new Length(17.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(24, LengthUnit.Millimeter);

        public IPEA600() { }
    }
}

