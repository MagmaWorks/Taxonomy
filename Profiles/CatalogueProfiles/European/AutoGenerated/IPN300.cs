using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPN300 : SingletonEuropeanBase<IPN300>, IITaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.IPN;
        public override string Designation => "IPN 300";
        public Length Height => new Length(300, LengthUnit.Millimeter);
        public Length Width => new Length(125, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(10.8, LengthUnit.Millimeter);
        public Length WebThickness => new Length(16.2, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(10.8, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(6.5, LengthUnit.Millimeter);
        public Length WebHeight => new Length(241, LengthUnit.Millimeter);

        public IPN300() { }
    }
}

