namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT20x165_5 : SingletonAmericanBase<WT20x165_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT20X165.5";
        public Length Height => new Length(20.40, LengthUnit.Inch);
        public Length Width => new Length(12.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.13, LengthUnit.Inch);
        public Length WebThickness => new Length(1.22, LengthUnit.Inch);
        public Length FilletRadius => new Length(17.09, LengthUnit.Inch);

        public WT20x165_5() { }
    }
}
