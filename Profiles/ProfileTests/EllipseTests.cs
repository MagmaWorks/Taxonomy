namespace ProfileTests
{
    public class EllipseTests
    {
        [Fact]
        public void CreateProfileTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var w = new Length(5.4, LengthUnit.Centimeter);

            // Act
            IEllipse prfl = new Ellipse(w, h);

            // Assert
            TestUtility.TestLengthsAreEqual(h, prfl.Height);
            TestUtility.TestLengthsAreEqual(w, prfl.Width);
        }

        [Fact]
        public void InterfaceSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var w = new Length(5.4, LengthUnit.Centimeter);

            // Act
            IEllipse prfl = new Ellipse(w, h);
            string json = prfl.ToJson();
            IEllipse prflDeserialized = json.FromJson<IEllipse>();

            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Height, prflDeserialized.Height);
            TestUtility.TestLengthsAreEqual(prfl.Width, prflDeserialized.Width);
        }

        [Fact]
        public void ConcreteImplementationSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var w = new Length(5.4, LengthUnit.Centimeter);

            // Act
            IEllipse prfl = new Ellipse(w, h);
            string json = prfl.ToJson();
            IEllipse prflDeserialized = json.FromJson<Ellipse>();

            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Height, prflDeserialized.Height);
            TestUtility.TestLengthsAreEqual(prfl.Width, prflDeserialized.Width);
        }

        [Fact]
        public void GetPerimeterTest()
        {
            // Assemble
            var h = new Length(12, LengthUnit.Centimeter);
            var w = new Length(18, LengthUnit.Centimeter);

            // Act
            IEllipse prfl = new Ellipse(w, h);
            IPerimeter perimeter = new Perimeter(prfl, 57);

            // Assert
            Assert.Equal(58, perimeter.OuterEdge.Points.Count);
            List<double> u1 = perimeter.OuterEdge.Points.Select(x => x.Y.Millimeters).ToList();
            List<double> v1 = perimeter.OuterEdge.Points.Select(x => x.Z.Millimeters).ToList();

            var expectedU1 = new List<double>()
            {
                90,
89.45376095861546,
87.82167443646921,
85.12355175305711,
81.39214446278197,
76.67274679544944,
71.02264584567541,
64.51042618516061,
57.21513733889712,
49.22533423101842,
40.63800224798006,
31.5573799673479,
22.093693842671932,
12.361820203656741,
2.4798908131345856,
-7.432141092509903,
-17.253956873136453,
-26.866332990152507,
-36.15258821876725,
-44.999999999999986,
-53.30117273984819,
-60.95534144631668,
-67.86959487992065,
-73.96000337027206,
-79.15263760858402,
-83.38446604933215,
-86.60412002783254,
-88.772517306245,
-89.86333647899845,
-89.86333647899845,
-88.77251730624502,
-86.60412002783254,
-83.38446604933215,
-79.15263760858402,
-73.96000337027208,
-67.86959487992065,
-60.9553414463167,
-53.30117273984824,
-45.000000000000036,
-36.152588218767285,
-26.86633299015255,
-17.253956873136495,
-7.432141092509946,
2.4798908131345434,
12.361820203656702,
22.093693842671893,
31.557379967347856,
40.63800224798001,
49.225334231018394,
57.215137338897094,
64.51042618516058,
71.0226458456754,
76.67274679544943,
81.39214446278196,
85.12355175305711,
87.8216744364692,
89.45376095861546,
90
};

            var expectedV1 = new List<double>() {
                -1.4695761589768237E-14,
-6.600493259644773,
-13.120865472382564,
-19.481968152281024,
-25.606586129784237,
-31.42037483927268,
-36.852762761380085,
-41.837808065639734,
-46.314999054979275,
-50.22998869575172,
-53.53525431710364,
-56.1906744718233,
-58.16401595635983,
-59.4313250782502,
-59.977218421497085,
-59.795069580400195,
-58.88708959514506,
-57.26430011277044,
-54.94639959930343,
-51.96152422706631,
-48.345906339658676,
-44.14343464038789,
-39.40512144286406,
-34.18848345061597,
-28.556843582224406,
-22.57856231687012,
-16.326207890720095,
-9.875675416844029,
-3.30526562135192,
3.3052656213519342,
9.875675416844041,
16.32620789072011,
22.578562316870133,
28.55684358222442,
34.188483450615976,
39.40512144286408,
44.1434346403879,
48.3459063396587,
51.96152422706632,
54.94639959930345,
57.26430011277044,
58.88708959514508,
59.795069580400195,
59.977218421497085,
59.4313250782502,
58.164015956359826,
56.19067447182329,
53.535254317103636,
50.229988695751715,
46.31499905497925,
41.83780806563973,
36.85276276138006,
31.42037483927267,
25.60658612978422,
19.48196815228101,
13.120865472382548,
6.600493259644757,
0
};

            TestUtility.TestListsOfDoublesAreEqual(expectedU1, u1);
            TestUtility.TestListsOfDoublesAreEqual(expectedV1, v1);
        }
    }
}
