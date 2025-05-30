namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE280M : SingletonEuropeanBase<HE280M>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEM;
        public override string Label => "HE 280 M";
        public Length Height => new Length(310, LengthUnit.Millimeter);
        public Length Width => new Length(288, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(33, LengthUnit.Millimeter);
        public Length WebThickness => new Length(18.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(24, LengthUnit.Millimeter);

        public HE280M() { }
    }
}
