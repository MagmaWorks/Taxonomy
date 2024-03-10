using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using MagmaWorks.Taxonomy.Stages;
using MagmaWorks.Taxonomy.Serialization.Stages.Extensions;
using MagmaWorks.Taxonomy.Stages.RIBA;

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
            if (typeof(IStage).IsAssignableFrom(type))
            {
                IStage instance = (IStage)constructor.Invoke(null);
                Assert.NotNull(instance);
                TestObjectsSurvivesJsonRoundtrip(instance);
            }
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
                Type[] typelist = Assembly.GetAssembly(typeof(RIBA)).GetTypes()
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

        private void TestObjectsPropertiesAreNotNull(object obj)
        {
            PropertyInfo[] propertyInfo = obj.GetType().GetProperties(
                BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
            foreach (PropertyInfo property in propertyInfo)
            {
                Assert.NotNull(property.GetValue(obj));
            }
        }

        private void TestObjectsSurvivesJsonRoundtrip<T>(T obj) where T : IStage
        {
            string json = obj.ToJson();
            Assert.NotNull(json);
            Assert.True(json.Length > 0);
            T deserialized = json.FromJson<T>();
            Assert.NotNull(deserialized);
            TestPropertiesInObjectsAreEqual(obj, deserialized);
        }

        private void TestPropertiesInObjectsAreEqual<T>(T expected, T actual) where T : IStage
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
