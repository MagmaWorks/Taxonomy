namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT9x43 : SingletonAmericanBase<WT9x43>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT9X43";
        public Length Height => new Length(9.20, LengthUnit.Inch);
        public Length Width => new Length(11.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.77, LengthUnit.Inch);
        public Length WebThickness => new Length(0.48, LengthUnit.Inch);
        public Length FilletRadius => new Length(8.03, LengthUnit.Inch);

        public WT9x43() { }
    }
}
