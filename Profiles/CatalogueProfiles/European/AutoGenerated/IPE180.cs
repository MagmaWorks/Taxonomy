using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPE180 : SingletonEuropeanBase<IPE180>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.IPE;
        public override string Designation => "IPE 180";
        public Length Height => new Length(180, LengthUnit.Millimeter);
        public Length Width => new Length(91, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(5.3, LengthUnit.Millimeter);
        public Length WebThickness => new Length(8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(9, LengthUnit.Millimeter);

        public IPE180() { }
    }
}

