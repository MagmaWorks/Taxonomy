using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPN140 : SingletonEuropeanBase<IPN140>, IITaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.IPN;
        public override string Designation => "IPN 140";
        public Length Height => new Length(140, LengthUnit.Millimeter);
        public Length Width => new Length(66, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(5.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(8.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(5.7, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(3.4, LengthUnit.Millimeter);
        public Length WebHeight => new Length(109, LengthUnit.Millimeter);

        public IPN140() { }
    }
}

