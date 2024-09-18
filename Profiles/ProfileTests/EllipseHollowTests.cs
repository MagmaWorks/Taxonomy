using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Serialization.Profiles.Extensions;
using OasysUnits;
using OasysUnits.Units;
using ProfileTests.Utility;

namespace ProfileTests
{
    public class EllipseHollowTests
    {
        [Fact]
        public void CreateProfileTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var w = new Length(5.4, LengthUnit.Centimeter);
            var thk = new Length(10.9, LengthUnit.Millimeter);

            // Act
            IEllipseHollow prfl = new EllipseHollow(h, w, thk);

            // Assert
            TestUtility.TestLengthsAreEqual(h, prfl.Height);
            TestUtility.TestLengthsAreEqual(w, prfl.Width);
            TestUtility.TestLengthsAreEqual(thk, prfl.Thickness);
        }

        [Fact]
        public void InterfaceSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var w = new Length(5.4, LengthUnit.Centimeter);
            var thk = new Length(10.9, LengthUnit.Millimeter);

            // Act
            IEllipseHollow prfl = new EllipseHollow(h, w, thk);
            string json = prfl.ToJson();
            IEllipseHollow prflDeserialized = json.FromJson<IEllipseHollow>();

            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Height, prflDeserialized.Height);
            TestUtility.TestLengthsAreEqual(prfl.Width, prflDeserialized.Width);
            TestUtility.TestLengthsAreEqual(prfl.Thickness, prflDeserialized.Thickness);
        }

        [Fact]
        public void ConcreteImplementationSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var w = new Length(5.4, LengthUnit.Centimeter);
            var thk = new Length(10.9, LengthUnit.Millimeter);

            // Act
            IEllipseHollow prfl = new EllipseHollow(h, w, thk);
            string json = prfl.ToJson();
            IEllipseHollow prflDeserialized = json.FromJson<EllipseHollow>();

            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Height, prflDeserialized.Height);
            TestUtility.TestLengthsAreEqual(prfl.Width, prflDeserialized.Width);
            TestUtility.TestLengthsAreEqual(prfl.Thickness, prflDeserialized.Thickness);
        }

        [Fact]
        public void GetPerimeterTest()
        {
            // Assemble
            var h = new Length(12, LengthUnit.Centimeter);
            var w = new Length(18, LengthUnit.Centimeter);
            var thk = new Length(14.3, LengthUnit.Millimeter);

            // Act
            IEllipseHollow prfl = new EllipseHollow(h, w, thk);
            IPerimeter perimeter = new Perimeter(prfl, 57);

            // Assert
            Assert.Equal(58, perimeter.OuterEdge.Points.Count);
            List<double> u1 = perimeter.OuterEdge.Points.Select(x => x.Y.Millimeters).ToList();
            List<double> v1 = perimeter.OuterEdge.Points.Select(x => x.Z.Millimeters).ToList();

            Assert.Single(perimeter.VoidEdges);
            Assert.Equal(58, perimeter.VoidEdges[0].Points.Count);
            List<double> u2 = perimeter.VoidEdges[0].Points.Select(x => x.Y.Millimeters).ToList();
            List<double> v2 = perimeter.VoidEdges[0].Points.Select(x => x.Z.Millimeters).ToList();

            var expectedU1 = new List<double>()
            {
               90,
89.45376095861546,
87.8216744364692,
85.12355175305711,
81.39214446278196,
76.67274679544943,
71.0226458456754,
64.51042618516058,
57.215137338897094,
49.225334231018394,
40.63800224798001,
31.557379967347856,
22.093693842671893,
12.361820203656702,
2.4798908131345434,
-7.432141092509946,
-17.253956873136495,
-26.86633299015255,
-36.152588218767285,
-45.000000000000036,
-53.30117273984824,
-60.9553414463167,
-67.86959487992065,
-73.96000337027208,
-79.15263760858402,
-83.38446604933215,
-86.60412002783254,
-88.77251730624502,
-89.86333647899845,
-89.86333647899845,
-88.772517306245,
-86.60412002783254,
-83.38446604933215,
-79.15263760858402,
-73.96000337027206,
-67.86959487992065,
-60.95534144631668,
-53.30117273984819,
-44.999999999999986,
-36.15258821876725,
-26.866332990152507,
-17.253956873136453,
-7.432141092509903,
2.4798908131345856,
12.361820203656741,
22.093693842671932,
31.5573799673479,
40.63800224798006,
49.22533423101842,
57.21513733889712,
64.51042618516061,
71.02264584567541,
76.67274679544944,
81.39214446278197,
85.12355175305711,
87.82167443646921,
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

            var expectedU2 = new List<double>()
            {
                75.7,
75.24055227296877,
73.86778616489687,
71.59836519673806,
68.4598370648066,
64.49029924906135,
59.737936561306974,
54.26043624685173,
48.12428773949456,
41.4039755698677,
34.181075224134304,
26.543262928091483,
18.58325137655847,
10.397664326853471,
2.0858637172698327,
-6.251256452255589,
-14.512494836627031,
-22.597571192828312,
-30.40834364622982,
-37.85000000000004,
-44.832208626739025,
-51.27021497206861,
-57.085870360111045,
-62.20858061255106,
-66.57616296633122,
-70.1356008881605,
-72.84368762341026,
-74.6675506675861,
-75.58505079400204,
-75.58505079400204,
-74.66755066758608,
-72.84368762341026,
-70.1356008881605,
-66.57616296633121,
-62.20858061255106,
-57.08587036011104,
-51.27021497206859,
-44.832208626738975,
-37.84999999999999,
-30.40834364622979,
-22.597571192828276,
-14.512494836626997,
-6.251256452255553,
2.0858637172698677,
10.397664326853503,
18.5832513765585,
26.543262928091515,
34.18107522413433,
41.403975569867725,
48.12428773949458,
54.26043624685176,
59.737936561306995,
64.49029924906135,
68.4598370648066,
71.59836519673806,
73.86778616489687,
75.24055227296877,
75.7
};

            var expectedV2 = new List<double>() {
                -1.1193271744206811E-14,
-5.027375699429435,
-9.993725868131389,
-14.838765742654047,
-19.50368310218566,
-23.93185216924603,
-28.06952096991783,
-31.8664638099956,
-35.27659094687588,
-38.25850805659757,
-40.77601870486062,
-42.79856372270541,
-44.30159215342741,
-45.26685926793391,
-45.68264803104028,
-45.54391133040481,
-44.8523332416355,
-43.616308585893485,
-41.85084102813612,
-39.577360952948844,
-36.823465328706696,
-33.62258271776212,
-30.013567498981462,
-26.04022822821916,
-21.750795861794256,
-17.19733829801608,
-12.435128343431808,
-7.521972775829534,
-2.517510648263045,
2.5175106482630567,
7.521972775829546,
12.435128343431817,
17.197338298016085,
21.75079586179427,
26.040228228219174,
30.013567498981473,
33.62258271776212,
36.82346532870671,
39.57736095294885,
41.850841028136124,
43.616308585893485,
44.852333241635506,
45.54391133040481,
45.68264803104028,
45.2668592679339,
44.30159215342739,
42.7985637227054,
40.776018704860604,
38.258508056597556,
35.276590946875864,
31.86646380999559,
28.06952096991782,
23.931852169246017,
19.503683102185647,
14.838765742654033,
9.993725868131374,
5.027375699429424,
0
};

            TestUtility.TestListsOfDoublesAreEqual(expectedU1, u1);
            TestUtility.TestListsOfDoublesAreEqual(expectedV1, v1);
            TestUtility.TestListsOfDoublesAreEqual(expectedU2, u2);
            TestUtility.TestListsOfDoublesAreEqual(expectedV2, v2);
        }
    }
}
