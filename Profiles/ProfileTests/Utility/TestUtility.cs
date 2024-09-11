using OasysUnits;

namespace ProfileTests.Utility
{
    internal static class TestUtility
    {
        internal static void TestLengthsAreEqual(Length expected, Length actual)
        {
            Assert.Equal(expected.Value, actual.Value);
            Assert.Equal(expected.Unit, actual.Unit);
        }

        internal static void TestListsOfDoublesAreEqual(List<double> expected, List<double> actual, int precision = 12)
        {
            Assert.Equal(expected.Count, actual.Count);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.Equal(expected[i], actual[i], precision);
            }
        }
    }
}
