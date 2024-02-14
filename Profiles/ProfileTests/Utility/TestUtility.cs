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
    }
}
