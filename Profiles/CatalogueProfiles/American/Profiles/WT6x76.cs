namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT6x76 : SingletonAmericanBase<WT6x76>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT6X76";
        public Length Height => new Length(6.86, LengthUnit.Inch);
        public Length Width => new Length(12.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.40, LengthUnit.Inch);
        public Length WebThickness => new Length(0.87, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.86, LengthUnit.Inch);

        public WT6x76() { }
    }
}
