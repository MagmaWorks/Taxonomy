using System;
using MagmaWorks.Taxonomy.Materials.StandardMaterials.En;
using MagmaWorks.Taxonomy.Standards;
using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace MagmaWorks.Taxonomy.Materials
{
    public static partial class AnalysisMaterialFactory
    {
        public static ILinearElasticMaterial CreateLinearElastic<Std, Grd>(IStandardMaterial<Std, Grd> material)
            where Std : IStandard where Grd : Enum
        {
            switch (material.Standard)
            {
                case IEurocode:
                    switch (material.Type)
                    {
                        case MaterialType.Concrete:
                            return EnConcreteFactory.CreateLinearElastic(material.Grade);

                        case MaterialType.Reinforcement:
                            return EnRebarFactory.CreateLinearElastic(material.Grade);

                        case MaterialType.Steel:
                            return EnSteelFactory.CreateLinearElastic(material.Grade);

                        default:
                            throw new ArgumentException($"{material.Type} material type not implemented for Eurocode");
                    }

                default:
                    throw new ArgumentException($"{material.Standard} standard not implemented");

            }
        }
    }
}
