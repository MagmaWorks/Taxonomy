namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT20x296_5 : SingletonAmericanBase<WT20x296_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT20X296.5";
        public Length Height => new Length(21.50, LengthUnit.Inch);
        public Length Width => new Length(16.70, LengthUnit.Inch);
        public Length FlangeThickness => new Length(3.23, LengthUnit.Inch);
        public Length WebThickness => new Length(1.79, LengthUnit.Inch);
        public Length FilletRadius => new Length(17.09, LengthUnit.Inch);

        public WT20x296_5() { }
    }
}
