namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB356x171x51 : SingletonEuropeanBase<UB356x171x51>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 356 × 171 × 51";
        public Length Height => new Length(355, LengthUnit.Millimeter);
        public Length Width => new Length(171.5, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(11.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(7.4, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(10, LengthUnit.Millimeter);

        public UB356x171x51() { }
    }
}
