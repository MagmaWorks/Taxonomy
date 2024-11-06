using System;
using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace MagmaWorks.Taxonomy.Materials
{
    public interface IENMaterial<Grd> : IStandardMaterial<IEurocode, Grd> where Grd : Enum { }
}
