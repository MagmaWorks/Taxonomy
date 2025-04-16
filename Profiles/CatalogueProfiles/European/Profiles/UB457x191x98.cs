namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB457x191x98 : SingletonEuropeanBase<UB457x191x98>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 457 × 191 × 98";
        public Length Height => new Length(467.2, LengthUnit.Millimeter);
        public Length Width => new Length(192.8, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(19.6, LengthUnit.Millimeter);
        public Length WebThickness => new Length(11.4, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(10, LengthUnit.Millimeter);

        public UB457x191x98() { }
    }
}
