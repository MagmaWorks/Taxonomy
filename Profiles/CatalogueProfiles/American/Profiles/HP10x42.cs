namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP10x42 : SingletonAmericanBase<HP10x42>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.HP;
        public override string Label => "HP10X42";
        public Length Height => new Length(9.70, LengthUnit.Inch);
        public Length Width => new Length(10.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.42, LengthUnit.Inch);
        public Length WebThickness => new Length(0.42, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.6, LengthUnit.Inch);

        public HP10x42() { }
    }
}
