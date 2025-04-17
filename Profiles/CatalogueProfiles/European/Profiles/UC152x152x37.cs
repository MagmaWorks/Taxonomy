namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC152x152x37 : SingletonEuropeanBase<UC152x152x37>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UC;
        public override string Label => "UC 152 × 152 × 37";
        public Length Height => new Length(161.8, LengthUnit.Millimeter);
        public Length Width => new Length(154.4, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(11.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(8, LengthUnit.Millimeter);

        public UC152x152x37() { }
    }
}
