using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Profiles.Utilities;
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
            IPerimeter perimeter = prfl.GetPerimeter();

            // Assert
            Assert.Equal(58, perimeter.OuterEdge.Points.Count);
            List<double> u1 = perimeter.OuterEdge.Points.Select(x => x.U.Millimeters).ToList();
            List<double> v1 = perimeter.OuterEdge.Points.Select(x => x.V.Millimeters).ToList();

            Assert.Single(perimeter.VoidEdges);
            Assert.Equal(58, perimeter.VoidEdges[0].Points.Count);
            List<double> u2 = perimeter.VoidEdges[0].Points.Select(x => x.U.Millimeters).ToList();
            List<double> v2 = perimeter.VoidEdges[0].Points.Select(x => x.V.Millimeters).ToList();

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
                0,
6.600493259644757,
13.120865472382548,
19.48196815228101,
25.60658612978422,
31.42037483927267,
36.85276276138006,
41.83780806563973,
46.31499905497925,
50.229988695751715,
53.535254317103636,
56.19067447182329,
58.164015956359826,
59.4313250782502,
59.977218421497085,
59.795069580400195,
58.88708959514508,
57.26430011277044,
54.94639959930345,
51.96152422706632,
48.3459063396587,
44.1434346403879,
39.40512144286408,
34.188483450615976,
28.55684358222442,
22.578562316870133,
16.32620789072011,
9.875675416844041,
3.3052656213519342,
-3.30526562135192,
-9.875675416844029,
-16.326207890720095,
-22.57856231687012,
-28.556843582224406,
-34.18848345061597,
-39.40512144286406,
-44.14343464038789,
-48.345906339658676,
-51.96152422706631,
-54.94639959930343,
-57.26430011277044,
-58.88708959514506,
-59.795069580400195,
-59.977218421497085,
-59.4313250782502,
-58.16401595635983,
-56.1906744718233,
-53.53525431710364,
-50.22998869575172,
-46.314999054979275,
-41.837808065639734,
-36.852762761380085,
-31.42037483927268,
-25.606586129784237,
-19.481968152281024,
-13.120865472382564,
-6.600493259644773,
-1.4695761589768237E-14
};

            var expectedU2 = new List<double>()
            {
                75.7,
75.24055227296877,
73.86778616489687,
71.59836519673806,
68.4598370648066,
64.49029924906135,
59.737936561306995,
54.26043624685176,
48.12428773949458,
41.403975569867725,
34.18107522413433,
26.543262928091515,
18.5832513765585,
10.397664326853503,
2.0858637172698677,
-6.251256452255553,
-14.512494836626997,
-22.597571192828276,
-30.40834364622979,
-37.84999999999999,
-44.832208626738975,
-51.27021497206859,
-57.08587036011104,
-62.20858061255106,
-66.57616296633121,
-70.1356008881605,
-72.84368762341026,
-74.66755066758608,
-75.58505079400204,
-75.58505079400204,
-74.6675506675861,
-72.84368762341026,
-70.1356008881605,
-66.57616296633122,
-62.20858061255106,
-57.085870360111045,
-51.27021497206861,
-44.832208626739025,
-37.85000000000004,
-30.40834364622982,
-22.597571192828312,
-14.512494836627031,
-6.251256452255589,
2.0858637172698327,
10.397664326853471,
18.58325137655847,
26.543262928091483,
34.181075224134304,
41.4039755698677,
48.12428773949456,
54.26043624685173,
59.737936561306974,
64.49029924906135,
68.4598370648066,
71.59836519673806,
73.86778616489687,
75.24055227296877,
75.7
};

            var expectedV2 = new List<double>() {
                0,
5.027375699429424,
9.993725868131374,
14.838765742654033,
19.503683102185647,
23.931852169246017,
28.06952096991782,
31.86646380999559,
35.276590946875864,
38.258508056597556,
40.776018704860604,
42.7985637227054,
44.30159215342739,
45.2668592679339,
45.68264803104028,
45.54391133040481,
44.852333241635506,
43.616308585893485,
41.850841028136124,
39.57736095294885,
36.82346532870671,
33.62258271776212,
30.013567498981473,
26.040228228219174,
21.75079586179427,
17.197338298016085,
12.435128343431817,
7.521972775829546,
2.5175106482630567,
-2.517510648263045,
-7.521972775829534,
-12.435128343431808,
-17.19733829801608,
-21.750795861794256,
-26.04022822821916,
-30.013567498981462,
-33.62258271776212,
-36.823465328706696,
-39.577360952948844,
-41.85084102813612,
-43.616308585893485,
-44.8523332416355,
-45.54391133040481,
-45.68264803104028,
-45.26685926793391,
-44.30159215342741,
-42.79856372270541,
-40.77601870486062,
-38.25850805659757,
-35.27659094687588,
-31.8664638099956,
-28.06952096991783,
-23.93185216924603,
-19.50368310218566,
-14.838765742654047,
-9.993725868131389,
-5.027375699429435,
-1.1193271744206811E-14
};

            TestUtility.TestListsOfDoublesAreEqual(expectedU1, u1);
            TestUtility.TestListsOfDoublesAreEqual(expectedV1, v1);
            TestUtility.TestListsOfDoublesAreEqual(expectedU2, u2);
            TestUtility.TestListsOfDoublesAreEqual(expectedV2, v2);
        }
    }
}
