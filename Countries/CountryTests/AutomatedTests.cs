using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using MagmaWorks.Taxonomy.Countries;
using MagmaWorks.Taxonomy.Serialization.Countries.Extensions;

namespace CountryTests
{
    public class AutomatedTests
    {
        // Add classes here that has complex constructors (e.i throws exceptions)
        // Add manual tests of these class' constructors instead
        private static readonly List<Type> _excludedTypes =
        [

        ];

        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void InheritanceTest(Type type)
        {
            if (typeof(IAfrica).IsAssignableFrom(type))
            {
                TestAfricanInheritance(type);
                return;
            }

            if (typeof(IAmericas).IsAssignableFrom(type))
            {
                TestAmericanInheritance(type);
                return;
            }

            if (typeof(IAsia).IsAssignableFrom(type))
            {
                TestAsianInheritance(type);
                return;
            }

            if (typeof(IEurope).IsAssignableFrom(type))
            {
                TestEuropeanInheritance(type);
                return;
            }

            if (typeof(IOceania).IsAssignableFrom(type))
            {
                TestOceanianInheritance(type);
                return;
            }

            Assert.Fail("Inheritance structure not found");
        }

        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void ConstructorTest(Type type)
        {
            ConstructorInfo constructor = type.GetConstructor(Type.EmptyTypes);
            object instance = constructor.Invoke(null);
            Assert.NotNull(instance);
            TestObjectsPropertiesAreNotNull(instance);
        }

        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void DeserializeTest(Type type)
        {
            ConstructorInfo constructor = type.GetConstructor(Type.EmptyTypes);
            ICountry instance = (ICountry)constructor.Invoke(null);
            Assert.NotNull(instance);
            TestObjectsSurvivesJsonRoundtrip(instance);
        }

        public class TestDataGenerator : IEnumerable<object[]>
        {
            private readonly List<object[]> _data = GetAllComponents();

            public IEnumerator<object[]> GetEnumerator()
            {
                return _data.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            private static List<object[]> GetAllComponents()
            {
                var data = new List<object[]>();
                Type[] typelist = Assembly.GetAssembly(typeof(UnitedKingdom)).GetTypes()
                    .Where(x => !x.IsAbstract && x.IsPublic && !x.IsInterface).ToArray();
                foreach (Type type in typelist)
                {
                    if (type.Namespace == null)
                    {
                        continue;
                    }

                    if (type.Namespace.StartsWith("MagmaWorks.Taxonomy")
                      && type.BaseType.Name != "Enum"
                      && !_excludedTypes.Contains(type)
                      && type.GetCustomAttribute(typeof(CompilerGeneratedAttribute), true) == null)
                    {
                        data.Add([type]);
                    }
                }

                return data;
            }
        }

        private void TestOceanianInheritance(Type type)
        {
            if (typeof(IAustraliaAndNewZealand).IsAssignableFrom(type))
            {
                return;
            }

            if (typeof(IMelanesia).IsAssignableFrom(type))
            {
                return;
            }

            if (typeof(IMicronesia).IsAssignableFrom(type))
            {
                return;
            }

            if (typeof(IPolynesia).IsAssignableFrom(type))
            {
                return;
            }

            Assert.Fail("Oceanian inheritance structure not found");
        }

        private void TestEuropeanInheritance(Type type)
        {
            if (typeof(IEasternEurope).IsAssignableFrom(type))
            {
                return;
            }

            if (typeof(INorthernEurope).IsAssignableFrom(type))
            {
                return;
            }

            if (typeof(ISouthernEurope).IsAssignableFrom(type))
            {
                return;
            }

            if (typeof(IWesternEurope).IsAssignableFrom(type))
            {
                return;
            }

            Assert.Fail("European inheritance structure not found");
        }

        private void TestAsianInheritance(Type type)
        {
            if (typeof(ICentralAsia).IsAssignableFrom(type))
            {
                return;
            }

            if (typeof(IEasternAsia).IsAssignableFrom(type))
            {
                return;
            }

            if (typeof(ISouthernAsia).IsAssignableFrom(type))
            {
                return;
            }

            if (typeof(ISouthEasternAsia).IsAssignableFrom(type))
            {
                return;
            }

            if (typeof(IWesternAsia).IsAssignableFrom(type))
            {
                return;
            }

            Assert.Fail("Asian inheritance structure not found");
        }

        private void TestAmericanInheritance(Type type)
        {
            if (typeof(INorthernAmerica).IsAssignableFrom(type))
            {
                return;
            }

            if (typeof(ILatinAmerica).IsAssignableFrom(type))
            {
                if (typeof(ICaribbean).IsAssignableFrom(type))
                {
                    return;
                }

                if (typeof(ICentralAmerica).IsAssignableFrom(type))
                {
                    return;
                }

                if (typeof(ISouthAmerica).IsAssignableFrom(type))
                {
                    return;
                }
            }

            Assert.Fail("American inheritance structure not found");
        }

        private void TestAfricanInheritance(Type type)
        {
            if (typeof(INorthernAfrica).IsAssignableFrom(type))
            {
                return;
            }

            if (typeof(ISubSaharanAfrica).IsAssignableFrom(type))
            {
                if (typeof(IEasternAfrica).IsAssignableFrom(type))
                {
                    return;
                }

                if (typeof(IMiddleAfrica).IsAssignableFrom(type))
                {
                    return;
                }

                if (typeof(ISouthernAfrica).IsAssignableFrom(type))
                {
                    return;
                }

                if (typeof(IWesternAfrica).IsAssignableFrom(type))
                {
                    return;
                }
            }

            Assert.Fail("African inheritance structure not found");
        }

        private void TestObjectsPropertiesAreNotNull(object obj)
        {
            PropertyInfo[] propertyInfo = obj.GetType().GetProperties(
                BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
            foreach (PropertyInfo property in propertyInfo)
            {
                Assert.NotNull(property.GetValue(obj));
            }
        }

        private void TestObjectsSurvivesJsonRoundtrip<T>(T obj) where T : ICountry
        {
            string json = obj.ToJson();
            Assert.NotNull(json);
            Assert.True(json.Length > 0);
            T deserialized = json.FromJson<T>();
            Assert.NotNull(deserialized);
            TestPropertiesInObjectsAreEqual(obj, deserialized);
        }

        private void TestPropertiesInObjectsAreEqual<T>(T expected, T actual) where T : ICountry
        {
            PropertyInfo[] expectedProperties = expected.GetType().GetProperties(
                BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
            PropertyInfo[] actualProperties = actual.GetType().GetProperties(
                BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
            Assert.Equal(expectedProperties.Length, actualProperties.Length);
            for (int i = 0; i < expectedProperties.Length; i++)
            {
                Assert.Equal(expectedProperties[i], actualProperties[i]);
            }
        }
    }
}
