using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using MagmaWorks.Taxonomy.Serialization;

namespace MaterialTests
{
    public class AutomatedTests
    {
        // Add classes here that has complex constructors (e.i throws exceptions)
        // Add manual tests of these class' constructors instead
        private static readonly List<Type> _excludedTypes =
        [
        ];

        // static inputs used to populate constructor variables
        private static string _string { get { return "lava"; } }
        private static int _int { get { return 0; } }
        private static double _double { get { return 9.8; } }
        private static bool _bool { get { return true; } }
        private static byte _byte { get { return 3; } }
        private static Length _length { get { return new Length(2.5, LengthUnit.Centimeter); } }
        private static Angle _angle { get { return new Angle(33, AngleUnit.Degree); } }
        private static Stress _stress { get { return new Stress(45, StressUnit.Megapascal); } }
        private static Strain _strain { get { return new Strain(7.5, StrainUnit.Percent); } }
        private static IStandard _standard { get { return new En1992(); } }
        private static Enum _grade { get { return EnConcreteGrade.C30_37; } }

        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void ConstructorTest(Type type)
        {
            ConstructorInfo[] constructors = type.GetConstructors(BindingFlags.Instance | BindingFlags.Public);
            foreach (ConstructorInfo constructor in constructors)
            {
                object[] args = CreateConstructorArguments(constructor);
                object instance = constructor.Invoke(args);
                Assert.NotNull(instance);
                TestObjectsPropertiesAreNotNull(instance);
            }
        }

        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void DeserializeTest(Type type)
        {
            ConstructorInfo[] constructors = type.GetConstructors(BindingFlags.Instance | BindingFlags.Public);
            foreach (ConstructorInfo constructor in constructors)
            {
                object[] args = CreateConstructorArguments(constructor);
                IMaterial instance = (IMaterial)constructor.Invoke(args);
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
                Type[] typelist = Assembly.GetAssembly(typeof(EnConcreteMaterial)).GetTypes();
                foreach (Type type in typelist)
                {
                    if (type.Namespace == null)
                    {
                        continue;
                    }

                    if (type.Namespace.StartsWith("MagmaWorks.Taxonomy")
                      && type.BaseType.Name != "Enum"
                      && !_excludedTypes.Contains(type)
                      && type.Attributes.HasFlag(TypeAttributes.Public)
                      && !type.Attributes.HasFlag(TypeAttributes.Abstract)
                      && !type.Attributes.HasFlag(TypeAttributes.Interface)
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

        private void TestObjectsSurvivesJsonRoundtrip<T>(T obj) where T : IMaterial
        {
            string json = obj.ToJson();
            Assert.NotNull(json);
            Assert.True(json.Length > 0);
            T deserialized = json.FromJson<T>();
            Assert.NotNull(deserialized);
            TestPropertiesInObjectsAreEqual(obj, deserialized);
        }

        private void TestPropertiesInObjectsAreEqual<T>(T expected, T actual) where T : IMaterial
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

        private object[] CreateConstructorArguments(ConstructorInfo constructor)
        {
            ParameterInfo[] parameters = constructor.GetParameters();
            var args = new List<object>();
            foreach (ParameterInfo parameter in parameters)
            {
                Type type = parameter.ParameterType;
                // check if parameter is primitive type
                switch (Type.GetTypeCode(type))
                {
                    case TypeCode.Int32:
                        args.Add(_int);
                        continue;

                    case TypeCode.String:
                        args.Add(_string);
                        continue;

                    case TypeCode.Double:
                        args.Add(_double);
                        continue;

                    case TypeCode.Boolean:
                        args.Add(_bool);
                        continue;

                    case TypeCode.Byte:
                        args.Add(_byte);
                        continue;
                }

                // check if type is IQuanty type
                if (typeof(IQuantity).IsAssignableFrom(type))
                {
                    switch (type.Name)
                    {
                        case "Length":
                            args.Add(_length);
                            continue;

                        case "Angle":
                            args.Add(_angle);
                            continue;

                        case "Pressure":
                            args.Add(_stress);
                            continue;

                        case "Strain":
                            args.Add(_strain);
                            continue;
                    }
                }

                // check if type is IList type
                Type[] genericArguments = type.GetGenericArguments();
                if (genericArguments.Length == 1)
                {
                    Type listType = typeof(IList<>).MakeGenericType(genericArguments);
                    if (listType.IsAssignableFrom(type))
                    {
                        dynamic list = CreateGenericList(typeof(List<>), genericArguments[0]);
                        dynamic objectInstance = CreateObjectInstance(genericArguments[0]);
                        list.Add(objectInstance);
                        args.Add(list);
                        continue;
                    }
                }

                if (type.Name == "IStandard")
                {
                    args.Add(_standard);
                    continue;
                }

                if (type.FullName == "System.Enum")
                {
                    args.Add(_grade);
                    continue;
                }

                // use the types constructor
                args.Add(CreateObjectInstance(type));
            }

            return args.ToArray();
        }

        private dynamic CreateObjectInstance(Type type)
        {
            if (type.IsInterface == false)
            {
                ConstructorInfo ctor = type.GetConstructors(BindingFlags.Instance | BindingFlags.Public)[0];
                object[] args = CreateConstructorArguments(ctor);
                return ctor.Invoke(args);
            }

            // reflect on assembly to find concrete implementation of interface
            AssemblyName[] referencedNames = Assembly.GetAssembly(typeof(EnConcreteMaterial)).GetReferencedAssemblies();
            List<Assembly> assemblies = new List<Assembly>()
            {
                Assembly.GetAssembly(typeof(EnConcreteMaterial))
            };
            assemblies.AddRange(referencedNames.Select(a => Assembly.Load(a)).ToList());

            foreach (Assembly assembly in assemblies)
            {
                if (!assembly.FullName.StartsWith("MagmaWorks."))
                {
                    continue;
                }

                Type[] typelist = assembly.GetTypes();
                foreach (Type concreteType in typelist)
                {
                    if (concreteType.GetInterfaces().Contains(type) && concreteType.IsInterface == false)
                    {
                        return CreateObjectInstance(concreteType);
                    }
                }
            }

            throw new NotImplementedException($"Could not find concrete implementation of type {type}");
        }

        public static dynamic CreateGenericList(Type generic, Type innerType, params object[] args)
        {
            Type specificType = generic.MakeGenericType(new Type[] { innerType });
            return Activator.CreateInstance(specificType, args);
        }
    }
}
