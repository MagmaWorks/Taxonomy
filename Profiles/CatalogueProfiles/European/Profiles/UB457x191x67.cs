namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB457x191x67 : SingletonEuropeanBase<UB457x191x67>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 457 × 191 × 67";
        public Length Height => new Length(453.4, LengthUnit.Millimeter);
        public Length Width => new Length(189.9, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(12.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(8.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(10, LengthUnit.Millimeter);

        public UB457x191x67() { }
    }
}
