namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE280A : SingletonEuropeanBase<HE280A>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEA;
        public override string Label => "HE 280 A";
        public Length Height => new Length(270, LengthUnit.Millimeter);
        public Length Width => new Length(280, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(13, LengthUnit.Millimeter);
        public Length WebThickness => new Length(8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(24, LengthUnit.Millimeter);

        public HE280A() { }
    }
}
