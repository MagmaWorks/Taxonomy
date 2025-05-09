namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD320x97_6 : SingletonEuropeanBase<HD320x97_6>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HD;
        public override string Label => "HD 320 × 97,6";
        public Length Height => new Length(310, LengthUnit.Millimeter);
        public Length Width => new Length(300, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(15.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(9, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HD320x97_6() { }
    }
}
