namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class M12x10_8 : SingletonAmericanBase<M12x10_8>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.M;
        public override string Label => "M12X10.8";
        public Length Height => new Length(12.00, LengthUnit.Inch);
        public Length Width => new Length(3.07, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.21, LengthUnit.Inch);
        public Length WebThickness => new Length(0.16, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.3, LengthUnit.Inch);

        public M12x10_8() { }
    }
}
