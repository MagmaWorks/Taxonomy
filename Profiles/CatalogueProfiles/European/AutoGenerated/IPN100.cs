using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPN100 : SingletonEuropeanBase<IPN100>, IITaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.IPN;
        public override string Designation => "IPN 100";
        public Length Height => new Length(100, LengthUnit.Millimeter);
        public Length Width => new Length(50, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(4.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(6.8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(4.5, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(2.7, LengthUnit.Millimeter);
        public Length WebHeight => new Length(75, LengthUnit.Millimeter);

        public IPN100() { }
    }
}

