namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT7x199 : SingletonAmericanBase<WT7x199>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT7X199";
        public Length Height => new Length(9.15, LengthUnit.Inch);
        public Length Width => new Length(16.60, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.85, LengthUnit.Inch);
        public Length WebThickness => new Length(1.77, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.71, LengthUnit.Inch);

        public WT7x199() { }
    }
}
