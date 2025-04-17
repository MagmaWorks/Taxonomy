namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC254x254x132 : SingletonEuropeanBase<UC254x254x132>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UC;
        public override string Label => "UC 254 × 254 × 132";
        public Length Height => new Length(276.3, LengthUnit.Millimeter);
        public Length Width => new Length(261.3, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(25.3, LengthUnit.Millimeter);
        public Length WebThickness => new Length(15.3, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(13, LengthUnit.Millimeter);

        public UC254x254x132() { }
    }
}
