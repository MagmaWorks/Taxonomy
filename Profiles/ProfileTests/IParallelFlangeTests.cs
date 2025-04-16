namespace ProfileTests
{
    public class IParallelFlangeTests
    {

        [Fact]
        public void GetPerimeterTest()
        {
            // Assemble
            IIParallelFlange prfl = new HE500B();

            // Act
            IPerimeter perimeter = new Perimeter(prfl);

            // Assert
            Assert.Equal(45, perimeter.OuterEdge.Points.Count);
            List<double> u = perimeter.OuterEdge.Points.Select(x => x.Y.Millimeters).ToList();
            List<double> v = perimeter.OuterEdge.Points.Select(x => x.Z.Millimeters).ToList();

            var expectedU = new List<double>()
            {
                -150,
150,
150,
34.25,
28.982561305564538,
23.917547326142575,
19.249603708470747,
15.158116907963219,
11.800320467831277,
9.305252622195258,
7.76879742911278,
7.25,
7.25,
7.76879742911278,
9.305252622195255,
11.800320467831273,
15.158116907963212,
19.24960370847074,
23.91754732614256,
28.982561305564527,
34.24999999999999,
150,
150,
-150,
-150,
-34.25000000000001,
-28.982561305564538,
-23.917547326142568,
-19.24960370847075,
-15.158116907963223,
-11.800320467831277,
-9.305252622195265,
-7.76879742911278,
-7.25,
-7.25,
-7.76879742911278,
-9.305252622195258,
-11.800320467831277,
-15.158116907963215,
-19.249603708470737,
-23.917547326142575,
-28.982561305564534,
-34.25,
-150,
-150
};

            var expectedV = new List<double>() {
                250,
250,
222,
222,
221.4812025708872,
219.94474737780473,
217.44967953216872,
214.0918830920368,
210.00039629152926,
205.33245267385743,
200.26743869443547,
195,
-195,
-200.26743869443547,
-205.33245267385743,
-210.00039629152926,
-214.09188309203677,
-217.44967953216872,
-219.94474737780473,
-221.4812025708872,
-222,
-222,
-250,
-250,
-222,
-222,
-221.4812025708872,
-219.94474737780473,
-217.44967953216872,
-214.0918830920368,
-210.00039629152926,
-205.33245267385743,
-200.26743869443547,
-195,
195,
200.26743869443547,
205.33245267385743,
210.00039629152926,
214.0918830920368,
217.44967953216872,
219.94474737780473,
221.4812025708872,
222,
222,
250
};

            TestUtility.TestListsOfDoublesAreEqual(expectedU, u);
            TestUtility.TestListsOfDoublesAreEqual(expectedV, v);
        }

        [Fact]
        public void GetPerimeterMockTest()
        {
            // Assemble
            IIParallelFlange prfl = new MockHEB500();

            // Act
            IPerimeter perimeter = new Perimeter(prfl);

            // Assert
            Assert.Equal(45, perimeter.OuterEdge.Points.Count);
            List<double> u = perimeter.OuterEdge.Points.Select(x => x.Y.Millimeters).ToList();
            List<double> v = perimeter.OuterEdge.Points.Select(x => x.Z.Millimeters).ToList();

            var expectedU = new List<double>()
            {
                -150,
150,
150,
34.25,
28.982561305564538,
23.917547326142575,
19.249603708470747,
15.158116907963219,
11.800320467831277,
9.305252622195258,
7.76879742911278,
7.25,
7.25,
7.76879742911278,
9.305252622195255,
11.800320467831273,
15.158116907963212,
19.24960370847074,
23.91754732614256,
28.982561305564527,
34.24999999999999,
150,
150,
-150,
-150,
-34.25000000000001,
-28.982561305564538,
-23.917547326142568,
-19.24960370847075,
-15.158116907963223,
-11.800320467831277,
-9.305252622195265,
-7.76879742911278,
-7.25,
-7.25,
-7.76879742911278,
-9.305252622195258,
-11.800320467831277,
-15.158116907963215,
-19.249603708470737,
-23.917547326142575,
-28.982561305564534,
-34.25,
-150,
-150
};

            var expectedV = new List<double>() {
                250,
250,
222,
222,
221.4812025708872,
219.94474737780473,
217.44967953216872,
214.0918830920368,
210.00039629152926,
205.33245267385743,
200.26743869443547,
195,
-195,
-200.26743869443547,
-205.33245267385743,
-210.00039629152926,
-214.09188309203677,
-217.44967953216872,
-219.94474737780473,
-221.4812025708872,
-222,
-222,
-250,
-250,
-222,
-222,
-221.4812025708872,
-219.94474737780473,
-217.44967953216872,
-214.0918830920368,
-210.00039629152926,
-205.33245267385743,
-200.26743869443547,
-195,
195,
200.26743869443547,
205.33245267385743,
210.00039629152926,
214.0918830920368,
217.44967953216872,
219.94474737780473,
221.4812025708872,
222,
222,
250
};

            TestUtility.TestListsOfDoublesAreEqual(expectedU, u);
            TestUtility.TestListsOfDoublesAreEqual(expectedV, v);
        }
    }

    public class MockHEB500 : IIParallelFlange
    {
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);
        public Length Height => new Length(500, LengthUnit.Millimeter);
        public Length Width => new Length(300, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(28, LengthUnit.Millimeter);
        public Length WebThickness => new Length(14.5, LengthUnit.Millimeter);

        public string Description => "HE 500 B";

        public MockHEB500() { }
    }
}
