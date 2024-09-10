using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Serialization.Profiles.Extensions;
using OasysUnits;
using OasysUnits.Units;
using ProfileTests.Utility;

namespace ProfileTests
{
    public class RoundedRectangularHollowTests
    {
        [Fact]
        public void CreateProfileTest()
        {
            // Assemble
            var h = new Length(6, LengthUnit.Centimeter);
            var w = new Length(7, LengthUnit.Centimeter);
            var h1 = new Length(4, LengthUnit.Centimeter);
            var w1 = new Length(5, LengthUnit.Centimeter);
            var thk = new Length(3.8, LengthUnit.Millimeter);

            // Act
            IRoundedRectangularHollow prfl = new RoundedRectangularHollow(h, w, h1, w1, thk);

            // Assert
            TestUtility.TestLengthsAreEqual(h, prfl.Height);
            TestUtility.TestLengthsAreEqual(w, prfl.Width);
            TestUtility.TestLengthsAreEqual(h1, prfl.FlatHeight);
            TestUtility.TestLengthsAreEqual(w1, prfl.FlatWidth);
            TestUtility.TestLengthsAreEqual(thk, prfl.Thickness);
        }

        [Fact]
        public void InterfaceSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var h = new Length(6, LengthUnit.Centimeter);
            var w = new Length(7, LengthUnit.Centimeter);
            var h1 = new Length(4, LengthUnit.Centimeter);
            var w1 = new Length(5, LengthUnit.Centimeter);
            var thk = new Length(3.8, LengthUnit.Millimeter);

            // Act
            IRoundedRectangularHollow prfl = new RoundedRectangularHollow(h, w, h1, w1, thk);
            string json = prfl.ToJson();
            IRoundedRectangularHollow prflDeserialized = json.FromJson<IRoundedRectangularHollow>();

            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Height, prflDeserialized.Height);
            TestUtility.TestLengthsAreEqual(prfl.Width, prflDeserialized.Width);
            TestUtility.TestLengthsAreEqual(prfl.FlatHeight, prflDeserialized.FlatHeight);
            TestUtility.TestLengthsAreEqual(prfl.FlatWidth, prflDeserialized.FlatWidth);
            TestUtility.TestLengthsAreEqual(prfl.Thickness, prflDeserialized.Thickness);
        }

        [Fact]
        public void ConcreteImplementationSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var h = new Length(6, LengthUnit.Centimeter);
            var w = new Length(7, LengthUnit.Centimeter);
            var h1 = new Length(4, LengthUnit.Centimeter);
            var w1 = new Length(5, LengthUnit.Centimeter);
            var thk = new Length(3.8, LengthUnit.Millimeter);

            // Act
            IRoundedRectangularHollow prfl = new RoundedRectangularHollow(h, w, h1, w1, thk);
            string json = prfl.ToJson();
            IRoundedRectangularHollow prflDeserialized = json.FromJson<RoundedRectangularHollow>();

            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Height, prflDeserialized.Height);
            TestUtility.TestLengthsAreEqual(prfl.Width, prflDeserialized.Width);
            TestUtility.TestLengthsAreEqual(prfl.FlatHeight, prflDeserialized.FlatHeight);
            TestUtility.TestLengthsAreEqual(prfl.FlatWidth, prflDeserialized.FlatWidth);
            TestUtility.TestLengthsAreEqual(prfl.Thickness, prflDeserialized.Thickness);
        }

        [Fact]
        public void GetPerimeterTest()
        {
            // Assemble
            var h = new Length(40, LengthUnit.Centimeter);
            var w = new Length(70, LengthUnit.Centimeter);
            var h1 = new Length(30, LengthUnit.Centimeter);
            var w1 = new Length(50, LengthUnit.Centimeter);
            var thk = new Length(5.5, LengthUnit.Millimeter);

            // Act
            IRoundedRectangularHollow prfl = new RoundedRectangularHollow(h, w, h1, w1, thk);
            IPerimeter perimeter = new Perimeter(prfl);

            // Assert
            Assert.Equal(69, perimeter.OuterEdge.Points.Count);
            List<double> u1 = perimeter.OuterEdge.Points.Select(x => x.U.Millimeters).ToList();
            List<double> v1 = perimeter.OuterEdge.Points.Select(x => x.V.Millimeters).ToList();

            Assert.Single(perimeter.VoidEdges);
            Assert.Equal(69, perimeter.VoidEdges[0].Points.Count);
            List<double> u2 = perimeter.VoidEdges[0].Points.Select(x => x.U.Millimeters).ToList();
            List<double> v2 = perimeter.VoidEdges[0].Points.Select(x => x.V.Millimeters).ToList();

            var expectedU1 = new List<double>()
            {
               350,
349.51847266721967,
348.078528040323,
345.69403357322085,
342.38795325112864,
338.1921264348355,
333.14696123025453,
327.30104533627366,
320.71067811865476,
313.43932841636456,
305.5570233019602,
297.1396736825997,
288.268343236509,
279.0284677254462,
269.5090322016128,
259.801714032956,
250,
-250,
-259.8017140329561,
-269.50903220161285,
-279.02846772544626,
-288.268343236509,
-297.1396736825998,
-305.5570233019602,
-313.43932841636456,
-320.71067811865476,
-327.30104533627366,
-333.14696123025453,
-338.19212643483553,
-342.3879532511287,
-345.69403357322085,
-348.0785280403231,
-349.51847266721967,
-350,
-350,
-349.51847266721967,
-348.0785280403231,
-345.69403357322085,
-342.3879532511287,
-338.19212643483553,
-333.14696123025453,
-327.30104533627366,
-320.71067811865476,
-313.4393284163645,
-305.5570233019602,
-297.1396736825998,
-288.268343236509,
-279.0284677254462,
-269.5090322016128,
-259.8017140329561,
-250,
250,
259.8017140329561,
269.5090322016128,
279.0284677254462,
288.268343236509,
297.1396736825998,
305.5570233019602,
313.43932841636456,
320.71067811865476,
327.30104533627366,
333.14696123025453,
338.19212643483553,
342.3879532511287,
345.69403357322085,
348.0785280403231,
349.51847266721967,
350,
350
};

            var expectedV1 = new List<double>() {
                -150,
-154.90085701647803,
-159.75451610080643,
-164.51423386272316,
-169.13417161825453,
-173.5698368412999,
-177.7785116509801,
-181.7196642081823,
-185.35533905932738,
-188.65052266813683,
-191.57348061512727,
-194.09606321741776,
-196.19397662556435,
-197.84701678661042,
-199.03926402016154,
-199.75923633360983,
-200,
-200,
-199.75923633360983,
-199.0392640201615,
-197.84701678661042,
-196.19397662556432,
-194.09606321741776,
-191.57348061512727,
-188.65052266813683,
-185.35533905932738,
-181.71966420818225,
-177.7785116509801,
-173.5698368412999,
-169.1341716182545,
-164.5142338627231,
-159.75451610080643,
-154.90085701647803,
-150,
150,
154.90085701647803,
159.75451610080643,
164.5142338627231,
169.1341716182545,
173.5698368412999,
177.7785116509801,
181.7196642081823,
185.35533905932738,
188.65052266813683,
191.57348061512727,
194.09606321741776,
196.19397662556435,
197.84701678661042,
199.03926402016154,
199.75923633360983,
200,
200,
199.75923633360983,
199.03926402016154,
197.84701678661042,
196.19397662556435,
194.09606321741776,
191.57348061512727,
188.65052266813683,
185.35533905932738,
181.7196642081823,
177.7785116509801,
173.5698368412999,
169.1341716182545,
164.5142338627231,
159.7545161008064,
154.90085701647803,
150,
-150
};

            var expectedU2 = new List<double>()
            {
                344.5,
344.0184726672197,
342.57852804032314,
340.1940335732209,
336.88795325112864,
332.6921264348356,
327.6469612302546,
321.8010453362737,
315.21067811865476,
307.93932841636456,
300.0570233019602,
291.6396736825998,
282.768343236509,
273.5284677254462,
264.00903220161285,
254.30171403295597,
244.5,
-244.5,
-254.30171403295608,
-264.00903220161285,
-273.52846772544626,
-282.76834323650905,
-291.6396736825998,
-300.05702330196027,
-307.93932841636456,
-315.21067811865476,
-321.8010453362737,
-327.6469612302546,
-332.6921264348356,
-336.8879532511288,
-340.1940335732209,
-342.57852804032314,
-344.0184726672197,
-344.5,
-344.5,
-344.0184726672197,
-342.57852804032314,
-340.1940335732209,
-336.8879532511288,
-332.6921264348356,
-327.6469612302546,
-321.8010453362737,
-315.21067811865476,
-307.93932841636456,
-300.0570233019602,
-291.6396736825998,
-282.768343236509,
-273.5284677254462,
-264.0090322016128,
-254.30171403295608,
-244.5,
244.5,
254.30171403295608,
264.00903220161285,
273.52846772544626,
282.768343236509,
291.6396736825998,
300.05702330196027,
307.93932841636456,
315.21067811865476,
321.8010453362737,
327.6469612302546,
332.6921264348356,
336.8879532511288,
340.1940335732209,
342.57852804032314,
344.0184726672197,
344.5,
344.5
};

            var expectedV2 = new List<double>() {
                -144.5,
-149.40085701647803,
-154.25451610080643,
-159.01423386272313,
-163.63417161825453,
-168.0698368412999,
-172.2785116509801,
-176.2196642081823,
-179.85533905932738,
-183.15052266813683,
-186.07348061512727,
-188.59606321741776,
-190.69397662556435,
-192.34701678661048,
-193.5392640201615,
-194.25923633360983,
-194.5,
-194.5,
-194.25923633360983,
-193.53926402016148,
-192.34701678661042,
-190.69397662556435,
-188.59606321741776,
-186.07348061512727,
-183.15052266813683,
-179.85533905932738,
-176.21966420818225,
-172.2785116509801,
-168.0698368412999,
-163.6341716182545,
-159.0142338627231,
-154.25451610080643,
-149.40085701647803,
-144.5,
144.5,
149.40085701647803,
154.25451610080643,
159.01423386272313,
163.6341716182545,
168.0698368412999,
172.2785116509801,
176.2196642081823,
179.85533905932738,
183.1505226681369,
186.07348061512727,
188.59606321741776,
190.69397662556435,
192.34701678661048,
193.5392640201615,
194.25923633360983,
194.5,
194.5,
194.25923633360983,
193.5392640201615,
192.34701678661048,
190.69397662556435,
188.59606321741776,
186.07348061512727,
183.15052266813683,
179.85533905932738,
176.2196642081823,
172.2785116509801,
168.0698368412999,
163.6341716182545,
159.0142338627231,
154.2545161008064,
149.40085701647803,
144.5,
-144.5
};

            TestUtility.TestListsOfDoublesAreEqual(expectedU1, u1);
            TestUtility.TestListsOfDoublesAreEqual(expectedV1, v1);
            TestUtility.TestListsOfDoublesAreEqual(expectedU2, u2);
            TestUtility.TestListsOfDoublesAreEqual(expectedV2, v2);
        }
    }
}
