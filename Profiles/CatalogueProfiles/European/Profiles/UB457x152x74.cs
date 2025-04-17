namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB457x152x74 : SingletonEuropeanBase<UB457x152x74>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 457 × 152 × 74";
        public Length Height => new Length(462, LengthUnit.Millimeter);
        public Length Width => new Length(154.4, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(17, LengthUnit.Millimeter);
        public Length WebThickness => new Length(9.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(10, LengthUnit.Millimeter);

        public UB457x152x74() { }
    }
}
