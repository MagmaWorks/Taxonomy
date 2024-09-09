using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Profiles.Utilities;
using MagmaWorks.Taxonomy.Serialization.Profiles.Extensions;
using OasysUnits;
using OasysUnits.Units;
using ProfileTests.Utility;

namespace ProfileTests
{
    public class CircularHollowTests
    {
        [Fact]
        public void CreateProfileTest()
        {
            // Assemble
            var dia = new Length(2.3, LengthUnit.Centimeter);
            var thk = new Length(10.9, LengthUnit.Millimeter);

            // Act
            ICircularHollow prfl = new CircularHollow(dia, thk);

            // Assert
            TestUtility.TestLengthsAreEqual(dia, prfl.Diameter);
            TestUtility.TestLengthsAreEqual(thk, prfl.Thickness);
        }

        [Fact]
        public void InterfaceSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var dia = new Length(2.3, LengthUnit.Centimeter);
            var thk = new Length(10.9, LengthUnit.Millimeter);

            // Act
            ICircularHollow prfl = new CircularHollow(dia, thk);
            string json = prfl.ToJson();
            ICircularHollow prflDeserialized = json.FromJson<ICircularHollow>();

            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Diameter, prflDeserialized.Diameter);
            TestUtility.TestLengthsAreEqual(prfl.Thickness, prflDeserialized.Thickness);
        }

        [Fact]
        public void ConcreteImplementationSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var dia = new Length(2.3, LengthUnit.Centimeter);
            var thk = new Length(10.9, LengthUnit.Millimeter);

            // Act
            ICircularHollow prfl = new CircularHollow(dia, thk);
            string json = prfl.ToJson();
            ICircularHollow prflDeserialized = json.FromJson<CircularHollow>();

            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Diameter, prflDeserialized.Diameter);
            TestUtility.TestLengthsAreEqual(prfl.Thickness, prflDeserialized.Thickness);
        }

        [Fact]
        public void GetPerimeterTest()
        {
            // Assemble
            var dia = new Length(15, LengthUnit.Centimeter);
            var thk = new Length(10, LengthUnit.Millimeter);

            // Act
            ICircularHollow prfl = new CircularHollow(dia, thk);
            IPerimeter perimeter = prfl.GetPerimeter();

            // Assert
            Assert.Equal(48, perimeter.OuterEdge.Points.Count);
            List<double> u = perimeter.OuterEdge.Points.Select(x => x.U.Millimeters).ToList();
            List<double> v = perimeter.OuterEdge.Points.Select(x => x.V.Millimeters).ToList();

            Assert.Single(perimeter.VoidEdges);
            Assert.Equal(48, perimeter.VoidEdges[0].Points.Count);
            List<double> ui = perimeter.VoidEdges[0].Points.Select(x => x.U.Millimeters).ToList();
            List<double> vi = perimeter.VoidEdges[0].Points.Select(x => x.V.Millimeters).ToList();

            var expectedU = new List<double>()
            {
                75,
74.33081161160851,
72.33518812907825,
69.04874150073216,
64.53011844451045,
58.859953895899565,
52.13943207559817,
44.488480854701656,
36.04363163900128,
26.95558296281346,
17.386511270064616,
7.507176871807383,
-2.506123275575589,
-12.474701593734752,
-22.22066856642254,
-31.57010718212512,
-40.35617648725294,
-48.42208886691018,
-55.62390792359682,
-61.83311702563203,
-66.93891268949109,
-70.8501818705939,
-73.497127877744,
-74.8325158967365,
-74.8325158967365,
-73.497127877744,
-70.85018187059391,
-66.93891268949109,
-61.833117025632035,
-55.623907923596825,
-48.42208886691019,
-40.35617648725296,
-31.570107182125135,
-22.220668566422553,
-12.474701593734753,
-2.506123275575591,
7.507176871807381,
17.386511270064627,
26.955582962813477,
36.043631639001305,
44.488480854701656,
52.139432075598144,
58.85995389589955,
64.53011844451044,
69.04874150073215,
72.33518812907825,
74.33081161160851,
75
};

            var expectedV = new List<double>() {
                -1.83697019872103E-14,
-9.996521653033433,
-19.814655140346474,
-29.279195637262138,
-38.22124819439384,
-46.4812416720184,
-53.91177629084473,
-60.380253984567204,
-65.77124461550035,
-69.98854582812018,
-72.95689978237779,
-74.62333613163781,
-74.9581172797691,
-73.95526904925215,
-71.63268729051843,
-68.03181853007555,
-63.21692035625978,
-57.273914741049886,
-50.30885476044174,
-42.446032074794616,
-33.825758941207646,
-24.601864337967683,
-14.938948882787704,
-5.00944753088411,
5.0094475308841275,
14.938948882787722,
24.601864337967704,
33.82575894120763,
42.44603207479464,
50.30885476044176,
57.27391474104991,
63.21692035625978,
68.03181853007555,
71.63268729051843,
73.95526904925215,
74.9581172797691,
74.62333613163781,
72.95689978237779,
69.98854582812018,
65.77124461550036,
60.38025398456721,
53.9117762908447,
46.48124167201838,
38.2212481943938,
29.279195637262113,
19.81465514034645,
9.996521653033412,
0
};

            var expectedUi = new List<double>()
            {
                65,
64.4200367300607,
62.690496378534476,
59.84224263396787,
55.92610265190906,
51.01196004311296,
45.18750779885175,
38.556683407408094,
31.237814087134446,
23.36150523443833,
15.068309767389332,
6.506219955566399,
-2.171973505498844,
-10.811408047903452,
-19.2579127575662,
-27.360759557841767,
-34.97535295561922,
-41.965810351322155,
-48.20738686711724,
-53.588701422214434,
-58.01372433089228,
-61.403490954514716,
-63.69751082737814,
-64.85484711050496,
-64.85484711050496,
-63.69751082737815,
-61.40349095451472,
-58.01372433089228,
-53.588701422214434,
-48.20738686711725,
-41.96581035132216,
-34.975352955619236,
-27.36075955784178,
-19.257912757566213,
-10.811408047903456,
-2.171973505498846,
6.506219955566398,
15.068309767389344,
23.361505234438344,
31.237814087134456,
38.5566834074081,
45.18750779885172,
51.01196004311294,
55.92610265190905,
59.842242633967864,
62.690496378534476,
64.4200367300607,
65
};

            var expectedVi = new List<double>() {
                -1.592040838891559E-14,
-8.663652099295643,
-17.17270112163361,
-25.37530288562719,
-33.12508176847466,
-40.28374278241595,
-46.72353945206543,
-52.32955345329158,
-57.00174533343364,
-60.65673971770417,
-63.22931314472742,
-64.67355798075276,
-64.96370164246655,
-64.09456650935185,
-62.08166231844931,
-58.96090939273215,
-54.78799764209181,
-49.63739277557657,
-43.60100745904951,
-36.78656113148866,
-29.315657749046622,
-21.321615759571994,
-12.947089031749345,
-4.341521193432895,
4.34152119343291,
12.94708903174936,
21.321615759572012,
29.315657749046615,
36.78656113148868,
43.60100745904953,
49.637392775576586,
54.78799764209182,
58.96090939273215,
62.08166231844931,
64.09456650935185,
64.96370164246655,
64.67355798075276,
63.22931314472742,
60.65673971770417,
57.00174533343365,
52.32955345329159,
46.7235394520654,
40.28374278241592,
33.12508176847463,
25.375302885627164,
17.17270112163359,
8.663652099295623,
0
};

            TestUtility.TestListsOfDoublesAreEqual(expectedU, u);
            TestUtility.TestListsOfDoublesAreEqual(expectedV, v);
            TestUtility.TestListsOfDoublesAreEqual(expectedUi, ui);
            TestUtility.TestListsOfDoublesAreEqual(expectedVi, vi);
        }
    }
}
