namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT9x155_5 : SingletonAmericanBase<WT9x155_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT9X155.5";
        public Length Height => new Length(11.20, LengthUnit.Inch);
        public Length Width => new Length(12.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.74, LengthUnit.Inch);
        public Length WebThickness => new Length(1.52, LengthUnit.Inch);
        public Length FilletRadius => new Length(7.96, LengthUnit.Inch);

        public WT9x155_5() { }
    }
}
