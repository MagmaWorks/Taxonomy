namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB914x305x521 : SingletonEuropeanBase<UB914x305x521>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 914 × 305 × 521";
        public Length Height => new Length(981, LengthUnit.Millimeter);
        public Length Width => new Length(319, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(58.9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(33, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(19, LengthUnit.Millimeter);

        public UB914x305x521() { }
    }
}
