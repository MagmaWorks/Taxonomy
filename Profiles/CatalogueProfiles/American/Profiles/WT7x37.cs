namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT7x37 : SingletonAmericanBase<WT7x37>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT7X37";
        public Length Height => new Length(7.09, LengthUnit.Inch);
        public Length Width => new Length(10.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.79, LengthUnit.Inch);
        public Length WebThickness => new Length(0.45, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.71, LengthUnit.Inch);

        public WT7x37() { }
    }
}
