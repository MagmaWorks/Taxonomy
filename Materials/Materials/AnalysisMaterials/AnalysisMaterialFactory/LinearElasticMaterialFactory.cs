using System;
using MagmaWorks.Taxonomy.Materials.StandardMaterials.EN;
using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace MagmaWorks.Taxonomy.Materials
{
    public static partial class AnalysisMaterialFactory
    {
        public static ILinearElasticMaterial CreateLinearElastic(IMaterial material)
        {
            switch (material)
            {
                case IAnalysisMaterial analysisMaterial:
                    return FromAnalysisMaterial(analysisMaterial);

                case IStandardMaterial standardMaterial:
                    return FromStandardMaterial(standardMaterial);

                default: throw new ArgumentException($"Material type {material.GetType()} not implemented");
            }
        }

        private static ILinearElasticMaterial FromAnalysisMaterial(IAnalysisMaterial material)
        {
            switch (material)
            {
                case ILinearElasticMaterial linearElasticMaterial:
                    return linearElasticMaterial;

                default:
                    throw new ArgumentException($"Unable to convert {material.GetType()} to Linear Elastic Analysis Material");

            }
        }

        private static ILinearElasticMaterial FromStandardMaterial(IStandardMaterial material)
        {
            switch (material.Standard)
            {
                case IEurocode:
                    switch (material.Type)
                    {
                        case MaterialType.Concrete:
                            return ENConcreteFactory.CreateLinearElastic((ENConcreteGrade)material.Grade);

                        case MaterialType.Reinforcement:
                            return ENRebarFactory.CreateLinearElastic((ENRebarGrade)material.Grade);

                        case MaterialType.Steel:
                            return ENSteelFactory.CreateLinearElastic((ENSteelGrade)material.Grade);

                        default:
                            throw new ArgumentException($"{material.Type} material type not implemented for Eurocode");
                    }

                default:
                    throw new ArgumentException($"{material.Standard} standard not implemented");

            }
        }
    }
}
