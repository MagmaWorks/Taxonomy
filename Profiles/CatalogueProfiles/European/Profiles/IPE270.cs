namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPE270 : SingletonEuropeanBase<IPE270>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPE;
        public override string Label => "IPE 270";
        public Length Height => new Length(270, LengthUnit.Millimeter);
        public Length Width => new Length(135, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(10.2, LengthUnit.Millimeter);
        public Length WebThickness => new Length(6.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public IPE270() { }
    }
}
