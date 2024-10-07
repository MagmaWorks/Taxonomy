using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using MagmaWorks.Taxonomy.Loads;
using MagmaWorks.Taxonomy.Serialization.Loads;
using OasysUnits;
using OasysUnits.Units;

namespace LoadTests
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
        private static int _int { get { return 42; } }
        private static double _double { get { return 9.8; } }
        private static bool _bool { get { return true; } }
        private static byte _byte { get { return 3; } }
        private static Length _length { get { return new Length(2.5, LengthUnit.Centimeter); } }
        private static Angle _angle { get { return new Angle(33, AngleUnit.Degree); } }
        private static Force _force { get { return new Force(11.5, ForceUnit.Kilonewton); } }
        private static Moment _moment { get { return new Moment(140, MomentUnit.KilonewtonMeter); } }
        private static ForcePerLength _forcePerLength { get { return new ForcePerLength(-15.2, ForcePerLengthUnit.KilonewtonPerMeter); } }
        private static Pressure _forcePerArea { get { return new Pressure(-105.4, PressureUnit.KilonewtonPerSquareMeter); } }

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
                ILoad instance = (ILoad)constructor.Invoke(args);
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
                Type[] typelist = Assembly.GetAssembly(typeof(PointForce2d)).GetTypes();
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

        private void TestObjectsSurvivesJsonRoundtrip<T>(T obj) where T : ILoad
        {
            string json = obj.ToJson();
            Assert.NotNull(json);
            Assert.True(json.Length > 0);
            T deserialized = json.FromJson<T>();
            Assert.NotNull(deserialized);
            TestPropertiesInObjectsAreEqual(obj, deserialized);
        }

        private void TestPropertiesInObjectsAreEqual<T>(T expected, T actual) where T : ILoad
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

                        case "Force":
                            args.Add(_force);
                            continue;

                        case "ForcePerLength":
                            args.Add(_forcePerLength);
                            continue;

                        case "Moment":
                            args.Add(_moment);
                            continue;

                        case "Pressure":
                            args.Add(_forcePerArea);
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
            Type[] typelist = Assembly.GetAssembly(typeof(PointForce2d)).GetTypes();
            foreach (Type concreteType in typelist)
            {
                if (type.IsAssignableFrom(concreteType))
                {
                    return CreateObjectInstance(concreteType);
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
