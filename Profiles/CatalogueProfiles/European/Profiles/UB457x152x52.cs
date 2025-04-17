namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB457x152x52 : SingletonEuropeanBase<UB457x152x52>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 457 × 152 × 52";
        public Length Height => new Length(449.8, LengthUnit.Millimeter);
        public Length Width => new Length(152.4, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(10.9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(7.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(10, LengthUnit.Millimeter);

        public UB457x152x52() { }
    }
}
